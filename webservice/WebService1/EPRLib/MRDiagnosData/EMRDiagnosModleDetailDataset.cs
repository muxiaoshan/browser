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

namespace MRDiagnosData
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("EMRDiagnosModleDetailDataset"), XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class EMRDiagnosModleDetailDataset : DataSet
	{
		public delegate void FindDiagoseTabDetailRowChangeEventHandler(object sender, EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class FindDiagoseTabDetailDataTable : DataTable, IEnumerable
		{
			private DataColumn columnICDRowId;

			private DataColumn columnICDDesc;

			private DataColumn columnGroupIndex;

			private DataColumn columnGroupItemIndex;

			private EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler FindDiagoseTabDetailRowChangingEvent;

			private EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler FindDiagoseTabDetailRowChangedEvent;

			private EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler FindDiagoseTabDetailRowDeletingEvent;

			private EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler FindDiagoseTabDetailRowDeletedEvent;

			public event EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler FindDiagoseTabDetailRowChanging
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.FindDiagoseTabDetailRowChangingEvent = (EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler)Delegate.Combine(this.FindDiagoseTabDetailRowChangingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.FindDiagoseTabDetailRowChangingEvent = (EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler)Delegate.Remove(this.FindDiagoseTabDetailRowChangingEvent, value);
				}
			}

			public event EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler FindDiagoseTabDetailRowChanged
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.FindDiagoseTabDetailRowChangedEvent = (EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler)Delegate.Combine(this.FindDiagoseTabDetailRowChangedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.FindDiagoseTabDetailRowChangedEvent = (EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler)Delegate.Remove(this.FindDiagoseTabDetailRowChangedEvent, value);
				}
			}

			public event EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler FindDiagoseTabDetailRowDeleting
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.FindDiagoseTabDetailRowDeletingEvent = (EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler)Delegate.Combine(this.FindDiagoseTabDetailRowDeletingEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.FindDiagoseTabDetailRowDeletingEvent = (EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler)Delegate.Remove(this.FindDiagoseTabDetailRowDeletingEvent, value);
				}
			}

			public event EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler FindDiagoseTabDetailRowDeleted
			{
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				add
				{
					this.FindDiagoseTabDetailRowDeletedEvent = (EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler)Delegate.Combine(this.FindDiagoseTabDetailRowDeletedEvent, value);
				}
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.Synchronized)]
				remove
				{
					this.FindDiagoseTabDetailRowDeletedEvent = (EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler)Delegate.Remove(this.FindDiagoseTabDetailRowDeletedEvent, value);
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ICDRowIdColumn
			{
				get
				{
					return this.columnICDRowId;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn ICDDescColumn
			{
				get
				{
					return this.columnICDDesc;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn GroupIndexColumn
			{
				get
				{
					return this.columnGroupIndex;
				}
			}

			[DebuggerNonUserCode]
			public DataColumn GroupItemIndexColumn
			{
				get
				{
					return this.columnGroupItemIndex;
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
			public EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow this[int index]
			{
				get
				{
					return (EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			public FindDiagoseTabDetailDataTable()
			{
				this.TableName = "FindDiagoseTabDetail";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			internal FindDiagoseTabDetailDataTable(DataTable table)
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
			protected FindDiagoseTabDetailDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			public void AddFindDiagoseTabDetailRow(EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			public EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow AddFindDiagoseTabDetailRow(string ICDRowId, string ICDDesc, string GroupIndex, string GroupItemIndex)
			{
				EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow findDiagoseTabDetailRow = (EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow)this.NewRow();
				object[] itemArray = new object[]
				{
					ICDRowId,
					ICDDesc,
					GroupIndex,
					GroupItemIndex
				};
				findDiagoseTabDetailRow.ItemArray = itemArray;
				this.Rows.Add(findDiagoseTabDetailRow);
				return findDiagoseTabDetailRow;
			}

			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return this.Rows.GetEnumerator();
			}

			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				EMRDiagnosModleDetailDataset.FindDiagoseTabDetailDataTable findDiagoseTabDetailDataTable = (EMRDiagnosModleDetailDataset.FindDiagoseTabDetailDataTable)base.Clone();
				findDiagoseTabDetailDataTable.InitVars();
				return findDiagoseTabDetailDataTable;
			}

			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new EMRDiagnosModleDetailDataset.FindDiagoseTabDetailDataTable();
			}

			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnICDRowId = base.Columns["ICDRowId"];
				this.columnICDDesc = base.Columns["ICDDesc"];
				this.columnGroupIndex = base.Columns["GroupIndex"];
				this.columnGroupItemIndex = base.Columns["GroupItemIndex"];
			}

			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnICDRowId = new DataColumn("ICDRowId", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnICDRowId);
				this.columnICDDesc = new DataColumn("ICDDesc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnICDDesc);
				this.columnGroupIndex = new DataColumn("GroupIndex", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGroupIndex);
				this.columnGroupItemIndex = new DataColumn("GroupItemIndex", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGroupItemIndex);
				this.Namespace = "";
			}

			[DebuggerNonUserCode]
			public EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow NewFindDiagoseTabDetailRow()
			{
				return (EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow(builder);
			}

			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow);
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.FindDiagoseTabDetailRowChangedEvent != null)
				{
					EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler findDiagoseTabDetailRowChangedEvent = this.FindDiagoseTabDetailRowChangedEvent;
					if (findDiagoseTabDetailRowChangedEvent != null)
					{
						findDiagoseTabDetailRowChangedEvent(this, new EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEvent((EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.FindDiagoseTabDetailRowChangingEvent != null)
				{
					EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler findDiagoseTabDetailRowChangingEvent = this.FindDiagoseTabDetailRowChangingEvent;
					if (findDiagoseTabDetailRowChangingEvent != null)
					{
						findDiagoseTabDetailRowChangingEvent(this, new EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEvent((EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.FindDiagoseTabDetailRowDeletedEvent != null)
				{
					EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler findDiagoseTabDetailRowDeletedEvent = this.FindDiagoseTabDetailRowDeletedEvent;
					if (findDiagoseTabDetailRowDeletedEvent != null)
					{
						findDiagoseTabDetailRowDeletedEvent(this, new EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEvent((EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.FindDiagoseTabDetailRowDeletingEvent != null)
				{
					EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEventHandler findDiagoseTabDetailRowDeletingEvent = this.FindDiagoseTabDetailRowDeletingEvent;
					if (findDiagoseTabDetailRowDeletingEvent != null)
					{
						findDiagoseTabDetailRowDeletingEvent(this, new EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRowChangeEvent((EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			public void RemoveFindDiagoseTabDetailRow(EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow row)
			{
				this.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				EMRDiagnosModleDetailDataset eMRDiagnosModleDetailDataset = new EMRDiagnosModleDetailDataset();
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
				xmlSchemaAttribute.FixedValue = eMRDiagnosModleDetailDataset.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "FindDiagoseTabDetailDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = eMRDiagnosModleDetailDataset.GetSchemaSerializable();
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
		public class FindDiagoseTabDetailRow : DataRow
		{
			private EMRDiagnosModleDetailDataset.FindDiagoseTabDetailDataTable tableFindDiagoseTabDetail;

			[DebuggerNonUserCode]
			public string ICDRowId
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableFindDiagoseTabDetail.ICDRowIdColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"FindDiagoseTabDetail\"中列\"ICDRowId\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableFindDiagoseTabDetail.ICDRowIdColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string ICDDesc
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableFindDiagoseTabDetail.ICDDescColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"FindDiagoseTabDetail\"中列\"ICDDesc\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableFindDiagoseTabDetail.ICDDescColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string GroupIndex
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableFindDiagoseTabDetail.GroupIndexColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"FindDiagoseTabDetail\"中列\"GroupIndex\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableFindDiagoseTabDetail.GroupIndexColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			public string GroupItemIndex
			{
				get
				{
					string result;
					try
					{
						result = Conversions.ToString(this[this.tableFindDiagoseTabDetail.GroupItemIndexColumn]);
					}
					catch (InvalidCastException expr_19)
					{
						ProjectData.SetProjectError(expr_19);
						InvalidCastException innerException = expr_19;
						throw new StrongTypingException("表\"FindDiagoseTabDetail\"中列\"GroupItemIndex\"的值为 DBNull。", innerException);
					}
					return result;
				}
				set
				{
					this[this.tableFindDiagoseTabDetail.GroupItemIndexColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			internal FindDiagoseTabDetailRow(DataRowBuilder rb) : base(rb)
			{
				this.tableFindDiagoseTabDetail = (EMRDiagnosModleDetailDataset.FindDiagoseTabDetailDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			public bool IsICDRowIdNull()
			{
				return this.IsNull(this.tableFindDiagoseTabDetail.ICDRowIdColumn);
			}

			[DebuggerNonUserCode]
			public void SetICDRowIdNull()
			{
				this[this.tableFindDiagoseTabDetail.ICDRowIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsICDDescNull()
			{
				return this.IsNull(this.tableFindDiagoseTabDetail.ICDDescColumn);
			}

			[DebuggerNonUserCode]
			public void SetICDDescNull()
			{
				this[this.tableFindDiagoseTabDetail.ICDDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsGroupIndexNull()
			{
				return this.IsNull(this.tableFindDiagoseTabDetail.GroupIndexColumn);
			}

			[DebuggerNonUserCode]
			public void SetGroupIndexNull()
			{
				this[this.tableFindDiagoseTabDetail.GroupIndexColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			public bool IsGroupItemIndexNull()
			{
				return this.IsNull(this.tableFindDiagoseTabDetail.GroupItemIndexColumn);
			}

			[DebuggerNonUserCode]
			public void SetGroupItemIndexNull()
			{
				this[this.tableFindDiagoseTabDetail.GroupItemIndexColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class FindDiagoseTabDetailRowChangeEvent : EventArgs
		{
			private EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			public EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow Row
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
			public FindDiagoseTabDetailRowChangeEvent(EMRDiagnosModleDetailDataset.FindDiagoseTabDetailRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		private EMRDiagnosModleDetailDataset.FindDiagoseTabDetailDataTable tableFindDiagoseTabDetail;

		private SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
		public EMRDiagnosModleDetailDataset.FindDiagoseTabDetailDataTable FindDiagoseTabDetail
		{
			get
			{
				return this.tableFindDiagoseTabDetail;
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
		public EMRDiagnosModleDetailDataset()
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
		protected EMRDiagnosModleDetailDataset(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
				if (dataSet.Tables["FindDiagoseTabDetail"] != null)
				{
					base.Tables.Add(new EMRDiagnosModleDetailDataset.FindDiagoseTabDetailDataTable(dataSet.Tables["FindDiagoseTabDetail"]));
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
			EMRDiagnosModleDetailDataset eMRDiagnosModleDetailDataset = (EMRDiagnosModleDetailDataset)base.Clone();
			eMRDiagnosModleDetailDataset.InitVars();
			eMRDiagnosModleDetailDataset.SchemaSerializationMode = this.SchemaSerializationMode;
			return eMRDiagnosModleDetailDataset;
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
				if (dataSet.Tables["FindDiagoseTabDetail"] != null)
				{
					base.Tables.Add(new EMRDiagnosModleDetailDataset.FindDiagoseTabDetailDataTable(dataSet.Tables["FindDiagoseTabDetail"]));
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
			this.tableFindDiagoseTabDetail = (EMRDiagnosModleDetailDataset.FindDiagoseTabDetailDataTable)base.Tables["FindDiagoseTabDetail"];
			if (initTable && this.tableFindDiagoseTabDetail != null)
			{
				this.tableFindDiagoseTabDetail.InitVars();
			}
		}

		[DebuggerNonUserCode]
		private void InitClass()
		{
			this.DataSetName = "EMRDiagnosModleDetailDataset";
			this.Prefix = "";
			this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EMRDiagnosModleDetailDataset";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableFindDiagoseTabDetail = new EMRDiagnosModleDetailDataset.FindDiagoseTabDetailDataTable();
			base.Tables.Add(this.tableFindDiagoseTabDetail);
		}

		[DebuggerNonUserCode]
		private bool ShouldSerializeFindDiagoseTabDetail()
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
			EMRDiagnosModleDetailDataset eMRDiagnosModleDetailDataset = new EMRDiagnosModleDetailDataset();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = eMRDiagnosModleDetailDataset.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = eMRDiagnosModleDetailDataset.GetSchemaSerializable();
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
