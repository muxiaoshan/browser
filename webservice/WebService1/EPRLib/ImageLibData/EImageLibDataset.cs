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

namespace ImageLibData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EImageLibDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EImageLibDataset : DataSet
	{
		public delegate void GetImageLibsByCateIDRowChangeEventHandler(object sender, EImageLibDataset.GetImageLibsByCateIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetImageLibsByCateIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnDescription;

			private DataColumn columnSequence;

			private EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler GetImageLibsByCateIDRowChangingEvent;

			private EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler GetImageLibsByCateIDRowChangedEvent;

			private EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler GetImageLibsByCateIDRowDeletingEvent;

			private EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler GetImageLibsByCateIDRowDeletedEvent;

			public event EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler GetImageLibsByCateIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetImageLibsByCateIDRowChangingEvent = (EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler)Delegate.Combine(this.GetImageLibsByCateIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetImageLibsByCateIDRowChangingEvent = (EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler)Delegate.Remove(this.GetImageLibsByCateIDRowChangingEvent, value);
				}
			}

			public event EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler GetImageLibsByCateIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetImageLibsByCateIDRowChangedEvent = (EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler)Delegate.Combine(this.GetImageLibsByCateIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetImageLibsByCateIDRowChangedEvent = (EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler)Delegate.Remove(this.GetImageLibsByCateIDRowChangedEvent, value);
				}
			}

			public event EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler GetImageLibsByCateIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetImageLibsByCateIDRowDeletingEvent = (EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler)Delegate.Combine(this.GetImageLibsByCateIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetImageLibsByCateIDRowDeletingEvent = (EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler)Delegate.Remove(this.GetImageLibsByCateIDRowDeletingEvent, value);
				}
			}

			public event EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler GetImageLibsByCateIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetImageLibsByCateIDRowDeletedEvent = (EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler)Delegate.Combine(this.GetImageLibsByCateIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetImageLibsByCateIDRowDeletedEvent = (EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler)Delegate.Remove(this.GetImageLibsByCateIDRowDeletedEvent, value);
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
			public DataColumn SequenceColumn
			{
				get
				{
					return this.columnSequence;
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
			public EImageLibDataset.GetImageLibsByCateIDRow this[int index]
			{
				get
				{
					return (EImageLibDataset.GetImageLibsByCateIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetImageLibsByCateIDDataTable()
			{
				this.TableName = "GetImageLibsByCateID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetImageLibsByCateIDDataTable(DataTable table)
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
			protected GetImageLibsByCateIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetImageLibsByCateIDRow(EImageLibDataset.GetImageLibsByCateIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EImageLibDataset.GetImageLibsByCateIDRow AddGetImageLibsByCateIDRow(string ID, string Name, string Description, string Sequence)
			{
				EImageLibDataset.GetImageLibsByCateIDRow getImageLibsByCateIDRow = (EImageLibDataset.GetImageLibsByCateIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					Description,
					Sequence
				};
				getImageLibsByCateIDRow.ItemArray = itemArray;
				this.Rows.Add(getImageLibsByCateIDRow);
				return getImageLibsByCateIDRow;
			}

			[DebuggerNonUserCode]
			public EImageLibDataset.GetImageLibsByCateIDRow FindByID(string ID)
			{
				return (EImageLibDataset.GetImageLibsByCateIDRow)this.Rows.Find(new object[]
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
				EImageLibDataset.GetImageLibsByCateIDDataTable getImageLibsByCateIDDataTable = (EImageLibDataset.GetImageLibsByCateIDDataTable)base.Clone();
				getImageLibsByCateIDDataTable.InitVars();
				return getImageLibsByCateIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EImageLibDataset.GetImageLibsByCateIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnDescription = base.Columns["Description"];
				this.columnSequence = base.Columns["Sequence"];
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
				this.columnSequence = new DataColumn("Sequence", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSequence);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EImageLibDataset.GetImageLibsByCateIDRow NewGetImageLibsByCateIDRow()
			{
				return (EImageLibDataset.GetImageLibsByCateIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EImageLibDataset.GetImageLibsByCateIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EImageLibDataset.GetImageLibsByCateIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetImageLibsByCateIDRowChangedEvent != null)
				{
					EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler getImageLibsByCateIDRowChangedEvent = this.GetImageLibsByCateIDRowChangedEvent;
					if (getImageLibsByCateIDRowChangedEvent != null)
					{
						getImageLibsByCateIDRowChangedEvent(this, new EImageLibDataset.GetImageLibsByCateIDRowChangeEvent((EImageLibDataset.GetImageLibsByCateIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetImageLibsByCateIDRowChangingEvent != null)
				{
					EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler getImageLibsByCateIDRowChangingEvent = this.GetImageLibsByCateIDRowChangingEvent;
					if (getImageLibsByCateIDRowChangingEvent != null)
					{
						getImageLibsByCateIDRowChangingEvent(this, new EImageLibDataset.GetImageLibsByCateIDRowChangeEvent((EImageLibDataset.GetImageLibsByCateIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetImageLibsByCateIDRowDeletedEvent != null)
				{
					EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler getImageLibsByCateIDRowDeletedEvent = this.GetImageLibsByCateIDRowDeletedEvent;
					if (getImageLibsByCateIDRowDeletedEvent != null)
					{
						getImageLibsByCateIDRowDeletedEvent(this, new EImageLibDataset.GetImageLibsByCateIDRowChangeEvent((EImageLibDataset.GetImageLibsByCateIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetImageLibsByCateIDRowDeletingEvent != null)
				{
					EImageLibDataset.GetImageLibsByCateIDRowChangeEventHandler getImageLibsByCateIDRowDeletingEvent = this.GetImageLibsByCateIDRowDeletingEvent;
					if (getImageLibsByCateIDRowDeletingEvent != null)
					{
						getImageLibsByCateIDRowDeletingEvent(this, new EImageLibDataset.GetImageLibsByCateIDRowChangeEvent((EImageLibDataset.GetImageLibsByCateIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetImageLibsByCateIDRow(EImageLibDataset.GetImageLibsByCateIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EImageLibDataset eImageLibDataset = new EImageLibDataset();
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
				xmlSchemaAttribute.FixedValue = eImageLibDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetImageLibsByCateIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eImageLibDataset.GetSchemaSerializable();
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
		public class GetImageLibsByCateIDRow : DataRow
		{
			private EImageLibDataset.GetImageLibsByCateIDDataTable tableGetImageLibsByCateID;

			[DebuggerNonUserCode]
			public string ID
			{
				get
				{
					return Conversions.ToString(this[this.tableGetImageLibsByCateID.IDColumn]);
				}
				set
				{
					this[this.tableGetImageLibsByCateID.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetImageLibsByCateID.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetImageLibsByCateID\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetImageLibsByCateID.NameColumn] = value;
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
						result = Conversions.ToString(this[this.tableGetImageLibsByCateID.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetImageLibsByCateID\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetImageLibsByCateID.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string Sequence
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetImageLibsByCateID.SequenceColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetImageLibsByCateID\"中列\"Sequence\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetImageLibsByCateID.SequenceColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetImageLibsByCateIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetImageLibsByCateID = (EImageLibDataset.GetImageLibsByCateIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableGetImageLibsByCateID.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableGetImageLibsByCateID.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableGetImageLibsByCateID.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableGetImageLibsByCateID.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsSequenceNull()
			{
				return this.IsNull(this.tableGetImageLibsByCateID.SequenceColumn);
			}

			[DebuggerNonUserCode]
			public void SetSequenceNull()
			{
				this[this.tableGetImageLibsByCateID.SequenceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetImageLibsByCateIDRowChangeEvent : EventArgs
		{
			private EImageLibDataset.GetImageLibsByCateIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EImageLibDataset.GetImageLibsByCateIDRow Row
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
			public GetImageLibsByCateIDRowChangeEvent(EImageLibDataset.GetImageLibsByCateIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EImageLibDataset.GetImageLibsByCateIDDataTable tableGetImageLibsByCateID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EImageLibDataset.GetImageLibsByCateIDDataTable GetImageLibsByCateID
		{
			get
			{
				return this.tableGetImageLibsByCateID;
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
		public EImageLibDataset()
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
		protected EImageLibDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetImageLibsByCateID"] != null)
				{
					base.Tables.Add(new EImageLibDataset.GetImageLibsByCateIDDataTable(dataSet.Tables["GetImageLibsByCateID"]));
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
			EImageLibDataset eImageLibDataset = (EImageLibDataset)base.Clone();
			eImageLibDataset.InitVars();
			eImageLibDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eImageLibDataset;
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
				if (dataSet.Tables["GetImageLibsByCateID"] != null)
				{
					base.Tables.Add(new EImageLibDataset.GetImageLibsByCateIDDataTable(dataSet.Tables["GetImageLibsByCateID"]));
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
			this.tableGetImageLibsByCateID = (EImageLibDataset.GetImageLibsByCateIDDataTable)base.Tables["GetImageLibsByCateID"];
			if (initTable && this.tableGetImageLibsByCateID != null)
			{
				this.tableGetImageLibsByCateID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EImageLibDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EImageLibDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetImageLibsByCateID = new EImageLibDataset.GetImageLibsByCateIDDataTable();
			base.Tables.Add(this.tableGetImageLibsByCateID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetImageLibsByCateID()
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
			EImageLibDataset eImageLibDataset = new EImageLibDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eImageLibDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eImageLibDataset.GetSchemaSerializable();
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
