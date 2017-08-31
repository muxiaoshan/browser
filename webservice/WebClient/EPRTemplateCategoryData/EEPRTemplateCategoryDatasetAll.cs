// Decompiled with JetBrains decompiler
// Type: EPRTemplateCategoryData.EEPRTemplateCategoryDatasetAll
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

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
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace EPRTemplateCategoryData
{
  [XmlRoot("EEPRTemplateCategoryDatasetAll")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [HelpKeyword("vs.data.DataSet")]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [ToolboxItem(true)]
  [DesignerCategory("code")]
  [Serializable]
  public class EEPRTemplateCategoryDatasetAll : DataSet
  {
    private EEPRTemplateCategoryDatasetAll.SelectAllDataTable tableSelectAll;
    private SchemaSerializationMode _schemaSerializationMode;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public EEPRTemplateCategoryDatasetAll.SelectAllDataTable SelectAll
    {
      get
      {
        return this.tableSelectAll;
      }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DebuggerNonUserCode]
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

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DebuggerNonUserCode]
    public new DataTableCollection Tables
    {
      get
      {
        return base.Tables;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DebuggerNonUserCode]
    public new DataRelationCollection Relations
    {
      get
      {
        return base.Relations;
      }
    }

    [DebuggerNonUserCode]
    public EEPRTemplateCategoryDatasetAll()
    {
      this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    protected EEPRTemplateCategoryDatasetAll(SerializationInfo info, StreamingContext context)
      : base(info, context, false)
    {
      this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      if (this.IsBinarySerialized(info, context))
      {
        this.InitVars(false);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        this.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
      else
      {
        string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
        if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
        {
          DataSet dataSet = new DataSet();
          dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
          if (dataSet.Tables["SelectAll"] != null)
            base.Tables.Add((DataTable) new EEPRTemplateCategoryDatasetAll.SelectAllDataTable(dataSet.Tables["SelectAll"]));
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
          this.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        this.GetSerializationData(info, context);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        base.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
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
      EEPRTemplateCategoryDatasetAll categoryDatasetAll = (EEPRTemplateCategoryDatasetAll) base.Clone();
      categoryDatasetAll.InitVars();
      categoryDatasetAll.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) categoryDatasetAll;
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
        int num = (int) dataSet.ReadXml(reader);
        if (dataSet.Tables["SelectAll"] != null)
          base.Tables.Add((DataTable) new EEPRTemplateCategoryDatasetAll.SelectAllDataTable(dataSet.Tables["SelectAll"]));
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
        int num = (int) this.ReadXml(reader);
        this.InitVars();
      }
    }

    [DebuggerNonUserCode]
    protected override XmlSchema GetSchemaSerializable()
    {
      MemoryStream memoryStream = new MemoryStream();
      this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
      memoryStream.Position = 0L;
      return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
    }

    [DebuggerNonUserCode]
    internal void InitVars()
    {
      this.InitVars(true);
    }

    [DebuggerNonUserCode]
    internal void InitVars(bool initTable)
    {
      this.tableSelectAll = (EEPRTemplateCategoryDatasetAll.SelectAllDataTable) base.Tables["SelectAll"];
      if (!initTable || this.tableSelectAll == null)
        return;
      this.tableSelectAll.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = "EEPRTemplateCategoryDatasetAll";
      this.Prefix = "";
      this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EEPRTemplateCategoryDataset";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableSelectAll = new EEPRTemplateCategoryDatasetAll.SelectAllDataTable();
      base.Tables.Add((DataTable) this.tableSelectAll);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeSelectAll()
    {
      return false;
    }

    [DebuggerNonUserCode]
    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
    {
      if (e.Action != CollectionChangeAction.Remove)
        return;
      this.InitVars();
    }

    [DebuggerNonUserCode]
    public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
    {
      EEPRTemplateCategoryDatasetAll categoryDatasetAll = new EEPRTemplateCategoryDatasetAll();
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
      {
        Items = {
          (XmlSchemaObject) new XmlSchemaAny()
          {
            Namespace = categoryDatasetAll.Namespace
          }
        }
      };
      XmlSchema schemaSerializable = categoryDatasetAll.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
          {
            memoryStream2.SetLength(0L);
            schema.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return schemaComplexType;
            }
          }
        }
        finally
        {
          if (memoryStream1 != null)
            memoryStream1.Close();
          if (memoryStream2 != null)
            memoryStream2.Close();
        }
      }
      xs.Add(schemaSerializable);
      return schemaComplexType;
    }

    public delegate void SelectAllRowChangeEventHandler(object sender, EEPRTemplateCategoryDatasetAll.SelectAllRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class SelectAllDataTable : DataTable, IEnumerable
    {
      private DataColumn columnID;
      private DataColumn columnCategoryName;
      private DataColumn columnCategoryType;
      private DataColumn columnParentCategoryID;
      private DataColumn columnCategorySeq;
      private DataColumn columnBindPrnTemplateID;
      private DataColumn columnBindPrnTemplateCategoryID;

      [DebuggerNonUserCode]
      public DataColumn IDColumn
      {
        get
        {
          return this.columnID;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn CategoryNameColumn
      {
        get
        {
          return this.columnCategoryName;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn CategoryTypeColumn
      {
        get
        {
          return this.columnCategoryType;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn ParentCategoryIDColumn
      {
        get
        {
          return this.columnParentCategoryID;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn CategorySeqColumn
      {
        get
        {
          return this.columnCategorySeq;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn BindPrnTemplateIDColumn
      {
        get
        {
          return this.columnBindPrnTemplateID;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn BindPrnTemplateCategoryIDColumn
      {
        get
        {
          return this.columnBindPrnTemplateCategoryID;
        }
      }

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [DebuggerNonUserCode]
      public EEPRTemplateCategoryDatasetAll.SelectAllRow this[int index]
      {
        get
        {
          return (EEPRTemplateCategoryDatasetAll.SelectAllRow) this.Rows[index];
        }
      }

      public event EEPRTemplateCategoryDatasetAll.SelectAllRowChangeEventHandler SelectAllRowChanging;

      public event EEPRTemplateCategoryDatasetAll.SelectAllRowChangeEventHandler SelectAllRowChanged;

      public event EEPRTemplateCategoryDatasetAll.SelectAllRowChangeEventHandler SelectAllRowDeleting;

      public event EEPRTemplateCategoryDatasetAll.SelectAllRowChangeEventHandler SelectAllRowDeleted;

      [DebuggerNonUserCode]
      public SelectAllDataTable()
      {
        this.TableName = "SelectAll";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal SelectAllDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
          this.Locale = table.Locale;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected SelectAllDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public void AddSelectAllRow(EEPRTemplateCategoryDatasetAll.SelectAllRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public EEPRTemplateCategoryDatasetAll.SelectAllRow AddSelectAllRow(string ID, string CategoryName, string CategoryType, string ParentCategoryID, long CategorySeq, string BindPrnTemplateID, string BindPrnTemplateCategoryID)
      {
        EEPRTemplateCategoryDatasetAll.SelectAllRow selectAllRow = (EEPRTemplateCategoryDatasetAll.SelectAllRow) this.NewRow();
        object[] objArray = new object[7]
        {
          (object) ID,
          (object) CategoryName,
          (object) CategoryType,
          (object) ParentCategoryID,
          (object) CategorySeq,
          (object) BindPrnTemplateID,
          (object) BindPrnTemplateCategoryID
        };
        selectAllRow.ItemArray = objArray;
        this.Rows.Add((DataRow) selectAllRow);
        return selectAllRow;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator()
      {
        return this.Rows.GetEnumerator();
      }

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        EEPRTemplateCategoryDatasetAll.SelectAllDataTable selectAllDataTable = (EEPRTemplateCategoryDatasetAll.SelectAllDataTable) base.Clone();
        selectAllDataTable.InitVars();
        return (DataTable) selectAllDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new EEPRTemplateCategoryDatasetAll.SelectAllDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnCategoryName = this.Columns["CategoryName"];
        this.columnCategoryType = this.Columns["CategoryType"];
        this.columnParentCategoryID = this.Columns["ParentCategoryID"];
        this.columnCategorySeq = this.Columns["CategorySeq"];
        this.columnBindPrnTemplateID = this.Columns["BindPrnTemplateID"];
        this.columnBindPrnTemplateCategoryID = this.Columns["BindPrnTemplateCategoryID"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnCategoryName = new DataColumn("CategoryName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCategoryName);
        this.columnCategoryType = new DataColumn("CategoryType", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCategoryType);
        this.columnParentCategoryID = new DataColumn("ParentCategoryID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnParentCategoryID);
        this.columnCategorySeq = new DataColumn("CategorySeq", typeof (long), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCategorySeq);
        this.columnBindPrnTemplateID = new DataColumn("BindPrnTemplateID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBindPrnTemplateID);
        this.columnBindPrnTemplateCategoryID = new DataColumn("BindPrnTemplateCategoryID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBindPrnTemplateCategoryID);
        this.Namespace = "";
      }

      [DebuggerNonUserCode]
      public EEPRTemplateCategoryDatasetAll.SelectAllRow NewSelectAllRow()
      {
        return (EEPRTemplateCategoryDatasetAll.SelectAllRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new EEPRTemplateCategoryDatasetAll.SelectAllRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType()
      {
        return typeof (EEPRTemplateCategoryDatasetAll.SelectAllRow);
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.SelectAllRowChangedEvent == null)
          return;
        EEPRTemplateCategoryDatasetAll.SelectAllRowChangeEventHandler allRowChangedEvent = this.SelectAllRowChangedEvent;
        if (allRowChangedEvent == null)
          return;
        allRowChangedEvent((object) this, new EEPRTemplateCategoryDatasetAll.SelectAllRowChangeEvent((EEPRTemplateCategoryDatasetAll.SelectAllRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.SelectAllRowChangingEvent == null)
          return;
        EEPRTemplateCategoryDatasetAll.SelectAllRowChangeEventHandler rowChangingEvent = this.SelectAllRowChangingEvent;
        if (rowChangingEvent == null)
          return;
        rowChangingEvent((object) this, new EEPRTemplateCategoryDatasetAll.SelectAllRowChangeEvent((EEPRTemplateCategoryDatasetAll.SelectAllRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.SelectAllRowDeletedEvent == null)
          return;
        EEPRTemplateCategoryDatasetAll.SelectAllRowChangeEventHandler allRowDeletedEvent = this.SelectAllRowDeletedEvent;
        if (allRowDeletedEvent == null)
          return;
        allRowDeletedEvent((object) this, new EEPRTemplateCategoryDatasetAll.SelectAllRowChangeEvent((EEPRTemplateCategoryDatasetAll.SelectAllRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.SelectAllRowDeletingEvent == null)
          return;
        EEPRTemplateCategoryDatasetAll.SelectAllRowChangeEventHandler rowDeletingEvent = this.SelectAllRowDeletingEvent;
        if (rowDeletingEvent == null)
          return;
        rowDeletingEvent((object) this, new EEPRTemplateCategoryDatasetAll.SelectAllRowChangeEvent((EEPRTemplateCategoryDatasetAll.SelectAllRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveSelectAllRow(EEPRTemplateCategoryDatasetAll.SelectAllRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        EEPRTemplateCategoryDatasetAll categoryDatasetAll = new EEPRTemplateCategoryDatasetAll();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
        Decimal num1 = new Decimal(0);
        Decimal num2 = num1;
        xmlSchemaAny2.MinOccurs = num2;
        xmlSchemaAny1.MaxOccurs = new Decimal(-1, -1, -1, false, (byte) 0);
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
        xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
        num1 = new Decimal(1);
        Decimal num3 = num1;
        xmlSchemaAny4.MinOccurs = num3;
        xmlSchemaAny3.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny3);
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = categoryDatasetAll.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "SelectAllDataTable"
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = categoryDatasetAll.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
            {
              memoryStream2.SetLength(0L);
              schema.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
          }
          finally
          {
            if (memoryStream1 != null)
              memoryStream1.Close();
            if (memoryStream2 != null)
              memoryStream2.Close();
          }
        }
        xs.Add(schemaSerializable);
        return schemaComplexType;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SelectAllRow : DataRow
    {
      private EEPRTemplateCategoryDatasetAll.SelectAllDataTable tableSelectAll;

      [DebuggerNonUserCode]
      public string ID
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectAll.IDColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectAll\"中列\"ID\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectAll.IDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string CategoryName
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectAll.CategoryNameColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectAll\"中列\"CategoryName\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectAll.CategoryNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string CategoryType
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectAll.CategoryTypeColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectAll\"中列\"CategoryType\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectAll.CategoryTypeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string ParentCategoryID
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectAll.ParentCategoryIDColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectAll\"中列\"ParentCategoryID\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectAll.ParentCategoryIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public long CategorySeq
      {
        get
        {
          try
          {
            return Conversions.ToLong(this[this.tableSelectAll.CategorySeqColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectAll\"中列\"CategorySeq\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectAll.CategorySeqColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string BindPrnTemplateID
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectAll.BindPrnTemplateIDColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectAll\"中列\"BindPrnTemplateID\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectAll.BindPrnTemplateIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string BindPrnTemplateCategoryID
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectAll.BindPrnTemplateCategoryIDColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectAll\"中列\"BindPrnTemplateCategoryID\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectAll.BindPrnTemplateCategoryIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      internal SelectAllRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSelectAll = (EEPRTemplateCategoryDatasetAll.SelectAllDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public bool IsIDNull()
      {
        return this.IsNull(this.tableSelectAll.IDColumn);
      }

      [DebuggerNonUserCode]
      public void SetIDNull()
      {
        this[this.tableSelectAll.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsCategoryNameNull()
      {
        return this.IsNull(this.tableSelectAll.CategoryNameColumn);
      }

      [DebuggerNonUserCode]
      public void SetCategoryNameNull()
      {
        this[this.tableSelectAll.CategoryNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsCategoryTypeNull()
      {
        return this.IsNull(this.tableSelectAll.CategoryTypeColumn);
      }

      [DebuggerNonUserCode]
      public void SetCategoryTypeNull()
      {
        this[this.tableSelectAll.CategoryTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsParentCategoryIDNull()
      {
        return this.IsNull(this.tableSelectAll.ParentCategoryIDColumn);
      }

      [DebuggerNonUserCode]
      public void SetParentCategoryIDNull()
      {
        this[this.tableSelectAll.ParentCategoryIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsCategorySeqNull()
      {
        return this.IsNull(this.tableSelectAll.CategorySeqColumn);
      }

      [DebuggerNonUserCode]
      public void SetCategorySeqNull()
      {
        this[this.tableSelectAll.CategorySeqColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsBindPrnTemplateIDNull()
      {
        return this.IsNull(this.tableSelectAll.BindPrnTemplateIDColumn);
      }

      [DebuggerNonUserCode]
      public void SetBindPrnTemplateIDNull()
      {
        this[this.tableSelectAll.BindPrnTemplateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsBindPrnTemplateCategoryIDNull()
      {
        return this.IsNull(this.tableSelectAll.BindPrnTemplateCategoryIDColumn);
      }

      [DebuggerNonUserCode]
      public void SetBindPrnTemplateCategoryIDNull()
      {
        this[this.tableSelectAll.BindPrnTemplateCategoryIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SelectAllRowChangeEvent : EventArgs
    {
      private EEPRTemplateCategoryDatasetAll.SelectAllRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public EEPRTemplateCategoryDatasetAll.SelectAllRow Row
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
      public SelectAllRowChangeEvent(EEPRTemplateCategoryDatasetAll.SelectAllRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }
  }
}
