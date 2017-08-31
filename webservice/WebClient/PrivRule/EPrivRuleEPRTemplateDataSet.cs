// Decompiled with JetBrains decompiler
// Type: PrivRule.EPrivRuleEPRTemplateDataSet
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

namespace PrivRule
{
  [HelpKeyword("vs.data.DataSet")]
  [ToolboxItem(true)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [DesignerCategory("code")]
  [XmlRoot("EPrivRuleEPRTemplateDataSet")]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [Serializable]
  public class EPrivRuleEPRTemplateDataSet : DataSet
  {
    private EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRDataTable tableGetTemplateByPrivRuleDR;
    private SchemaSerializationMode _schemaSerializationMode;

    [Browsable(false)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRDataTable GetTemplateByPrivRuleDR
    {
      get
      {
        return this.tableGetTemplateByPrivRuleDR;
      }
    }

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Browsable(true)]
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
    public EPrivRuleEPRTemplateDataSet()
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
    protected EPrivRuleEPRTemplateDataSet(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables["GetTemplateByPrivRuleDR"] != null)
            base.Tables.Add((DataTable) new EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRDataTable(dataSet.Tables["GetTemplateByPrivRuleDR"]));
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
      EPrivRuleEPRTemplateDataSet eprTemplateDataSet = (EPrivRuleEPRTemplateDataSet) base.Clone();
      eprTemplateDataSet.InitVars();
      eprTemplateDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) eprTemplateDataSet;
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
        if (dataSet.Tables["GetTemplateByPrivRuleDR"] != null)
          base.Tables.Add((DataTable) new EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRDataTable(dataSet.Tables["GetTemplateByPrivRuleDR"]));
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
      this.tableGetTemplateByPrivRuleDR = (EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRDataTable) base.Tables["GetTemplateByPrivRuleDR"];
      if (!initTable || this.tableGetTemplateByPrivRuleDR == null)
        return;
      this.tableGetTemplateByPrivRuleDR.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = "EPrivRuleEPRTemplateDataSet";
      this.Prefix = "";
      this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EPrivRuleEPRTemplate";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableGetTemplateByPrivRuleDR = new EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRDataTable();
      base.Tables.Add((DataTable) this.tableGetTemplateByPrivRuleDR);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeGetTemplateByPrivRuleDR()
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
      EPrivRuleEPRTemplateDataSet eprTemplateDataSet = new EPrivRuleEPRTemplateDataSet();
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
      {
        Items = {
          (XmlSchemaObject) new XmlSchemaAny()
          {
            Namespace = eprTemplateDataSet.Namespace
          }
        }
      };
      XmlSchema schemaSerializable = eprTemplateDataSet.GetSchemaSerializable();
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

    public delegate void GetTemplateByPrivRuleDRRowChangeEventHandler(object sender, EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class GetTemplateByPrivRuleDRDataTable : DataTable, IEnumerable
    {
      private DataColumn columnID;
      private DataColumn columnEPRTemplateName;
      private DataColumn columnEPRCategoryName;

      [DebuggerNonUserCode]
      public DataColumn IDColumn
      {
        get
        {
          return this.columnID;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn EPRTemplateNameColumn
      {
        get
        {
          return this.columnEPRTemplateName;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn EPRCategoryNameColumn
      {
        get
        {
          return this.columnEPRCategoryName;
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
      public EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow this[int index]
      {
        get
        {
          return (EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow) this.Rows[index];
        }
      }

      public event EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRowChangeEventHandler GetTemplateByPrivRuleDRRowChanging;

      public event EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRowChangeEventHandler GetTemplateByPrivRuleDRRowChanged;

      public event EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRowChangeEventHandler GetTemplateByPrivRuleDRRowDeleting;

      public event EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRowChangeEventHandler GetTemplateByPrivRuleDRRowDeleted;

      [DebuggerNonUserCode]
      public GetTemplateByPrivRuleDRDataTable()
      {
        this.TableName = "GetTemplateByPrivRuleDR";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal GetTemplateByPrivRuleDRDataTable(DataTable table)
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
      protected GetTemplateByPrivRuleDRDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public void AddGetTemplateByPrivRuleDRRow(EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow AddGetTemplateByPrivRuleDRRow(string ID, string EPRTemplateName, string EPRCategoryName)
      {
        EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow templateByPrivRuleDrRow = (EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow) this.NewRow();
        object[] objArray = new object[3]
        {
          (object) ID,
          (object) EPRTemplateName,
          (object) EPRCategoryName
        };
        templateByPrivRuleDrRow.ItemArray = objArray;
        this.Rows.Add((DataRow) templateByPrivRuleDrRow);
        return templateByPrivRuleDrRow;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator()
      {
        return this.Rows.GetEnumerator();
      }

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRDataTable privRuleDrDataTable = (EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRDataTable) base.Clone();
        privRuleDrDataTable.InitVars();
        return (DataTable) privRuleDrDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnEPRTemplateName = this.Columns["EPRTemplateName"];
        this.columnEPRCategoryName = this.Columns["EPRCategoryName"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnEPRTemplateName = new DataColumn("EPRTemplateName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEPRTemplateName);
        this.columnEPRCategoryName = new DataColumn("EPRCategoryName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEPRCategoryName);
        this.Namespace = "";
      }

      [DebuggerNonUserCode]
      public EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow NewGetTemplateByPrivRuleDRRow()
      {
        return (EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType()
      {
        return typeof (EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow);
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.GetTemplateByPrivRuleDRRowChangedEvent == null)
          return;
        EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRowChangeEventHandler drRowChangedEvent = this.GetTemplateByPrivRuleDRRowChangedEvent;
        if (drRowChangedEvent == null)
          return;
        drRowChangedEvent((object) this, new EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRowChangeEvent((EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.GetTemplateByPrivRuleDRRowChangingEvent == null)
          return;
        EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRowChangeEventHandler rowChangingEvent = this.GetTemplateByPrivRuleDRRowChangingEvent;
        if (rowChangingEvent == null)
          return;
        rowChangingEvent((object) this, new EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRowChangeEvent((EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.GetTemplateByPrivRuleDRRowDeletedEvent == null)
          return;
        EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRowChangeEventHandler drRowDeletedEvent = this.GetTemplateByPrivRuleDRRowDeletedEvent;
        if (drRowDeletedEvent == null)
          return;
        drRowDeletedEvent((object) this, new EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRowChangeEvent((EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.GetTemplateByPrivRuleDRRowDeletingEvent == null)
          return;
        EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRowChangeEventHandler rowDeletingEvent = this.GetTemplateByPrivRuleDRRowDeletingEvent;
        if (rowDeletingEvent == null)
          return;
        rowDeletingEvent((object) this, new EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRowChangeEvent((EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveGetTemplateByPrivRuleDRRow(EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        EPrivRuleEPRTemplateDataSet eprTemplateDataSet = new EPrivRuleEPRTemplateDataSet();
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
          FixedValue = eprTemplateDataSet.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "GetTemplateByPrivRuleDRDataTable"
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = eprTemplateDataSet.GetSchemaSerializable();
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
    public class GetTemplateByPrivRuleDRRow : DataRow
    {
      private EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRDataTable tableGetTemplateByPrivRuleDR;

      [DebuggerNonUserCode]
      public string ID
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableGetTemplateByPrivRuleDR.IDColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"GetTemplateByPrivRuleDR\"中列\"ID\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableGetTemplateByPrivRuleDR.IDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string EPRTemplateName
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableGetTemplateByPrivRuleDR.EPRTemplateNameColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"GetTemplateByPrivRuleDR\"中列\"EPRTemplateName\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableGetTemplateByPrivRuleDR.EPRTemplateNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string EPRCategoryName
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableGetTemplateByPrivRuleDR.EPRCategoryNameColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"GetTemplateByPrivRuleDR\"中列\"EPRCategoryName\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableGetTemplateByPrivRuleDR.EPRCategoryNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      internal GetTemplateByPrivRuleDRRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableGetTemplateByPrivRuleDR = (EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public bool IsIDNull()
      {
        return this.IsNull(this.tableGetTemplateByPrivRuleDR.IDColumn);
      }

      [DebuggerNonUserCode]
      public void SetIDNull()
      {
        this[this.tableGetTemplateByPrivRuleDR.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsEPRTemplateNameNull()
      {
        return this.IsNull(this.tableGetTemplateByPrivRuleDR.EPRTemplateNameColumn);
      }

      [DebuggerNonUserCode]
      public void SetEPRTemplateNameNull()
      {
        this[this.tableGetTemplateByPrivRuleDR.EPRTemplateNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsEPRCategoryNameNull()
      {
        return this.IsNull(this.tableGetTemplateByPrivRuleDR.EPRCategoryNameColumn);
      }

      [DebuggerNonUserCode]
      public void SetEPRCategoryNameNull()
      {
        this[this.tableGetTemplateByPrivRuleDR.EPRCategoryNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GetTemplateByPrivRuleDRRowChangeEvent : EventArgs
    {
      private EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow Row
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
      public GetTemplateByPrivRuleDRRowChangeEvent(EPrivRuleEPRTemplateDataSet.GetTemplateByPrivRuleDRRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }
  }
}
