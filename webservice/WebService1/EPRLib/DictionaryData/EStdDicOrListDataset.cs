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

namespace DictionaryData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EStdDicOrListDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EStdDicOrListDataset : DataSet
	{
		public delegate void GetStdDicOrListRowChangeEventHandler(object sender, EStdDicOrListDataset.GetStdDicOrListRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetStdDicOrListDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnDicAlias;

			private DataColumn columnDicCode;

			private DataColumn columnDicDesc;

			private EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler GetStdDicOrListRowChangingEvent;

			private EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler GetStdDicOrListRowChangedEvent;

			private EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler GetStdDicOrListRowDeletingEvent;

			private EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler GetStdDicOrListRowDeletedEvent;

			public event EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler GetStdDicOrListRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetStdDicOrListRowChangingEvent = (EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler)Delegate.Combine(this.GetStdDicOrListRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetStdDicOrListRowChangingEvent = (EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler)Delegate.Remove(this.GetStdDicOrListRowChangingEvent, value);
				}
			}

			public event EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler GetStdDicOrListRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetStdDicOrListRowChangedEvent = (EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler)Delegate.Combine(this.GetStdDicOrListRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetStdDicOrListRowChangedEvent = (EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler)Delegate.Remove(this.GetStdDicOrListRowChangedEvent, value);
				}
			}

			public event EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler GetStdDicOrListRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetStdDicOrListRowDeletingEvent = (EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler)Delegate.Combine(this.GetStdDicOrListRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetStdDicOrListRowDeletingEvent = (EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler)Delegate.Remove(this.GetStdDicOrListRowDeletingEvent, value);
				}
			}

			public event EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler GetStdDicOrListRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetStdDicOrListRowDeletedEvent = (EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler)Delegate.Combine(this.GetStdDicOrListRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetStdDicOrListRowDeletedEvent = (EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler)Delegate.Remove(this.GetStdDicOrListRowDeletedEvent, value);
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
			public DataColumn DicAliasColumn
			{
				get
				{
					return this.columnDicAlias;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DicCodeColumn
			{
				get
				{
					return this.columnDicCode;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn DicDescColumn
			{
				get
				{
					return this.columnDicDesc;
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
			public EStdDicOrListDataset.GetStdDicOrListRow this[int index]
			{
				get
				{
					return (EStdDicOrListDataset.GetStdDicOrListRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetStdDicOrListDataTable()
			{
				this.TableName = "GetStdDicOrList";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetStdDicOrListDataTable(DataTable table)
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
			protected GetStdDicOrListDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetStdDicOrListRow(EStdDicOrListDataset.GetStdDicOrListRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EStdDicOrListDataset.GetStdDicOrListRow AddGetStdDicOrListRow(string ID, string DicAlias, string DicCode, string DicDesc)
			{
				EStdDicOrListDataset.GetStdDicOrListRow getStdDicOrListRow = (EStdDicOrListDataset.GetStdDicOrListRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					DicAlias,
					DicCode,
					DicDesc
				};
				getStdDicOrListRow.ItemArray = itemArray;
				this.Rows.Add(getStdDicOrListRow);
				return getStdDicOrListRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EStdDicOrListDataset.GetStdDicOrListDataTable getStdDicOrListDataTable = (EStdDicOrListDataset.GetStdDicOrListDataTable)base.Clone();
				getStdDicOrListDataTable.InitVars();
				return getStdDicOrListDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EStdDicOrListDataset.GetStdDicOrListDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnDicAlias = base.Columns["DicAlias"];
				this.columnDicCode = base.Columns["DicCode"];
				this.columnDicDesc = base.Columns["DicDesc"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnDicAlias = new DataColumn("DicAlias", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDicAlias);
				this.columnDicCode = new DataColumn("DicCode", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDicCode);
				this.columnDicDesc = new DataColumn("DicDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDicDesc);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EStdDicOrListDataset.GetStdDicOrListRow NewGetStdDicOrListRow()
			{
				return (EStdDicOrListDataset.GetStdDicOrListRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EStdDicOrListDataset.GetStdDicOrListRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EStdDicOrListDataset.GetStdDicOrListRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetStdDicOrListRowChangedEvent != null)
				{
					EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler getStdDicOrListRowChangedEvent = this.GetStdDicOrListRowChangedEvent;
					if (getStdDicOrListRowChangedEvent != null)
					{
						getStdDicOrListRowChangedEvent(this, new EStdDicOrListDataset.GetStdDicOrListRowChangeEvent((EStdDicOrListDataset.GetStdDicOrListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetStdDicOrListRowChangingEvent != null)
				{
					EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler getStdDicOrListRowChangingEvent = this.GetStdDicOrListRowChangingEvent;
					if (getStdDicOrListRowChangingEvent != null)
					{
						getStdDicOrListRowChangingEvent(this, new EStdDicOrListDataset.GetStdDicOrListRowChangeEvent((EStdDicOrListDataset.GetStdDicOrListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetStdDicOrListRowDeletedEvent != null)
				{
					EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler getStdDicOrListRowDeletedEvent = this.GetStdDicOrListRowDeletedEvent;
					if (getStdDicOrListRowDeletedEvent != null)
					{
						getStdDicOrListRowDeletedEvent(this, new EStdDicOrListDataset.GetStdDicOrListRowChangeEvent((EStdDicOrListDataset.GetStdDicOrListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetStdDicOrListRowDeletingEvent != null)
				{
					EStdDicOrListDataset.GetStdDicOrListRowChangeEventHandler getStdDicOrListRowDeletingEvent = this.GetStdDicOrListRowDeletingEvent;
					if (getStdDicOrListRowDeletingEvent != null)
					{
						getStdDicOrListRowDeletingEvent(this, new EStdDicOrListDataset.GetStdDicOrListRowChangeEvent((EStdDicOrListDataset.GetStdDicOrListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetStdDicOrListRow(EStdDicOrListDataset.GetStdDicOrListRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EStdDicOrListDataset eStdDicOrListDataset = new EStdDicOrListDataset();
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
				xmlSchemaAttribute.FixedValue = eStdDicOrListDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetStdDicOrListDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eStdDicOrListDataset.GetSchemaSerializable();
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
		public class GetStdDicOrListRow : DataRow
		{
			private EStdDicOrListDataset.GetStdDicOrListDataTable tableGetStdDicOrList;

			[DebuggerNonUserCode]
			public string ID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetStdDicOrList.IDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetStdDicOrList\"中列\"ID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetStdDicOrList.IDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string DicAlias
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetStdDicOrList.DicAliasColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetStdDicOrList\"中列\"DicAlias\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetStdDicOrList.DicAliasColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string DicCode
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetStdDicOrList.DicCodeColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetStdDicOrList\"中列\"DicCode\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetStdDicOrList.DicCodeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string DicDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetStdDicOrList.DicDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetStdDicOrList\"中列\"DicDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetStdDicOrList.DicDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetStdDicOrListRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetStdDicOrList = (EStdDicOrListDataset.GetStdDicOrListDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsIDNull()
			{
				return this.IsNull(this.tableGetStdDicOrList.IDColumn);
			}

			[DebuggerNonUserCode]
			public void SetIDNull()
			{
				this[this.tableGetStdDicOrList.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDicAliasNull()
			{
				return this.IsNull(this.tableGetStdDicOrList.DicAliasColumn);
			}

			[DebuggerNonUserCode]
			public void SetDicAliasNull()
			{
				this[this.tableGetStdDicOrList.DicAliasColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDicCodeNull()
			{
				return this.IsNull(this.tableGetStdDicOrList.DicCodeColumn);
			}

			[DebuggerNonUserCode]
			public void SetDicCodeNull()
			{
				this[this.tableGetStdDicOrList.DicCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDicDescNull()
			{
				return this.IsNull(this.tableGetStdDicOrList.DicDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetDicDescNull()
			{
				this[this.tableGetStdDicOrList.DicDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetStdDicOrListRowChangeEvent : EventArgs
		{
			private EStdDicOrListDataset.GetStdDicOrListRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EStdDicOrListDataset.GetStdDicOrListRow Row
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
			public GetStdDicOrListRowChangeEvent(EStdDicOrListDataset.GetStdDicOrListRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EStdDicOrListDataset.GetStdDicOrListDataTable tableGetStdDicOrList;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EStdDicOrListDataset.GetStdDicOrListDataTable GetStdDicOrList
		{
			get
			{
				return this.tableGetStdDicOrList;
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
		public EStdDicOrListDataset()
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
		protected EStdDicOrListDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetStdDicOrList"] != null)
				{
					base.Tables.Add(new EStdDicOrListDataset.GetStdDicOrListDataTable(dataSet.Tables["GetStdDicOrList"]));
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
			EStdDicOrListDataset eStdDicOrListDataset = (EStdDicOrListDataset)base.Clone();
			eStdDicOrListDataset.InitVars();
			eStdDicOrListDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eStdDicOrListDataset;
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
				if (dataSet.Tables["GetStdDicOrList"] != null)
				{
					base.Tables.Add(new EStdDicOrListDataset.GetStdDicOrListDataTable(dataSet.Tables["GetStdDicOrList"]));
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
			this.tableGetStdDicOrList = (EStdDicOrListDataset.GetStdDicOrListDataTable)base.Tables["GetStdDicOrList"];
			if (initTable && this.tableGetStdDicOrList != null)
			{
				this.tableGetStdDicOrList.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EStdDicOrListDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EStdDicOrListDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetStdDicOrList = new EStdDicOrListDataset.GetStdDicOrListDataTable();
			base.Tables.Add(this.tableGetStdDicOrList);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetStdDicOrList()
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
			EStdDicOrListDataset eStdDicOrListDataset = new EStdDicOrListDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eStdDicOrListDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eStdDicOrListDataset.GetSchemaSerializable();
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
