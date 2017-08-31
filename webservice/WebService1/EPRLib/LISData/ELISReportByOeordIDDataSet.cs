using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace LISData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("ELISReportByOeordIDDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class ELISReportByOeordIDDataSet : DataSet
	{
		public delegate void SelReportByOeordIDListRowChangeEventHandler(object sender, ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelReportByOeordIDListDataTable : DataTable, IEnumerable
		{
			private DataColumn columnItemDesc;

			private DataColumn columnSynonym;

			private DataColumn columnItemResult;

			private DataColumn columnItemUnit;

			private DataColumn columnAbnorFlag;

			private DataColumn columnItemRanges;

			private DataColumn columnOeordID;

			private ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler SelReportByOeordIDListRowChangingEvent;

			private ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler SelReportByOeordIDListRowChangedEvent;

			private ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler SelReportByOeordIDListRowDeletingEvent;

			private ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler SelReportByOeordIDListRowDeletedEvent;

			public event ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler SelReportByOeordIDListRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelReportByOeordIDListRowChangingEvent = (ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler)Delegate.Combine(this.SelReportByOeordIDListRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelReportByOeordIDListRowChangingEvent = (ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler)Delegate.Remove(this.SelReportByOeordIDListRowChangingEvent, value);
				}
			}

			public event ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler SelReportByOeordIDListRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelReportByOeordIDListRowChangedEvent = (ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler)Delegate.Combine(this.SelReportByOeordIDListRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelReportByOeordIDListRowChangedEvent = (ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler)Delegate.Remove(this.SelReportByOeordIDListRowChangedEvent, value);
				}
			}

			public event ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler SelReportByOeordIDListRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelReportByOeordIDListRowDeletingEvent = (ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler)Delegate.Combine(this.SelReportByOeordIDListRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelReportByOeordIDListRowDeletingEvent = (ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler)Delegate.Remove(this.SelReportByOeordIDListRowDeletingEvent, value);
				}
			}

			public event ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler SelReportByOeordIDListRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelReportByOeordIDListRowDeletedEvent = (ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler)Delegate.Combine(this.SelReportByOeordIDListRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelReportByOeordIDListRowDeletedEvent = (ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler)Delegate.Remove(this.SelReportByOeordIDListRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ItemDescColumn
			{
				get
				{
					return this.columnItemDesc;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn SynonymColumn
			{
				get
				{
					return this.columnSynonym;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ItemResultColumn
			{
				get
				{
					return this.columnItemResult;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ItemUnitColumn
			{
				get
				{
					return this.columnItemUnit;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn AbnorFlagColumn
			{
				get
				{
					return this.columnAbnorFlag;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ItemRangesColumn
			{
				get
				{
					return this.columnItemRanges;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OeordIDColumn
			{
				get
				{
					return this.columnOeordID;
				}
			}

			[Browsable(false), DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			public ELISReportByOeordIDDataSet.SelReportByOeordIDListRow this[int index]
			{
				get
				{
					return (ELISReportByOeordIDDataSet.SelReportByOeordIDListRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelReportByOeordIDListDataTable()
			{
				this.TableName = "SelReportByOeordIDList";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelReportByOeordIDListDataTable(DataTable table)
			{
				this.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					this.CaseSensitive = table.CaseSensitive;
				}
				if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
				{
					this.Locale = table.Locale;
				}
				if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
				{
					this.Namespace = table.Namespace;
				}
				this.Prefix = table.Prefix;
				this.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			protected SelReportByOeordIDListDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelReportByOeordIDListRow(ELISReportByOeordIDDataSet.SelReportByOeordIDListRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public ELISReportByOeordIDDataSet.SelReportByOeordIDListRow AddSelReportByOeordIDListRow(string ItemDesc, string Synonym, string ItemResult, string ItemUnit, string AbnorFlag, string ItemRanges, string OeordID)
			{
				ELISReportByOeordIDDataSet.SelReportByOeordIDListRow selReportByOeordIDListRow = (ELISReportByOeordIDDataSet.SelReportByOeordIDListRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ItemDesc,
					Synonym,
					ItemResult,
					ItemUnit,
					AbnorFlag,
					ItemRanges,
					OeordID
				};
				selReportByOeordIDListRow.ItemArray = itemArray;
				this.Rows.Add(selReportByOeordIDListRow);
				return selReportByOeordIDListRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				ELISReportByOeordIDDataSet.SelReportByOeordIDListDataTable selReportByOeordIDListDataTable = (ELISReportByOeordIDDataSet.SelReportByOeordIDListDataTable)base.Clone();
				selReportByOeordIDListDataTable.InitVars();
				return selReportByOeordIDListDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new ELISReportByOeordIDDataSet.SelReportByOeordIDListDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnItemDesc = base.Columns["ItemDesc"];
				this.columnSynonym = base.Columns["Synonym"];
				this.columnItemResult = base.Columns["ItemResult"];
				this.columnItemUnit = base.Columns["ItemUnit"];
				this.columnAbnorFlag = base.Columns["AbnorFlag"];
				this.columnItemRanges = base.Columns["ItemRanges"];
				this.columnOeordID = base.Columns["OeordID"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnItemDesc = new DataColumn("ItemDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnItemDesc);
				this.columnSynonym = new DataColumn("Synonym", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSynonym);
				this.columnItemResult = new DataColumn("ItemResult", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnItemResult);
				this.columnItemUnit = new DataColumn("ItemUnit", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnItemUnit);
				this.columnAbnorFlag = new DataColumn("AbnorFlag", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAbnorFlag);
				this.columnItemRanges = new DataColumn("ItemRanges", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnItemRanges);
				this.columnOeordID = new DataColumn("OeordID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOeordID);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public ELISReportByOeordIDDataSet.SelReportByOeordIDListRow NewSelReportByOeordIDListRow()
			{
				return (ELISReportByOeordIDDataSet.SelReportByOeordIDListRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new ELISReportByOeordIDDataSet.SelReportByOeordIDListRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(ELISReportByOeordIDDataSet.SelReportByOeordIDListRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelReportByOeordIDListRowChangedEvent != null)
				{
					ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler selReportByOeordIDListRowChangedEvent = this.SelReportByOeordIDListRowChangedEvent;
					if (selReportByOeordIDListRowChangedEvent != null)
					{
						selReportByOeordIDListRowChangedEvent(this, new ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEvent((ELISReportByOeordIDDataSet.SelReportByOeordIDListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelReportByOeordIDListRowChangingEvent != null)
				{
					ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler selReportByOeordIDListRowChangingEvent = this.SelReportByOeordIDListRowChangingEvent;
					if (selReportByOeordIDListRowChangingEvent != null)
					{
						selReportByOeordIDListRowChangingEvent(this, new ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEvent((ELISReportByOeordIDDataSet.SelReportByOeordIDListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelReportByOeordIDListRowDeletedEvent != null)
				{
					ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler selReportByOeordIDListRowDeletedEvent = this.SelReportByOeordIDListRowDeletedEvent;
					if (selReportByOeordIDListRowDeletedEvent != null)
					{
						selReportByOeordIDListRowDeletedEvent(this, new ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEvent((ELISReportByOeordIDDataSet.SelReportByOeordIDListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelReportByOeordIDListRowDeletingEvent != null)
				{
					ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEventHandler selReportByOeordIDListRowDeletingEvent = this.SelReportByOeordIDListRowDeletingEvent;
					if (selReportByOeordIDListRowDeletingEvent != null)
					{
						selReportByOeordIDListRowDeletingEvent(this, new ELISReportByOeordIDDataSet.SelReportByOeordIDListRowChangeEvent((ELISReportByOeordIDDataSet.SelReportByOeordIDListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelReportByOeordIDListRow(ELISReportByOeordIDDataSet.SelReportByOeordIDListRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				ELISReportByOeordIDDataSet eLISReportByOeordIDDataSet = new ELISReportByOeordIDDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				XmlSchemaParticle arg_31_0 = xmlSchemaAny;
				decimal minOccurs = new decimal(0);
				arg_31_0.MinOccurs = minOccurs;
				xmlSchemaAny.MaxOccurs = 79228162514264337593543950335m;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				XmlSchemaParticle arg_8B_0 = xmlSchemaAny2;
				minOccurs = new decimal(1);
				arg_8B_0.MinOccurs = minOccurs;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = eLISReportByOeordIDDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelReportByOeordIDListDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eLISReportByOeordIDDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							XmlSchema xmlSchema = (XmlSchema)enumerator.Current;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelReportByOeordIDListRow : DataRow
		{
			private ELISReportByOeordIDDataSet.SelReportByOeordIDListDataTable tableSelReportByOeordIDList;

			[DebuggerNonUserCode]
			public string ItemDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelReportByOeordIDList.ItemDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelReportByOeordIDList\"中列\"ItemDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelReportByOeordIDList.ItemDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Synonym
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelReportByOeordIDList.SynonymColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelReportByOeordIDList\"中列\"Synonym\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelReportByOeordIDList.SynonymColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ItemResult
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelReportByOeordIDList.ItemResultColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelReportByOeordIDList\"中列\"ItemResult\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelReportByOeordIDList.ItemResultColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ItemUnit
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelReportByOeordIDList.ItemUnitColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelReportByOeordIDList\"中列\"ItemUnit\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelReportByOeordIDList.ItemUnitColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string AbnorFlag
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelReportByOeordIDList.AbnorFlagColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelReportByOeordIDList\"中列\"AbnorFlag\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelReportByOeordIDList.AbnorFlagColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ItemRanges
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelReportByOeordIDList.ItemRangesColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelReportByOeordIDList\"中列\"ItemRanges\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelReportByOeordIDList.ItemRangesColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OeordID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelReportByOeordIDList.OeordIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelReportByOeordIDList\"中列\"OeordID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelReportByOeordIDList.OeordIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelReportByOeordIDListRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelReportByOeordIDList = (ELISReportByOeordIDDataSet.SelReportByOeordIDListDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsItemDescNull()
			{
				return this.IsNull(this.tableSelReportByOeordIDList.ItemDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetItemDescNull()
			{
				this[this.tableSelReportByOeordIDList.ItemDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsSynonymNull()
			{
				return this.IsNull(this.tableSelReportByOeordIDList.SynonymColumn);
			}

			[DebuggerNonUserCode]
			public void SetSynonymNull()
			{
				this[this.tableSelReportByOeordIDList.SynonymColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsItemResultNull()
			{
				return this.IsNull(this.tableSelReportByOeordIDList.ItemResultColumn);
			}

			[DebuggerNonUserCode]
			public void SetItemResultNull()
			{
				this[this.tableSelReportByOeordIDList.ItemResultColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsItemUnitNull()
			{
				return this.IsNull(this.tableSelReportByOeordIDList.ItemUnitColumn);
			}

			[DebuggerNonUserCode]
			public void SetItemUnitNull()
			{
				this[this.tableSelReportByOeordIDList.ItemUnitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsAbnorFlagNull()
			{
				return this.IsNull(this.tableSelReportByOeordIDList.AbnorFlagColumn);
			}

			[DebuggerNonUserCode]
			public void SetAbnorFlagNull()
			{
				this[this.tableSelReportByOeordIDList.AbnorFlagColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsItemRangesNull()
			{
				return this.IsNull(this.tableSelReportByOeordIDList.ItemRangesColumn);
			}

			[DebuggerNonUserCode]
			public void SetItemRangesNull()
			{
				this[this.tableSelReportByOeordIDList.ItemRangesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOeordIDNull()
			{
				return this.IsNull(this.tableSelReportByOeordIDList.OeordIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetOeordIDNull()
			{
				this[this.tableSelReportByOeordIDList.OeordIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelReportByOeordIDListRowChangeEvent : EventArgs
		{
			private ELISReportByOeordIDDataSet.SelReportByOeordIDListRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public ELISReportByOeordIDDataSet.SelReportByOeordIDListRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			public SelReportByOeordIDListRowChangeEvent(ELISReportByOeordIDDataSet.SelReportByOeordIDListRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private ELISReportByOeordIDDataSet.SelReportByOeordIDListDataTable tableSelReportByOeordIDList;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public ELISReportByOeordIDDataSet.SelReportByOeordIDListDataTable SelReportByOeordIDList
		{
			get
			{
				return this.tableSelReportByOeordIDList;
			}
		}

		[Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), DebuggerNonUserCode]
		public override SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this._schemaSerializationMode;
			}
			set
			{
				this._schemaSerializationMode = value;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		[DebuggerNonUserCode]
		public ELISReportByOeordIDDataSet()
		{
			this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			this.EndInit();
		}

		[DebuggerNonUserCode]
		protected ELISReportByOeordIDDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			if (this.IsBinarySerialized(info, context))
			{
				this.InitVars(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
				return;
			}
			string s = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
			if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				if (dataSet.Tables["SelReportByOeordIDList"] != null)
				{
					base.Tables.Add(new ELISReportByOeordIDDataSet.SelReportByOeordIDListDataTable(dataSet.Tables["SelReportByOeordIDList"]));
				}
				this.DataSetName = dataSet.DataSetName;
				this.Prefix = dataSet.Prefix;
				this.Namespace = dataSet.Namespace;
				this.Locale = dataSet.Locale;
				this.CaseSensitive = dataSet.CaseSensitive;
				this.EnforceConstraints = dataSet.EnforceConstraints;
				this.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				this.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			}
			this.GetSerializationData(info, context);
			CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value2;
			this.Relations.CollectionChanged += value2;
		}

		[DebuggerNonUserCode]
		protected override void InitializeDerivedDataSet()
		{
			this.BeginInit();
			this.InitClass();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		public override DataSet Clone()
		{
			ELISReportByOeordIDDataSet eLISReportByOeordIDDataSet = (ELISReportByOeordIDDataSet)base.Clone();
			eLISReportByOeordIDDataSet.InitVars();
			eLISReportByOeordIDDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return eLISReportByOeordIDDataSet;
		}

		[DebuggerNonUserCode]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		[DebuggerNonUserCode]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		[DebuggerNonUserCode]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["SelReportByOeordIDList"] != null)
				{
					base.Tables.Add(new ELISReportByOeordIDDataSet.SelReportByOeordIDListDataTable(dataSet.Tables["SelReportByOeordIDList"]));
				}
				this.DataSetName = dataSet.DataSetName;
				this.Prefix = dataSet.Prefix;
				this.Namespace = dataSet.Namespace;
				this.Locale = dataSet.Locale;
				this.CaseSensitive = dataSet.CaseSensitive;
				this.EnforceConstraints = dataSet.EnforceConstraints;
				this.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				this.ReadXml(reader);
				this.InitVars();
			}
		}

		[DebuggerNonUserCode]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			this.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		[DebuggerNonUserCode]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		[DebuggerNonUserCode]
		internal void InitVars(bool initTable)
		{
			this.tableSelReportByOeordIDList = (ELISReportByOeordIDDataSet.SelReportByOeordIDListDataTable)base.Tables["SelReportByOeordIDList"];
			if (initTable && this.tableSelReportByOeordIDList != null)
			{
				this.tableSelReportByOeordIDList.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "ELISReportByOeordIDDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/ELISReportByOeordIDDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelReportByOeordIDList = new ELISReportByOeordIDDataSet.SelReportByOeordIDListDataTable();
			base.Tables.Add(this.tableSelReportByOeordIDList);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelReportByOeordIDList()
		{
			return false;
		}

		[DebuggerNonUserCode]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			ELISReportByOeordIDDataSet eLISReportByOeordIDDataSet = new ELISReportByOeordIDDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eLISReportByOeordIDDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eLISReportByOeordIDDataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						XmlSchema xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						memoryStream.Close();
					}
					if (memoryStream2 != null)
					{
						memoryStream2.Close();
					}
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}
}
