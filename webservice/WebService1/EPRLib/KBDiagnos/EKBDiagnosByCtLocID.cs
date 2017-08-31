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

namespace KBDiagnos
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EKBDiagnosByCtLocID"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EKBDiagnosByCtLocID : DataSet
	{
		public delegate void GetDiagnosByCtLocIDRowChangeEventHandler(object sender, EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetDiagnosByCtLocIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnDescription;

			private DataColumn columnDiagnos;

			private DataColumn columnUserID;

			private DataColumn columnUserName;

			private DataColumn columnCreateDate;

			private EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler GetDiagnosByCtLocIDRowChangingEvent;

			private EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler GetDiagnosByCtLocIDRowChangedEvent;

			private EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler GetDiagnosByCtLocIDRowDeletingEvent;

			private EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler GetDiagnosByCtLocIDRowDeletedEvent;

			public event EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler GetDiagnosByCtLocIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetDiagnosByCtLocIDRowChangingEvent = (EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler)Delegate.Combine(this.GetDiagnosByCtLocIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetDiagnosByCtLocIDRowChangingEvent = (EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler)Delegate.Remove(this.GetDiagnosByCtLocIDRowChangingEvent, value);
				}
			}

			public event EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler GetDiagnosByCtLocIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetDiagnosByCtLocIDRowChangedEvent = (EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler)Delegate.Combine(this.GetDiagnosByCtLocIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetDiagnosByCtLocIDRowChangedEvent = (EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler)Delegate.Remove(this.GetDiagnosByCtLocIDRowChangedEvent, value);
				}
			}

			public event EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler GetDiagnosByCtLocIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetDiagnosByCtLocIDRowDeletingEvent = (EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler)Delegate.Combine(this.GetDiagnosByCtLocIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetDiagnosByCtLocIDRowDeletingEvent = (EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler)Delegate.Remove(this.GetDiagnosByCtLocIDRowDeletingEvent, value);
				}
			}

			public event EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler GetDiagnosByCtLocIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetDiagnosByCtLocIDRowDeletedEvent = (EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler)Delegate.Combine(this.GetDiagnosByCtLocIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetDiagnosByCtLocIDRowDeletedEvent = (EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler)Delegate.Remove(this.GetDiagnosByCtLocIDRowDeletedEvent, value);
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
			public DataColumn DiagnosColumn
			{
				get
				{
					return this.columnDiagnos;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn UserIDColumn
			{
				get
				{
					return this.columnUserID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn UserNameColumn
			{
				get
				{
					return this.columnUserName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn CreateDateColumn
			{
				get
				{
					return this.columnCreateDate;
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
			public EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow this[int index]
			{
				get
				{
					return (EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetDiagnosByCtLocIDDataTable()
			{
				this.TableName = "GetDiagnosByCtLocID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetDiagnosByCtLocIDDataTable(DataTable table)
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
			protected GetDiagnosByCtLocIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetDiagnosByCtLocIDRow(EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow AddGetDiagnosByCtLocIDRow(string ID, string Name, string Description, string Diagnos, string UserID, string UserName, DateTime CreateDate)
			{
				EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow getDiagnosByCtLocIDRow = (EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					Description,
					Diagnos,
					UserID,
					UserName,
					CreateDate
				};
				getDiagnosByCtLocIDRow.ItemArray = itemArray;
				this.Rows.Add(getDiagnosByCtLocIDRow);
				return getDiagnosByCtLocIDRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EKBDiagnosByCtLocID.GetDiagnosByCtLocIDDataTable getDiagnosByCtLocIDDataTable = (EKBDiagnosByCtLocID.GetDiagnosByCtLocIDDataTable)base.Clone();
				getDiagnosByCtLocIDDataTable.InitVars();
				return getDiagnosByCtLocIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EKBDiagnosByCtLocID.GetDiagnosByCtLocIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnDescription = base.Columns["Description"];
				this.columnDiagnos = base.Columns["Diagnos"];
				this.columnUserID = base.Columns["UserID"];
				this.columnUserName = base.Columns["UserName"];
				this.columnCreateDate = base.Columns["CreateDate"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				this.columnDiagnos = new DataColumn("Diagnos", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDiagnos);
				this.columnUserID = new DataColumn("UserID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnUserID);
				this.columnUserName = new DataColumn("UserName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnUserName);
				this.columnCreateDate = new DataColumn("CreateDate", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnCreateDate);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow NewGetDiagnosByCtLocIDRow()
			{
				return (EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetDiagnosByCtLocIDRowChangedEvent != null)
				{
					EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler getDiagnosByCtLocIDRowChangedEvent = this.GetDiagnosByCtLocIDRowChangedEvent;
					if (getDiagnosByCtLocIDRowChangedEvent != null)
					{
						getDiagnosByCtLocIDRowChangedEvent(this, new EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEvent((EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetDiagnosByCtLocIDRowChangingEvent != null)
				{
					EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler getDiagnosByCtLocIDRowChangingEvent = this.GetDiagnosByCtLocIDRowChangingEvent;
					if (getDiagnosByCtLocIDRowChangingEvent != null)
					{
						getDiagnosByCtLocIDRowChangingEvent(this, new EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEvent((EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetDiagnosByCtLocIDRowDeletedEvent != null)
				{
					EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler getDiagnosByCtLocIDRowDeletedEvent = this.GetDiagnosByCtLocIDRowDeletedEvent;
					if (getDiagnosByCtLocIDRowDeletedEvent != null)
					{
						getDiagnosByCtLocIDRowDeletedEvent(this, new EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEvent((EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetDiagnosByCtLocIDRowDeletingEvent != null)
				{
					EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEventHandler getDiagnosByCtLocIDRowDeletingEvent = this.GetDiagnosByCtLocIDRowDeletingEvent;
					if (getDiagnosByCtLocIDRowDeletingEvent != null)
					{
						getDiagnosByCtLocIDRowDeletingEvent(this, new EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRowChangeEvent((EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetDiagnosByCtLocIDRow(EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EKBDiagnosByCtLocID eKBDiagnosByCtLocID = new EKBDiagnosByCtLocID();
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
				xmlSchemaAttribute.FixedValue = eKBDiagnosByCtLocID.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetDiagnosByCtLocIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eKBDiagnosByCtLocID.GetSchemaSerializable();
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
		public class GetDiagnosByCtLocIDRow : DataRow
		{
			private EKBDiagnosByCtLocID.GetDiagnosByCtLocIDDataTable tableGetDiagnosByCtLocID;

			[DebuggerNonUserCode]
			public string ID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetDiagnosByCtLocID.IDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetDiagnosByCtLocID\"中列\"ID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetDiagnosByCtLocID.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetDiagnosByCtLocID.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetDiagnosByCtLocID\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetDiagnosByCtLocID.NameColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetDiagnosByCtLocID.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetDiagnosByCtLocID\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetDiagnosByCtLocID.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Diagnos
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetDiagnosByCtLocID.DiagnosColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetDiagnosByCtLocID\"中列\"Diagnos\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetDiagnosByCtLocID.DiagnosColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string UserID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetDiagnosByCtLocID.UserIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetDiagnosByCtLocID\"中列\"UserID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetDiagnosByCtLocID.UserIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string UserName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetDiagnosByCtLocID.UserNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetDiagnosByCtLocID\"中列\"UserName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetDiagnosByCtLocID.UserNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public DateTime CreateDate
			{
				get
				{
					DateTime result;
					try
					{
						result = Conversions.ToDate(this[this.tableGetDiagnosByCtLocID.CreateDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetDiagnosByCtLocID\"中列\"CreateDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetDiagnosByCtLocID.CreateDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetDiagnosByCtLocIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetDiagnosByCtLocID = (EKBDiagnosByCtLocID.GetDiagnosByCtLocIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsIDNull()
			{
				return this.IsNull(this.tableGetDiagnosByCtLocID.IDColumn);
			}

			[DebuggerNonUserCode]
			public void SetIDNull()
			{
				this[this.tableGetDiagnosByCtLocID.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableGetDiagnosByCtLocID.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableGetDiagnosByCtLocID.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableGetDiagnosByCtLocID.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableGetDiagnosByCtLocID.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDiagnosNull()
			{
				return this.IsNull(this.tableGetDiagnosByCtLocID.DiagnosColumn);
			}

			[DebuggerNonUserCode]
			public void SetDiagnosNull()
			{
				this[this.tableGetDiagnosByCtLocID.DiagnosColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsUserIDNull()
			{
				return this.IsNull(this.tableGetDiagnosByCtLocID.UserIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetUserIDNull()
			{
				this[this.tableGetDiagnosByCtLocID.UserIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsUserNameNull()
			{
				return this.IsNull(this.tableGetDiagnosByCtLocID.UserNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetUserNameNull()
			{
				this[this.tableGetDiagnosByCtLocID.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCreateDateNull()
			{
				return this.IsNull(this.tableGetDiagnosByCtLocID.CreateDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetCreateDateNull()
			{
				this[this.tableGetDiagnosByCtLocID.CreateDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetDiagnosByCtLocIDRowChangeEvent : EventArgs
		{
			private EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow Row
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
			public GetDiagnosByCtLocIDRowChangeEvent(EKBDiagnosByCtLocID.GetDiagnosByCtLocIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EKBDiagnosByCtLocID.GetDiagnosByCtLocIDDataTable tableGetDiagnosByCtLocID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EKBDiagnosByCtLocID.GetDiagnosByCtLocIDDataTable GetDiagnosByCtLocID
		{
			get
			{
				return this.tableGetDiagnosByCtLocID;
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
		public EKBDiagnosByCtLocID()
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
		protected EKBDiagnosByCtLocID(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetDiagnosByCtLocID"] != null)
				{
					base.Tables.Add(new EKBDiagnosByCtLocID.GetDiagnosByCtLocIDDataTable(dataSet.Tables["GetDiagnosByCtLocID"]));
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
			EKBDiagnosByCtLocID eKBDiagnosByCtLocID = (EKBDiagnosByCtLocID)base.Clone();
			eKBDiagnosByCtLocID.InitVars();
			eKBDiagnosByCtLocID.SchemaSerializationMode = this.SchemaSerializationMode;
			return eKBDiagnosByCtLocID;
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
				if (dataSet.Tables["GetDiagnosByCtLocID"] != null)
				{
					base.Tables.Add(new EKBDiagnosByCtLocID.GetDiagnosByCtLocIDDataTable(dataSet.Tables["GetDiagnosByCtLocID"]));
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
			this.tableGetDiagnosByCtLocID = (EKBDiagnosByCtLocID.GetDiagnosByCtLocIDDataTable)base.Tables["GetDiagnosByCtLocID"];
			if (initTable && this.tableGetDiagnosByCtLocID != null)
			{
				this.tableGetDiagnosByCtLocID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EKBDiagnosByCtLocID";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EKBDiagnosByCtLocID";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetDiagnosByCtLocID = new EKBDiagnosByCtLocID.GetDiagnosByCtLocIDDataTable();
			base.Tables.Add(this.tableGetDiagnosByCtLocID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetDiagnosByCtLocID()
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
			EKBDiagnosByCtLocID eKBDiagnosByCtLocID = new EKBDiagnosByCtLocID();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eKBDiagnosByCtLocID.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eKBDiagnosByCtLocID.GetSchemaSerializable();
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
