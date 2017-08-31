using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.eprlib.formula;
using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.eprlib.presentation.annotate;
using dhcc.epr.eprlib.presentation.figure;
using dhcc.epr.eprlib.presentation.table;
using dhcc.epr.eprlib.presentation.textedit;
using dhcc.epr.systemframework;
using KBNodeData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation
{
	public class PPanel : Panel
	{
		public delegate void ErrorChangedEventHandler();

		public delegate void RefreshBindKBTreeHandler(string eCode, string kbBaseID, int kbPartNo);

		private IContainer components;

		private PCTextEdit _TextDescEdit1;

		private PCTextEdit _TextDescEdit2;

		private PCTextEdit _TextDescEdit3;

		private string _InstanceStatus;

		private NInstanceData _InstanceData;

		private Hashtable _PCTextEditHashtable;

		private bool boolAudit;

		private bool boolAutoCal;

		private bool boolTip;

		private bool boolSingleKB;

		public CheckMsgCollection CheckErrors;

		private MFormulaItemCollection CalFormulas;

		private MFormulaItemCollection AuditFormulas;

		private MFormulaItemCollection TipFormulas;

		private PPanel.ErrorChangedEventHandler ErrorChangedEvent;

		private IDisposable dispObj;

		private PPanel.RefreshBindKBTreeHandler OnRefreshBindKBTreeEvent;

		private PCImageAnnotate m_CurrentPCImageAnnotate;

		public static string sysDatetime = string.Empty;

		private CheckValueChangedEventHandler CheckValueChangedEventEvent;

		private InitValueEventHandler SetInitValueEventEvent;

		public event PPanel.ErrorChangedEventHandler ErrorChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.ErrorChangedEvent = (PPanel.ErrorChangedEventHandler)Delegate.Combine(this.ErrorChangedEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.ErrorChangedEvent = (PPanel.ErrorChangedEventHandler)Delegate.Remove(this.ErrorChangedEvent, value);
			}
		}

		public event PPanel.RefreshBindKBTreeHandler OnRefreshBindKBTree
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.OnRefreshBindKBTreeEvent = (PPanel.RefreshBindKBTreeHandler)Delegate.Combine(this.OnRefreshBindKBTreeEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.OnRefreshBindKBTreeEvent = (PPanel.RefreshBindKBTreeHandler)Delegate.Remove(this.OnRefreshBindKBTreeEvent, value);
			}
		}

		public event CheckValueChangedEventHandler CheckValueChangedEvent
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.CheckValueChangedEventEvent = (CheckValueChangedEventHandler)Delegate.Combine(this.CheckValueChangedEventEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.CheckValueChangedEventEvent = (CheckValueChangedEventHandler)Delegate.Remove(this.CheckValueChangedEventEvent, value);
			}
		}

		public event InitValueEventHandler SetInitValueEvent
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.SetInitValueEventEvent = (InitValueEventHandler)Delegate.Combine(this.SetInitValueEventEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.SetInitValueEventEvent = (InitValueEventHandler)Delegate.Remove(this.SetInitValueEventEvent, value);
			}
		}

		public NInstanceData InstanceData
		{
			get
			{
				return this._InstanceData;
			}
			set
			{
				this._InstanceData = value;
			}
		}

		public string InstanceStatus
		{
			get
			{
				return this._InstanceStatus;
			}
			set
			{
				this._InstanceStatus = value;
			}
		}

		public string XMLString
		{
			set
			{
				PPanel.sysDatetime = WebServiceLayer.SystemServiceDataAccess.GetDateTime();
				string sysOptionValue = SysOptionManager.GetSysOptionValue("UseMultiThreading", "Y");
				if (Operators.CompareString(sysOptionValue.ToUpper(), "Y", false) != 0)
				{
					this.Controls.Clear();
					LogManager.WriteLog("反序列化Interface", true);
					StringReader input = new StringReader(value);
					XmlTextReader xmlTextReader = new XmlTextReader(input);
					xmlTextReader.WhitespaceHandling = WhitespaceHandling.All;
					xmlTextReader.Read();
					this.XMLDeserialize(xmlTextReader);
					xmlTextReader.Close();
					LogManager.WriteLog("End反序列化Interface", true);
					LogManager.WriteLog("绑定Instance", true);
					this.BindInstance();
					LogManager.WriteLog("End绑定Instance", true);
					LogManager.WriteLog("编译公式", true);
					MMetaData mMetaData = (MMetaData)this._InstanceData.BindMMetaItem;
					this.CalFormulas = mMetaData.CalculateFormulaItems;
					this.CalFormulas.NInstanceData = this._InstanceData;
					try
					{
						MFormulaItemEnumerator enumerator = this.CalFormulas.GetEnumerator();
						while (enumerator.MoveNext())
						{
							MFormulaItem mFormulaItem = (MFormulaItem)enumerator.Current;
							mFormulaItem.Formula.Compile();
						}
					}
					catch (ApplicationException expr_109)
					{
						ProjectData.SetProjectError(expr_109);
						MessageManager.ShowWarningMessage("自动计算公式编译有问题！");
						this.boolAutoCal = false;
						ProjectData.ClearProjectError();
					}
					this.AuditFormulas = mMetaData.AuditFormulaItems;
					this.AuditFormulas.NInstanceData = this._InstanceData;
					try
					{
						MFormulaItemEnumerator enumerator2 = this.AuditFormulas.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							MFormulaItem mFormulaItem2 = (MFormulaItem)enumerator2.Current;
							mFormulaItem2.Formula.Compile();
						}
					}
					catch (ApplicationException expr_17B)
					{
						ProjectData.SetProjectError(expr_17B);
						MessageManager.ShowWarningMessage("自动编译公式编译有问题！");
						this.boolAudit = false;
						ProjectData.ClearProjectError();
					}
					LogManager.WriteLog("End编译公式", true);
					this.CheckErrors.Clear();
					PPanel.ErrorChangedEventHandler errorChangedEvent = this.ErrorChangedEvent;
					if (errorChangedEvent != null)
					{
						errorChangedEvent();
					}
				}
				else
				{
					this.PPanelDeserialize(value);
					if (this.dispObj != null)
					{
						this.dispObj.Dispose();
					}
				}
			}
		}

		public bool IsValueChanged
		{
			get
			{
				bool result = false;
				CheckValueChangedEventHandler checkValueChangedEventEvent = this.CheckValueChangedEventEvent;
				if (checkValueChangedEventEvent != null)
				{
					checkValueChangedEventEvent(ref result);
				}
				return result;
			}
			set
			{
				if (value)
				{
					return;
				}
				InitValueEventHandler setInitValueEventEvent = this.SetInitValueEventEvent;
				if (setInitValueEventEvent != null)
				{
					setInitValueEventEvent();
				}
			}
		}

		public PPanel()
		{
			base.Click += new EventHandler(this.PPanel_Click);
			this.boolAudit = true;
			this.boolAutoCal = true;
			this.boolTip = true;
			this.boolSingleKB = false;
			this.CheckErrors = new CheckMsgCollection();
			this.m_CurrentPCImageAnnotate = null;
			this.InitializeComponent();
			this.InitVisualStyles();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			if (this.dispObj != null)
			{
				this.dispObj.Dispose();
			}
			base.Dispose(disposing);
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			this.AutoScroll = true;
		}

		public void ReplaceTextDesc(NISegment s1, NISegment s2, NISegment s3, string eCode, int kbPartNo)
		{
			if (this.boolSingleKB)
			{
				PCTextEdit pCTextEdit = (PCTextEdit)this._PCTextEditHashtable[eCode];
				NISegment nISegment;
				switch (kbPartNo)
				{
				case 1:
					nISegment = s1;
					break;
				case 2:
					nISegment = s2;
					break;
				case 3:
					nISegment = s3;
					break;
				default:
					nISegment = s1;
					break;
				}
				if (nISegment != null && pCTextEdit != null)
				{
					this.RefreshFontSize(nISegment, pCTextEdit.Font.Size);
					pCTextEdit.ReplaceItem(nISegment);
					nISegment.EPRDataBind();
					nISegment.SystemDataBind();
					pCTextEdit.ReDraw();
				}
			}
			else
			{
				if (s1 != null & this._TextDescEdit1 != null)
				{
					this.RefreshFontSize(s1, this._TextDescEdit1.Font.Size);
					this._TextDescEdit1.ReplaceItem(s1);
					s1.EPRDataBind();
					s1.SystemDataBind();
					this._TextDescEdit1.ReDraw();
				}
				if (s2 != null & this._TextDescEdit2 != null)
				{
					this.RefreshFontSize(s2, this._TextDescEdit1.Font.Size);
					this._TextDescEdit2.ReplaceItem(s2);
					s2.EPRDataBind();
					s2.SystemDataBind();
					this._TextDescEdit2.ReDraw();
				}
				if (s3 != null & this._TextDescEdit3 != null)
				{
					this.RefreshFontSize(s3, this._TextDescEdit1.Font.Size);
					this._TextDescEdit3.ReplaceItem(s3);
					s3.EPRDataBind();
					s3.SystemDataBind();
					this._TextDescEdit3.ReDraw();
				}
			}
		}

		public void AddTextDesc(NISegment s1, NISegment s2, NISegment s3, string eCode, int kbPartNo)
		{
			if (this.boolSingleKB)
			{
				PCTextEdit pCTextEdit = (PCTextEdit)this._PCTextEditHashtable[eCode];
				NISegment nISegment;
				switch (kbPartNo)
				{
				case 1:
					nISegment = s1;
					break;
				case 2:
					nISegment = s2;
					break;
				case 3:
					nISegment = s3;
					break;
				default:
					nISegment = s1;
					break;
				}
				if (nISegment != null && pCTextEdit != null)
				{
					this.RefreshFontSize(nISegment, pCTextEdit.Font.Size);
					pCTextEdit.AddItem(nISegment);
					nISegment.EPRDataBind();
					nISegment.SystemDataBind();
					pCTextEdit.ReDraw();
				}
			}
			else
			{
				if (s1 != null & this._TextDescEdit1 != null)
				{
					this.RefreshFontSize(s1, this._TextDescEdit1.Font.Size);
					this._TextDescEdit1.AddItem(s1);
					s1.EPRDataBind();
					s1.SystemDataBind();
					this._TextDescEdit1.ReDraw();
				}
				if (s2 != null & this._TextDescEdit2 != null)
				{
					this.RefreshFontSize(s2, this._TextDescEdit1.Font.Size);
					this._TextDescEdit2.AddItem(s2);
					s2.EPRDataBind();
					s2.SystemDataBind();
					this._TextDescEdit2.ReDraw();
				}
				if (s3 != null & this._TextDescEdit3 != null)
				{
					this.RefreshFontSize(s3, this._TextDescEdit1.Font.Size);
					this._TextDescEdit3.AddItem(s3);
					s3.EPRDataBind();
					s3.SystemDataBind();
					this._TextDescEdit3.ReDraw();
				}
			}
		}

		private void RefreshFontSize(NISegment segment, float size)
		{
			if (segment.FormatRangeCollection != null)
			{
				FormateRangeEnumerator enumerator = segment.FormatRangeCollection.GetEnumerator();
				while (enumerator.MoveNext())
				{
					FormateRange formateRange = (FormateRange)enumerator.Current;
					formateRange.FontStruct.Size = size;
					formateRange.FontStruct.ResetFont();
				}
			}
			NInstanceItemEnumerator enumerator2 = segment.SubItems.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				NInstanceItem nInstanceItem = (NInstanceItem)enumerator2.Current;
				if (nInstanceItem.FormatRangeCollection != null)
				{
					FormateRangeEnumerator enumerator3 = nInstanceItem.FormatRangeCollection.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						FormateRange formateRange2 = (FormateRange)enumerator3.Current;
						formateRange2.FontStruct.Size = size;
						formateRange2.FontStruct.ResetFont();
					}
				}
			}
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern long LockWindowUpdate(IntPtr hwndLock);

		private void PPanelDeserialize(string xmlText)
		{
			PPanelThread pPanelThread = new PPanelThread();
			pPanelThread.InstanceData = this.InstanceData;
			this._PCTextEditHashtable = new Hashtable();
			try
			{
				LogManager.WriteLog("Begin反序列化Interface", true);
				Collection controlsCollection = pPanelThread.XMLDeserialize(xmlText);
				LogManager.WriteLog("End反序列化Interface", true);
				this.Controls.Clear();
				LogManager.WriteLog("Begin绑定Instance", true);
				this.BindInstance(controlsCollection);
				LogManager.WriteLog("End绑定Instance", true);
			}
			catch (Exception expr_65)
			{
				ProjectData.SetProjectError(expr_65);
				Exception ex = expr_65;
				MessageManager.ShowWarningMessage("PPanel.PPanelDeserialize失败！" + ex.Message);
				ProjectData.ClearProjectError();
			}
			LogManager.WriteLog("Begin编译公式", true);
			this.CompileCompute();
			this.CheckErrors.Clear();
			LogManager.WriteLog("End编译公式", true);
			PPanel.ErrorChangedEventHandler errorChangedEvent = this.ErrorChangedEvent;
			if (errorChangedEvent != null)
			{
				errorChangedEvent();
			}
		}

		public void BindInstance(Collection controlsCollection)
		{
			string str = string.Empty;
			checked
			{
				try
				{
					try
					{
						IEnumerator enumerator = controlsCollection.GetEnumerator();
						while (enumerator.MoveNext())
						{
							Control control = (Control)enumerator.Current;
							str = control.Name;
							this.Controls.Add(control);
							if (control is PCLabel)
							{
								PCLabel pCLabel = (PCLabel)control;
								pCLabel.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCLabel.Code);
							}
							else if (control is PCString)
							{
								PCString pCString = (PCString)control;
								pCString.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCString.Code);
								pCString.VChanged += new PCString.VChangedEventHandler(this.VChangedProcess);
								this.CheckValueChangedEvent += new CheckValueChangedEventHandler(pCString.IsValueChanged);
								this.SetInitValueEvent += new InitValueEventHandler(pCString.SetInitValue);
								pCString.MouseDown += new MouseEventHandler(this.ControlMouseDown);
							}
							else if (control is PCNumber)
							{
								PCNumber pCNumber = (PCNumber)control;
								pCNumber.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCNumber.Code);
								pCNumber.VChanged += new PCNumber.VChangedEventHandler(this.VChangedProcess);
								this.CheckValueChangedEvent += new CheckValueChangedEventHandler(pCNumber.IsValueChanged);
								this.SetInitValueEvent += new InitValueEventHandler(pCNumber.SetInitValue);
								pCNumber.MouseDown += new MouseEventHandler(this.ControlMouseDown);
							}
							else if (control is PCMonoChoice)
							{
								PCMonoChoice pCMonoChoice = (PCMonoChoice)control;
								pCMonoChoice.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCMonoChoice.Code);
								pCMonoChoice.VChanged += new PCMonoChoice.VChangedEventHandler(this.VChangedProcess);
								this.CheckValueChangedEvent += new CheckValueChangedEventHandler(pCMonoChoice.IsValueChanged);
								this.SetInitValueEvent += new InitValueEventHandler(pCMonoChoice.SetInitValue);
								pCMonoChoice.MouseDown += new MouseEventHandler(this.ControlMouseDown);
							}
							else if (control is PCMultiChoice)
							{
								PCMultiChoice pCMultiChoice = (PCMultiChoice)control;
								pCMultiChoice.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCMultiChoice.Code);
								pCMultiChoice.VChanged += new PCMultiChoice.VChangedEventHandler(this.VChangedProcess);
								this.CheckValueChangedEvent += new CheckValueChangedEventHandler(pCMultiChoice.IsValueChanged);
								this.SetInitValueEvent += new InitValueEventHandler(pCMultiChoice.SetInitValue);
								pCMultiChoice.MouseDown += new MouseEventHandler(this.ControlMouseDown);
							}
							else if (control is PCDateTime)
							{
								PCDateTime pCDateTime = (PCDateTime)control;
								pCDateTime.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCDateTime.Code);
								pCDateTime.VChanged += new PCDateTime.VChangedEventHandler(this.VChangedProcess);
								this.CheckValueChangedEvent += new CheckValueChangedEventHandler(pCDateTime.IsValueChanged);
								this.SetInitValueEvent += new InitValueEventHandler(pCDateTime.SetInitValue);
								pCDateTime.MouseDown += new MouseEventHandler(this.ControlMouseDown);
							}
							else if (control is PCDictionary)
							{
								PCDictionary pCDictionary = (PCDictionary)control;
								pCDictionary.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCDictionary.Code);
								pCDictionary.VChanged += new PCDictionary.VChangedEventHandler(this.VChangedProcess);
								this.CheckValueChangedEvent += new CheckValueChangedEventHandler(pCDictionary.IsValueChanged);
								this.SetInitValueEvent += new InitValueEventHandler(pCDictionary.SetInitValue);
								pCDictionary.MouseDown += new MouseEventHandler(this.ControlMouseDown);
							}
							else if (control is PCPosition)
							{
								PCPosition pCPosition = (PCPosition)control;
								pCPosition.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCPosition.Code);
								pCPosition.VChanged += new PCPosition.VChangedEventHandler(this.VChangedProcess);
								this.CheckValueChangedEvent += new CheckValueChangedEventHandler(pCPosition.IsValueChanged);
								this.SetInitValueEvent += new InitValueEventHandler(pCPosition.SetInitValue);
								pCPosition.MouseDown += new MouseEventHandler(this.ControlMouseDown);
							}
							else if (control is PCQuantity)
							{
								PCQuantity pCQuantity = (PCQuantity)control;
								pCQuantity.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCQuantity.Code);
								pCQuantity.VChanged += new PCQuantity.VChangedEventHandler(this.VChangedProcess);
								this.CheckValueChangedEvent += new CheckValueChangedEventHandler(pCQuantity.IsValueChanged);
								this.SetInitValueEvent += new InitValueEventHandler(pCQuantity.SetInitValue);
								pCQuantity.MouseDown += new MouseEventHandler(this.ControlMouseDown);
							}
							else if (control is PCTable)
							{
								PCTable pCTable = (PCTable)control;
								pCTable.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCTable.Code);
								this.CheckValueChangedEvent += new CheckValueChangedEventHandler(pCTable.IsValueChanged);
								this.SetInitValueEvent += new InitValueEventHandler(pCTable.SetInitValue);
								pCTable.MouseDown += new MouseEventHandler(this.ControlMouseDown);
							}
							else if (control is PCImageAnnotate)
							{
								PCImageAnnotate pCImageAnnotate = (PCImageAnnotate)control;
								pCImageAnnotate.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCImageAnnotate.Code);
								pCImageAnnotate.VChanged += new PCImageAnnotate.VChangedEventHandler(this.VChangedProcess);
								this.CheckValueChangedEvent += new CheckValueChangedEventHandler(pCImageAnnotate.IsValueChanged);
								this.SetInitValueEvent += new InitValueEventHandler(pCImageAnnotate.SetInitValue);
								pCImageAnnotate.MouseDown += new MouseEventHandler(this.ControlMouseDown);
							}
							else if (control is PCTextEdit)
							{
								PCTextEdit pCTextEdit = (PCTextEdit)control;
								pCTextEdit.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCTextEdit.Code);
								if (pCTextEdit.BindInstanceItem is NITextDesc)
								{
									MITextDesc mITextDesc = (MITextDesc)pCTextEdit.BindInstanceItem.BindMMetaItem;
									if (!string.IsNullOrEmpty(mITextDesc.BindKBBaseID))
									{
										this.boolSingleKB = true;
										if (mITextDesc.BindDefaultKB)
										{
											this.SetPCTextEditDefaultDB(pCTextEdit, Convert.ToInt32(mITextDesc.BindKBBaseID), Convert.ToInt32((int)mITextDesc.BindKBPart));
										}
										if (!this._PCTextEditHashtable.Contains(pCTextEdit.Code))
										{
											this._PCTextEditHashtable.Add(pCTextEdit.Code, pCTextEdit);
										}
									}
									else
									{
										this.boolSingleKB = false;
										if (mITextDesc.BindDefaultKB)
										{
											this.SetPCTextEditDefaultDB(pCTextEdit, Convert.ToInt32(((MMetaData)this._InstanceData.BindMMetaItem).BindKBCode), Convert.ToInt32((int)mITextDesc.BindKBPart));
										}
										if (mITextDesc.BindKBPart == KBPart.First)
										{
											this._TextDescEdit1 = pCTextEdit;
										}
										else if (mITextDesc.BindKBPart == KBPart.Second)
										{
											this._TextDescEdit2 = pCTextEdit;
										}
										else if (mITextDesc.BindKBPart == KBPart.Third)
										{
											this._TextDescEdit3 = pCTextEdit;
										}
									}
								}
								pCTextEdit.VChanged += new PCTextEdit.VChangedEventHandler(this.VChangedProcess);
								this.CheckValueChangedEvent += new CheckValueChangedEventHandler(pCTextEdit.IsValueChanged);
								this.SetInitValueEvent += new InitValueEventHandler(pCTextEdit.SetInitValue);
								pCTextEdit.OnPCTextEditGetFocus += new PCTextEdit.GetFocusHandler(this.PCTextEdit_GetFocus);
								if (SysOptionManager.GetSysOptionValue("ShowLinenum", "N").Equals("Y"))
								{
									Linenum linenum = new Linenum();
									linenum.ParentRichTextBox = pCTextEdit;
									Control arg_6F1_0 = linenum;
									Size size = new Size(17, pCTextEdit.Height);
									arg_6F1_0.Size = size;
									this.Controls.Add(linenum);
									linenum.Refresh();
								}
								pCTextEdit.MouseDown += new MouseEventHandler(this.ControlMouseDown);
							}
							else if (control is PCFigure)
							{
								PCFigure pCFigure = (PCFigure)control;
								pCFigure.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCFigure.Code);
								this.CheckValueChangedEvent += new CheckValueChangedEventHandler(pCFigure.IsValueChanged);
								this.SetInitValueEvent += new InitValueEventHandler(pCFigure.SetInitValue);
								pCFigure.MouseDown += new MouseEventHandler(this.ControlMouseDown);
							}
							else if (control is PCAlignTable)
							{
								PCAlignTable pCAlignTable = (PCAlignTable)control;
								pCAlignTable.InstanceData = this.InstanceData;
								int arg_7B7_0 = 1;
								int rowCount = pCAlignTable.get_RowCount();
								for (int i = arg_7B7_0; i <= rowCount; i++)
								{
									int arg_7C8_0 = 1;
									int colCount = pCAlignTable.get_ColCount();
									for (int j = arg_7C8_0; j <= colCount; j++)
									{
										object objectValue = RuntimeHelpers.GetObjectValue(pCAlignTable.get_Item(i, j).get_Tag());
										if (objectValue != null && objectValue is string)
										{
											NInstanceItem nInstanceItem = this._InstanceData.FindInstanceItemByCode(Conversions.ToString(objectValue));
											if (nInstanceItem != null)
											{
												if (nInstanceItem.BindMMetaItem is MIQuantity)
												{
													pCAlignTable.get_Item(i, j).set_Text(nInstanceItem.Value + nInstanceItem.ValueCode);
												}
												else
												{
													pCAlignTable.get_Item(i, j).set_Text(nInstanceItem.Value);
												}
											}
										}
									}
								}
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception expr_899)
				{
					ProjectData.SetProjectError(expr_899);
					Exception ex = expr_899;
					throw new Exception("PPanel.BindInstance失败！失败单元：" + str + "  失败原因：" + ex.Message);
				}
			}
		}

		public void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.BackColor = ControlXML.StrToColor(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.ForeColor = ControlXML.StrToColor(reader.Value);
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCString", false) == 0)
					{
						PCString pCString = new PCString();
						pCString.XMLDeserialize(reader);
						pCString.VChanged += new PCString.VChangedEventHandler(this.VChangedProcess);
						this.Controls.Add(pCString);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCNumber", false) == 0)
					{
						PCNumber pCNumber = new PCNumber();
						pCNumber.XMLDeserialize(reader);
						pCNumber.VChanged += new PCNumber.VChangedEventHandler(this.VChangedProcess);
						this.Controls.Add(pCNumber);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCMonoChoice", false) == 0)
					{
						PCMonoChoice pCMonoChoice = new PCMonoChoice();
						pCMonoChoice.XMLDeserialize(reader);
						pCMonoChoice.VChanged += new PCMonoChoice.VChangedEventHandler(this.VChangedProcess);
						this.Controls.Add(pCMonoChoice);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCMultiChoice", false) == 0)
					{
						PCMultiChoice pCMultiChoice = new PCMultiChoice();
						pCMultiChoice.XMLDeserialize(reader);
						pCMultiChoice.VChanged += new PCMultiChoice.VChangedEventHandler(this.VChangedProcess);
						this.Controls.Add(pCMultiChoice);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCDictionary", false) == 0)
					{
						PCDictionary pCDictionary = new PCDictionary();
						pCDictionary.XMLDeserialize(reader);
						pCDictionary.VChanged += new PCDictionary.VChangedEventHandler(this.VChangedProcess);
						this.Controls.Add(pCDictionary);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCPosition", false) == 0)
					{
						PCPosition pCPosition = new PCPosition();
						pCPosition.XMLDeserialize(reader);
						pCPosition.VChanged += new PCPosition.VChangedEventHandler(this.VChangedProcess);
						this.Controls.Add(pCPosition);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCDateTime", false) == 0)
					{
						PCDateTime pCDateTime = new PCDateTime();
						pCDateTime.XMLDeserialize(reader);
						pCDateTime.VChanged += new PCDateTime.VChangedEventHandler(this.VChangedProcess);
						this.Controls.Add(pCDateTime);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCQuantity", false) == 0)
					{
						PCQuantity pCQuantity = new PCQuantity();
						pCQuantity.XMLDeserialize(reader);
						pCQuantity.VChanged += new PCQuantity.VChangedEventHandler(this.VChangedProcess);
						this.Controls.Add(pCQuantity);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCTextEdit", false) == 0)
					{
						PCTextEdit pCTextEdit = new PCTextEdit();
						pCTextEdit.XMLDeserialize(reader);
						this.Controls.Add(pCTextEdit);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCImageAnnotate", false) == 0)
					{
						PCImageAnnotate pCImageAnnotate = new PCImageAnnotate();
						pCImageAnnotate.XMLDeserialize(reader);
						this.Controls.Add(pCImageAnnotate);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCTable", false) == 0)
					{
						PCTable pCTable = new PCTable();
						pCTable.XMLDeserialize(reader);
						this.Controls.Add(pCTable);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCLabel", false) == 0)
					{
						PCLabel pCLabel = new PCLabel();
						pCLabel.XMLDeserialize(reader);
						this.Controls.Add(pCLabel);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCVLine", false) == 0)
					{
						PCVline pCVline = new PCVline();
						pCVline.XMLDeserialize(reader);
						this.Controls.Add(pCVline);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCHLine", false) == 0)
					{
						PCHLine pCHLine = new PCHLine();
						pCHLine.XMLDeserialize(reader);
						this.Controls.Add(pCHLine);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCBox", false) == 0)
					{
						PCBox pCBox = new PCBox();
						pCBox.XMLDeserialize(reader);
						this.Controls.Add(pCBox);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCAlignTable", false) == 0)
					{
						PCAlignTable pCAlignTable = new PCAlignTable();
						pCAlignTable.InstanceData = this.InstanceData;
						pCAlignTable.XMLDeserialize(reader);
						this.Controls.Add(pCAlignTable);
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCFigure", false) == 0)
					{
						PCFigure pCFigure = new PCFigure();
						pCFigure.XMLDeserialize(reader);
						this.Controls.Add(pCFigure);
					}
					else if (reader.NodeType == XmlNodeType.EndElement & Operators.CompareString(reader.Name, "SubItems", false) == 0)
					{
						break;
					}
				}
			}
		}

		private string GetDefaultDesignKB(NITextDesc curNITextDesc)
		{
			string result = string.Empty;
			NInstanceItemEnumerator enumerator = curNITextDesc.SubItems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				NInstanceItem nInstanceItem = (NInstanceItem)enumerator.Current;
				if (nInstanceItem is NISegment)
				{
					NISegment nISegment = (NISegment)nInstanceItem;
					string code = nISegment.Code;
					string kBNodeID = nISegment.KBNodeID;
					int num = Conversions.ToInteger(nISegment.SegmentNumber);
					result = string.Format("{0}|{1}|{2}", code, kBNodeID, num);
					break;
				}
			}
			return result;
		}

		private void SetPCTextEditDefaultDB(PCTextEdit curPCTextEdit, int kbBaseID, int kbPartNo)
		{
			if (this.InstanceStatus == null || Operators.CompareString(this.InstanceStatus, "UnSave", false) == 0)
			{
				string valueByKey = GlobalValues.GetValueByKey("CTLocID");
				string valueByKey2 = GlobalValues.GetValueByKey("EpisodeID");
				string sysOptionValue = SysOptionManager.GetSysOptionValue("LoadDefaultDiagnosKB", "Y");
				if (!string.IsNullOrEmpty(valueByKey2) && Operators.CompareString(sysOptionValue.ToUpper(), "Y", false) == 0)
				{
					this.SetPCTextEditDefaultKBDetail(curPCTextEdit, kbBaseID, kbPartNo, valueByKey2);
				}
			}
		}

		private void SetPCTextEditDefaultKBDetail(PCTextEdit curPCTextEdit, int kbBaseID, int kbPartNo, string episodeID)
		{
			string defaultDesignKB = this.GetDefaultDesignKB((NITextDesc)curPCTextEdit.BindInstanceItem);
			EKBNode defaultKBNodeByLocDiagnosID = WebServiceLayer.KBNodeAccess.GetDefaultKBNodeByLocDiagnosID(episodeID, Conversions.ToString(kbBaseID));
			if (defaultKBNodeByLocDiagnosID != null)
			{
				string text = string.Empty;
				string text2 = string.Empty;
				if (!string.IsNullOrEmpty(defaultDesignKB.Trim()))
				{
					text = defaultDesignKB.Split(new char[]
					{
						'|'
					})[1];
					text2 = defaultDesignKB.Split(new char[]
					{
						'|'
					})[2];
					if (text.Equals(defaultKBNodeByLocDiagnosID.ID) & text2.Equals(kbPartNo.ToString()))
					{
						return;
					}
				}
				string text3 = string.Empty;
				string xMLString = string.Empty;
				switch (kbPartNo)
				{
				case 1:
					text3 = defaultKBNodeByLocDiagnosID.S1MetaData;
					xMLString = defaultKBNodeByLocDiagnosID.S1InstanceData;
					break;
				case 2:
					text3 = defaultKBNodeByLocDiagnosID.S2MetaData;
					xMLString = defaultKBNodeByLocDiagnosID.S2InstanceData;
					break;
				case 3:
					text3 = defaultKBNodeByLocDiagnosID.S3MetaData;
					xMLString = defaultKBNodeByLocDiagnosID.S3InstanceData;
					break;
				default:
					text3 = defaultKBNodeByLocDiagnosID.S1MetaData;
					xMLString = defaultKBNodeByLocDiagnosID.S1InstanceData;
					break;
				}
				if (!string.IsNullOrEmpty(text3))
				{
					MISegment mISegment = new MISegment();
					NISegment nISegment = new NISegment();
					mISegment.XMLString = text3;
					nISegment.XMLString = xMLString;
					nISegment.SyncMetaItem(mISegment);
					this.RefreshFontSize(nISegment, curPCTextEdit.Font.Size);
					curPCTextEdit.ReplaceItem(nISegment);
					nISegment.EPRDataBind();
					nISegment.SystemDataBind();
				}
			}
		}

		public void BindInstance()
		{
			string str = "";
			checked
			{
				try
				{
					try
					{
						IEnumerator enumerator = this.Controls.GetEnumerator();
						while (enumerator.MoveNext())
						{
							Control control = (Control)enumerator.Current;
							str = control.Name;
							if (control is PCLabel)
							{
								PCLabel pCLabel = (PCLabel)control;
								pCLabel.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCLabel.Code);
							}
							else if (control is PCString)
							{
								PCString pCString = (PCString)control;
								pCString.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCString.Code);
							}
							else if (control is PCNumber)
							{
								PCNumber pCNumber = (PCNumber)control;
								pCNumber.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCNumber.Code);
							}
							else if (control is PCMonoChoice)
							{
								PCMonoChoice pCMonoChoice = (PCMonoChoice)control;
								pCMonoChoice.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCMonoChoice.Code);
							}
							else if (control is PCMultiChoice)
							{
								PCMultiChoice pCMultiChoice = (PCMultiChoice)control;
								pCMultiChoice.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCMultiChoice.Code);
							}
							else if (control is PCDateTime)
							{
								PCDateTime pCDateTime = (PCDateTime)control;
								pCDateTime.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCDateTime.Code);
							}
							else if (control is PCDictionary)
							{
								PCDictionary pCDictionary = (PCDictionary)control;
								pCDictionary.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCDictionary.Code);
							}
							else if (control is PCPosition)
							{
								PCPosition pCPosition = (PCPosition)control;
								pCPosition.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCPosition.Code);
							}
							else if (control is PCQuantity)
							{
								PCQuantity pCQuantity = (PCQuantity)control;
								pCQuantity.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCQuantity.Code);
							}
							else if (control is PCTable)
							{
								PCTable pCTable = (PCTable)control;
								pCTable.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCTable.Code);
							}
							else if (control is PCImageAnnotate)
							{
								PCImageAnnotate pCImageAnnotate = (PCImageAnnotate)control;
								pCImageAnnotate.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCImageAnnotate.Code);
							}
							else if (control is PCTextEdit)
							{
								PCTextEdit pCTextEdit = (PCTextEdit)control;
								pCTextEdit.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCTextEdit.Code);
								if (pCTextEdit.BindInstanceItem is NITextDesc)
								{
									MITextDesc mITextDesc = (MITextDesc)pCTextEdit.BindInstanceItem.BindMMetaItem;
									if (!string.IsNullOrEmpty(mITextDesc.BindKBBaseID))
									{
										this.boolSingleKB = true;
										if (mITextDesc.BindDefaultKB)
										{
											this.SetPCTextEditDefaultDB(pCTextEdit, Convert.ToInt32(mITextDesc.BindKBBaseID), Convert.ToInt32((int)mITextDesc.BindKBPart));
										}
										if (!this._PCTextEditHashtable.Contains(pCTextEdit.Code))
										{
											this._PCTextEditHashtable.Add(pCTextEdit.Code, pCTextEdit);
										}
									}
									else
									{
										this.boolSingleKB = false;
										if (mITextDesc.BindDefaultKB)
										{
											this.SetPCTextEditDefaultDB(pCTextEdit, Convert.ToInt32(((MMetaData)this._InstanceData.BindMMetaItem).BindKBCode), Convert.ToInt32((int)mITextDesc.BindKBPart));
										}
										if (mITextDesc.BindKBPart == KBPart.First)
										{
											this._TextDescEdit1 = pCTextEdit;
										}
										else if (mITextDesc.BindKBPart == KBPart.Second)
										{
											this._TextDescEdit2 = pCTextEdit;
										}
										else if (mITextDesc.BindKBPart == KBPart.Third)
										{
											this._TextDescEdit3 = pCTextEdit;
										}
									}
								}
								pCTextEdit.OnPCTextEditGetFocus += new PCTextEdit.GetFocusHandler(this.PCTextEdit_GetFocus);
							}
							else if (control is PCFigure)
							{
								PCFigure pCFigure = (PCFigure)control;
								pCFigure.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(pCFigure.Code);
							}
							else if (control is PCAlignTable)
							{
								PCAlignTable pCAlignTable = (PCAlignTable)control;
								pCAlignTable.InstanceData = this.InstanceData;
								int arg_3C4_0 = 1;
								int rowCount = pCAlignTable.get_RowCount();
								for (int i = arg_3C4_0; i <= rowCount; i++)
								{
									int arg_3D5_0 = 1;
									int colCount = pCAlignTable.get_ColCount();
									for (int j = arg_3D5_0; j <= colCount; j++)
									{
										object objectValue = RuntimeHelpers.GetObjectValue(pCAlignTable.get_Item(i, j).get_Tag());
										if (objectValue != null && objectValue is string)
										{
											NInstanceItem nInstanceItem = this._InstanceData.FindInstanceItemByCode(Conversions.ToString(objectValue));
											if (nInstanceItem != null)
											{
												if (nInstanceItem.BindMMetaItem is MIQuantity)
												{
													pCAlignTable.get_Item(i, j).set_Text(nInstanceItem.Value + nInstanceItem.ValueCode);
												}
												else
												{
													pCAlignTable.get_Item(i, j).set_Text(nInstanceItem.Value);
												}
											}
										}
									}
								}
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception expr_4A6)
				{
					ProjectData.SetProjectError(expr_4A6);
					Exception ex = expr_4A6;
					MessageManager.ShowWarningMessage("BindInstance失败！失败单元：" + str + "  失败原因：" + ex.Message);
					ProjectData.ClearProjectError();
				}
			}
		}

		private void CompileCompute()
		{
			MMetaData mMetaData = (MMetaData)this._InstanceData.BindMMetaItem;
			this.CalFormulas = mMetaData.CalculateFormulaItems;
			this.CalFormulas.NInstanceData = this._InstanceData;
			try
			{
				MFormulaItemEnumerator enumerator = this.CalFormulas.GetEnumerator();
				while (enumerator.MoveNext())
				{
					MFormulaItem mFormulaItem = (MFormulaItem)enumerator.Current;
					mFormulaItem.Formula.Compile();
				}
			}
			catch (ApplicationException expr_60)
			{
				ProjectData.SetProjectError(expr_60);
				MessageManager.ShowWarningMessage("自动计算公式编译有问题！");
				this.boolAutoCal = false;
				ProjectData.ClearProjectError();
			}
			this.AuditFormulas = mMetaData.AuditFormulaItems;
			this.AuditFormulas.NInstanceData = this._InstanceData;
			try
			{
				MFormulaItemEnumerator enumerator2 = this.AuditFormulas.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					MFormulaItem mFormulaItem2 = (MFormulaItem)enumerator2.Current;
					mFormulaItem2.Formula.Compile();
				}
			}
			catch (ApplicationException expr_CF)
			{
				ProjectData.SetProjectError(expr_CF);
				MessageManager.ShowWarningMessage("自动审核公式编译有问题！");
				this.boolAudit = false;
				ProjectData.ClearProjectError();
			}
			this.TipFormulas = mMetaData.TipFormulaItems;
			this.TipFormulas.NInstanceData = this._InstanceData;
			try
			{
				MFormulaItemEnumerator enumerator3 = this.TipFormulas.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					MFormulaItem mFormulaItem3 = (MFormulaItem)enumerator3.Current;
					mFormulaItem3.Formula.Compile();
				}
			}
			catch (ApplicationException expr_141)
			{
				ProjectData.SetProjectError(expr_141);
				MessageManager.ShowWarningMessage("提示公式编译有问题！");
				this.boolTip = false;
				ProjectData.ClearProjectError();
			}
		}

		public CheckMsgCollection Check()
		{
			this.CheckErrors.Clear();
			ArrayList arrayList = new ArrayList();
			int num = 0;
			checked
			{
				try
				{
					IEnumerator enumerator = this.Controls.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Control control = (Control)enumerator.Current;
						if (control is ICheck)
						{
							ICheck check = (ICheck)control;
							CheckMsg checkMsg = check.CheckNull();
							if (checkMsg != null)
							{
								for (int i = arrayList.Count - 1; i >= 0; i += -1)
								{
									if (Operators.ConditionalCompareObjectGreaterEqual(control.TabIndex, arrayList[i], false))
									{
										num = i + 1;
										break;
									}
									num = 0;
								}
								if (num == arrayList.Count)
								{
									this.CheckErrors.Add(checkMsg);
									arrayList.Add(control.TabIndex);
								}
								else
								{
									this.CheckErrors.Insert(num, checkMsg);
									arrayList.Insert(num, control.TabIndex);
								}
							}
							checkMsg = check.SpecialCheck();
							if (checkMsg != null)
							{
								for (int j = arrayList.Count - 1; j >= 0; j += -1)
								{
									if (Operators.ConditionalCompareObjectGreaterEqual(control.TabIndex, arrayList[j], false))
									{
										num = j + 1;
										break;
									}
									num = 0;
								}
								if (num == arrayList.Count)
								{
									this.CheckErrors.Add(checkMsg);
									arrayList.Add(control.TabIndex);
								}
								else
								{
									this.CheckErrors.Insert(num, checkMsg);
									arrayList.Insert(num, control.TabIndex);
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (this.boolAudit)
				{
					MFormulaItemEnumerator enumerator2 = this.AuditFormulas.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						MFormulaItem mFormulaItem = (MFormulaItem)enumerator2.Current;
						string auditResult = mFormulaItem.Formula.Calculate();
						if (!CFormula.IsAuditResultOK(auditResult))
						{
							CheckMsg checkMsg2 = new CheckMsg();
							checkMsg2.CheckType = ECheckType.Formula;
							checkMsg2.ErrorDesc = mFormulaItem.Description;
							checkMsg2.RelatedElements = mFormulaItem.Formula.NIHashTable;
							checkMsg2.RelatedObject = mFormulaItem.Formula;
							this.CheckErrors.Add(checkMsg2);
						}
					}
				}
				return this.CheckErrors;
			}
		}

		public void SetMsg(Hashtable relatedctrls, bool hasError)
		{
			try
			{
				IEnumerator enumerator = this.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					if (control is PControlInterface & !(control is PCLabel))
					{
						PControlInterface pControlInterface = (PControlInterface)control;
						object objectValue = RuntimeHelpers.GetObjectValue(relatedctrls[pControlInterface.BindInstanceItem.Code]);
						if (objectValue != null)
						{
							ICheck check = (ICheck)control;
							check.SetMsg(hasError);
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		public void RunControlCalFormula()
		{
			MFormulaItemEnumerator enumerator = this.CalFormulas.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MFormulaItem mFormulaItem = (MFormulaItem)enumerator.Current;
				if (mFormulaItem.Formula.IsControlVType())
				{
					string strPropretyValue = mFormulaItem.Formula.Calculate();
					this.SetControlPropertyByCode(mFormulaItem.Formula.ResultCode, mFormulaItem.Formula.ResultType, strPropretyValue);
				}
			}
		}

		private PControlInterface FindCtrlByCode(string strCode)
		{
			try
			{
				IEnumerator enumerator = this.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					if (control is PControlInterface & !(control is PCLabel))
					{
						PControlInterface pControlInterface = (PControlInterface)control;
						if (Operators.CompareString(pControlInterface.BindInstanceItem.Code, strCode, false) == 0)
						{
							return pControlInterface;
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return null;
		}

		private void VChangedProcess(string strCode)
		{
			checked
			{
				try
				{
					MFormulaItemEnumerator enumerator = this.CalFormulas.GetEnumerator();
					while (enumerator.MoveNext())
					{
						MFormulaItem mFormulaItem = (MFormulaItem)enumerator.Current;
						if (mFormulaItem.Formula.NeedCaculate(strCode))
						{
							string text = mFormulaItem.Formula.Calculate();
							string resultType = mFormulaItem.Formula.ResultType;
							if (mFormulaItem.Formula.IsControlVType())
							{
								this.SetControlPropertyByCode(mFormulaItem.Formula.ResultCode, resultType, text);
							}
							else if (mFormulaItem.Formula.IsItemVType())
							{
								if (mFormulaItem.Formula.IsItemVTypeResultValid(text))
								{
									PControlInterface pControlInterface = this.FindCtrlByCode(mFormulaItem.Formula.ResultCode);
									pControlInterface.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(mFormulaItem.Formula.ResultCode);
								}
							}
							else
							{
								PControlInterface pControlInterface2 = this.FindCtrlByCode(mFormulaItem.Formula.ResultCode);
								pControlInterface2.BindInstanceItem = this._InstanceData.FindInstanceItemByCode(mFormulaItem.Formula.ResultCode);
							}
						}
					}
					if (this.boolTip)
					{
						MFormulaItemEnumerator enumerator2 = this.TipFormulas.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							MFormulaItem mFormulaItem2 = (MFormulaItem)enumerator2.Current;
							if (mFormulaItem2.Formula.NeedCaculate(strCode))
							{
								string tipResult = mFormulaItem2.Formula.Calculate();
								if (CFormula.IsTipResultOK(tipResult))
								{
									MessageManager.ShowInformationMessage(mFormulaItem2.Description);
								}
							}
						}
					}
					bool flag = false;
					int num = this.CheckErrors.Count;
					int count = this.CheckErrors.Count;
					int i = 0;
					while (i < num)
					{
						CheckMsg checkMsg = this.CheckErrors[i];
						if (checkMsg.RelatedElements[strCode] != null)
						{
							if (checkMsg.CheckType == ECheckType.Formula)
							{
								CFormula cFormula = (CFormula)checkMsg.RelatedObject;
								if (Operators.CompareString(cFormula.Calculate(), "true", false) == 0)
								{
									this.SetMsg(checkMsg.RelatedElements, false);
									this.CheckErrors.Remove(checkMsg);
									flag = true;
								}
							}
							else
							{
								try
								{
									IEnumerator enumerator3 = this.Controls.GetEnumerator();
									while (enumerator3.MoveNext())
									{
										Control control = (Control)enumerator3.Current;
										if (control is PControlInterface & !(control is PCLabel))
										{
											PControlInterface pControlInterface3 = (PControlInterface)control;
											if (Operators.CompareString(pControlInterface3.BindInstanceItem.Code, strCode, false) == 0)
											{
												ICheck check = (ICheck)control;
												if (checkMsg.CheckType == ECheckType.Null)
												{
													if (check.CheckNull() == null)
													{
														this.SetMsg(checkMsg.RelatedElements, false);
														this.CheckErrors.Remove(checkMsg);
														flag = true;
													}
												}
												else if (checkMsg.CheckType == ECheckType.Special && check.SpecialCheck() == null)
												{
													this.SetMsg(checkMsg.RelatedElements, false);
													this.CheckErrors.Remove(checkMsg);
													flag = true;
												}
											}
										}
									}
								}
								finally
								{
									IEnumerator enumerator3;
									if (enumerator3 is IDisposable)
									{
										(enumerator3 as IDisposable).Dispose();
									}
								}
							}
						}
						if (flag)
						{
							num--;
						}
						else
						{
							i++;
						}
					}
					if (num < count)
					{
						PPanel.ErrorChangedEventHandler errorChangedEvent = this.ErrorChangedEvent;
						if (errorChangedEvent != null)
						{
							errorChangedEvent();
						}
					}
				}
				catch (ApplicationException expr_318)
				{
					ProjectData.SetProjectError(expr_318);
					MessageManager.ShowWarningMessage("自动计算或检查有问题！");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void SetControlPropertyByCode(string strCode, string strPropertyType, string strPropretyValue)
		{
			try
			{
				IEnumerator enumerator = this.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					if (control is PControlInterface)
					{
						if (!(control is PCLabel))
						{
							PControlInterface pControlInterface = (PControlInterface)control;
							if (Operators.CompareString(pControlInterface.BindInstanceItem.Code, strCode, false) == 0)
							{
								this.SetControlProperty(control, strPropertyType, strPropretyValue);
								break;
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		private void SetControlProperty(Control ctrl, string strPropertyType, string strPropertyValue)
		{
			if (Operators.CompareString(strPropertyType.ToLower(), "controle", false) == 0)
			{
				ctrl.Enabled = (Operators.CompareString(strPropertyValue.ToLower(), "false", false) != 0);
			}
			if (Operators.CompareString(strPropertyType.ToLower(), "controlv", false) == 0)
			{
				ctrl.Visible = (Operators.CompareString(strPropertyValue.ToLower(), "false", false) != 0);
			}
		}

		private void PPanel_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentPCImageAnnotate != null)
			{
				this.m_CurrentPCImageAnnotate.CloseToolForm();
			}
			this.m_CurrentPCImageAnnotate = null;
			this.Focus();
		}

		private void PCTextEdit_GetFocus(string eCode, string kbBaseID, int kbPartNo)
		{
			PPanel.RefreshBindKBTreeHandler onRefreshBindKBTreeEvent = this.OnRefreshBindKBTreeEvent;
			if (onRefreshBindKBTreeEvent != null)
			{
				onRefreshBindKBTreeEvent(eCode, kbBaseID, kbPartNo);
			}
		}

		private void ControlMouseDown(object sender, EventArgs e)
		{
			this.HandleAnnoToolForm(RuntimeHelpers.GetObjectValue(sender));
		}

		public void HandleAnnoToolForm(object sender)
		{
			if (sender is PCImageAnnotate)
			{
				if (this.m_CurrentPCImageAnnotate != null && !((PCImageAnnotate)sender).Equals(this.m_CurrentPCImageAnnotate))
				{
					this.m_CurrentPCImageAnnotate.CloseToolForm();
				}
				this.m_CurrentPCImageAnnotate = (PCImageAnnotate)sender;
			}
			else
			{
				if (this.m_CurrentPCImageAnnotate != null)
				{
					this.m_CurrentPCImageAnnotate.CloseToolForm();
				}
				this.m_CurrentPCImageAnnotate = null;
			}
		}

		private void InitVisualStyles()
		{
			if (SysOptionManager.GetSysOptionValue("XPStyle", "N").Equals("Y"))
			{
				Application.EnableVisualStyles();
			}
		}
	}
}
