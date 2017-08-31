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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EGlossarySubDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EGlossarySubDataset : DataSet
	{
		public delegate void GetSubGlossariesByParentIDRowChangeEventHandler(object sender, EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetSubGlossariesByParentIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnDescription;

			private DataColumn columnGUID;

			private DataColumn columnGlossaryCategoryID;

			private DataColumn columnGlossaryType;

			private DataColumn columnInternalID;

			private DataColumn columnMetaID;

			private EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler GetSubGlossariesByParentIDRowChangingEvent;

			private EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler GetSubGlossariesByParentIDRowChangedEvent;

			private EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler GetSubGlossariesByParentIDRowDeletingEvent;

			private EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler GetSubGlossariesByParentIDRowDeletedEvent;

			public event EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler GetSubGlossariesByParentIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetSubGlossariesByParentIDRowChangingEvent = (EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler)Delegate.Combine(this.GetSubGlossariesByParentIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetSubGlossariesByParentIDRowChangingEvent = (EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler)Delegate.Remove(this.GetSubGlossariesByParentIDRowChangingEvent, value);
				}
			}

			public event EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler GetSubGlossariesByParentIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetSubGlossariesByParentIDRowChangedEvent = (EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler)Delegate.Combine(this.GetSubGlossariesByParentIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetSubGlossariesByParentIDRowChangedEvent = (EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler)Delegate.Remove(this.GetSubGlossariesByParentIDRowChangedEvent, value);
				}
			}

			public event EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler GetSubGlossariesByParentIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetSubGlossariesByParentIDRowDeletingEvent = (EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler)Delegate.Combine(this.GetSubGlossariesByParentIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetSubGlossariesByParentIDRowDeletingEvent = (EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler)Delegate.Remove(this.GetSubGlossariesByParentIDRowDeletingEvent, value);
				}
			}

			public event EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler GetSubGlossariesByParentIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetSubGlossariesByParentIDRowDeletedEvent = (EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler)Delegate.Combine(this.GetSubGlossariesByParentIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetSubGlossariesByParentIDRowDeletedEvent = (EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler)Delegate.Remove(this.GetSubGlossariesByParentIDRowDeletedEvent, value);
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
			public EGlossarySubDataset.GetSubGlossariesByParentIDRow this[int index]
			{
				get
				{
					return (EGlossarySubDataset.GetSubGlossariesByParentIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetSubGlossariesByParentIDDataTable()
			{
				this.TableName = "GetSubGlossariesByParentID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetSubGlossariesByParentIDDataTable(DataTable table)
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
			protected GetSubGlossariesByParentIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetSubGlossariesByParentIDRow(EGlossarySubDataset.GetSubGlossariesByParentIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EGlossarySubDataset.GetSubGlossariesByParentIDRow AddGetSubGlossariesByParentIDRow(long ID, string Name, string Description, string GUID, string GlossaryCategoryID, string GlossaryType, string InternalID, string MetaID)
			{
				EGlossarySubDataset.GetSubGlossariesByParentIDRow getSubGlossariesByParentIDRow = (EGlossarySubDataset.GetSubGlossariesByParentIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					Description,
					GUID,
					GlossaryCategoryID,
					GlossaryType,
					InternalID,
					MetaID
				};
				getSubGlossariesByParentIDRow.ItemArray = itemArray;
				this.Rows.Add(getSubGlossariesByParentIDRow);
				return getSubGlossariesByParentIDRow;
			}

			[DebuggerNonUserCode]
			public EGlossarySubDataset.GetSubGlossariesByParentIDRow FindByID(long ID)
			{
				return (EGlossarySubDataset.GetSubGlossariesByParentIDRow)this.Rows.Find(new object[]
				{
					ID
				});
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EGlossarySubDataset.GetSubGlossariesByParentIDDataTable getSubGlossariesByParentIDDataTable = (EGlossarySubDataset.GetSubGlossariesByParentIDDataTable)base.Clone();
				getSubGlossariesByParentIDDataTable.InitVars();
				return getSubGlossariesByParentIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EGlossarySubDataset.GetSubGlossariesByParentIDDataTable();
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
				this.columnInternalID = new DataColumn("InternalID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnInternalID);
				this.columnMetaID = new DataColumn("MetaID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnMetaID);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EGlossarySubDataset.GetSubGlossariesByParentIDRow NewGetSubGlossariesByParentIDRow()
			{
				return (EGlossarySubDataset.GetSubGlossariesByParentIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EGlossarySubDataset.GetSubGlossariesByParentIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EGlossarySubDataset.GetSubGlossariesByParentIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetSubGlossariesByParentIDRowChangedEvent != null)
				{
					EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler getSubGlossariesByParentIDRowChangedEvent = this.GetSubGlossariesByParentIDRowChangedEvent;
					if (getSubGlossariesByParentIDRowChangedEvent != null)
					{
						getSubGlossariesByParentIDRowChangedEvent(this, new EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEvent((EGlossarySubDataset.GetSubGlossariesByParentIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetSubGlossariesByParentIDRowChangingEvent != null)
				{
					EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler getSubGlossariesByParentIDRowChangingEvent = this.GetSubGlossariesByParentIDRowChangingEvent;
					if (getSubGlossariesByParentIDRowChangingEvent != null)
					{
						getSubGlossariesByParentIDRowChangingEvent(this, new EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEvent((EGlossarySubDataset.GetSubGlossariesByParentIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetSubGlossariesByParentIDRowDeletedEvent != null)
				{
					EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler getSubGlossariesByParentIDRowDeletedEvent = this.GetSubGlossariesByParentIDRowDeletedEvent;
					if (getSubGlossariesByParentIDRowDeletedEvent != null)
					{
						getSubGlossariesByParentIDRowDeletedEvent(this, new EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEvent((EGlossarySubDataset.GetSubGlossariesByParentIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetSubGlossariesByParentIDRowDeletingEvent != null)
				{
					EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEventHandler getSubGlossariesByParentIDRowDeletingEvent = this.GetSubGlossariesByParentIDRowDeletingEvent;
					if (getSubGlossariesByParentIDRowDeletingEvent != null)
					{
						getSubGlossariesByParentIDRowDeletingEvent(this, new EGlossarySubDataset.GetSubGlossariesByParentIDRowChangeEvent((EGlossarySubDataset.GetSubGlossariesByParentIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetSubGlossariesByParentIDRow(EGlossarySubDataset.GetSubGlossariesByParentIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EGlossarySubDataset eGlossarySubDataset = new EGlossarySubDataset();
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
				xmlSchemaAttribute.FixedValue = eGlossarySubDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetSubGlossariesByParentIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eGlossarySubDataset.GetSchemaSerializable();
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
		public class GetSubGlossariesByParentIDRow : DataRow
		{
			private EGlossarySubDataset.GetSubGlossariesByParentIDDataTable tableGetSubGlossariesByParentID;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableGetSubGlossariesByParentID.IDColumn]);
				}
				set
				{
					this[this.tableGetSubGlossariesByParentID.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetSubGlossariesByParentID.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetSubGlossariesByParentID\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetSubGlossariesByParentID.NameColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetSubGlossariesByParentID.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetSubGlossariesByParentID\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetSubGlossariesByParentID.DescriptionColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetSubGlossariesByParentID.GUIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetSubGlossariesByParentID\"中列\"GUID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetSubGlossariesByParentID.GUIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetSubGlossariesByParentID.GlossaryCategoryIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetSubGlossariesByParentID\"中列\"GlossaryCategoryID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetSubGlossariesByParentID.GlossaryCategoryIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetSubGlossariesByParentID.GlossaryTypeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetSubGlossariesByParentID\"中列\"GlossaryType\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetSubGlossariesByParentID.GlossaryTypeColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetSubGlossariesByParentID.InternalIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetSubGlossariesByParentID\"中列\"InternalID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetSubGlossariesByParentID.InternalIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetSubGlossariesByParentID.MetaIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetSubGlossariesByParentID\"中列\"MetaID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetSubGlossariesByParentID.MetaIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetSubGlossariesByParentIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetSubGlossariesByParentID = (EGlossarySubDataset.GetSubGlossariesByParentIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableGetSubGlossariesByParentID.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableGetSubGlossariesByParentID.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableGetSubGlossariesByParentID.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableGetSubGlossariesByParentID.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsGUIDNull()
			{
				return this.IsNull(this.tableGetSubGlossariesByParentID.GUIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetGUIDNull()
			{
				this[this.tableGetSubGlossariesByParentID.GUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsGlossaryCategoryIDNull()
			{
				return this.IsNull(this.tableGetSubGlossariesByParentID.GlossaryCategoryIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetGlossaryCategoryIDNull()
			{
				this[this.tableGetSubGlossariesByParentID.GlossaryCategoryIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsGlossaryTypeNull()
			{
				return this.IsNull(this.tableGetSubGlossariesByParentID.GlossaryTypeColumn);
			}

			[DebuggerNonUserCode]
			public void SetGlossaryTypeNull()
			{
				this[this.tableGetSubGlossariesByParentID.GlossaryTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsInternalIDNull()
			{
				return this.IsNull(this.tableGetSubGlossariesByParentID.InternalIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetInternalIDNull()
			{
				this[this.tableGetSubGlossariesByParentID.InternalIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsMetaIDNull()
			{
				return this.IsNull(this.tableGetSubGlossariesByParentID.MetaIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetMetaIDNull()
			{
				this[this.tableGetSubGlossariesByParentID.MetaIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetSubGlossariesByParentIDRowChangeEvent : EventArgs
		{
			private EGlossarySubDataset.GetSubGlossariesByParentIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EGlossarySubDataset.GetSubGlossariesByParentIDRow Row
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
			public GetSubGlossariesByParentIDRowChangeEvent(EGlossarySubDataset.GetSubGlossariesByParentIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EGlossarySubDataset.GetSubGlossariesByParentIDDataTable tableGetSubGlossariesByParentID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EGlossarySubDataset.GetSubGlossariesByParentIDDataTable GetSubGlossariesByParentID
		{
			get
			{
				return this.tableGetSubGlossariesByParentID;
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
		public EGlossarySubDataset()
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
		protected EGlossarySubDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetSubGlossariesByParentID"] != null)
				{
					base.Tables.Add(new EGlossarySubDataset.GetSubGlossariesByParentIDDataTable(dataSet.Tables["GetSubGlossariesByParentID"]));
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
			EGlossarySubDataset eGlossarySubDataset = (EGlossarySubDataset)base.Clone();
			eGlossarySubDataset.InitVars();
			eGlossarySubDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eGlossarySubDataset;
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
				if (dataSet.Tables["GetSubGlossariesByParentID"] != null)
				{
					base.Tables.Add(new EGlossarySubDataset.GetSubGlossariesByParentIDDataTable(dataSet.Tables["GetSubGlossariesByParentID"]));
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
			this.tableGetSubGlossariesByParentID = (EGlossarySubDataset.GetSubGlossariesByParentIDDataTable)base.Tables["GetSubGlossariesByParentID"];
			if (initTable && this.tableGetSubGlossariesByParentID != null)
			{
				this.tableGetSubGlossariesByParentID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EGlossarySubDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EGlossarySubDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetSubGlossariesByParentID = new EGlossarySubDataset.GetSubGlossariesByParentIDDataTable();
			base.Tables.Add(this.tableGetSubGlossariesByParentID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetSubGlossariesByParentID()
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
			EGlossarySubDataset eGlossarySubDataset = new EGlossarySubDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eGlossarySubDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eGlossarySubDataset.GetSchemaSerializable();
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
