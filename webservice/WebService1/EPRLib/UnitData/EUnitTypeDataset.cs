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

namespace UnitData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EUnitTypeDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EUnitTypeDataset : DataSet
	{
		public delegate void SelectAllTypeRowChangeEventHandler(object sender, EUnitTypeDataset.SelectAllTypeRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectAllTypeDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnCode;

			private DataColumn columnENGName;

			private DataColumn columnCHSName;

			private EUnitTypeDataset.SelectAllTypeRowChangeEventHandler SelectAllTypeRowChangingEvent;

			private EUnitTypeDataset.SelectAllTypeRowChangeEventHandler SelectAllTypeRowChangedEvent;

			private EUnitTypeDataset.SelectAllTypeRowChangeEventHandler SelectAllTypeRowDeletingEvent;

			private EUnitTypeDataset.SelectAllTypeRowChangeEventHandler SelectAllTypeRowDeletedEvent;

			public event EUnitTypeDataset.SelectAllTypeRowChangeEventHandler SelectAllTypeRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllTypeRowChangingEvent = (EUnitTypeDataset.SelectAllTypeRowChangeEventHandler)Delegate.Combine(this.SelectAllTypeRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllTypeRowChangingEvent = (EUnitTypeDataset.SelectAllTypeRowChangeEventHandler)Delegate.Remove(this.SelectAllTypeRowChangingEvent, value);
				}
			}

			public event EUnitTypeDataset.SelectAllTypeRowChangeEventHandler SelectAllTypeRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllTypeRowChangedEvent = (EUnitTypeDataset.SelectAllTypeRowChangeEventHandler)Delegate.Combine(this.SelectAllTypeRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllTypeRowChangedEvent = (EUnitTypeDataset.SelectAllTypeRowChangeEventHandler)Delegate.Remove(this.SelectAllTypeRowChangedEvent, value);
				}
			}

			public event EUnitTypeDataset.SelectAllTypeRowChangeEventHandler SelectAllTypeRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllTypeRowDeletingEvent = (EUnitTypeDataset.SelectAllTypeRowChangeEventHandler)Delegate.Combine(this.SelectAllTypeRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllTypeRowDeletingEvent = (EUnitTypeDataset.SelectAllTypeRowChangeEventHandler)Delegate.Remove(this.SelectAllTypeRowDeletingEvent, value);
				}
			}

			public event EUnitTypeDataset.SelectAllTypeRowChangeEventHandler SelectAllTypeRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectAllTypeRowDeletedEvent = (EUnitTypeDataset.SelectAllTypeRowChangeEventHandler)Delegate.Combine(this.SelectAllTypeRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectAllTypeRowDeletedEvent = (EUnitTypeDataset.SelectAllTypeRowChangeEventHandler)Delegate.Remove(this.SelectAllTypeRowDeletedEvent, value);
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
			public DataColumn ENGNameColumn
			{
				get
				{
					return this.columnENGName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn CHSNameColumn
			{
				get
				{
					return this.columnCHSName;
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
			public EUnitTypeDataset.SelectAllTypeRow this[int index]
			{
				get
				{
					return (EUnitTypeDataset.SelectAllTypeRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectAllTypeDataTable()
			{
				this.TableName = "SelectAllType";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectAllTypeDataTable(DataTable table)
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
			protected SelectAllTypeDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectAllTypeRow(EUnitTypeDataset.SelectAllTypeRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EUnitTypeDataset.SelectAllTypeRow AddSelectAllTypeRow(long ID, string Code, string ENGName, string CHSName)
			{
				EUnitTypeDataset.SelectAllTypeRow selectAllTypeRow = (EUnitTypeDataset.SelectAllTypeRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Code,
					ENGName,
					CHSName
				};
				selectAllTypeRow.ItemArray = itemArray;
				this.Rows.Add(selectAllTypeRow);
				return selectAllTypeRow;
			}

			[DebuggerNonUserCode]
			public EUnitTypeDataset.SelectAllTypeRow FindByID(long ID)
			{
				return (EUnitTypeDataset.SelectAllTypeRow)this.Rows.Find(new object[]
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
				EUnitTypeDataset.SelectAllTypeDataTable selectAllTypeDataTable = (EUnitTypeDataset.SelectAllTypeDataTable)base.Clone();
				selectAllTypeDataTable.InitVars();
				return selectAllTypeDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EUnitTypeDataset.SelectAllTypeDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnCode = base.Columns["Code"];
				this.columnENGName = base.Columns["ENGName"];
				this.columnCHSName = base.Columns["CHSName"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCode);
				this.columnENGName = new DataColumn("ENGName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnENGName);
				this.columnCHSName = new DataColumn("CHSName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCHSName);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EUnitTypeDataset.SelectAllTypeRow NewSelectAllTypeRow()
			{
				return (EUnitTypeDataset.SelectAllTypeRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EUnitTypeDataset.SelectAllTypeRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EUnitTypeDataset.SelectAllTypeRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectAllTypeRowChangedEvent != null)
				{
					EUnitTypeDataset.SelectAllTypeRowChangeEventHandler selectAllTypeRowChangedEvent = this.SelectAllTypeRowChangedEvent;
					if (selectAllTypeRowChangedEvent != null)
					{
						selectAllTypeRowChangedEvent(this, new EUnitTypeDataset.SelectAllTypeRowChangeEvent((EUnitTypeDataset.SelectAllTypeRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectAllTypeRowChangingEvent != null)
				{
					EUnitTypeDataset.SelectAllTypeRowChangeEventHandler selectAllTypeRowChangingEvent = this.SelectAllTypeRowChangingEvent;
					if (selectAllTypeRowChangingEvent != null)
					{
						selectAllTypeRowChangingEvent(this, new EUnitTypeDataset.SelectAllTypeRowChangeEvent((EUnitTypeDataset.SelectAllTypeRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectAllTypeRowDeletedEvent != null)
				{
					EUnitTypeDataset.SelectAllTypeRowChangeEventHandler selectAllTypeRowDeletedEvent = this.SelectAllTypeRowDeletedEvent;
					if (selectAllTypeRowDeletedEvent != null)
					{
						selectAllTypeRowDeletedEvent(this, new EUnitTypeDataset.SelectAllTypeRowChangeEvent((EUnitTypeDataset.SelectAllTypeRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectAllTypeRowDeletingEvent != null)
				{
					EUnitTypeDataset.SelectAllTypeRowChangeEventHandler selectAllTypeRowDeletingEvent = this.SelectAllTypeRowDeletingEvent;
					if (selectAllTypeRowDeletingEvent != null)
					{
						selectAllTypeRowDeletingEvent(this, new EUnitTypeDataset.SelectAllTypeRowChangeEvent((EUnitTypeDataset.SelectAllTypeRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectAllTypeRow(EUnitTypeDataset.SelectAllTypeRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EUnitTypeDataset eUnitTypeDataset = new EUnitTypeDataset();
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
				xmlSchemaAttribute.FixedValue = eUnitTypeDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectAllTypeDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eUnitTypeDataset.GetSchemaSerializable();
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
		public class SelectAllTypeRow : DataRow
		{
			private EUnitTypeDataset.SelectAllTypeDataTable tableSelectAllType;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableSelectAllType.IDColumn]);
				}
				set
				{
					this[this.tableSelectAllType.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSelectAllType.CodeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllType\"中列\"Code\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllType.CodeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ENGName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectAllType.ENGNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllType\"中列\"ENGName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllType.ENGNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string CHSName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectAllType.CHSNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectAllType\"中列\"CHSName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectAllType.CHSNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectAllTypeRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectAllType = (EUnitTypeDataset.SelectAllTypeDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsCodeNull()
			{
				return this.IsNull(this.tableSelectAllType.CodeColumn);
			}

			[DebuggerNonUserCode]
			public void SetCodeNull()
			{
				this[this.tableSelectAllType.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsENGNameNull()
			{
				return this.IsNull(this.tableSelectAllType.ENGNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetENGNameNull()
			{
				this[this.tableSelectAllType.ENGNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCHSNameNull()
			{
				return this.IsNull(this.tableSelectAllType.CHSNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetCHSNameNull()
			{
				this[this.tableSelectAllType.CHSNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectAllTypeRowChangeEvent : EventArgs
		{
			private EUnitTypeDataset.SelectAllTypeRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EUnitTypeDataset.SelectAllTypeRow Row
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
			public SelectAllTypeRowChangeEvent(EUnitTypeDataset.SelectAllTypeRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EUnitTypeDataset.SelectAllTypeDataTable tableSelectAllType;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EUnitTypeDataset.SelectAllTypeDataTable SelectAllType
		{
			get
			{
				return this.tableSelectAllType;
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
		public EUnitTypeDataset()
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
		protected EUnitTypeDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectAllType"] != null)
				{
					base.Tables.Add(new EUnitTypeDataset.SelectAllTypeDataTable(dataSet.Tables["SelectAllType"]));
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
			EUnitTypeDataset eUnitTypeDataset = (EUnitTypeDataset)base.Clone();
			eUnitTypeDataset.InitVars();
			eUnitTypeDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eUnitTypeDataset;
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
				if (dataSet.Tables["SelectAllType"] != null)
				{
					base.Tables.Add(new EUnitTypeDataset.SelectAllTypeDataTable(dataSet.Tables["SelectAllType"]));
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
			this.tableSelectAllType = (EUnitTypeDataset.SelectAllTypeDataTable)base.Tables["SelectAllType"];
			if (initTable && this.tableSelectAllType != null)
			{
				this.tableSelectAllType.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EUnitTypeDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EUnitTypeDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectAllType = new EUnitTypeDataset.SelectAllTypeDataTable();
			base.Tables.Add(this.tableSelectAllType);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectAllType()
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
			EUnitTypeDataset eUnitTypeDataset = new EUnitTypeDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eUnitTypeDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eUnitTypeDataset.GetSchemaSerializable();
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
