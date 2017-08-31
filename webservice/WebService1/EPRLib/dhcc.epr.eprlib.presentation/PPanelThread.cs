using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.presentation.annotate;
using dhcc.epr.eprlib.presentation.figure;
using dhcc.epr.eprlib.presentation.table;
using dhcc.epr.eprlib.presentation.textedit;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace dhcc.epr.eprlib.presentation
{
	public class PPanelThread
	{
		private const int OUTTIEMCOUNT = 450;

		private XmlNodeList _ControlNodes;

		private Control[] _ControlList;

		private Color _BackColor;

		private Color _ForeColor;

		private NInstanceData _InstanceData;

		public Color BackColor
		{
			get
			{
				return this._BackColor;
			}
		}

		public Color ForeColor
		{
			get
			{
				return this._ForeColor;
			}
		}

		public NInstanceData InstanceData
		{
			set
			{
				this._InstanceData = value;
			}
		}

		public PPanelThread()
		{
			this._ControlList = new Control[701];
		}

		public Collection XMLDeserialize(string xmlText)
		{
			Collection collection = new Collection();
			checked
			{
				Collection result;
				try
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml(xmlText);
					XmlNode xmlNode = xmlDocument.SelectSingleNode("//Controls");
					this._ControlNodes = xmlNode.ChildNodes;
					int count = this._ControlNodes.Count;
					int arg_42_0 = 0;
					int num = count - 1;
					for (int i = arg_42_0; i <= num; i++)
					{
						Thread thread = new Thread(new ThreadStart(this.DeserializeControlThread));
						thread.Name = "T" + i.ToString();
						collection.Add(thread, null, null, null);
						thread.Start();
					}
					bool flag;
					bool flag2;
					while (!flag)
					{
						Thread.Sleep(20);
						flag = true;
						int num2;
						num2++;
						try
						{
							IEnumerator enumerator = collection.GetEnumerator();
							while (enumerator.MoveNext())
							{
								Thread thread2 = (Thread)enumerator.Current;
								if (thread2.IsAlive && num2 == 450)
								{
									thread2.Abort();
									flag2 = true;
								}
								else if (thread2.IsAlive)
								{
									flag = false;
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
					collection = null;
					this._ControlNodes = null;
					if (flag2)
					{
						throw new Exception(" 在创建某些单元时超时，界面不能完整序列化！");
					}
					Collection collection2 = new Collection();
					int arg_12D_0 = 0;
					int num3 = count - 1;
					for (int j = arg_12D_0; j <= num3; j++)
					{
						Control control = this._ControlList[j];
						if (control != null)
						{
							collection2.Add(control, null, null, null);
						}
					}
					if (count != collection2.Count)
					{
						throw new Exception(" 界面不能完整序列化，有 " + (count - collection2.Count).ToString() + "个控件丢失！");
					}
					result = collection2;
				}
				catch (ApplicationException expr_18A)
				{
					ProjectData.SetProjectError(expr_18A);
					ApplicationException ex = expr_18A;
					throw new Exception("PPanelControl.XMLDeserialize失败！ " + ex.Message);
				}
				return result;
			}
		}

		private void DeserializeControlThread()
		{
			try
			{
				string name = Thread.CurrentThread.Name;
				int num = Conversions.ToInteger(name.Substring(1));
				XmlNode xmlNode = this._ControlNodes.Item(num);
				StringReader stringReader = new StringReader(string.Concat(new string[]
				{
					"<",
					xmlNode.Name,
					">",
					xmlNode.InnerXml,
					"</",
					xmlNode.Name,
					">"
				}));
				XmlTextReader xmlTextReader = new XmlTextReader(stringReader);
				xmlTextReader.WhitespaceHandling = WhitespaceHandling.All;
				this.XMLDeserialize(xmlTextReader, num);
				xmlTextReader.Close();
				stringReader.Close();
			}
			catch (ApplicationException expr_A6)
			{
				ProjectData.SetProjectError(expr_A6);
				ApplicationException ex = expr_A6;
				throw new Exception(ex.Message);
			}
		}

		private void XMLDeserialize(XmlReader reader, int nodeIndex)
		{
			if (!reader.IsEmptyElement)
			{
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCString", false) == 0)
					{
						PCString pCString = new PCString();
						pCString.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCString;
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCNumber", false) == 0)
					{
						PCNumber pCNumber = new PCNumber();
						pCNumber.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCNumber;
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCMonoChoice", false) == 0)
					{
						PCMonoChoice pCMonoChoice = new PCMonoChoice();
						pCMonoChoice.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCMonoChoice;
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCMultiChoice", false) == 0)
					{
						PCMultiChoice pCMultiChoice = new PCMultiChoice();
						pCMultiChoice.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCMultiChoice;
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCDictionary", false) == 0)
					{
						PCDictionary pCDictionary = new PCDictionary();
						pCDictionary.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCDictionary;
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCPosition", false) == 0)
					{
						PCPosition pCPosition = new PCPosition();
						pCPosition.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCPosition;
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCDateTime", false) == 0)
					{
						PCDateTime pCDateTime = new PCDateTime();
						pCDateTime.initDate(Conversions.ToDate(PPanel.sysDatetime));
						pCDateTime.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCDateTime;
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCQuantity", false) == 0)
					{
						PCQuantity pCQuantity = new PCQuantity();
						pCQuantity.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCQuantity;
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCTextEdit", false) == 0)
					{
						PCTextEdit pCTextEdit = new PCTextEdit();
						pCTextEdit.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCTextEdit;
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCImageAnnotate", false) == 0)
					{
						PCImageAnnotate pCImageAnnotate = new PCImageAnnotate();
						pCImageAnnotate.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCImageAnnotate;
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCTable", false) == 0)
					{
						PCTable pCTable = new PCTable();
						pCTable.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCTable;
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCLabel", false) == 0)
					{
						PCLabel pCLabel = new PCLabel();
						pCLabel.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCLabel;
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCVLine", false) == 0)
					{
						PCVline pCVline = new PCVline();
						pCVline.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCVline;
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCHLine", false) == 0)
					{
						PCHLine pCHLine = new PCHLine();
						pCHLine.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCHLine;
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCBox", false) == 0)
					{
						PCBox pCBox = new PCBox();
						pCBox.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCBox;
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCAlignTable", false) == 0)
					{
						PCAlignTable pCAlignTable = new PCAlignTable();
						pCAlignTable.InstanceData = this._InstanceData;
						pCAlignTable.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCAlignTable;
					}
					else if (reader.NodeType == XmlNodeType.Element & Operators.CompareString(reader.Name, "PCFigure", false) == 0)
					{
						PCFigure pCFigure = new PCFigure();
						pCFigure.XMLDeserialize(reader);
						this._ControlList[nodeIndex] = pCFigure;
					}
				}
			}
		}
	}
}
