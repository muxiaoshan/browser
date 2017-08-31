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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EPACSRptStructureDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EPACSRptStructureDataSet : DataSet
	{
		public delegate void SelectRptStructureRowChangeEventHandler(object sender, EPACSRptStructureDataSet.SelectRptStructureRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectRptStructureDataTable : DataTable, IEnumerable
		{
			private DataColumn columnTypeID;

			private DataColumn columnTypeDesc;

			private EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler SelectRptStructureRowChangingEvent;

			private EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler SelectRptStructureRowChangedEvent;

			private EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler SelectRptStructureRowDeletingEvent;

			private EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler SelectRptStructureRowDeletedEvent;

			public event EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler SelectRptStructureRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectRptStructureRowChangingEvent = (EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler)Delegate.Combine(this.SelectRptStructureRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectRptStructureRowChangingEvent = (EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler)Delegate.Remove(this.SelectRptStructureRowChangingEvent, value);
				}
			}

			public event EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler SelectRptStructureRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectRptStructureRowChangedEvent = (EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler)Delegate.Combine(this.SelectRptStructureRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectRptStructureRowChangedEvent = (EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler)Delegate.Remove(this.SelectRptStructureRowChangedEvent, value);
				}
			}

			public event EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler SelectRptStructureRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectRptStructureRowDeletingEvent = (EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler)Delegate.Combine(this.SelectRptStructureRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectRptStructureRowDeletingEvent = (EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler)Delegate.Remove(this.SelectRptStructureRowDeletingEvent, value);
				}
			}

			public event EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler SelectRptStructureRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectRptStructureRowDeletedEvent = (EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler)Delegate.Combine(this.SelectRptStructureRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectRptStructureRowDeletedEvent = (EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler)Delegate.Remove(this.SelectRptStructureRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn TypeIDColumn
			{
				get
				{
					return this.columnTypeID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn TypeDescColumn
			{
				get
				{
					return this.columnTypeDesc;
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
			public EPACSRptStructureDataSet.SelectRptStructureRow this[int index]
			{
				get
				{
					return (EPACSRptStructureDataSet.SelectRptStructureRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectRptStructureDataTable()
			{
				this.TableName = "SelectRptStructure";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectRptStructureDataTable(DataTable table)
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
			protected SelectRptStructureDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectRptStructureRow(EPACSRptStructureDataSet.SelectRptStructureRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EPACSRptStructureDataSet.SelectRptStructureRow AddSelectRptStructureRow(string TypeID, string TypeDesc)
			{
				EPACSRptStructureDataSet.SelectRptStructureRow selectRptStructureRow = (EPACSRptStructureDataSet.SelectRptStructureRow)this.NewRow();
				object[] itemArray = new object[]
				{
					TypeID,
					TypeDesc
				};
				selectRptStructureRow.ItemArray = itemArray;
				this.Rows.Add(selectRptStructureRow);
				return selectRptStructureRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EPACSRptStructureDataSet.SelectRptStructureDataTable selectRptStructureDataTable = (EPACSRptStructureDataSet.SelectRptStructureDataTable)base.Clone();
				selectRptStructureDataTable.InitVars();
				return selectRptStructureDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EPACSRptStructureDataSet.SelectRptStructureDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnTypeID = base.Columns["TypeID"];
				this.columnTypeDesc = base.Columns["TypeDesc"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnTypeID = new DataColumn("TypeID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTypeID);
				this.columnTypeDesc = new DataColumn("TypeDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTypeDesc);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EPACSRptStructureDataSet.SelectRptStructureRow NewSelectRptStructureRow()
			{
				return (EPACSRptStructureDataSet.SelectRptStructureRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EPACSRptStructureDataSet.SelectRptStructureRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EPACSRptStructureDataSet.SelectRptStructureRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectRptStructureRowChangedEvent != null)
				{
					EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler selectRptStructureRowChangedEvent = this.SelectRptStructureRowChangedEvent;
					if (selectRptStructureRowChangedEvent != null)
					{
						selectRptStructureRowChangedEvent(this, new EPACSRptStructureDataSet.SelectRptStructureRowChangeEvent((EPACSRptStructureDataSet.SelectRptStructureRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectRptStructureRowChangingEvent != null)
				{
					EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler selectRptStructureRowChangingEvent = this.SelectRptStructureRowChangingEvent;
					if (selectRptStructureRowChangingEvent != null)
					{
						selectRptStructureRowChangingEvent(this, new EPACSRptStructureDataSet.SelectRptStructureRowChangeEvent((EPACSRptStructureDataSet.SelectRptStructureRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectRptStructureRowDeletedEvent != null)
				{
					EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler selectRptStructureRowDeletedEvent = this.SelectRptStructureRowDeletedEvent;
					if (selectRptStructureRowDeletedEvent != null)
					{
						selectRptStructureRowDeletedEvent(this, new EPACSRptStructureDataSet.SelectRptStructureRowChangeEvent((EPACSRptStructureDataSet.SelectRptStructureRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectRptStructureRowDeletingEvent != null)
				{
					EPACSRptStructureDataSet.SelectRptStructureRowChangeEventHandler selectRptStructureRowDeletingEvent = this.SelectRptStructureRowDeletingEvent;
					if (selectRptStructureRowDeletingEvent != null)
					{
						selectRptStructureRowDeletingEvent(this, new EPACSRptStructureDataSet.SelectRptStructureRowChangeEvent((EPACSRptStructureDataSet.SelectRptStructureRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectRptStructureRow(EPACSRptStructureDataSet.SelectRptStructureRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EPACSRptStructureDataSet ePACSRptStructureDataSet = new EPACSRptStructureDataSet();
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
				xmlSchemaAttribute.FixedValue = ePACSRptStructureDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectRptStructureDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = ePACSRptStructureDataSet.GetSchemaSerializable();
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
		public class SelectRptStructureRow : DataRow
		{
			private EPACSRptStructureDataSet.SelectRptStructureDataTable tableSelectRptStructure;

			[DebuggerNonUserCode]
			public string TypeID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectRptStructure.TypeIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectRptStructure\"中列\"TypeID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectRptStructure.TypeIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string TypeDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectRptStructure.TypeDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectRptStructure\"中列\"TypeDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectRptStructure.TypeDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectRptStructureRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectRptStructure = (EPACSRptStructureDataSet.SelectRptStructureDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsTypeIDNull()
			{
				return this.IsNull(this.tableSelectRptStructure.TypeIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetTypeIDNull()
			{
				this[this.tableSelectRptStructure.TypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsTypeDescNull()
			{
				return this.IsNull(this.tableSelectRptStructure.TypeDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetTypeDescNull()
			{
				this[this.tableSelectRptStructure.TypeDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectRptStructureRowChangeEvent : EventArgs
		{
			private EPACSRptStructureDataSet.SelectRptStructureRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EPACSRptStructureDataSet.SelectRptStructureRow Row
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
			public SelectRptStructureRowChangeEvent(EPACSRptStructureDataSet.SelectRptStructureRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EPACSRptStructureDataSet.SelectRptStructureDataTable tableSelectRptStructure;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EPACSRptStructureDataSet.SelectRptStructureDataTable SelectRptStructure
		{
			get
			{
				return this.tableSelectRptStructure;
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
		public EPACSRptStructureDataSet()
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
		protected EPACSRptStructureDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectRptStructure"] != null)
				{
					base.Tables.Add(new EPACSRptStructureDataSet.SelectRptStructureDataTable(dataSet.Tables["SelectRptStructure"]));
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
			EPACSRptStructureDataSet ePACSRptStructureDataSet = (EPACSRptStructureDataSet)base.Clone();
			ePACSRptStructureDataSet.InitVars();
			ePACSRptStructureDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return ePACSRptStructureDataSet;
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
				if (dataSet.Tables["SelectRptStructure"] != null)
				{
					base.Tables.Add(new EPACSRptStructureDataSet.SelectRptStructureDataTable(dataSet.Tables["SelectRptStructure"]));
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
			this.tableSelectRptStructure = (EPACSRptStructureDataSet.SelectRptStructureDataTable)base.Tables["SelectRptStructure"];
			if (initTable && this.tableSelectRptStructure != null)
			{
				this.tableSelectRptStructure.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EPACSRptStructureDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EPACSRptStructureDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectRptStructure = new EPACSRptStructureDataSet.SelectRptStructureDataTable();
			base.Tables.Add(this.tableSelectRptStructure);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectRptStructure()
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
			EPACSRptStructureDataSet ePACSRptStructureDataSet = new EPACSRptStructureDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = ePACSRptStructureDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = ePACSRptStructureDataSet.GetSchemaSerializable();
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
