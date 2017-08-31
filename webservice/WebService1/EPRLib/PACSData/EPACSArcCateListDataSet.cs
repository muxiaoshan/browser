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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EPACSArcCateListDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EPACSArcCateListDataSet : DataSet
	{
		public delegate void SelectPACSArcCateListRowChangeEventHandler(object sender, EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectPACSArcCateListDataTable : DataTable, IEnumerable
		{
			private DataColumn columnCatItemDR;

			private DataColumn columnCatDesc;

			private EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler SelectPACSArcCateListRowChangingEvent;

			private EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler SelectPACSArcCateListRowChangedEvent;

			private EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler SelectPACSArcCateListRowDeletingEvent;

			private EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler SelectPACSArcCateListRowDeletedEvent;

			public event EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler SelectPACSArcCateListRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectPACSArcCateListRowChangingEvent = (EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler)Delegate.Combine(this.SelectPACSArcCateListRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectPACSArcCateListRowChangingEvent = (EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler)Delegate.Remove(this.SelectPACSArcCateListRowChangingEvent, value);
				}
			}

			public event EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler SelectPACSArcCateListRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectPACSArcCateListRowChangedEvent = (EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler)Delegate.Combine(this.SelectPACSArcCateListRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectPACSArcCateListRowChangedEvent = (EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler)Delegate.Remove(this.SelectPACSArcCateListRowChangedEvent, value);
				}
			}

			public event EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler SelectPACSArcCateListRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectPACSArcCateListRowDeletingEvent = (EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler)Delegate.Combine(this.SelectPACSArcCateListRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectPACSArcCateListRowDeletingEvent = (EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler)Delegate.Remove(this.SelectPACSArcCateListRowDeletingEvent, value);
				}
			}

			public event EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler SelectPACSArcCateListRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectPACSArcCateListRowDeletedEvent = (EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler)Delegate.Combine(this.SelectPACSArcCateListRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectPACSArcCateListRowDeletedEvent = (EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler)Delegate.Remove(this.SelectPACSArcCateListRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn CatItemDRColumn
			{
				get
				{
					return this.columnCatItemDR;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn CatDescColumn
			{
				get
				{
					return this.columnCatDesc;
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
			public EPACSArcCateListDataSet.SelectPACSArcCateListRow this[int index]
			{
				get
				{
					return (EPACSArcCateListDataSet.SelectPACSArcCateListRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectPACSArcCateListDataTable()
			{
				this.TableName = "SelectPACSArcCateList";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectPACSArcCateListDataTable(DataTable table)
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
			protected SelectPACSArcCateListDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectPACSArcCateListRow(EPACSArcCateListDataSet.SelectPACSArcCateListRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EPACSArcCateListDataSet.SelectPACSArcCateListRow AddSelectPACSArcCateListRow(string CatItemDR, string CatDesc)
			{
				EPACSArcCateListDataSet.SelectPACSArcCateListRow selectPACSArcCateListRow = (EPACSArcCateListDataSet.SelectPACSArcCateListRow)this.NewRow();
				object[] itemArray = new object[]
				{
					CatItemDR,
					CatDesc
				};
				selectPACSArcCateListRow.ItemArray = itemArray;
				this.Rows.Add(selectPACSArcCateListRow);
				return selectPACSArcCateListRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EPACSArcCateListDataSet.SelectPACSArcCateListDataTable selectPACSArcCateListDataTable = (EPACSArcCateListDataSet.SelectPACSArcCateListDataTable)base.Clone();
				selectPACSArcCateListDataTable.InitVars();
				return selectPACSArcCateListDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EPACSArcCateListDataSet.SelectPACSArcCateListDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnCatItemDR = base.Columns["CatItemDR"];
				this.columnCatDesc = base.Columns["CatDesc"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnCatItemDR = new DataColumn("CatItemDR", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCatItemDR);
				this.columnCatDesc = new DataColumn("CatDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCatDesc);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EPACSArcCateListDataSet.SelectPACSArcCateListRow NewSelectPACSArcCateListRow()
			{
				return (EPACSArcCateListDataSet.SelectPACSArcCateListRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EPACSArcCateListDataSet.SelectPACSArcCateListRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EPACSArcCateListDataSet.SelectPACSArcCateListRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectPACSArcCateListRowChangedEvent != null)
				{
					EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler selectPACSArcCateListRowChangedEvent = this.SelectPACSArcCateListRowChangedEvent;
					if (selectPACSArcCateListRowChangedEvent != null)
					{
						selectPACSArcCateListRowChangedEvent(this, new EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEvent((EPACSArcCateListDataSet.SelectPACSArcCateListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectPACSArcCateListRowChangingEvent != null)
				{
					EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler selectPACSArcCateListRowChangingEvent = this.SelectPACSArcCateListRowChangingEvent;
					if (selectPACSArcCateListRowChangingEvent != null)
					{
						selectPACSArcCateListRowChangingEvent(this, new EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEvent((EPACSArcCateListDataSet.SelectPACSArcCateListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectPACSArcCateListRowDeletedEvent != null)
				{
					EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler selectPACSArcCateListRowDeletedEvent = this.SelectPACSArcCateListRowDeletedEvent;
					if (selectPACSArcCateListRowDeletedEvent != null)
					{
						selectPACSArcCateListRowDeletedEvent(this, new EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEvent((EPACSArcCateListDataSet.SelectPACSArcCateListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectPACSArcCateListRowDeletingEvent != null)
				{
					EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEventHandler selectPACSArcCateListRowDeletingEvent = this.SelectPACSArcCateListRowDeletingEvent;
					if (selectPACSArcCateListRowDeletingEvent != null)
					{
						selectPACSArcCateListRowDeletingEvent(this, new EPACSArcCateListDataSet.SelectPACSArcCateListRowChangeEvent((EPACSArcCateListDataSet.SelectPACSArcCateListRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectPACSArcCateListRow(EPACSArcCateListDataSet.SelectPACSArcCateListRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EPACSArcCateListDataSet ePACSArcCateListDataSet = new EPACSArcCateListDataSet();
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
				xmlSchemaAttribute.FixedValue = ePACSArcCateListDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectPACSArcCateListDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = ePACSArcCateListDataSet.GetSchemaSerializable();
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
		public class SelectPACSArcCateListRow : DataRow
		{
			private EPACSArcCateListDataSet.SelectPACSArcCateListDataTable tableSelectPACSArcCateList;

			[DebuggerNonUserCode]
			public string CatItemDR
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectPACSArcCateList.CatItemDRColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectPACSArcCateList\"中列\"CatItemDR\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectPACSArcCateList.CatItemDRColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string CatDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectPACSArcCateList.CatDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectPACSArcCateList\"中列\"CatDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectPACSArcCateList.CatDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectPACSArcCateListRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectPACSArcCateList = (EPACSArcCateListDataSet.SelectPACSArcCateListDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsCatItemDRNull()
			{
				return this.IsNull(this.tableSelectPACSArcCateList.CatItemDRColumn);
			}

			[DebuggerNonUserCode]
			public void SetCatItemDRNull()
			{
				this[this.tableSelectPACSArcCateList.CatItemDRColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsCatDescNull()
			{
				return this.IsNull(this.tableSelectPACSArcCateList.CatDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetCatDescNull()
			{
				this[this.tableSelectPACSArcCateList.CatDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectPACSArcCateListRowChangeEvent : EventArgs
		{
			private EPACSArcCateListDataSet.SelectPACSArcCateListRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EPACSArcCateListDataSet.SelectPACSArcCateListRow Row
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
			public SelectPACSArcCateListRowChangeEvent(EPACSArcCateListDataSet.SelectPACSArcCateListRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EPACSArcCateListDataSet.SelectPACSArcCateListDataTable tableSelectPACSArcCateList;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EPACSArcCateListDataSet.SelectPACSArcCateListDataTable SelectPACSArcCateList
		{
			get
			{
				return this.tableSelectPACSArcCateList;
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
		public EPACSArcCateListDataSet()
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
		protected EPACSArcCateListDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectPACSArcCateList"] != null)
				{
					base.Tables.Add(new EPACSArcCateListDataSet.SelectPACSArcCateListDataTable(dataSet.Tables["SelectPACSArcCateList"]));
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
			EPACSArcCateListDataSet ePACSArcCateListDataSet = (EPACSArcCateListDataSet)base.Clone();
			ePACSArcCateListDataSet.InitVars();
			ePACSArcCateListDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return ePACSArcCateListDataSet;
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
				if (dataSet.Tables["SelectPACSArcCateList"] != null)
				{
					base.Tables.Add(new EPACSArcCateListDataSet.SelectPACSArcCateListDataTable(dataSet.Tables["SelectPACSArcCateList"]));
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
			this.tableSelectPACSArcCateList = (EPACSArcCateListDataSet.SelectPACSArcCateListDataTable)base.Tables["SelectPACSArcCateList"];
			if (initTable && this.tableSelectPACSArcCateList != null)
			{
				this.tableSelectPACSArcCateList.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EPACSArcCateListDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EPACSArcCateListDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectPACSArcCateList = new EPACSArcCateListDataSet.SelectPACSArcCateListDataTable();
			base.Tables.Add(this.tableSelectPACSArcCateList);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectPACSArcCateList()
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
			EPACSArcCateListDataSet ePACSArcCateListDataSet = new EPACSArcCateListDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = ePACSArcCateListDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = ePACSArcCateListDataSet.GetSchemaSerializable();
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
