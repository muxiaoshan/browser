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

namespace PACSData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EPACSArcItemListDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EPACSArcItemListDataSet : DataSet
	{
		public delegate void SelectPACSArcItemListRowChangeEventHandler(object sender, EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectPACSArcItemListDataTable : DataTable, IEnumerable
		{
			private DataColumn columnItemRowid;

			private DataColumn columnItemDesc;

			private EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler SelectPACSArcItemListRowChangingEvent;

			private EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler SelectPACSArcItemListRowChangedEvent;

			private EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler SelectPACSArcItemListRowDeletingEvent;

			private EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler SelectPACSArcItemListRowDeletedEvent;

			public event EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler SelectPACSArcItemListRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectPACSArcItemListRowChangingEvent = (EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler)Delegate.Combine(this.SelectPACSArcItemListRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectPACSArcItemListRowChangingEvent = (EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler)Delegate.Remove(this.SelectPACSArcItemListRowChangingEvent, value);
				}
			}

			public event EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler SelectPACSArcItemListRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectPACSArcItemListRowChangedEvent = (EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler)Delegate.Combine(this.SelectPACSArcItemListRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectPACSArcItemListRowChangedEvent = (EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler)Delegate.Remove(this.SelectPACSArcItemListRowChangedEvent, value);
				}
			}

			public event EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler SelectPACSArcItemListRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectPACSArcItemListRowDeletingEvent = (EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler)Delegate.Combine(this.SelectPACSArcItemListRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectPACSArcItemListRowDeletingEvent = (EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler)Delegate.Remove(this.SelectPACSArcItemListRowDeletingEvent, value);
				}
			}

			public event EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler SelectPACSArcItemListRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectPACSArcItemListRowDeletedEvent = (EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler)Delegate.Combine(this.SelectPACSArcItemListRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectPACSArcItemListRowDeletedEvent = (EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler)Delegate.Remove(this.SelectPACSArcItemListRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ItemRowidColumn
			{
				get
				{
					return this.columnItemRowid;
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

			[Browsable(false), DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			public EPACSArcItemListDataSet.SelectPACSArcItemListRow this[int index]
			{
				get
				{
					return (EPACSArcItemListDataSet.SelectPACSArcItemListRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectPACSArcItemListDataTable()
			{
				this.TableName = "SelectPACSArcItemList";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectPACSArcItemListDataTable(DataTable table)
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
			protected SelectPACSArcItemListDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectPACSArcItemListRow(EPACSArcItemListDataSet.SelectPACSArcItemListRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EPACSArcItemListDataSet.SelectPACSArcItemListRow AddSelectPACSArcItemListRow(string ItemRowid, string ItemDesc)
			{
				EPACSArcItemListDataSet.SelectPACSArcItemListRow selectPACSArcItemListRow = (EPACSArcItemListDataSet.SelectPACSArcItemListRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ItemRowid,
					ItemDesc
				};
				selectPACSArcItemListRow.ItemArray = itemArray;
				this.Rows.Add(selectPACSArcItemListRow);
				return selectPACSArcItemListRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EPACSArcItemListDataSet.SelectPACSArcItemListDataTable selectPACSArcItemListDataTable = (EPACSArcItemListDataSet.SelectPACSArcItemListDataTable)base.Clone();
				selectPACSArcItemListDataTable.InitVars();
				return selectPACSArcItemListDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EPACSArcItemListDataSet.SelectPACSArcItemListDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnItemRowid = base.Columns["ItemRowid"];
				this.columnItemDesc = base.Columns["ItemDesc"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnItemRowid = new DataColumn("ItemRowid", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnItemRowid);
				this.columnItemDesc = new DataColumn("ItemDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnItemDesc);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EPACSArcItemListDataSet.SelectPACSArcItemListRow NewSelectPACSArcItemListRow()
			{
				return (EPACSArcItemListDataSet.SelectPACSArcItemListRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EPACSArcItemListDataSet.SelectPACSArcItemListRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EPACSArcItemListDataSet.SelectPACSArcItemListRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectPACSArcItemListRowChangedEvent != null)
				{
					EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler selectPACSArcItemListRowChangedEvent = this.SelectPACSArcItemListRowChangedEvent;
					if (selectPACSArcItemListRowChangedEvent != null)
					{
						selectPACSArcItemListRowChangedEvent(this, new EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEvent((EPACSArcItemListDataSet.SelectPACSArcItemListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectPACSArcItemListRowChangingEvent != null)
				{
					EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler selectPACSArcItemListRowChangingEvent = this.SelectPACSArcItemListRowChangingEvent;
					if (selectPACSArcItemListRowChangingEvent != null)
					{
						selectPACSArcItemListRowChangingEvent(this, new EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEvent((EPACSArcItemListDataSet.SelectPACSArcItemListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectPACSArcItemListRowDeletedEvent != null)
				{
					EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler selectPACSArcItemListRowDeletedEvent = this.SelectPACSArcItemListRowDeletedEvent;
					if (selectPACSArcItemListRowDeletedEvent != null)
					{
						selectPACSArcItemListRowDeletedEvent(this, new EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEvent((EPACSArcItemListDataSet.SelectPACSArcItemListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectPACSArcItemListRowDeletingEvent != null)
				{
					EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEventHandler selectPACSArcItemListRowDeletingEvent = this.SelectPACSArcItemListRowDeletingEvent;
					if (selectPACSArcItemListRowDeletingEvent != null)
					{
						selectPACSArcItemListRowDeletingEvent(this, new EPACSArcItemListDataSet.SelectPACSArcItemListRowChangeEvent((EPACSArcItemListDataSet.SelectPACSArcItemListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectPACSArcItemListRow(EPACSArcItemListDataSet.SelectPACSArcItemListRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EPACSArcItemListDataSet ePACSArcItemListDataSet = new EPACSArcItemListDataSet();
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
				xmlSchemaAttribute.FixedValue = ePACSArcItemListDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectPACSArcItemListDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = ePACSArcItemListDataSet.GetSchemaSerializable();
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
		public class SelectPACSArcItemListRow : DataRow
		{
			private EPACSArcItemListDataSet.SelectPACSArcItemListDataTable tableSelectPACSArcItemList;

			[DebuggerNonUserCode]
			public string ItemRowid
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectPACSArcItemList.ItemRowidColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectPACSArcItemList\"中列\"ItemRowid\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectPACSArcItemList.ItemRowidColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ItemDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectPACSArcItemList.ItemDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectPACSArcItemList\"中列\"ItemDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectPACSArcItemList.ItemDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectPACSArcItemListRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectPACSArcItemList = (EPACSArcItemListDataSet.SelectPACSArcItemListDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsItemRowidNull()
			{
				return this.IsNull(this.tableSelectPACSArcItemList.ItemRowidColumn);
			}

			[DebuggerNonUserCode]
			public void SetItemRowidNull()
			{
				this[this.tableSelectPACSArcItemList.ItemRowidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsItemDescNull()
			{
				return this.IsNull(this.tableSelectPACSArcItemList.ItemDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetItemDescNull()
			{
				this[this.tableSelectPACSArcItemList.ItemDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectPACSArcItemListRowChangeEvent : EventArgs
		{
			private EPACSArcItemListDataSet.SelectPACSArcItemListRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EPACSArcItemListDataSet.SelectPACSArcItemListRow Row
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
			public SelectPACSArcItemListRowChangeEvent(EPACSArcItemListDataSet.SelectPACSArcItemListRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EPACSArcItemListDataSet.SelectPACSArcItemListDataTable tableSelectPACSArcItemList;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EPACSArcItemListDataSet.SelectPACSArcItemListDataTable SelectPACSArcItemList
		{
			get
			{
				return this.tableSelectPACSArcItemList;
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
		public EPACSArcItemListDataSet()
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
		protected EPACSArcItemListDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectPACSArcItemList"] != null)
				{
					base.Tables.Add(new EPACSArcItemListDataSet.SelectPACSArcItemListDataTable(dataSet.Tables["SelectPACSArcItemList"]));
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
			EPACSArcItemListDataSet ePACSArcItemListDataSet = (EPACSArcItemListDataSet)base.Clone();
			ePACSArcItemListDataSet.InitVars();
			ePACSArcItemListDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return ePACSArcItemListDataSet;
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
				if (dataSet.Tables["SelectPACSArcItemList"] != null)
				{
					base.Tables.Add(new EPACSArcItemListDataSet.SelectPACSArcItemListDataTable(dataSet.Tables["SelectPACSArcItemList"]));
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
			this.tableSelectPACSArcItemList = (EPACSArcItemListDataSet.SelectPACSArcItemListDataTable)base.Tables["SelectPACSArcItemList"];
			if (initTable && this.tableSelectPACSArcItemList != null)
			{
				this.tableSelectPACSArcItemList.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EPACSArcItemListDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EPACSArcItemListDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectPACSArcItemList = new EPACSArcItemListDataSet.SelectPACSArcItemListDataTable();
			base.Tables.Add(this.tableSelectPACSArcItemList);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectPACSArcItemList()
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
			EPACSArcItemListDataSet ePACSArcItemListDataSet = new EPACSArcItemListDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = ePACSArcItemListDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = ePACSArcItemListDataSet.GetSchemaSerializable();
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
