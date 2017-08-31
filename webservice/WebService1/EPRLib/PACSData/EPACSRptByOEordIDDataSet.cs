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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EPACSRptByOEordIDDataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EPACSRptByOEordIDDataSet : DataSet
	{
		public delegate void SelectReportByOeordIDRowChangeEventHandler(object sender, EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class SelectReportByOeordIDDataTable : DataTable, IEnumerable
		{
			private DataColumn columnExamDesc;

			private DataColumn columnstrResult;

			private DataColumn columnstrOrderName;

			private EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler SelectReportByOeordIDRowChangingEvent;

			private EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler SelectReportByOeordIDRowChangedEvent;

			private EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler SelectReportByOeordIDRowDeletingEvent;

			private EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler SelectReportByOeordIDRowDeletedEvent;

			public event EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler SelectReportByOeordIDRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectReportByOeordIDRowChangingEvent = (EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler)Delegate.Combine(this.SelectReportByOeordIDRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectReportByOeordIDRowChangingEvent = (EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler)Delegate.Remove(this.SelectReportByOeordIDRowChangingEvent, value);
				}
			}

			public event EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler SelectReportByOeordIDRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectReportByOeordIDRowChangedEvent = (EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler)Delegate.Combine(this.SelectReportByOeordIDRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectReportByOeordIDRowChangedEvent = (EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler)Delegate.Remove(this.SelectReportByOeordIDRowChangedEvent, value);
				}
			}

			public event EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler SelectReportByOeordIDRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectReportByOeordIDRowDeletingEvent = (EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler)Delegate.Combine(this.SelectReportByOeordIDRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectReportByOeordIDRowDeletingEvent = (EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler)Delegate.Remove(this.SelectReportByOeordIDRowDeletingEvent, value);
				}
			}

			public event EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler SelectReportByOeordIDRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.SelectReportByOeordIDRowDeletedEvent = (EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler)Delegate.Combine(this.SelectReportByOeordIDRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.SelectReportByOeordIDRowDeletedEvent = (EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler)Delegate.Remove(this.SelectReportByOeordIDRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ExamDescColumn
			{
				get
				{
					return this.columnExamDesc;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn strResultColumn
			{
				get
				{
					return this.columnstrResult;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn strOrderNameColumn
			{
				get
				{
					return this.columnstrOrderName;
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
			public EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow this[int index]
			{
				get
				{
					return (EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public SelectReportByOeordIDDataTable()
			{
				this.TableName = "SelectReportByOeordID";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal SelectReportByOeordIDDataTable(DataTable table)
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
			protected SelectReportByOeordIDDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddSelectReportByOeordIDRow(EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow AddSelectReportByOeordIDRow(string ExamDesc, string strResult, string strOrderName)
			{
				EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow selectReportByOeordIDRow = (EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ExamDesc,
					strResult,
					strOrderName
				};
				selectReportByOeordIDRow.ItemArray = itemArray;
				this.Rows.Add(selectReportByOeordIDRow);
				return selectReportByOeordIDRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EPACSRptByOEordIDDataSet.SelectReportByOeordIDDataTable selectReportByOeordIDDataTable = (EPACSRptByOEordIDDataSet.SelectReportByOeordIDDataTable)base.Clone();
				selectReportByOeordIDDataTable.InitVars();
				return selectReportByOeordIDDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EPACSRptByOEordIDDataSet.SelectReportByOeordIDDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnExamDesc = base.Columns["ExamDesc"];
				this.columnstrResult = base.Columns["strResult"];
				this.columnstrOrderName = base.Columns["strOrderName"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnExamDesc = new DataColumn("ExamDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnExamDesc);
				this.columnstrResult = new DataColumn("strResult", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnstrResult);
				this.columnstrOrderName = new DataColumn("strOrderName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnstrOrderName);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow NewSelectReportByOeordIDRow()
			{
				return (EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.SelectReportByOeordIDRowChangedEvent != null)
				{
					EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler selectReportByOeordIDRowChangedEvent = this.SelectReportByOeordIDRowChangedEvent;
					if (selectReportByOeordIDRowChangedEvent != null)
					{
						selectReportByOeordIDRowChangedEvent(this, new EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEvent((EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.SelectReportByOeordIDRowChangingEvent != null)
				{
					EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler selectReportByOeordIDRowChangingEvent = this.SelectReportByOeordIDRowChangingEvent;
					if (selectReportByOeordIDRowChangingEvent != null)
					{
						selectReportByOeordIDRowChangingEvent(this, new EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEvent((EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.SelectReportByOeordIDRowDeletedEvent != null)
				{
					EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler selectReportByOeordIDRowDeletedEvent = this.SelectReportByOeordIDRowDeletedEvent;
					if (selectReportByOeordIDRowDeletedEvent != null)
					{
						selectReportByOeordIDRowDeletedEvent(this, new EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEvent((EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.SelectReportByOeordIDRowDeletingEvent != null)
				{
					EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEventHandler selectReportByOeordIDRowDeletingEvent = this.SelectReportByOeordIDRowDeletingEvent;
					if (selectReportByOeordIDRowDeletingEvent != null)
					{
						selectReportByOeordIDRowDeletingEvent(this, new EPACSRptByOEordIDDataSet.SelectReportByOeordIDRowChangeEvent((EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveSelectReportByOeordIDRow(EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EPACSRptByOEordIDDataSet ePACSRptByOEordIDDataSet = new EPACSRptByOEordIDDataSet();
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
				xmlSchemaAttribute.FixedValue = ePACSRptByOEordIDDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "SelectReportByOeordIDDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = ePACSRptByOEordIDDataSet.GetSchemaSerializable();
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
		public class SelectReportByOeordIDRow : DataRow
		{
			private EPACSRptByOEordIDDataSet.SelectReportByOeordIDDataTable tableSelectReportByOeordID;

			[DebuggerNonUserCode]
			public string ExamDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectReportByOeordID.ExamDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectReportByOeordID\"中列\"ExamDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectReportByOeordID.ExamDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string strResult
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectReportByOeordID.strResultColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectReportByOeordID\"中列\"strResult\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectReportByOeordID.strResultColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string strOrderName
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableSelectReportByOeordID.strOrderNameColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"SelectReportByOeordID\"中列\"strOrderName\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableSelectReportByOeordID.strOrderNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal SelectReportByOeordIDRow(DataRowBuilder rb) : base(rb)
			{
				this.tableSelectReportByOeordID = (EPACSRptByOEordIDDataSet.SelectReportByOeordIDDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsExamDescNull()
			{
				return this.IsNull(this.tableSelectReportByOeordID.ExamDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetExamDescNull()
			{
				this[this.tableSelectReportByOeordID.ExamDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsstrResultNull()
			{
				return this.IsNull(this.tableSelectReportByOeordID.strResultColumn);
			}

			[DebuggerNonUserCode]
			public void SetstrResultNull()
			{
				this[this.tableSelectReportByOeordID.strResultColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsstrOrderNameNull()
			{
				return this.IsNull(this.tableSelectReportByOeordID.strOrderNameColumn);
			}

			[DebuggerNonUserCode]
			public void SetstrOrderNameNull()
			{
				this[this.tableSelectReportByOeordID.strOrderNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class SelectReportByOeordIDRowChangeEvent : EventArgs
		{
			private EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow Row
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
			public SelectReportByOeordIDRowChangeEvent(EPACSRptByOEordIDDataSet.SelectReportByOeordIDRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EPACSRptByOEordIDDataSet.SelectReportByOeordIDDataTable tableSelectReportByOeordID;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EPACSRptByOEordIDDataSet.SelectReportByOeordIDDataTable SelectReportByOeordID
		{
			get
			{
				return this.tableSelectReportByOeordID;
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
		public EPACSRptByOEordIDDataSet()
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
		protected EPACSRptByOEordIDDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["SelectReportByOeordID"] != null)
				{
					base.Tables.Add(new EPACSRptByOEordIDDataSet.SelectReportByOeordIDDataTable(dataSet.Tables["SelectReportByOeordID"]));
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
			EPACSRptByOEordIDDataSet ePACSRptByOEordIDDataSet = (EPACSRptByOEordIDDataSet)base.Clone();
			ePACSRptByOEordIDDataSet.InitVars();
			ePACSRptByOEordIDDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return ePACSRptByOEordIDDataSet;
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
				if (dataSet.Tables["SelectReportByOeordID"] != null)
				{
					base.Tables.Add(new EPACSRptByOEordIDDataSet.SelectReportByOeordIDDataTable(dataSet.Tables["SelectReportByOeordID"]));
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
			this.tableSelectReportByOeordID = (EPACSRptByOEordIDDataSet.SelectReportByOeordIDDataTable)base.Tables["SelectReportByOeordID"];
			if (initTable && this.tableSelectReportByOeordID != null)
			{
				this.tableSelectReportByOeordID.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EPACSRptByOEordIDDataSet";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EPACSRptByOEordIDDataSet";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableSelectReportByOeordID = new EPACSRptByOEordIDDataSet.SelectReportByOeordIDDataTable();
			base.Tables.Add(this.tableSelectReportByOeordID);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeSelectReportByOeordID()
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
			EPACSRptByOEordIDDataSet ePACSRptByOEordIDDataSet = new EPACSRptByOEordIDDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = ePACSRptByOEordIDDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = ePACSRptByOEordIDDataSet.GetSchemaSerializable();
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
