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

namespace InstanceDataInfo
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EInsGroupNewDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EInsGroupNewDataSet : DataSet
	{
		public delegate void SELECTGroupListNewRowChangeEventHandler(object sender, EInsGroupNewDataSet.SELECTGroupListNewRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SELECTGroupListNewDataTable : DataTable, IEnumerable
		{
			private DataColumn columnID;

			private DataColumn columnGroupItemName;

			private DataColumn columnGroupItemID;

			private DataColumn columnItemStatus;

			private EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler SELECTGroupListNewRowChangingEvent;

			private EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler SELECTGroupListNewRowChangedEvent;

			private EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler SELECTGroupListNewRowDeletingEvent;

			private EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler SELECTGroupListNewRowDeletedEvent;

			public event EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler SELECTGroupListNewRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTGroupListNewRowChangingEvent = (EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler)Delegate.Combine(this.SELECTGroupListNewRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTGroupListNewRowChangingEvent = (EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler)Delegate.Remove(this.SELECTGroupListNewRowChangingEvent, value);
				}
			}

			public event EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler SELECTGroupListNewRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTGroupListNewRowChangedEvent = (EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler)Delegate.Combine(this.SELECTGroupListNewRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTGroupListNewRowChangedEvent = (EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler)Delegate.Remove(this.SELECTGroupListNewRowChangedEvent, value);
				}
			}

			public event EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler SELECTGroupListNewRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTGroupListNewRowDeletingEvent = (EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler)Delegate.Combine(this.SELECTGroupListNewRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTGroupListNewRowDeletingEvent = (EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler)Delegate.Remove(this.SELECTGroupListNewRowDeletingEvent, value);
				}
			}

			public event EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler SELECTGroupListNewRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SELECTGroupListNewRowDeletedEvent = (EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler)Delegate.Combine(this.SELECTGroupListNewRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SELECTGroupListNewRowDeletedEvent = (EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler)Delegate.Remove(this.SELECTGroupListNewRowDeletedEvent, value);
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
			public DataColumn GroupItemNameColumn
			{
				get
				{
					return this.columnGroupItemName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn GroupItemIDColumn
			{
				get
				{
					return this.columnGroupItemID;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ItemStatusColumn
			{
				get
				{
					return this.columnItemStatus;
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
			public EInsGroupNewDataSet.SELECTGroupListNewRow this[int index]
			{
				get
				{
					return (EInsGroupNewDataSet.SELECTGroupListNewRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SELECTGroupListNewDataTable()
			{
				this.TableName = "SELECTGroupListNew";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SELECTGroupListNewDataTable(DataTable table)
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
			protected SELECTGroupListNewDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSELECTGroupListNewRow(EInsGroupNewDataSet.SELECTGroupListNewRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EInsGroupNewDataSet.SELECTGroupListNewRow AddSELECTGroupListNewRow(string ID, string GroupItemName, string GroupItemID, string ItemStatus)
			{
				EInsGroupNewDataSet.SELECTGroupListNewRow sELECTGroupListNewRow = (EInsGroupNewDataSet.SELECTGroupListNewRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ID,
					GroupItemName,
					GroupItemID,
					ItemStatus
				};
				sELECTGroupListNewRow.ItemArray = itemArray;
				this.Rows.Add(sELECTGroupListNewRow);
				return sELECTGroupListNewRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EInsGroupNewDataSet.SELECTGroupListNewDataTable sELECTGroupListNewDataTable = (EInsGroupNewDataSet.SELECTGroupListNewDataTable)base.Clone();
				sELECTGroupListNewDataTable.InitVars();
				return sELECTGroupListNewDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EInsGroupNewDataSet.SELECTGroupListNewDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnID = base.Columns["ID"];
				this.columnGroupItemName = base.Columns["GroupItemName"];
				this.columnGroupItemID = base.Columns["GroupItemID"];
				this.columnItemStatus = base.Columns["ItemStatus"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnID = new DataColumn("ID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnGroupItemName = new DataColumn("GroupItemName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGroupItemName);
				this.columnGroupItemID = new DataColumn("GroupItemID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGroupItemID);
				this.columnItemStatus = new DataColumn("ItemStatus", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnItemStatus);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EInsGroupNewDataSet.SELECTGroupListNewRow NewSELECTGroupListNewRow()
			{
				return (EInsGroupNewDataSet.SELECTGroupListNewRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EInsGroupNewDataSet.SELECTGroupListNewRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EInsGroupNewDataSet.SELECTGroupListNewRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SELECTGroupListNewRowChangedEvent != null)
				{
					EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler sELECTGroupListNewRowChangedEvent = this.SELECTGroupListNewRowChangedEvent;
					if (sELECTGroupListNewRowChangedEvent != null)
					{
						sELECTGroupListNewRowChangedEvent(this, new EInsGroupNewDataSet.SELECTGroupListNewRowChangeEvent((EInsGroupNewDataSet.SELECTGroupListNewRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SELECTGroupListNewRowChangingEvent != null)
				{
					EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler sELECTGroupListNewRowChangingEvent = this.SELECTGroupListNewRowChangingEvent;
					if (sELECTGroupListNewRowChangingEvent != null)
					{
						sELECTGroupListNewRowChangingEvent(this, new EInsGroupNewDataSet.SELECTGroupListNewRowChangeEvent((EInsGroupNewDataSet.SELECTGroupListNewRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SELECTGroupListNewRowDeletedEvent != null)
				{
					EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler sELECTGroupListNewRowDeletedEvent = this.SELECTGroupListNewRowDeletedEvent;
					if (sELECTGroupListNewRowDeletedEvent != null)
					{
						sELECTGroupListNewRowDeletedEvent(this, new EInsGroupNewDataSet.SELECTGroupListNewRowChangeEvent((EInsGroupNewDataSet.SELECTGroupListNewRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SELECTGroupListNewRowDeletingEvent != null)
				{
					EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler sELECTGroupListNewRowDeletingEvent = this.SELECTGroupListNewRowDeletingEvent;
					if (sELECTGroupListNewRowDeletingEvent != null)
					{
						sELECTGroupListNewRowDeletingEvent(this, new EInsGroupNewDataSet.SELECTGroupListNewRowChangeEvent((EInsGroupNewDataSet.SELECTGroupListNewRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSELECTGroupListNewRow(EInsGroupNewDataSet.SELECTGroupListNewRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EInsGroupNewDataSet eInsGroupNewDataSet = new EInsGroupNewDataSet();
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
				xmlSchemaAttribute.FixedValue = eInsGroupNewDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SELECTGroupListNewDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eInsGroupNewDataSet.GetSchemaSerializable();
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
		public class SELECTGroupListNewRow : DataRow
		{
			private EInsGroupNewDataSet.SELECTGroupListNewDataTable tableSELECTGroupListNew;

			[DebuggerNonUserCode]
			public string ID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTGroupListNew.IDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTGroupListNew\"中列\"ID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTGroupListNew.IDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string GroupItemName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTGroupListNew.GroupItemNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTGroupListNew\"中列\"GroupItemName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTGroupListNew.GroupItemNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string GroupItemID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTGroupListNew.GroupItemIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTGroupListNew\"中列\"GroupItemID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTGroupListNew.GroupItemIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ItemStatus
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSELECTGroupListNew.ItemStatusColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SELECTGroupListNew\"中列\"ItemStatus\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSELECTGroupListNew.ItemStatusColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SELECTGroupListNewRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSELECTGroupListNew = (EInsGroupNewDataSet.SELECTGroupListNewDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsIDNull()
			{
				return this.IsNull(this.tableSELECTGroupListNew.IDColumn);
			}

			[DebuggerNonUserCode]
			public void SetIDNull()
			{
				this[this.tableSELECTGroupListNew.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsGroupItemNameNull()
			{
				return this.IsNull(this.tableSELECTGroupListNew.GroupItemNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetGroupItemNameNull()
			{
				this[this.tableSELECTGroupListNew.GroupItemNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsGroupItemIDNull()
			{
				return this.IsNull(this.tableSELECTGroupListNew.GroupItemIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetGroupItemIDNull()
			{
				this[this.tableSELECTGroupListNew.GroupItemIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsItemStatusNull()
			{
				return this.IsNull(this.tableSELECTGroupListNew.ItemStatusColumn);
			}

			[DebuggerNonUserCode]
			public void SetItemStatusNull()
			{
				this[this.tableSELECTGroupListNew.ItemStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SELECTGroupListNewRowChangeEvent : EventArgs
		{
			private EInsGroupNewDataSet.SELECTGroupListNewRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EInsGroupNewDataSet.SELECTGroupListNewRow Row
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
			public SELECTGroupListNewRowChangeEvent(EInsGroupNewDataSet.SELECTGroupListNewRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EInsGroupNewDataSet.SELECTGroupListNewDataTable tableSELECTGroupListNew;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EInsGroupNewDataSet.SELECTGroupListNewDataTable SELECTGroupListNew
		{
			get
			{
				return this.tableSELECTGroupListNew;
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
		public EInsGroupNewDataSet()
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
		protected EInsGroupNewDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SELECTGroupListNew"] != null)
				{
					base.Tables.Add(new EInsGroupNewDataSet.SELECTGroupListNewDataTable(dataSet.Tables["SELECTGroupListNew"]));
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
			EInsGroupNewDataSet eInsGroupNewDataSet = (EInsGroupNewDataSet)base.Clone();
			eInsGroupNewDataSet.InitVars();
			eInsGroupNewDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return eInsGroupNewDataSet;
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
				if (dataSet.Tables["SELECTGroupListNew"] != null)
				{
					base.Tables.Add(new EInsGroupNewDataSet.SELECTGroupListNewDataTable(dataSet.Tables["SELECTGroupListNew"]));
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
			this.tableSELECTGroupListNew = (EInsGroupNewDataSet.SELECTGroupListNewDataTable)base.Tables["SELECTGroupListNew"];
			if (initTable && this.tableSELECTGroupListNew != null)
			{
				this.tableSELECTGroupListNew.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EInsGroupNewDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/SELECTGroupListNew";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSELECTGroupListNew = new EInsGroupNewDataSet.SELECTGroupListNewDataTable();
			base.Tables.Add(this.tableSELECTGroupListNew);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSELECTGroupListNew()
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
			EInsGroupNewDataSet eInsGroupNewDataSet = new EInsGroupNewDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eInsGroupNewDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eInsGroupNewDataSet.GetSchemaSerializable();
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
