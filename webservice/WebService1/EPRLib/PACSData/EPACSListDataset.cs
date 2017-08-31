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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EPACSListDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EPACSListDataset : DataSet
	{
		public delegate void GetPACSListItemsRowChangeEventHandler(object sender, EPACSListDataset.GetPACSListItemsRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GetPACSListItemsDataTable : DataTable, IEnumerable
		{
			private DataColumn columnEpisodeDate;

			private DataColumn columnEpisodeSection;

			private DataColumn columnEpisodeItemName;

			private DataColumn columnOEOrdItemDR;

			private DataColumn columnRptRowID;

			private EPACSListDataset.GetPACSListItemsRowChangeEventHandler GetPACSListItemsRowChangingEvent;

			private EPACSListDataset.GetPACSListItemsRowChangeEventHandler GetPACSListItemsRowChangedEvent;

			private EPACSListDataset.GetPACSListItemsRowChangeEventHandler GetPACSListItemsRowDeletingEvent;

			private EPACSListDataset.GetPACSListItemsRowChangeEventHandler GetPACSListItemsRowDeletedEvent;

			public event EPACSListDataset.GetPACSListItemsRowChangeEventHandler GetPACSListItemsRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetPACSListItemsRowChangingEvent = (EPACSListDataset.GetPACSListItemsRowChangeEventHandler)Delegate.Combine(this.GetPACSListItemsRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetPACSListItemsRowChangingEvent = (EPACSListDataset.GetPACSListItemsRowChangeEventHandler)Delegate.Remove(this.GetPACSListItemsRowChangingEvent, value);
				}
			}

			public event EPACSListDataset.GetPACSListItemsRowChangeEventHandler GetPACSListItemsRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetPACSListItemsRowChangedEvent = (EPACSListDataset.GetPACSListItemsRowChangeEventHandler)Delegate.Combine(this.GetPACSListItemsRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetPACSListItemsRowChangedEvent = (EPACSListDataset.GetPACSListItemsRowChangeEventHandler)Delegate.Remove(this.GetPACSListItemsRowChangedEvent, value);
				}
			}

			public event EPACSListDataset.GetPACSListItemsRowChangeEventHandler GetPACSListItemsRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetPACSListItemsRowDeletingEvent = (EPACSListDataset.GetPACSListItemsRowChangeEventHandler)Delegate.Combine(this.GetPACSListItemsRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetPACSListItemsRowDeletingEvent = (EPACSListDataset.GetPACSListItemsRowChangeEventHandler)Delegate.Remove(this.GetPACSListItemsRowDeletingEvent, value);
				}
			}

			public event EPACSListDataset.GetPACSListItemsRowChangeEventHandler GetPACSListItemsRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.GetPACSListItemsRowDeletedEvent = (EPACSListDataset.GetPACSListItemsRowChangeEventHandler)Delegate.Combine(this.GetPACSListItemsRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.GetPACSListItemsRowDeletedEvent = (EPACSListDataset.GetPACSListItemsRowChangeEventHandler)Delegate.Remove(this.GetPACSListItemsRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn EpisodeDateColumn
			{
				get
				{
					return this.columnEpisodeDate;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn EpisodeSectionColumn
			{
				get
				{
					return this.columnEpisodeSection;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn EpisodeItemNameColumn
			{
				get
				{
					return this.columnEpisodeItemName;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn OEOrdItemDRColumn
			{
				get
				{
					return this.columnOEOrdItemDR;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn RptRowIDColumn
			{
				get
				{
					return this.columnRptRowID;
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
			public EPACSListDataset.GetPACSListItemsRow this[int index]
			{
				get
				{
					return (EPACSListDataset.GetPACSListItemsRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public GetPACSListItemsDataTable()
			{
				this.TableName = "GetPACSListItems";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal GetPACSListItemsDataTable(DataTable table)
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
			protected GetPACSListItemsDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddGetPACSListItemsRow(EPACSListDataset.GetPACSListItemsRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EPACSListDataset.GetPACSListItemsRow AddGetPACSListItemsRow(string EpisodeDate, string EpisodeSection, string EpisodeItemName, string OEOrdItemDR, string RptRowID)
			{
				EPACSListDataset.GetPACSListItemsRow getPACSListItemsRow = (EPACSListDataset.GetPACSListItemsRow)this.NewRow();
				object[] itemArray = new object[]
				{
					EpisodeDate,
					EpisodeSection,
					EpisodeItemName,
					OEOrdItemDR,
					RptRowID
				};
				getPACSListItemsRow.ItemArray = itemArray;
				this.Rows.Add(getPACSListItemsRow);
				return getPACSListItemsRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EPACSListDataset.GetPACSListItemsDataTable getPACSListItemsDataTable = (EPACSListDataset.GetPACSListItemsDataTable)base.Clone();
				getPACSListItemsDataTable.InitVars();
				return getPACSListItemsDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EPACSListDataset.GetPACSListItemsDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnEpisodeDate = base.Columns["EpisodeDate"];
				this.columnEpisodeSection = base.Columns["EpisodeSection"];
				this.columnEpisodeItemName = base.Columns["EpisodeItemName"];
				this.columnOEOrdItemDR = base.Columns["OEOrdItemDR"];
				this.columnRptRowID = base.Columns["RptRowID"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnEpisodeDate = new DataColumn("EpisodeDate", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnEpisodeDate);
				this.columnEpisodeSection = new DataColumn("EpisodeSection", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnEpisodeSection);
				this.columnEpisodeItemName = new DataColumn("EpisodeItemName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnEpisodeItemName);
				this.columnOEOrdItemDR = new DataColumn("OEOrdItemDR", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOEOrdItemDR);
				this.columnRptRowID = new DataColumn("RptRowID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRptRowID);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EPACSListDataset.GetPACSListItemsRow NewGetPACSListItemsRow()
			{
				return (EPACSListDataset.GetPACSListItemsRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EPACSListDataset.GetPACSListItemsRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EPACSListDataset.GetPACSListItemsRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.GetPACSListItemsRowChangedEvent != null)
				{
					EPACSListDataset.GetPACSListItemsRowChangeEventHandler getPACSListItemsRowChangedEvent = this.GetPACSListItemsRowChangedEvent;
					if (getPACSListItemsRowChangedEvent != null)
					{
						getPACSListItemsRowChangedEvent(this, new EPACSListDataset.GetPACSListItemsRowChangeEvent((EPACSListDataset.GetPACSListItemsRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.GetPACSListItemsRowChangingEvent != null)
				{
					EPACSListDataset.GetPACSListItemsRowChangeEventHandler getPACSListItemsRowChangingEvent = this.GetPACSListItemsRowChangingEvent;
					if (getPACSListItemsRowChangingEvent != null)
					{
						getPACSListItemsRowChangingEvent(this, new EPACSListDataset.GetPACSListItemsRowChangeEvent((EPACSListDataset.GetPACSListItemsRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.GetPACSListItemsRowDeletedEvent != null)
				{
					EPACSListDataset.GetPACSListItemsRowChangeEventHandler getPACSListItemsRowDeletedEvent = this.GetPACSListItemsRowDeletedEvent;
					if (getPACSListItemsRowDeletedEvent != null)
					{
						getPACSListItemsRowDeletedEvent(this, new EPACSListDataset.GetPACSListItemsRowChangeEvent((EPACSListDataset.GetPACSListItemsRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.GetPACSListItemsRowDeletingEvent != null)
				{
					EPACSListDataset.GetPACSListItemsRowChangeEventHandler getPACSListItemsRowDeletingEvent = this.GetPACSListItemsRowDeletingEvent;
					if (getPACSListItemsRowDeletingEvent != null)
					{
						getPACSListItemsRowDeletingEvent(this, new EPACSListDataset.GetPACSListItemsRowChangeEvent((EPACSListDataset.GetPACSListItemsRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveGetPACSListItemsRow(EPACSListDataset.GetPACSListItemsRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EPACSListDataset ePACSListDataset = new EPACSListDataset();
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
				xmlSchemaAttribute.FixedValue = ePACSListDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "GetPACSListItemsDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = ePACSListDataset.GetSchemaSerializable();
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
		public class GetPACSListItemsRow : DataRow
		{
			private EPACSListDataset.GetPACSListItemsDataTable tableGetPACSListItems;

			[DebuggerNonUserCode]
			public string EpisodeDate
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetPACSListItems.EpisodeDateColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetPACSListItems\"中列\"EpisodeDate\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetPACSListItems.EpisodeDateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string EpisodeSection
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetPACSListItems.EpisodeSectionColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetPACSListItems\"中列\"EpisodeSection\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetPACSListItems.EpisodeSectionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string EpisodeItemName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetPACSListItems.EpisodeItemNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetPACSListItems\"中列\"EpisodeItemName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetPACSListItems.EpisodeItemNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string OEOrdItemDR
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetPACSListItems.OEOrdItemDRColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetPACSListItems\"中列\"OEOrdItemDR\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetPACSListItems.OEOrdItemDRColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string RptRowID
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableGetPACSListItems.RptRowIDColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"GetPACSListItems\"中列\"RptRowID\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableGetPACSListItems.RptRowIDColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal GetPACSListItemsRow(DataRowBuilder rb) : base(rb)
			{
				this.tableGetPACSListItems = (EPACSListDataset.GetPACSListItemsDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsEpisodeDateNull()
			{
				return this.IsNull(this.tableGetPACSListItems.EpisodeDateColumn);
			}

			[DebuggerNonUserCode]
			public void SetEpisodeDateNull()
			{
				this[this.tableGetPACSListItems.EpisodeDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsEpisodeSectionNull()
			{
				return this.IsNull(this.tableGetPACSListItems.EpisodeSectionColumn);
			}

			[DebuggerNonUserCode]
			public void SetEpisodeSectionNull()
			{
				this[this.tableGetPACSListItems.EpisodeSectionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsEpisodeItemNameNull()
			{
				return this.IsNull(this.tableGetPACSListItems.EpisodeItemNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetEpisodeItemNameNull()
			{
				this[this.tableGetPACSListItems.EpisodeItemNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsOEOrdItemDRNull()
			{
				return this.IsNull(this.tableGetPACSListItems.OEOrdItemDRColumn);
			}

			[DebuggerNonUserCode]
			public void SetOEOrdItemDRNull()
			{
				this[this.tableGetPACSListItems.OEOrdItemDRColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsRptRowIDNull()
			{
				return this.IsNull(this.tableGetPACSListItems.RptRowIDColumn);
			}

			[DebuggerNonUserCode]
			public void SetRptRowIDNull()
			{
				this[this.tableGetPACSListItems.RptRowIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class GetPACSListItemsRowChangeEvent : EventArgs
		{
			private EPACSListDataset.GetPACSListItemsRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EPACSListDataset.GetPACSListItemsRow Row
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
			public GetPACSListItemsRowChangeEvent(EPACSListDataset.GetPACSListItemsRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EPACSListDataset.GetPACSListItemsDataTable tableGetPACSListItems;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EPACSListDataset.GetPACSListItemsDataTable GetPACSListItems
		{
			get
			{
				return this.tableGetPACSListItems;
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
		public EPACSListDataset()
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
		protected EPACSListDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["GetPACSListItems"] != null)
				{
					base.Tables.Add(new EPACSListDataset.GetPACSListItemsDataTable(dataSet.Tables["GetPACSListItems"]));
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
			EPACSListDataset ePACSListDataset = (EPACSListDataset)base.Clone();
			ePACSListDataset.InitVars();
			ePACSListDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return ePACSListDataset;
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
				if (dataSet.Tables["GetPACSListItems"] != null)
				{
					base.Tables.Add(new EPACSListDataset.GetPACSListItemsDataTable(dataSet.Tables["GetPACSListItems"]));
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
			this.tableGetPACSListItems = (EPACSListDataset.GetPACSListItemsDataTable)base.Tables["GetPACSListItems"];
			if (initTable && this.tableGetPACSListItems != null)
			{
				this.tableGetPACSListItems.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EPACSListDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EPACSListDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableGetPACSListItems = new EPACSListDataset.GetPACSListItemsDataTable();
			base.Tables.Add(this.tableGetPACSListItems);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeGetPACSListItems()
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
			EPACSListDataset ePACSListDataset = new EPACSListDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = ePACSListDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = ePACSListDataset.GetSchemaSerializable();
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
