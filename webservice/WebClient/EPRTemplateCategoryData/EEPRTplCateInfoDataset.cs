// Decompiled with JetBrains decompiler
// Type: EPRTemplateCategoryData.EEPRTplCateInfoDataset
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [HelpKeyword("vs.data.DataSet")]
  [XmlRoot("EEPRTplCateInfoDataset")]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [ToolboxItem(true)]
  [DesignerCategory("code")]
  [Serializable]
  public class EEPRTplCateInfoDataset : DataSet
  {
    private EEPRTplCateInfoDataset.GetCategoryInfoByIDsDataTable tableGetCategoryInfoByIDs;
    private SchemaSerializationMode _schemaSerializationMode;

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    public EEPRTplCateInfoDataset.GetCategoryInfoByIDsDataTable GetCategoryInfoByIDs
    {
      get
      {
        return this.tableGetCategoryInfoByIDs;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Browsable(true)]
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
    public EEPRTplCateInfoDataset()
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
    protected EEPRTplCateInfoDataset(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables["GetCategoryInfoByIDs"] != null)
            base.Tables.Add((DataTable) new EEPRTplCateInfoDataset.GetCategoryInfoByIDsDataTable(dataSet.Tables["GetCategoryInfoByIDs"]));
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
      EEPRTplCateInfoDataset tplCateInfoDataset = (EEPRTplCateInfoDataset) base.Clone();
      tplCateInfoDataset.InitVars();
      tplCateInfoDataset.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) tplCateInfoDataset;
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
        if (dataSet.Tables["GetCategoryInfoByIDs"] != null)
          base.Tables.Add((DataTable) new EEPRTplCateInfoDataset.GetCategoryInfoByIDsDataTable(dataSet.Tables["GetCategoryInfoByIDs"]));
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
      this.tableGetCategoryInfoByIDs = (EEPRTplCateInfoDataset.GetCategoryInfoByIDsDataTable) base.Tables["GetCategoryInfoByIDs"];
      if (!initTable || this.tableGetCategoryInfoByIDs == null)
        return;
      this.tableGetCategoryInfoByIDs.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = "EEPRTplCateInfoDataset";
      this.Prefix = "";
      this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EEPRTplCateInfoDataset";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableGetCategoryInfoByIDs = new EEPRTplCateInfoDataset.GetCategoryInfoByIDsDataTable();
      base.Tables.Add((DataTable) this.tableGetCategoryInfoByIDs);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeGetCategoryInfoByIDs()
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
      EEPRTplCateInfoDataset tplCateInfoDataset = new EEPRTplCateInfoDataset();
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
      {
        Items = {
          (XmlSchemaObject) new XmlSchemaAny()
          {
            Namespace = tplCateInfoDataset.Namespace
          }
        }
      };
      XmlSchema schemaSerializable = tplCateInfoDataset.GetSchemaSerializable();
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

    public delegate void GetCategoryInfoByIDsRowChangeEventHandler(object sender, EEPRTplCateInfoDataset.GetCategoryInfoByIDsRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class GetCategoryInfoByIDsDataTable : DataTable, IEnumerable
    {
      private DataColumn columnEPRTemplateCategoryID;
      private DataColumn columnName;
      private DataColumn columnFullParentName;

      [DebuggerNonUserCode]
      public DataColumn EPRTemplateCategoryIDColumn
      {
        get
        {
          return this.columnEPRTemplateCategoryID;
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
      public DataColumn FullParentNameColumn
      {
        get
        {
          return this.columnFullParentName;
        }
      }

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [DebuggerNonUserCode]
      public EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow this[int index]
      {
        get
        {
          return (EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow) this.Rows[index];
        }
      }

      public event EEPRTplCateInfoDataset.GetCategoryInfoByIDsRowChangeEventHandler GetCategoryInfoByIDsRowChanging;

      public event EEPRTplCateInfoDataset.GetCategoryInfoByIDsRowChangeEventHandler GetCategoryInfoByIDsRowChanged;

      public event EEPRTplCateInfoDataset.GetCategoryInfoByIDsRowChangeEventHandler GetCategoryInfoByIDsRowDeleting;

      public event EEPRTplCateInfoDataset.GetCategoryInfoByIDsRowChangeEventHandler GetCategoryInfoByIDsRowDeleted;

      [DebuggerNonUserCode]
      public GetCategoryInfoByIDsDataTable()
      {
        this.TableName = "GetCategoryInfoByIDs";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal GetCategoryInfoByIDsDataTable(DataTable table)
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
      protected GetCategoryInfoByIDsDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public void AddGetCategoryInfoByIDsRow(EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow AddGetCategoryInfoByIDsRow(string EPRTemplateCategoryID, string Name, string FullParentName)
      {
        EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow categoryInfoByIdsRow = (EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow) this.NewRow();
        object[] objArray = new object[3]
        {
          (object) EPRTemplateCategoryID,
          (object) Name,
          (object) FullParentName
        };
        categoryInfoByIdsRow.ItemArray = objArray;
        this.Rows.Add((DataRow) categoryInfoByIdsRow);
        return categoryInfoByIdsRow;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator()
      {
        return this.Rows.GetEnumerator();
      }

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        EEPRTplCateInfoDataset.GetCategoryInfoByIDsDataTable infoByIdsDataTable = (EEPRTplCateInfoDataset.GetCategoryInfoByIDsDataTable) base.Clone();
        infoByIdsDataTable.InitVars();
        return (DataTable) infoByIdsDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new EEPRTplCateInfoDataset.GetCategoryInfoByIDsDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnEPRTemplateCategoryID = this.Columns["EPRTemplateCategoryID"];
        this.columnName = this.Columns["Name"];
        this.columnFullParentName = this.Columns["FullParentName"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnEPRTemplateCategoryID = new DataColumn("EPRTemplateCategoryID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEPRTemplateCategoryID);
        this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnName);
        this.columnFullParentName = new DataColumn("FullParentName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnFullParentName);
        this.Namespace = "";
      }

      [DebuggerNonUserCode]
      public EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow NewGetCategoryInfoByIDsRow()
      {
        return (EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType()
      {
        return typeof (EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow);
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.GetCategoryInfoByIDsRowChangedEvent == null)
          return;
        EEPRTplCateInfoDataset.GetCategoryInfoByIDsRowChangeEventHandler idsRowChangedEvent = this.GetCategoryInfoByIDsRowChangedEvent;
        if (idsRowChangedEvent == null)
          return;
        idsRowChangedEvent((object) this, new EEPRTplCateInfoDataset.GetCategoryInfoByIDsRowChangeEvent((EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.GetCategoryInfoByIDsRowChangingEvent == null)
          return;
        EEPRTplCateInfoDataset.GetCategoryInfoByIDsRowChangeEventHandler rowChangingEvent = this.GetCategoryInfoByIDsRowChangingEvent;
        if (rowChangingEvent == null)
          return;
        rowChangingEvent((object) this, new EEPRTplCateInfoDataset.GetCategoryInfoByIDsRowChangeEvent((EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.GetCategoryInfoByIDsRowDeletedEvent == null)
          return;
        EEPRTplCateInfoDataset.GetCategoryInfoByIDsRowChangeEventHandler idsRowDeletedEvent = this.GetCategoryInfoByIDsRowDeletedEvent;
        if (idsRowDeletedEvent == null)
          return;
        idsRowDeletedEvent((object) this, new EEPRTplCateInfoDataset.GetCategoryInfoByIDsRowChangeEvent((EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.GetCategoryInfoByIDsRowDeletingEvent == null)
          return;
        EEPRTplCateInfoDataset.GetCategoryInfoByIDsRowChangeEventHandler rowDeletingEvent = this.GetCategoryInfoByIDsRowDeletingEvent;
        if (rowDeletingEvent == null)
          return;
        rowDeletingEvent((object) this, new EEPRTplCateInfoDataset.GetCategoryInfoByIDsRowChangeEvent((EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveGetCategoryInfoByIDsRow(EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        EEPRTplCateInfoDataset tplCateInfoDataset = new EEPRTplCateInfoDataset();
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
          FixedValue = tplCateInfoDataset.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "GetCategoryInfoByIDsDataTable"
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = tplCateInfoDataset.GetSchemaSerializable();
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
    public class GetCategoryInfoByIDsRow : DataRow
    {
      private EEPRTplCateInfoDataset.GetCategoryInfoByIDsDataTable tableGetCategoryInfoByIDs;

      [DebuggerNonUserCode]
      public string EPRTemplateCategoryID
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableGetCategoryInfoByIDs.EPRTemplateCategoryIDColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"GetCategoryInfoByIDs\"中列\"EPRTemplateCategoryID\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableGetCategoryInfoByIDs.EPRTemplateCategoryIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string Name
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableGetCategoryInfoByIDs.NameColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"GetCategoryInfoByIDs\"中列\"Name\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableGetCategoryInfoByIDs.NameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string FullParentName
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableGetCategoryInfoByIDs.FullParentNameColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"GetCategoryInfoByIDs\"中列\"FullParentName\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableGetCategoryInfoByIDs.FullParentNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      internal GetCategoryInfoByIDsRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableGetCategoryInfoByIDs = (EEPRTplCateInfoDataset.GetCategoryInfoByIDsDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public bool IsEPRTemplateCategoryIDNull()
      {
        return this.IsNull(this.tableGetCategoryInfoByIDs.EPRTemplateCategoryIDColumn);
      }

      [DebuggerNonUserCode]
      public void SetEPRTemplateCategoryIDNull()
      {
        this[this.tableGetCategoryInfoByIDs.EPRTemplateCategoryIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsNameNull()
      {
        return this.IsNull(this.tableGetCategoryInfoByIDs.NameColumn);
      }

      [DebuggerNonUserCode]
      public void SetNameNull()
      {
        this[this.tableGetCategoryInfoByIDs.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsFullParentNameNull()
      {
        return this.IsNull(this.tableGetCategoryInfoByIDs.FullParentNameColumn);
      }

      [DebuggerNonUserCode]
      public void SetFullParentNameNull()
      {
        this[this.tableGetCategoryInfoByIDs.FullParentNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GetCategoryInfoByIDsRowChangeEvent : EventArgs
    {
      private EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow Row
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
      public GetCategoryInfoByIDsRowChangeEvent(EEPRTplCateInfoDataset.GetCategoryInfoByIDsRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }
  }
}
