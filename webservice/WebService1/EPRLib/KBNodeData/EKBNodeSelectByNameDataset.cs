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

namespace KBNodeData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EKBNodeSelectByNameDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EKBNodeSelectByNameDataset : DataSet
	{
		public delegate void SELECTBYNAMERowChangeEventHandler(object sender, EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SELECTBYNAMEDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnName;

			private DataColumn columnKBTreeID;

			private EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler SELECTBYNAMERowChangingEvent;

			private EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler SELECTBYNAMERowChangedEvent;

			private EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler SELECTBYNAMERowDeletingEvent;

			private EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler SELECTBYNAMERowDeletedEvent;

			public event EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler SELECTBYNAMERowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTBYNAMERowChangingEvent = (EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler)Delegate.Combine(this.SELECTBYNAMERowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTBYNAMERowChangingEvent = (EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler)Delegate.Remove(this.SELECTBYNAMERowChangingEvent, value);
				}
			}

			public event EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler SELECTBYNAMERowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTBYNAMERowChangedEvent = (EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler)Delegate.Combine(this.SELECTBYNAMERowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTBYNAMERowChangedEvent = (EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler)Delegate.Remove(this.SELECTBYNAMERowChangedEvent, value);
				}
			}

			public event EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler SELECTBYNAMERowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTBYNAMERowDeletingEvent = (EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler)Delegate.Combine(this.SELECTBYNAMERowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTBYNAMERowDeletingEvent = (EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler)Delegate.Remove(this.SELECTBYNAMERowDeletingEvent, value);
				}
			}

			public event EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler SELECTBYNAMERowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTBYNAMERowDeletedEvent = (EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler)Delegate.Combine(this.SELECTBYNAMERowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTBYNAMERowDeletedEvent = (EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler)Delegate.Remove(this.SELECTBYNAMERowDeletedEvent, value);
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
			public DataColumn KBTreeIDColumn
			{
				get
				{
					return this.columnKBTreeID;
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
			public EKBNodeSelectByNameDataset.SELECTBYNAMERow this[int index]
			{
				get
				{
					return (EKBNodeSelectByNameDataset.SELECTBYNAMERow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SELECTBYNAMEDataTable()
			{
				this.TableName = "SELECTBYNAME";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SELECTBYNAMEDataTable(DataTable table)
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
			protected SELECTBYNAMEDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSELECTBYNAMERow(EKBNodeSelectByNameDataset.SELECTBYNAMERow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EKBNodeSelectByNameDataset.SELECTBYNAMERow AddSELECTBYNAMERow(long ID, string Name, string KBTreeID)
			{
				EKBNodeSelectByNameDataset.SELECTBYNAMERow sELECTBYNAMERow = (EKBNodeSelectByNameDataset.SELECTBYNAMERow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					Name,
					KBTreeID
				};
				sELECTBYNAMERow.ItemArray = itemArray;
				this.Rows.Add(sELECTBYNAMERow);
				return sELECTBYNAMERow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EKBNodeSelectByNameDataset.SELECTBYNAMEDataTable sELECTBYNAMEDataTable = (EKBNodeSelectByNameDataset.SELECTBYNAMEDataTable)base.Clone();
				sELECTBYNAMEDataTable.InitVars();
				return sELECTBYNAMEDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EKBNodeSelectByNameDataset.SELECTBYNAMEDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnKBTreeID = base.Columns["KBTreeID"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnKBTreeID = new DataColumn("KBTreeID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKBTreeID);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EKBNodeSelectByNameDataset.SELECTBYNAMERow NewSELECTBYNAMERow()
			{
				return (EKBNodeSelectByNameDataset.SELECTBYNAMERow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EKBNodeSelectByNameDataset.SELECTBYNAMERow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EKBNodeSelectByNameDataset.SELECTBYNAMERow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SELECTBYNAMERowChangedEvent != null)
				{
					EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler sELECTBYNAMERowChangedEvent = this.SELECTBYNAMERowChangedEvent;
					if (sELECTBYNAMERowChangedEvent != null)
					{
						sELECTBYNAMERowChangedEvent(this, new EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEvent((EKBNodeSelectByNameDataset.SELECTBYNAMERow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SELECTBYNAMERowChangingEvent != null)
				{
					EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler sELECTBYNAMERowChangingEvent = this.SELECTBYNAMERowChangingEvent;
					if (sELECTBYNAMERowChangingEvent != null)
					{
						sELECTBYNAMERowChangingEvent(this, new EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEvent((EKBNodeSelectByNameDataset.SELECTBYNAMERow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SELECTBYNAMERowDeletedEvent != null)
				{
					EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler sELECTBYNAMERowDeletedEvent = this.SELECTBYNAMERowDeletedEvent;
					if (sELECTBYNAMERowDeletedEvent != null)
					{
						sELECTBYNAMERowDeletedEvent(this, new EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEvent((EKBNodeSelectByNameDataset.SELECTBYNAMERow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SELECTBYNAMERowDeletingEvent != null)
				{
					EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEventHandler sELECTBYNAMERowDeletingEvent = this.SELECTBYNAMERowDeletingEvent;
					if (sELECTBYNAMERowDeletingEvent != null)
					{
						sELECTBYNAMERowDeletingEvent(this, new EKBNodeSelectByNameDataset.SELECTBYNAMERowChangeEvent((EKBNodeSelectByNameDataset.SELECTBYNAMERow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSELECTBYNAMERow(EKBNodeSelectByNameDataset.SELECTBYNAMERow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EKBNodeSelectByNameDataset eKBNodeSelectByNameDataset = new EKBNodeSelectByNameDataset();
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
				xmlSchemaAttribute.FixedValue = eKBNodeSelectByNameDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SELECTBYNAMEDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eKBNodeSelectByNameDataset.GetSchemaSerializable();
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
		public class SELECTBYNAMERow : DataRow
		{
			private EKBNodeSelectByNameDataset.SELECTBYNAMEDataTable tableSELECTBYNAME;

			[DebuggerNonUserCode]
			public long ID
			{
				get
				{
					long result;
					try
					{
						result = Conversions.ToLong(this[this.tableSELECTBYNAME.IDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYNAME\"中列\"ID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYNAME.IDColumn] = value;
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
						result = Conversions.ToString(this[this.tableSELECTBYNAME.NameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYNAME\"中列\"Name\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYNAME.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string KBTreeID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTBYNAME.KBTreeIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTBYNAME\"中列\"KBTreeID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTBYNAME.KBTreeIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SELECTBYNAMERow(DataRowBuilder rb) : base(rb)
			{
				this.tableSELECTBYNAME = (EKBNodeSelectByNameDataset.SELECTBYNAMEDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsIDNull()
			{
				return this.IsNull(this.tableSELECTBYNAME.IDColumn);
			}

			[DebuggerNonUserCode]
			public void SetIDNull()
			{
				this[this.tableSELECTBYNAME.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return this.IsNull(this.tableSELECTBYNAME.NameColumn);
			}

			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				this[this.tableSELECTBYNAME.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsKBTreeIDNull()
			{
				return this.IsNull(this.tableSELECTBYNAME.KBTreeIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetKBTreeIDNull()
			{
				this[this.tableSELECTBYNAME.KBTreeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SELECTBYNAMERowChangeEvent : EventArgs
		{
			private EKBNodeSelectByNameDataset.SELECTBYNAMERow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EKBNodeSelectByNameDataset.SELECTBYNAMERow Row
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
			public SELECTBYNAMERowChangeEvent(EKBNodeSelectByNameDataset.SELECTBYNAMERow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EKBNodeSelectByNameDataset.SELECTBYNAMEDataTable tableSELECTBYNAME;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EKBNodeSelectByNameDataset.SELECTBYNAMEDataTable SELECTBYNAME
		{
			get
			{
				return this.tableSELECTBYNAME;
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
		public EKBNodeSelectByNameDataset()
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
		protected EKBNodeSelectByNameDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SELECTBYNAME"] != null)
				{
					base.Tables.Add(new EKBNodeSelectByNameDataset.SELECTBYNAMEDataTable(dataSet.Tables["SELECTBYNAME"]));
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
			EKBNodeSelectByNameDataset eKBNodeSelectByNameDataset = (EKBNodeSelectByNameDataset)base.Clone();
			eKBNodeSelectByNameDataset.InitVars();
			eKBNodeSelectByNameDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eKBNodeSelectByNameDataset;
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
				if (dataSet.Tables["SELECTBYNAME"] != null)
				{
					base.Tables.Add(new EKBNodeSelectByNameDataset.SELECTBYNAMEDataTable(dataSet.Tables["SELECTBYNAME"]));
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
			this.tableSELECTBYNAME = (EKBNodeSelectByNameDataset.SELECTBYNAMEDataTable)base.Tables["SELECTBYNAME"];
			if (initTable && this.tableSELECTBYNAME != null)
			{
				this.tableSELECTBYNAME.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EKBNodeSelectByNameDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EKBNodeSelectByNameDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSELECTBYNAME = new EKBNodeSelectByNameDataset.SELECTBYNAMEDataTable();
			base.Tables.Add(this.tableSELECTBYNAME);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSELECTBYNAME()
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
			EKBNodeSelectByNameDataset eKBNodeSelectByNameDataset = new EKBNodeSelectByNameDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eKBNodeSelectByNameDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eKBNodeSelectByNameDataset.GetSchemaSerializable();
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
