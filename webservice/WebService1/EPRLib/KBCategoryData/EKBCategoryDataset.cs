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

namespace KBCategoryData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EKBCategoryDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EKBCategoryDataset : DataSet
	{
		public delegate void SELECTALLRowChangeEventHandler(object sender, EKBCategoryDataset.SELECTALLRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SELECTALLDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnParentID;

			private DataColumn columnDescription;

			private DataColumn columnResChildCount;

			private EKBCategoryDataset.SELECTALLRowChangeEventHandler SELECTALLRowChangingEvent;

			private EKBCategoryDataset.SELECTALLRowChangeEventHandler SELECTALLRowChangedEvent;

			private EKBCategoryDataset.SELECTALLRowChangeEventHandler SELECTALLRowDeletingEvent;

			private EKBCategoryDataset.SELECTALLRowChangeEventHandler SELECTALLRowDeletedEvent;

			public event EKBCategoryDataset.SELECTALLRowChangeEventHandler SELECTALLRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLRowChangingEvent = (EKBCategoryDataset.SELECTALLRowChangeEventHandler)Delegate.Combine(this.SELECTALLRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLRowChangingEvent = (EKBCategoryDataset.SELECTALLRowChangeEventHandler)Delegate.Remove(this.SELECTALLRowChangingEvent, value);
				}
			}

			public event EKBCategoryDataset.SELECTALLRowChangeEventHandler SELECTALLRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLRowChangedEvent = (EKBCategoryDataset.SELECTALLRowChangeEventHandler)Delegate.Combine(this.SELECTALLRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLRowChangedEvent = (EKBCategoryDataset.SELECTALLRowChangeEventHandler)Delegate.Remove(this.SELECTALLRowChangedEvent, value);
				}
			}

			public event EKBCategoryDataset.SELECTALLRowChangeEventHandler SELECTALLRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLRowDeletingEvent = (EKBCategoryDataset.SELECTALLRowChangeEventHandler)Delegate.Combine(this.SELECTALLRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLRowDeletingEvent = (EKBCategoryDataset.SELECTALLRowChangeEventHandler)Delegate.Remove(this.SELECTALLRowDeletingEvent, value);
				}
			}

			public event EKBCategoryDataset.SELECTALLRowChangeEventHandler SELECTALLRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTALLRowDeletedEvent = (EKBCategoryDataset.SELECTALLRowChangeEventHandler)Delegate.Combine(this.SELECTALLRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTALLRowDeletedEvent = (EKBCategoryDataset.SELECTALLRowChangeEventHandler)Delegate.Remove(this.SELECTALLRowDeletedEvent, value);
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
			public DataColumn ParentIDColumn
			{
				get
				{
					return this.columnParentID;
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
			public DataColumn ResChildCountColumn
			{
				get
				{
					return this.columnResChildCount;
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
			public EKBCategoryDataset.SELECTALLRow this[int index]
			{
				get
				{
					return (EKBCategoryDataset.SELECTALLRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SELECTALLDataTable()
			{
				this.TableName = "SELECTALL";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SELECTALLDataTable(DataTable table)
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
			protected SELECTALLDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSELECTALLRow(EKBCategoryDataset.SELECTALLRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EKBCategoryDataset.SELECTALLRow AddSELECTALLRow(long ID, string Name, string ParentID, string Description, long ResChildCount)
			{
				EKBCategoryDataset.SELECTALLRow sELECTALLRow = (EKBCategoryDataset.SELECTALLRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					ParentID,
					Description,
					ResChildCount
				};
				sELECTALLRow.ItemArray = itemArray;
				this.Rows.Add(sELECTALLRow);
				return sELECTALLRow;
			}

			[DebuggerNonUserCode]
			public EKBCategoryDataset.SELECTALLRow FindByID(long ID)
			{
				return (EKBCategoryDataset.SELECTALLRow)this.Rows.Find(new object[]
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
				EKBCategoryDataset.SELECTALLDataTable sELECTALLDataTable = (EKBCategoryDataset.SELECTALLDataTable)base.Clone();
				sELECTALLDataTable.InitVars();
				return sELECTALLDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EKBCategoryDataset.SELECTALLDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnParentID = base.Columns["ParentID"];
				this.columnDescription = base.Columns["Description"];
				this.columnResChildCount = base.Columns["ResChildCount"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnParentID = new DataColumn("ParentID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParentID);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				this.columnResChildCount = new DataColumn("ResChildCount", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnResChildCount);
				this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnID
				}, true));
				this.columnID.AllowDBNull = false;
				this.columnID.Unique = true;
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EKBCategoryDataset.SELECTALLRow NewSELECTALLRow()
			{
				return (EKBCategoryDataset.SELECTALLRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EKBCategoryDataset.SELECTALLRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EKBCategoryDataset.SELECTALLRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SELECTALLRowChangedEvent != null)
				{
					EKBCategoryDataset.SELECTALLRowChangeEventHandler sELECTALLRowChangedEvent = this.SELECTALLRowChangedEvent;
					if (sELECTALLRowChangedEvent != null)
					{
						sELECTALLRowChangedEvent(this, new EKBCategoryDataset.SELECTALLRowChangeEvent((EKBCategoryDataset.SELECTALLRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SELECTALLRowChangingEvent != null)
				{
					EKBCategoryDataset.SELECTALLRowChangeEventHandler sELECTALLRowChangingEvent = this.SELECTALLRowChangingEvent;
					if (sELECTALLRowChangingEvent != null)
					{
						sELECTALLRowChangingEvent(this, new EKBCategoryDataset.SELECTALLRowChangeEvent((EKBCategoryDataset.SELECTALLRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SELECTALLRowDeletedEvent != null)
				{
					EKBCategoryDataset.SELECTALLRowChangeEventHandler sELECTALLRowDeletedEvent = this.SELECTALLRowDeletedEvent;
					if (sELECTALLRowDeletedEvent != null)
					{
						sELECTALLRowDeletedEvent(this, new EKBCategoryDataset.SELECTALLRowChangeEvent((EKBCategoryDataset.SELECTALLRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SELECTALLRowDeletingEvent != null)
				{
					EKBCategoryDataset.SELECTALLRowChangeEventHandler sELECTALLRowDeletingEvent = this.SELECTALLRowDeletingEvent;
					if (sELECTALLRowDeletingEvent != null)
					{
						sELECTALLRowDeletingEvent(this, new EKBCategoryDataset.SELECTALLRowChangeEvent((EKBCategoryDataset.SELECTALLRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSELECTALLRow(EKBCategoryDataset.SELECTALLRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EKBCategoryDataset eKBCategoryDataset = new EKBCategoryDataset();
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
				xmlSchemaAttribute.FixedValue = eKBCategoryDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SELECTALLDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eKBCategoryDataset.GetSchemaSerializable();
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
			private EKBCategoryDataset.SELECTALLDataTable tableSELECTALL;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					return Conversions.ToLong(this[this.tableSELECTALL.IDColumn]);
				}
				set
				{
					this[this.tableSELECTALL.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTALL.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ParentID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTALL.ParentIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"ParentID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.ParentIDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTALL.DescriptionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"Description\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.DescriptionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public long ResChildCount
			{
				get
				{
					long result;
					try
					{
						result = Conversions.ToLong(this[this.tableSELECTALL.ResChildCountColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTALL\"中列\"ResChildCount\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTALL.ResChildCountColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SELECTALLRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSELECTALL = (EKBCategoryDataset.SELECTALLDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableSELECTALL.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableSELECTALL.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsParentIDNull()
			{
				return this.IsNull(this.tableSELECTALL.ParentIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetParentIDNull()
			{
				this[this.tableSELECTALL.ParentIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return this.IsNull(this.tableSELECTALL.DescriptionColumn);
			}

			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				this[this.tableSELECTALL.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsResChildCountNull()
			{
				return this.IsNull(this.tableSELECTALL.ResChildCountColumn);
			}

			[DebuggerNonUserCode]
			public void SetResChildCountNull()
			{
				this[this.tableSELECTALL.ResChildCountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SELECTALLRowChangeEvent : EventArgs
		{
			private EKBCategoryDataset.SELECTALLRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EKBCategoryDataset.SELECTALLRow Row
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
			public SELECTALLRowChangeEvent(EKBCategoryDataset.SELECTALLRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EKBCategoryDataset.SELECTALLDataTable tableSELECTALL;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EKBCategoryDataset.SELECTALLDataTable SELECTALL
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
		public EKBCategoryDataset()
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
		protected EKBCategoryDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SELECTALL"] != null)
				{
					base.Tables.Add(new EKBCategoryDataset.SELECTALLDataTable(dataSet.Tables["SELECTALL"]));
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
			EKBCategoryDataset eKBCategoryDataset = (EKBCategoryDataset)base.Clone();
			eKBCategoryDataset.InitVars();
			eKBCategoryDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eKBCategoryDataset;
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
				if (dataSet.Tables["SELECTALL"] != null)
				{
					base.Tables.Add(new EKBCategoryDataset.SELECTALLDataTable(dataSet.Tables["SELECTALL"]));
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
			this.tableSELECTALL = (EKBCategoryDataset.SELECTALLDataTable)base.Tables["SELECTALL"];
			if (initTable && this.tableSELECTALL != null)
			{
				this.tableSELECTALL.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EKBCategoryDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EKBCategoryDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSELECTALL = new EKBCategoryDataset.SELECTALLDataTable();
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
			EKBCategoryDataset eKBCategoryDataset = new EKBCategoryDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eKBCategoryDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eKBCategoryDataset.GetSchemaSerializable();
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
