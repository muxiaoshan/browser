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

namespace dhcc.epr.eprlib.previewmanage.SysOptionData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("ESysOptionDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class ESysOptionDataset : DataSet
	{
		public delegate void SELECTALLRowChangeEventHandler(object sender, ESysOptionDataset.SELECTALLRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SELECTALLDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnOptionValue;

			private DataColumn columnDescription;

			public event ESysOptionDataset.SELECTALLRowChangeEventHandler SELECTALLRowChanging
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLRowChanging = (ESysOptionDataset.SELECTALLRowChangeEventHandler)Delegate.Combine(this.SELECTALLRowChanging, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLRowChanging = (ESysOptionDataset.SELECTALLRowChangeEventHandler)Delegate.Remove(this.SELECTALLRowChanging, value);
				}
			}

			public event ESysOptionDataset.SELECTALLRowChangeEventHandler SELECTALLRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLRowChanged = (ESysOptionDataset.SELECTALLRowChangeEventHandler)Delegate.Combine(this.SELECTALLRowChanged, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLRowChanged = (ESysOptionDataset.SELECTALLRowChangeEventHandler)Delegate.Remove(this.SELECTALLRowChanged, value);
				}
			}

			public event ESysOptionDataset.SELECTALLRowChangeEventHandler SELECTALLRowDeleting
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLRowDeleting = (ESysOptionDataset.SELECTALLRowChangeEventHandler)Delegate.Combine(this.SELECTALLRowDeleting, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLRowDeleting = (ESysOptionDataset.SELECTALLRowChangeEventHandler)Delegate.Remove(this.SELECTALLRowDeleting, value);
				}
			}

			public event ESysOptionDataset.SELECTALLRowChangeEventHandler SELECTALLRowDeleted
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLRowDeleted = (ESysOptionDataset.SELECTALLRowChangeEventHandler)Delegate.Combine(this.SELECTALLRowDeleted, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLRowDeleted = (ESysOptionDataset.SELECTALLRowChangeEventHandler)Delegate.Remove(this.SELECTALLRowDeleted, value);
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
			public DataColumn OptionValueColumn
			{
				get
				{
					return this.columnOptionValue;
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

			[Browsable(false), DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			public ESysOptionDataset.SELECTALLRow this[int index]
			{
				get
				{
					return (ESysOptionDataset.SELECTALLRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SELECTALLDataTable()
			{
				base.TableName = "SELECTALL";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SELECTALLDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			protected SELECTALLDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSELECTALLRow(ESysOptionDataset.SELECTALLRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public ESysOptionDataset.SELECTALLRow AddSELECTALLRow(long ID, string Name, string OptionValue, string Description)
			{
				ESysOptionDataset.SELECTALLRow sELECTALLRow = (ESysOptionDataset.SELECTALLRow)base.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					OptionValue,
					Description
				};
				sELECTALLRow.ItemArray = itemArray;
				base.Rows.Add(sELECTALLRow);
				return sELECTALLRow;
			}

			[DebuggerNonUserCode]
			public ESysOptionDataset.SELECTALLRow FindByID(long ID)
			{
				return (ESysOptionDataset.SELECTALLRow)base.Rows.Find(new object[]
				{
					ID
				});
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				ESysOptionDataset.SELECTALLDataTable sELECTALLDataTable = (ESysOptionDataset.SELECTALLDataTable)base.Clone();
				sELECTALLDataTable.InitVars();
				return sELECTALLDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new ESysOptionDataset.SELECTALLDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnOptionValue = base.Columns["OptionValue"];
				this.columnDescription = base.Columns["Description"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnOptionValue = new DataColumn("OptionValue", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOptionValue);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				base.Namespace = "";
			}

			[DebuggerNonUserCode]
			public ESysOptionDataset.SELECTALLRow NewSELECTALLRow()
			{
				return (ESysOptionDataset.SELECTALLRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new ESysOptionDataset.SELECTALLRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(ESysOptionDataset.SELECTALLRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SELECTALLRowChanged != null)
				{
					this.SELECTALLRowChanged(this, new ESysOptionDataset.SELECTALLRowChangeEvent((ESysOptionDataset.SELECTALLRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SELECTALLRowChanging != null)
				{
					this.SELECTALLRowChanging(this, new ESysOptionDataset.SELECTALLRowChangeEvent((ESysOptionDataset.SELECTALLRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SELECTALLRowDeleted != null)
				{
					this.SELECTALLRowDeleted(this, new ESysOptionDataset.SELECTALLRowChangeEvent((ESysOptionDataset.SELECTALLRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SELECTALLRowDeleting != null)
				{
					this.SELECTALLRowDeleting(this, new ESysOptionDataset.SELECTALLRowChangeEvent((ESysOptionDataset.SELECTALLRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSELECTALLRow(ESysOptionDataset.SELECTALLRow row)
			{
				base.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				ESysOptionDataset eSysOptionDataset = new ESysOptionDataset();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = 79228162514264337593543950335m;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = eSysOptionDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SELECTALLDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eSysOptionDataset.GetSchemaSerializable();
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
		public class SELECTALLRow : DataRow
		{
			private ESysOptionDataset.SELECTALLDataTable tableSELECTALL;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return (long)base[this.tableSELECTALL.IDColumn];
				}
				set
				{
					base[this.tableSELECTALL.IDColumn] = value;
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
						result = (string)base[this.tableSELECTALL.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("表“SELECTALL”中列“Name”的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSELECTALL.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OptionValue
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableSELECTALL.OptionValueColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("表“SELECTALL”中列“OptionValue”的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSELECTALL.OptionValueColumn] = value;
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
						result = (string)base[this.tableSELECTALL.DescriptionColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("表“SELECTALL”中列“Description”的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableSELECTALL.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SELECTALLRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSELECTALL = (ESysOptionDataset.SELECTALLDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return base.IsNull(this.tableSELECTALL.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				base[this.tableSELECTALL.NameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			public bool IsOptionValueNull()
			{
				return base.IsNull(this.tableSELECTALL.OptionValueColumn);
			}

			[DebuggerNonUserCode]
			public void SetOptionValueNull()
			{
				base[this.tableSELECTALL.OptionValueColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return base.IsNull(this.tableSELECTALL.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				base[this.tableSELECTALL.DescriptionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SELECTALLRowChangeEvent : EventArgs
		{
			private ESysOptionDataset.SELECTALLRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public ESysOptionDataset.SELECTALLRow Row
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
			public SELECTALLRowChangeEvent(ESysOptionDataset.SELECTALLRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private ESysOptionDataset.SELECTALLDataTable tableSELECTALL;

		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public ESysOptionDataset.SELECTALLDataTable SELECTALL
		{
			get
			{
				return this.tableSELECTALL;
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
		public ESysOptionDataset()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}

		[DebuggerNonUserCode]
		protected ESysOptionDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			if (base.IsBinarySerialized(info, context))
			{
				this.InitVars(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
				return;
			}
			string s = (string)info.GetValue("XmlSchema", typeof(string));
			if (base.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				if (dataSet.Tables["SELECTALL"] != null)
				{
					base.Tables.Add(new ESysOptionDataset.SELECTALLDataTable(dataSet.Tables["SELECTALL"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				base.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			}
			base.GetSerializationData(info, context);
			CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value2;
			this.Relations.CollectionChanged += value2;
		}

		[DebuggerNonUserCode]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		[DebuggerNonUserCode]
		public override DataSet Clone()
		{
			ESysOptionDataset eSysOptionDataset = (ESysOptionDataset)base.Clone();
			eSysOptionDataset.InitVars();
			eSysOptionDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eSysOptionDataset;
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
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["SELECTALL"] != null)
				{
					base.Tables.Add(new ESysOptionDataset.SELECTALLDataTable(dataSet.Tables["SELECTALL"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
				return;
			}
			base.ReadXml(reader);
			this.InitVars();
		}

		[DebuggerNonUserCode]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
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
			this.tableSELECTALL = (ESysOptionDataset.SELECTALLDataTable)base.Tables["SELECTALL"];
			if (initTable && this.tableSELECTALL != null)
			{
				this.tableSELECTALL.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			base.DataSetName = "ESysOptionDataset";
			base.Prefix = "";
			base.Namespace = "http://www.dhcc.com.cn/epr/metaservice/ESysOptionDataset";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSELECTALL = new ESysOptionDataset.SELECTALLDataTable();
			base.Tables.Add(this.tableSELECTALL);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSELECTALL()
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
			ESysOptionDataset eSysOptionDataset = new ESysOptionDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eSysOptionDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eSysOptionDataset.GetSchemaSerializable();
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
