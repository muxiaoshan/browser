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

namespace GlossaryData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EGlossaryDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EGlossaryDataset : DataSet
	{
		public delegate void SelectAllByCategoryIDRowChangeEventHandler(object sender, EGlossaryDataset.SelectAllByCategoryIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectAllByCategoryIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnDescription;

			private DataColumn columnGUID;

			private DataColumn columnGlossaryCategoryID;

			private DataColumn columnGlossaryType;

			private DataColumn columnChildCount;

			private DataColumn columnInternalID;

			private DataColumn columnMetaID;

			private EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler SelectAllByCategoryIDRowChangingEvent;

			private EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler SelectAllByCategoryIDRowChangedEvent;

			private EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler SelectAllByCategoryIDRowDeletingEvent;

			private EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler SelectAllByCategoryIDRowDeletedEvent;

			public event EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler SelectAllByCategoryIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllByCategoryIDRowChangingEvent = (EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler)Delegate.Combine(this.SelectAllByCategoryIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllByCategoryIDRowChangingEvent = (EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler)Delegate.Remove(this.SelectAllByCategoryIDRowChangingEvent, value);
				}
			}

			public event EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler SelectAllByCategoryIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllByCategoryIDRowChangedEvent = (EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler)Delegate.Combine(this.SelectAllByCategoryIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllByCategoryIDRowChangedEvent = (EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler)Delegate.Remove(this.SelectAllByCategoryIDRowChangedEvent, value);
				}
			}

			public event EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler SelectAllByCategoryIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllByCategoryIDRowDeletingEvent = (EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler)Delegate.Combine(this.SelectAllByCategoryIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllByCategoryIDRowDeletingEvent = (EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler)Delegate.Remove(this.SelectAllByCategoryIDRowDeletingEvent, value);
				}
			}

			public event EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler SelectAllByCategoryIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllByCategoryIDRowDeletedEvent = (EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler)Delegate.Combine(this.SelectAllByCategoryIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllByCategoryIDRowDeletedEvent = (EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler)Delegate.Remove(this.SelectAllByCategoryIDRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn IDColumn
			{
				get
				{
					return this.columnID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DescriptionColumn
			{
				get
				{
					return this.columnDescription;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn GUIDColumn
			{
				get
				{
					return this.columnGUID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn GlossaryCategoryIDColumn
			{
				get
				{
					return this.columnGlossaryCategoryID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn GlossaryTypeColumn
			{
				get
				{
					return this.columnGlossaryType;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ChildCountColumn
			{
				get
				{
					return this.columnChildCount;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn InternalIDColumn
			{
				get
				{
					return this.columnInternalID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn MetaIDColumn
			{
				get
				{
					return this.columnMetaID;
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
			public EGlossaryDataset.SelectAllByCategoryIDRow this[int index]
			{
				get
				{
					return (EGlossaryDataset.SelectAllByCategoryIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectAllByCategoryIDDataTable()
			{
				this.TableName = "SelectAllByCategoryID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectAllByCategoryIDDataTable(DataTable table)
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
			protected SelectAllByCategoryIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectAllByCategoryIDRow(EGlossaryDataset.SelectAllByCategoryIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EGlossaryDataset.SelectAllByCategoryIDRow AddSelectAllByCategoryIDRow(long ID, string Name, string Description, string GUID, string GlossaryCategoryID, string GlossaryType, string ChildCount, string InternalID, string MetaID)
			{
				EGlossaryDataset.SelectAllByCategoryIDRow selectAllByCategoryIDRow = (EGlossaryDataset.SelectAllByCategoryIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					Description,
					GUID,
					GlossaryCategoryID,
					GlossaryType,
					ChildCount,
					InternalID,
					MetaID
				};
				selectAllByCategoryIDRow.ItemArray = itemArray;
				this.Rows.Add(selectAllByCategoryIDRow);
				return selectAllByCategoryIDRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EGlossaryDataset.SelectAllByCategoryIDDataTable selectAllByCategoryIDDataTable = (EGlossaryDataset.SelectAllByCategoryIDDataTable)base.Clone();
				selectAllByCategoryIDDataTable.InitVars();
				return selectAllByCategoryIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EGlossaryDataset.SelectAllByCategoryIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnDescription = base.Columns["Description"];
				this.columnGUID = base.Columns["GUID"];
				this.columnGlossaryCategoryID = base.Columns["GlossaryCategoryID"];
				this.columnGlossaryType = base.Columns["GlossaryType"];
				this.columnChildCount = base.Columns["ChildCount"];
				this.columnInternalID = base.Columns["InternalID"];
				this.columnMetaID = base.Columns["MetaID"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				this.columnGUID = new DataColumn("GUID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGUID);
				this.columnGlossaryCategoryID = new DataColumn("GlossaryCategoryID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGlossaryCategoryID);
				this.columnGlossaryType = new DataColumn("GlossaryType", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGlossaryType);
				this.columnChildCount = new DataColumn("ChildCount", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnChildCount);
				this.columnInternalID = new DataColumn("InternalID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnInternalID);
				this.columnMetaID = new DataColumn("MetaID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnMetaID);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EGlossaryDataset.SelectAllByCategoryIDRow NewSelectAllByCategoryIDRow()
			{
				return (EGlossaryDataset.SelectAllByCategoryIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EGlossaryDataset.SelectAllByCategoryIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EGlossaryDataset.SelectAllByCategoryIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectAllByCategoryIDRowChangedEvent != null)
				{
					EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler selectAllByCategoryIDRowChangedEvent = this.SelectAllByCategoryIDRowChangedEvent;
					if (selectAllByCategoryIDRowChangedEvent != null)
					{
						selectAllByCategoryIDRowChangedEvent(this, new EGlossaryDataset.SelectAllByCategoryIDRowChangeEvent((EGlossaryDataset.SelectAllByCategoryIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectAllByCategoryIDRowChangingEvent != null)
				{
					EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler selectAllByCategoryIDRowChangingEvent = this.SelectAllByCategoryIDRowChangingEvent;
					if (selectAllByCategoryIDRowChangingEvent != null)
					{
						selectAllByCategoryIDRowChangingEvent(this, new EGlossaryDataset.SelectAllByCategoryIDRowChangeEvent((EGlossaryDataset.SelectAllByCategoryIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectAllByCategoryIDRowDeletedEvent != null)
				{
					EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler selectAllByCategoryIDRowDeletedEvent = this.SelectAllByCategoryIDRowDeletedEvent;
					if (selectAllByCategoryIDRowDeletedEvent != null)
					{
						selectAllByCategoryIDRowDeletedEvent(this, new EGlossaryDataset.SelectAllByCategoryIDRowChangeEvent((EGlossaryDataset.SelectAllByCategoryIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectAllByCategoryIDRowDeletingEvent != null)
				{
					EGlossaryDataset.SelectAllByCategoryIDRowChangeEventHandler selectAllByCategoryIDRowDeletingEvent = this.SelectAllByCategoryIDRowDeletingEvent;
					if (selectAllByCategoryIDRowDeletingEvent != null)
					{
						selectAllByCategoryIDRowDeletingEvent(this, new EGlossaryDataset.SelectAllByCategoryIDRowChangeEvent((EGlossaryDataset.SelectAllByCategoryIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectAllByCategoryIDRow(EGlossaryDataset.SelectAllByCategoryIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EGlossaryDataset eGlossaryDataset = new EGlossaryDataset();
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
				xmlSchemaAttribute.FixedValue = eGlossaryDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectAllByCategoryIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eGlossaryDataset.GetSchemaSerializable();
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
		public class SelectAllByCategoryIDRow : DataRow
		{
			private EGlossaryDataset.SelectAllByCategoryIDDataTable tableSelectAllByCategoryID;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					long result;
					try
					{
						result = Conversions.ToLong(this[this.tableSelectAllByCategoryID.IDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllByCategoryID\"中列\"ID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllByCategoryID.IDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectAllByCategoryID.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllByCategoryID\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllByCategoryID.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Description
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectAllByCategoryID.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllByCategoryID\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllByCategoryID.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string GUID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectAllByCategoryID.GUIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllByCategoryID\"中列\"GUID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllByCategoryID.GUIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string GlossaryCategoryID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectAllByCategoryID.GlossaryCategoryIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllByCategoryID\"中列\"GlossaryCategoryID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllByCategoryID.GlossaryCategoryIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string GlossaryType
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectAllByCategoryID.GlossaryTypeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllByCategoryID\"中列\"GlossaryType\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllByCategoryID.GlossaryTypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ChildCount
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectAllByCategoryID.ChildCountColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllByCategoryID\"中列\"ChildCount\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllByCategoryID.ChildCountColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string InternalID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectAllByCategoryID.InternalIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllByCategoryID\"中列\"InternalID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllByCategoryID.InternalIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string MetaID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectAllByCategoryID.MetaIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllByCategoryID\"中列\"MetaID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllByCategoryID.MetaIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectAllByCategoryIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectAllByCategoryID = (EGlossaryDataset.SelectAllByCategoryIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsIDNull()
			{
				return this.IsNull(this.tableSelectAllByCategoryID.IDColumn);
			}

			[DebuggerNonUserCode]
			public void SetIDNull()
			{
				this[this.tableSelectAllByCategoryID.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableSelectAllByCategoryID.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableSelectAllByCategoryID.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableSelectAllByCategoryID.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableSelectAllByCategoryID.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsGUIDNull()
			{
				return this.IsNull(this.tableSelectAllByCategoryID.GUIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetGUIDNull()
			{
				this[this.tableSelectAllByCategoryID.GUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsGlossaryCategoryIDNull()
			{
				return this.IsNull(this.tableSelectAllByCategoryID.GlossaryCategoryIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetGlossaryCategoryIDNull()
			{
				this[this.tableSelectAllByCategoryID.GlossaryCategoryIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsGlossaryTypeNull()
			{
				return this.IsNull(this.tableSelectAllByCategoryID.GlossaryTypeColumn);
			}

			[DebuggerNonUserCode]
			public void SetGlossaryTypeNull()
			{
				this[this.tableSelectAllByCategoryID.GlossaryTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsChildCountNull()
			{
				return this.IsNull(this.tableSelectAllByCategoryID.ChildCountColumn);
			}

			[DebuggerNonUserCode]
			public void SetChildCountNull()
			{
				this[this.tableSelectAllByCategoryID.ChildCountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsInternalIDNull()
			{
				return this.IsNull(this.tableSelectAllByCategoryID.InternalIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetInternalIDNull()
			{
				this[this.tableSelectAllByCategoryID.InternalIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsMetaIDNull()
			{
				return this.IsNull(this.tableSelectAllByCategoryID.MetaIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetMetaIDNull()
			{
				this[this.tableSelectAllByCategoryID.MetaIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectAllByCategoryIDRowChangeEvent : EventArgs
		{
			private EGlossaryDataset.SelectAllByCategoryIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EGlossaryDataset.SelectAllByCategoryIDRow Row
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
			public SelectAllByCategoryIDRowChangeEvent(EGlossaryDataset.SelectAllByCategoryIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EGlossaryDataset.SelectAllByCategoryIDDataTable tableSelectAllByCategoryID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EGlossaryDataset.SelectAllByCategoryIDDataTable SelectAllByCategoryID
		{
			get
			{
				return this.tableSelectAllByCategoryID;
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
		public EGlossaryDataset()
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
		protected EGlossaryDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectAllByCategoryID"] != null)
				{
					base.Tables.Add(new EGlossaryDataset.SelectAllByCategoryIDDataTable(dataSet.Tables["SelectAllByCategoryID"]));
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
			EGlossaryDataset eGlossaryDataset = (EGlossaryDataset)base.Clone();
			eGlossaryDataset.InitVars();
			eGlossaryDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eGlossaryDataset;
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
				if (dataSet.Tables["SelectAllByCategoryID"] != null)
				{
					base.Tables.Add(new EGlossaryDataset.SelectAllByCategoryIDDataTable(dataSet.Tables["SelectAllByCategoryID"]));
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
			this.tableSelectAllByCategoryID = (EGlossaryDataset.SelectAllByCategoryIDDataTable)base.Tables["SelectAllByCategoryID"];
			if (initTable && this.tableSelectAllByCategoryID != null)
			{
				this.tableSelectAllByCategoryID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EGlossaryDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EGlossaryDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectAllByCategoryID = new EGlossaryDataset.SelectAllByCategoryIDDataTable();
			base.Tables.Add(this.tableSelectAllByCategoryID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectAllByCategoryID()
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
			EGlossaryDataset eGlossaryDataset = new EGlossaryDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eGlossaryDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eGlossaryDataset.GetSchemaSerializable();
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
