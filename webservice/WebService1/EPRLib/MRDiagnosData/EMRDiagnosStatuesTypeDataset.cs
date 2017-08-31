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

namespace MRDiagnosData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EMRDiagnosStatuesTypeDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EMRDiagnosStatuesTypeDataset : DataSet
	{
		public delegate void SelectDiagnosTypesRowChangeEventHandler(object sender, EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectDiagnosTypesDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnCode;

			private DataColumn columnDesc;

			private DataColumn columnType;

			private EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler SelectDiagnosTypesRowChangingEvent;

			private EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler SelectDiagnosTypesRowChangedEvent;

			private EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler SelectDiagnosTypesRowDeletingEvent;

			private EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler SelectDiagnosTypesRowDeletedEvent;

			public event EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler SelectDiagnosTypesRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectDiagnosTypesRowChangingEvent = (EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler)Delegate.Combine(this.SelectDiagnosTypesRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectDiagnosTypesRowChangingEvent = (EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler)Delegate.Remove(this.SelectDiagnosTypesRowChangingEvent, value);
				}
			}

			public event EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler SelectDiagnosTypesRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectDiagnosTypesRowChangedEvent = (EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler)Delegate.Combine(this.SelectDiagnosTypesRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectDiagnosTypesRowChangedEvent = (EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler)Delegate.Remove(this.SelectDiagnosTypesRowChangedEvent, value);
				}
			}

			public event EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler SelectDiagnosTypesRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectDiagnosTypesRowDeletingEvent = (EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler)Delegate.Combine(this.SelectDiagnosTypesRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectDiagnosTypesRowDeletingEvent = (EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler)Delegate.Remove(this.SelectDiagnosTypesRowDeletingEvent, value);
				}
			}

			public event EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler SelectDiagnosTypesRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectDiagnosTypesRowDeletedEvent = (EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler)Delegate.Combine(this.SelectDiagnosTypesRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectDiagnosTypesRowDeletedEvent = (EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler)Delegate.Remove(this.SelectDiagnosTypesRowDeletedEvent, value);
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
			public DataColumn CodeColumn
			{
				get
				{
					return this.columnCode;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DescColumn
			{
				get
				{
					return this.columnDesc;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn TypeColumn
			{
				get
				{
					return this.columnType;
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
			public EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow this[int index]
			{
				get
				{
					return (EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectDiagnosTypesDataTable()
			{
				this.TableName = "SelectDiagnosTypes";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectDiagnosTypesDataTable(DataTable table)
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
			protected SelectDiagnosTypesDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectDiagnosTypesRow(EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow AddSelectDiagnosTypesRow(long ID, string Code, string Desc, string Type)
			{
				EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow selectDiagnosTypesRow = (EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Code,
					Desc,
					Type
				};
				selectDiagnosTypesRow.ItemArray = itemArray;
				this.Rows.Add(selectDiagnosTypesRow);
				return selectDiagnosTypesRow;
			}

			[DebuggerNonUserCode]
			public EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow FindByID(long ID)
			{
				return (EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow)this.Rows.Find(new object[]
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
				EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesDataTable selectDiagnosTypesDataTable = (EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesDataTable)base.Clone();
				selectDiagnosTypesDataTable.InitVars();
				return selectDiagnosTypesDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnCode = base.Columns["Code"];
				this.columnDesc = base.Columns["Desc"];
				this.columnType = base.Columns["Type"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCode);
				this.columnDesc = new DataColumn("Desc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDesc);
				this.columnType = new DataColumn("Type", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnType);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow NewSelectDiagnosTypesRow()
			{
				return (EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectDiagnosTypesRowChangedEvent != null)
				{
					EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler selectDiagnosTypesRowChangedEvent = this.SelectDiagnosTypesRowChangedEvent;
					if (selectDiagnosTypesRowChangedEvent != null)
					{
						selectDiagnosTypesRowChangedEvent(this, new EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEvent((EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectDiagnosTypesRowChangingEvent != null)
				{
					EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler selectDiagnosTypesRowChangingEvent = this.SelectDiagnosTypesRowChangingEvent;
					if (selectDiagnosTypesRowChangingEvent != null)
					{
						selectDiagnosTypesRowChangingEvent(this, new EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEvent((EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectDiagnosTypesRowDeletedEvent != null)
				{
					EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler selectDiagnosTypesRowDeletedEvent = this.SelectDiagnosTypesRowDeletedEvent;
					if (selectDiagnosTypesRowDeletedEvent != null)
					{
						selectDiagnosTypesRowDeletedEvent(this, new EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEvent((EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectDiagnosTypesRowDeletingEvent != null)
				{
					EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEventHandler selectDiagnosTypesRowDeletingEvent = this.SelectDiagnosTypesRowDeletingEvent;
					if (selectDiagnosTypesRowDeletingEvent != null)
					{
						selectDiagnosTypesRowDeletingEvent(this, new EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRowChangeEvent((EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectDiagnosTypesRow(EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EMRDiagnosStatuesTypeDataset eMRDiagnosStatuesTypeDataset = new EMRDiagnosStatuesTypeDataset();
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
				xmlSchemaAttribute.FixedValue = eMRDiagnosStatuesTypeDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectDiagnosTypesDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eMRDiagnosStatuesTypeDataset.GetSchemaSerializable();
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
		public class SelectDiagnosTypesRow : DataRow
		{
			private EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesDataTable tableSelectDiagnosTypes;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableSelectDiagnosTypes.IDColumn]);
				}
				set
				{
					this[this.tableSelectDiagnosTypes.IDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Code
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectDiagnosTypes.CodeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectDiagnosTypes\"中列\"Code\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectDiagnosTypes.CodeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Desc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectDiagnosTypes.DescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectDiagnosTypes\"中列\"Desc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectDiagnosTypes.DescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Type
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectDiagnosTypes.TypeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectDiagnosTypes\"中列\"Type\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectDiagnosTypes.TypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectDiagnosTypesRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectDiagnosTypes = (EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsCodeNull()
			{
				return this.IsNull(this.tableSelectDiagnosTypes.CodeColumn);
			}

			[DebuggerNonUserCode]
			public void SetCodeNull()
			{
				this[this.tableSelectDiagnosTypes.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescNull()
			{
				return this.IsNull(this.tableSelectDiagnosTypes.DescColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescNull()
			{
				this[this.tableSelectDiagnosTypes.DescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsTypeNull()
			{
				return this.IsNull(this.tableSelectDiagnosTypes.TypeColumn);
			}

			[DebuggerNonUserCode]
			public void SetTypeNull()
			{
				this[this.tableSelectDiagnosTypes.TypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectDiagnosTypesRowChangeEvent : EventArgs
		{
			private EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow Row
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
			public SelectDiagnosTypesRowChangeEvent(EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesDataTable tableSelectDiagnosTypes;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesDataTable SelectDiagnosTypes
		{
			get
			{
				return this.tableSelectDiagnosTypes;
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
		public EMRDiagnosStatuesTypeDataset()
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
		protected EMRDiagnosStatuesTypeDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectDiagnosTypes"] != null)
				{
					base.Tables.Add(new EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesDataTable(dataSet.Tables["SelectDiagnosTypes"]));
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
			EMRDiagnosStatuesTypeDataset eMRDiagnosStatuesTypeDataset = (EMRDiagnosStatuesTypeDataset)base.Clone();
			eMRDiagnosStatuesTypeDataset.InitVars();
			eMRDiagnosStatuesTypeDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eMRDiagnosStatuesTypeDataset;
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
				if (dataSet.Tables["SelectDiagnosTypes"] != null)
				{
					base.Tables.Add(new EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesDataTable(dataSet.Tables["SelectDiagnosTypes"]));
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
			this.tableSelectDiagnosTypes = (EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesDataTable)base.Tables["SelectDiagnosTypes"];
			if (initTable && this.tableSelectDiagnosTypes != null)
			{
				this.tableSelectDiagnosTypes.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EMRDiagnosStatuesTypeDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EMRDiagnosStatuesTypeDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectDiagnosTypes = new EMRDiagnosStatuesTypeDataset.SelectDiagnosTypesDataTable();
			base.Tables.Add(this.tableSelectDiagnosTypes);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectDiagnosTypes()
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
			EMRDiagnosStatuesTypeDataset eMRDiagnosStatuesTypeDataset = new EMRDiagnosStatuesTypeDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eMRDiagnosStatuesTypeDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eMRDiagnosStatuesTypeDataset.GetSchemaSerializable();
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
