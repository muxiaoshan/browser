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

namespace CustomDictoryData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EDiagnosTypeByTitle"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EDiagnosTypeByTitle : DataSet
	{
		public delegate void GetDiagnosTypeByTitleRowChangeEventHandler(object sender, EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetDiagnosTypeByTitleDataTable : DataTable, IEnumerable
		{
			private DataColumn columnADiagnosTypeID;

			private DataColumn columnATitleName;

			private EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler GetDiagnosTypeByTitleRowChangingEvent;

			private EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler GetDiagnosTypeByTitleRowChangedEvent;

			private EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler GetDiagnosTypeByTitleRowDeletingEvent;

			private EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler GetDiagnosTypeByTitleRowDeletedEvent;

			public event EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler GetDiagnosTypeByTitleRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetDiagnosTypeByTitleRowChangingEvent = (EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler)Delegate.Combine(this.GetDiagnosTypeByTitleRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetDiagnosTypeByTitleRowChangingEvent = (EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler)Delegate.Remove(this.GetDiagnosTypeByTitleRowChangingEvent, value);
				}
			}

			public event EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler GetDiagnosTypeByTitleRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetDiagnosTypeByTitleRowChangedEvent = (EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler)Delegate.Combine(this.GetDiagnosTypeByTitleRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetDiagnosTypeByTitleRowChangedEvent = (EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler)Delegate.Remove(this.GetDiagnosTypeByTitleRowChangedEvent, value);
				}
			}

			public event EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler GetDiagnosTypeByTitleRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetDiagnosTypeByTitleRowDeletingEvent = (EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler)Delegate.Combine(this.GetDiagnosTypeByTitleRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetDiagnosTypeByTitleRowDeletingEvent = (EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler)Delegate.Remove(this.GetDiagnosTypeByTitleRowDeletingEvent, value);
				}
			}

			public event EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler GetDiagnosTypeByTitleRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetDiagnosTypeByTitleRowDeletedEvent = (EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler)Delegate.Combine(this.GetDiagnosTypeByTitleRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetDiagnosTypeByTitleRowDeletedEvent = (EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler)Delegate.Remove(this.GetDiagnosTypeByTitleRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ADiagnosTypeIDColumn
			{
				get
				{
					return this.columnADiagnosTypeID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ATitleNameColumn
			{
				get
				{
					return this.columnATitleName;
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
			public EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow this[int index]
			{
				get
				{
					return (EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetDiagnosTypeByTitleDataTable()
			{
				this.TableName = "GetDiagnosTypeByTitle";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetDiagnosTypeByTitleDataTable(DataTable table)
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
			protected GetDiagnosTypeByTitleDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetDiagnosTypeByTitleRow(EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow AddGetDiagnosTypeByTitleRow(string ADiagnosTypeID, string ATitleName)
			{
				EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow getDiagnosTypeByTitleRow = (EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ADiagnosTypeID,
					ATitleName
				};
				getDiagnosTypeByTitleRow.ItemArray = itemArray;
				this.Rows.Add(getDiagnosTypeByTitleRow);
				return getDiagnosTypeByTitleRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable getDiagnosTypeByTitleDataTable = (EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable)base.Clone();
				getDiagnosTypeByTitleDataTable.InitVars();
				return getDiagnosTypeByTitleDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnADiagnosTypeID = base.Columns["ADiagnosTypeID"];
				this.columnATitleName = base.Columns["ATitleName"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnADiagnosTypeID = new DataColumn("ADiagnosTypeID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnADiagnosTypeID);
				this.columnATitleName = new DataColumn("ATitleName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnATitleName);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow NewGetDiagnosTypeByTitleRow()
			{
				return (EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetDiagnosTypeByTitleRowChangedEvent != null)
				{
					EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler getDiagnosTypeByTitleRowChangedEvent = this.GetDiagnosTypeByTitleRowChangedEvent;
					if (getDiagnosTypeByTitleRowChangedEvent != null)
					{
						getDiagnosTypeByTitleRowChangedEvent(this, new EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEvent((EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetDiagnosTypeByTitleRowChangingEvent != null)
				{
					EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler getDiagnosTypeByTitleRowChangingEvent = this.GetDiagnosTypeByTitleRowChangingEvent;
					if (getDiagnosTypeByTitleRowChangingEvent != null)
					{
						getDiagnosTypeByTitleRowChangingEvent(this, new EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEvent((EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetDiagnosTypeByTitleRowDeletedEvent != null)
				{
					EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler getDiagnosTypeByTitleRowDeletedEvent = this.GetDiagnosTypeByTitleRowDeletedEvent;
					if (getDiagnosTypeByTitleRowDeletedEvent != null)
					{
						getDiagnosTypeByTitleRowDeletedEvent(this, new EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEvent((EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetDiagnosTypeByTitleRowDeletingEvent != null)
				{
					EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler getDiagnosTypeByTitleRowDeletingEvent = this.GetDiagnosTypeByTitleRowDeletingEvent;
					if (getDiagnosTypeByTitleRowDeletingEvent != null)
					{
						getDiagnosTypeByTitleRowDeletingEvent(this, new EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEvent((EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetDiagnosTypeByTitleRow(EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EDiagnosTypeByTitle eDiagnosTypeByTitle = new EDiagnosTypeByTitle();
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
				xmlSchemaAttribute.FixedValue = eDiagnosTypeByTitle.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetDiagnosTypeByTitleDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eDiagnosTypeByTitle.GetSchemaSerializable();
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
		public class GetDiagnosTypeByTitleRow : DataRow
		{
			private EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable tableGetDiagnosTypeByTitle;

			[DebuggerNonUserCode]
			public string ADiagnosTypeID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetDiagnosTypeByTitle.ADiagnosTypeIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetDiagnosTypeByTitle\"中列\"ADiagnosTypeID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetDiagnosTypeByTitle.ADiagnosTypeIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ATitleName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetDiagnosTypeByTitle.ATitleNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetDiagnosTypeByTitle\"中列\"ATitleName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetDiagnosTypeByTitle.ATitleNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetDiagnosTypeByTitleRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetDiagnosTypeByTitle = (EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsADiagnosTypeIDNull()
			{
				return this.IsNull(this.tableGetDiagnosTypeByTitle.ADiagnosTypeIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetADiagnosTypeIDNull()
			{
				this[this.tableGetDiagnosTypeByTitle.ADiagnosTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsATitleNameNull()
			{
				return this.IsNull(this.tableGetDiagnosTypeByTitle.ATitleNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetATitleNameNull()
			{
				this[this.tableGetDiagnosTypeByTitle.ATitleNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetDiagnosTypeByTitleRowChangeEvent : EventArgs
		{
			private EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow Row
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
			public GetDiagnosTypeByTitleRowChangeEvent(EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable tableGetDiagnosTypeByTitle;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable GetDiagnosTypeByTitle
		{
			get
			{
				return this.tableGetDiagnosTypeByTitle;
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
		public EDiagnosTypeByTitle()
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
		protected EDiagnosTypeByTitle(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetDiagnosTypeByTitle"] != null)
				{
					base.Tables.Add(new EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable(dataSet.Tables["GetDiagnosTypeByTitle"]));
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
			EDiagnosTypeByTitle eDiagnosTypeByTitle = (EDiagnosTypeByTitle)base.Clone();
			eDiagnosTypeByTitle.InitVars();
			eDiagnosTypeByTitle.SchemaSerializationMode = this.SchemaSerializationMode;
			return eDiagnosTypeByTitle;
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
				if (dataSet.Tables["GetDiagnosTypeByTitle"] != null)
				{
					base.Tables.Add(new EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable(dataSet.Tables["GetDiagnosTypeByTitle"]));
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
			this.tableGetDiagnosTypeByTitle = (EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable)base.Tables["GetDiagnosTypeByTitle"];
			if (initTable && this.tableGetDiagnosTypeByTitle != null)
			{
				this.tableGetDiagnosTypeByTitle.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EDiagnosTypeByTitle";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EMRDiagnosDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetDiagnosTypeByTitle = new EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable();
			base.Tables.Add(this.tableGetDiagnosTypeByTitle);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetDiagnosTypeByTitle()
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
			EDiagnosTypeByTitle eDiagnosTypeByTitle = new EDiagnosTypeByTitle();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eDiagnosTypeByTitle.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eDiagnosTypeByTitle.GetSchemaSerializable();
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
