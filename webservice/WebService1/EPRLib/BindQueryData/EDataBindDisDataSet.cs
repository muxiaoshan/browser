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

namespace BindQueryData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EDataBindDisDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EDataBindDisDataSet : DataSet
	{
		public delegate void SelectDistinctParameterRowChangeEventHandler(object sender, EDataBindDisDataSet.SelectDistinctParameterRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectDistinctParameterDataTable : DataTable, IEnumerable
		{
			private DataColumn columnParameterName;

			private EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler SelectDistinctParameterRowChangingEvent;

			private EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler SelectDistinctParameterRowChangedEvent;

			private EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler SelectDistinctParameterRowDeletingEvent;

			private EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler SelectDistinctParameterRowDeletedEvent;

			public event EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler SelectDistinctParameterRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectDistinctParameterRowChangingEvent = (EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler)Delegate.Combine(this.SelectDistinctParameterRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectDistinctParameterRowChangingEvent = (EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler)Delegate.Remove(this.SelectDistinctParameterRowChangingEvent, value);
				}
			}

			public event EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler SelectDistinctParameterRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectDistinctParameterRowChangedEvent = (EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler)Delegate.Combine(this.SelectDistinctParameterRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectDistinctParameterRowChangedEvent = (EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler)Delegate.Remove(this.SelectDistinctParameterRowChangedEvent, value);
				}
			}

			public event EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler SelectDistinctParameterRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectDistinctParameterRowDeletingEvent = (EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler)Delegate.Combine(this.SelectDistinctParameterRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectDistinctParameterRowDeletingEvent = (EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler)Delegate.Remove(this.SelectDistinctParameterRowDeletingEvent, value);
				}
			}

			public event EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler SelectDistinctParameterRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectDistinctParameterRowDeletedEvent = (EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler)Delegate.Combine(this.SelectDistinctParameterRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectDistinctParameterRowDeletedEvent = (EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler)Delegate.Remove(this.SelectDistinctParameterRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ParameterNameColumn
			{
				get
				{
					return this.columnParameterName;
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
			public EDataBindDisDataSet.SelectDistinctParameterRow this[int index]
			{
				get
				{
					return (EDataBindDisDataSet.SelectDistinctParameterRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectDistinctParameterDataTable()
			{
				this.TableName = "SelectDistinctParameter";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectDistinctParameterDataTable(DataTable table)
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
			protected SelectDistinctParameterDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectDistinctParameterRow(EDataBindDisDataSet.SelectDistinctParameterRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EDataBindDisDataSet.SelectDistinctParameterRow AddSelectDistinctParameterRow(string ParameterName)
			{
				EDataBindDisDataSet.SelectDistinctParameterRow selectDistinctParameterRow = (EDataBindDisDataSet.SelectDistinctParameterRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ParameterName
				};
				selectDistinctParameterRow.ItemArray = itemArray;
				this.Rows.Add(selectDistinctParameterRow);
				return selectDistinctParameterRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EDataBindDisDataSet.SelectDistinctParameterDataTable selectDistinctParameterDataTable = (EDataBindDisDataSet.SelectDistinctParameterDataTable)base.Clone();
				selectDistinctParameterDataTable.InitVars();
				return selectDistinctParameterDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EDataBindDisDataSet.SelectDistinctParameterDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnParameterName = base.Columns["ParameterName"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnParameterName = new DataColumn("ParameterName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParameterName);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EDataBindDisDataSet.SelectDistinctParameterRow NewSelectDistinctParameterRow()
			{
				return (EDataBindDisDataSet.SelectDistinctParameterRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EDataBindDisDataSet.SelectDistinctParameterRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EDataBindDisDataSet.SelectDistinctParameterRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectDistinctParameterRowChangedEvent != null)
				{
					EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler selectDistinctParameterRowChangedEvent = this.SelectDistinctParameterRowChangedEvent;
					if (selectDistinctParameterRowChangedEvent != null)
					{
						selectDistinctParameterRowChangedEvent(this, new EDataBindDisDataSet.SelectDistinctParameterRowChangeEvent((EDataBindDisDataSet.SelectDistinctParameterRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectDistinctParameterRowChangingEvent != null)
				{
					EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler selectDistinctParameterRowChangingEvent = this.SelectDistinctParameterRowChangingEvent;
					if (selectDistinctParameterRowChangingEvent != null)
					{
						selectDistinctParameterRowChangingEvent(this, new EDataBindDisDataSet.SelectDistinctParameterRowChangeEvent((EDataBindDisDataSet.SelectDistinctParameterRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectDistinctParameterRowDeletedEvent != null)
				{
					EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler selectDistinctParameterRowDeletedEvent = this.SelectDistinctParameterRowDeletedEvent;
					if (selectDistinctParameterRowDeletedEvent != null)
					{
						selectDistinctParameterRowDeletedEvent(this, new EDataBindDisDataSet.SelectDistinctParameterRowChangeEvent((EDataBindDisDataSet.SelectDistinctParameterRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectDistinctParameterRowDeletingEvent != null)
				{
					EDataBindDisDataSet.SelectDistinctParameterRowChangeEventHandler selectDistinctParameterRowDeletingEvent = this.SelectDistinctParameterRowDeletingEvent;
					if (selectDistinctParameterRowDeletingEvent != null)
					{
						selectDistinctParameterRowDeletingEvent(this, new EDataBindDisDataSet.SelectDistinctParameterRowChangeEvent((EDataBindDisDataSet.SelectDistinctParameterRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectDistinctParameterRow(EDataBindDisDataSet.SelectDistinctParameterRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EDataBindDisDataSet eDataBindDisDataSet = new EDataBindDisDataSet();
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
				xmlSchemaAttribute.FixedValue = eDataBindDisDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectDistinctParameterDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eDataBindDisDataSet.GetSchemaSerializable();
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
		public class SelectDistinctParameterRow : DataRow
		{
			private EDataBindDisDataSet.SelectDistinctParameterDataTable tableSelectDistinctParameter;

			[DebuggerNonUserCode]
			public string ParameterName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectDistinctParameter.ParameterNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectDistinctParameter\"中列\"ParameterName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectDistinctParameter.ParameterNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectDistinctParameterRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectDistinctParameter = (EDataBindDisDataSet.SelectDistinctParameterDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsParameterNameNull()
			{
				return this.IsNull(this.tableSelectDistinctParameter.ParameterNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetParameterNameNull()
			{
				this[this.tableSelectDistinctParameter.ParameterNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectDistinctParameterRowChangeEvent : EventArgs
		{
			private EDataBindDisDataSet.SelectDistinctParameterRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EDataBindDisDataSet.SelectDistinctParameterRow Row
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
			public SelectDistinctParameterRowChangeEvent(EDataBindDisDataSet.SelectDistinctParameterRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EDataBindDisDataSet.SelectDistinctParameterDataTable tableSelectDistinctParameter;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EDataBindDisDataSet.SelectDistinctParameterDataTable SelectDistinctParameter
		{
			get
			{
				return this.tableSelectDistinctParameter;
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
		public EDataBindDisDataSet()
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
		protected EDataBindDisDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectDistinctParameter"] != null)
				{
					base.Tables.Add(new EDataBindDisDataSet.SelectDistinctParameterDataTable(dataSet.Tables["SelectDistinctParameter"]));
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
			EDataBindDisDataSet eDataBindDisDataSet = (EDataBindDisDataSet)base.Clone();
			eDataBindDisDataSet.InitVars();
			eDataBindDisDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return eDataBindDisDataSet;
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
				if (dataSet.Tables["SelectDistinctParameter"] != null)
				{
					base.Tables.Add(new EDataBindDisDataSet.SelectDistinctParameterDataTable(dataSet.Tables["SelectDistinctParameter"]));
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
			this.tableSelectDistinctParameter = (EDataBindDisDataSet.SelectDistinctParameterDataTable)base.Tables["SelectDistinctParameter"];
			if (initTable && this.tableSelectDistinctParameter != null)
			{
				this.tableSelectDistinctParameter.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EDataBindDisDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EDataBindDisDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectDistinctParameter = new EDataBindDisDataSet.SelectDistinctParameterDataTable();
			base.Tables.Add(this.tableSelectDistinctParameter);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectDistinctParameter()
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
			EDataBindDisDataSet eDataBindDisDataSet = new EDataBindDisDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eDataBindDisDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eDataBindDisDataSet.GetSchemaSerializable();
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
