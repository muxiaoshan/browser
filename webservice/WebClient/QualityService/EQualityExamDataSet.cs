// Decompiled with JetBrains decompiler
// Type: QualityService.EQualityExamDataSet
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

namespace QualityService
{
  [HelpKeyword("vs.data.DataSet")]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [XmlRoot("EQualityExamDataSet")]
  [ToolboxItem(true)]
  [DesignerCategory("code")]
  [Serializable]
  public class EQualityExamDataSet : DataSet
  {
    private EQualityExamDataSet.GetQuaExamResultDataTable tableGetQuaExamResult;
    private SchemaSerializationMode _schemaSerializationMode;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public EQualityExamDataSet.GetQuaExamResultDataTable GetQuaExamResult
    {
      get
      {
        return this.tableGetQuaExamResult;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
    public EQualityExamDataSet()
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
    protected EQualityExamDataSet(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables["GetQuaExamResult"] != null)
            base.Tables.Add((DataTable) new EQualityExamDataSet.GetQuaExamResultDataTable(dataSet.Tables["GetQuaExamResult"]));
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
      EQualityExamDataSet equalityExamDataSet = (EQualityExamDataSet) base.Clone();
      equalityExamDataSet.InitVars();
      equalityExamDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) equalityExamDataSet;
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
        if (dataSet.Tables["GetQuaExamResult"] != null)
          base.Tables.Add((DataTable) new EQualityExamDataSet.GetQuaExamResultDataTable(dataSet.Tables["GetQuaExamResult"]));
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
      this.tableGetQuaExamResult = (EQualityExamDataSet.GetQuaExamResultDataTable) base.Tables["GetQuaExamResult"];
      if (!initTable || this.tableGetQuaExamResult == null)
        return;
      this.tableGetQuaExamResult.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = "EQualityExamDataSet";
      this.Prefix = "";
      this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EUnitDataset";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableGetQuaExamResult = new EQualityExamDataSet.GetQuaExamResultDataTable();
      base.Tables.Add((DataTable) this.tableGetQuaExamResult);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeGetQuaExamResult()
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
      EQualityExamDataSet equalityExamDataSet = new EQualityExamDataSet();
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
      {
        Items = {
          (XmlSchemaObject) new XmlSchemaAny()
          {
            Namespace = equalityExamDataSet.Namespace
          }
        }
      };
      XmlSchema schemaSerializable = equalityExamDataSet.GetSchemaSerializable();
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

    public delegate void GetQuaExamResultRowChangeEventHandler(object sender, EQualityExamDataSet.GetQuaExamResultRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class GetQuaExamResultDataTable : DataTable, IEnumerable
    {
      private DataColumn columnRuleDr;
      private DataColumn columnRuleDesc;
      private DataColumn columnSectionDr;
      private DataColumn columnSectionDesc;
      private DataColumn columnEntryDr;
      private DataColumn columnEntryDesc;
      private DataColumn columnExamItem;
      private DataColumn columnACRDesc;

      [DebuggerNonUserCode]
      public DataColumn RuleDrColumn
      {
        get
        {
          return this.columnRuleDr;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn RuleDescColumn
      {
        get
        {
          return this.columnRuleDesc;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn SectionDrColumn
      {
        get
        {
          return this.columnSectionDr;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn SectionDescColumn
      {
        get
        {
          return this.columnSectionDesc;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn EntryDrColumn
      {
        get
        {
          return this.columnEntryDr;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn EntryDescColumn
      {
        get
        {
          return this.columnEntryDesc;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn ExamItemColumn
      {
        get
        {
          return this.columnExamItem;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn ACRDescColumn
      {
        get
        {
          return this.columnACRDesc;
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
      public EQualityExamDataSet.GetQuaExamResultRow this[int index]
      {
        get
        {
          return (EQualityExamDataSet.GetQuaExamResultRow) this.Rows[index];
        }
      }

      public event EQualityExamDataSet.GetQuaExamResultRowChangeEventHandler GetQuaExamResultRowChanging;

      public event EQualityExamDataSet.GetQuaExamResultRowChangeEventHandler GetQuaExamResultRowChanged;

      public event EQualityExamDataSet.GetQuaExamResultRowChangeEventHandler GetQuaExamResultRowDeleting;

      public event EQualityExamDataSet.GetQuaExamResultRowChangeEventHandler GetQuaExamResultRowDeleted;

      [DebuggerNonUserCode]
      public GetQuaExamResultDataTable()
      {
        this.TableName = "GetQuaExamResult";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal GetQuaExamResultDataTable(DataTable table)
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
      protected GetQuaExamResultDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public void AddGetQuaExamResultRow(EQualityExamDataSet.GetQuaExamResultRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public EQualityExamDataSet.GetQuaExamResultRow AddGetQuaExamResultRow(string RuleDr, string RuleDesc, string SectionDr, string SectionDesc, string EntryDr, string EntryDesc, string ExamItem, string ACRDesc)
      {
        EQualityExamDataSet.GetQuaExamResultRow quaExamResultRow = (EQualityExamDataSet.GetQuaExamResultRow) this.NewRow();
        object[] objArray = new object[8]
        {
          (object) RuleDr,
          (object) RuleDesc,
          (object) SectionDr,
          (object) SectionDesc,
          (object) EntryDr,
          (object) EntryDesc,
          (object) ExamItem,
          (object) ACRDesc
        };
        quaExamResultRow.ItemArray = objArray;
        this.Rows.Add((DataRow) quaExamResultRow);
        return quaExamResultRow;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator()
      {
        return this.Rows.GetEnumerator();
      }

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        EQualityExamDataSet.GetQuaExamResultDataTable examResultDataTable = (EQualityExamDataSet.GetQuaExamResultDataTable) base.Clone();
        examResultDataTable.InitVars();
        return (DataTable) examResultDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new EQualityExamDataSet.GetQuaExamResultDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnRuleDr = this.Columns["RuleDr"];
        this.columnRuleDesc = this.Columns["RuleDesc"];
        this.columnSectionDr = this.Columns["SectionDr"];
        this.columnSectionDesc = this.Columns["SectionDesc"];
        this.columnEntryDr = this.Columns["EntryDr"];
        this.columnEntryDesc = this.Columns["EntryDesc"];
        this.columnExamItem = this.Columns["ExamItem"];
        this.columnACRDesc = this.Columns["ACRDesc"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnRuleDr = new DataColumn("RuleDr", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRuleDr);
        this.columnRuleDesc = new DataColumn("RuleDesc", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRuleDesc);
        this.columnSectionDr = new DataColumn("SectionDr", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSectionDr);
        this.columnSectionDesc = new DataColumn("SectionDesc", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSectionDesc);
        this.columnEntryDr = new DataColumn("EntryDr", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEntryDr);
        this.columnEntryDesc = new DataColumn("EntryDesc", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnEntryDesc);
        this.columnExamItem = new DataColumn("ExamItem", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnExamItem);
        this.columnACRDesc = new DataColumn("ACRDesc", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnACRDesc);
        this.Namespace = "";
      }

      [DebuggerNonUserCode]
      public EQualityExamDataSet.GetQuaExamResultRow NewGetQuaExamResultRow()
      {
        return (EQualityExamDataSet.GetQuaExamResultRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new EQualityExamDataSet.GetQuaExamResultRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType()
      {
        return typeof (EQualityExamDataSet.GetQuaExamResultRow);
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.GetQuaExamResultRowChangedEvent == null)
          return;
        EQualityExamDataSet.GetQuaExamResultRowChangeEventHandler resultRowChangedEvent = this.GetQuaExamResultRowChangedEvent;
        if (resultRowChangedEvent == null)
          return;
        resultRowChangedEvent((object) this, new EQualityExamDataSet.GetQuaExamResultRowChangeEvent((EQualityExamDataSet.GetQuaExamResultRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.GetQuaExamResultRowChangingEvent == null)
          return;
        EQualityExamDataSet.GetQuaExamResultRowChangeEventHandler rowChangingEvent = this.GetQuaExamResultRowChangingEvent;
        if (rowChangingEvent == null)
          return;
        rowChangingEvent((object) this, new EQualityExamDataSet.GetQuaExamResultRowChangeEvent((EQualityExamDataSet.GetQuaExamResultRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.GetQuaExamResultRowDeletedEvent == null)
          return;
        EQualityExamDataSet.GetQuaExamResultRowChangeEventHandler resultRowDeletedEvent = this.GetQuaExamResultRowDeletedEvent;
        if (resultRowDeletedEvent == null)
          return;
        resultRowDeletedEvent((object) this, new EQualityExamDataSet.GetQuaExamResultRowChangeEvent((EQualityExamDataSet.GetQuaExamResultRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.GetQuaExamResultRowDeletingEvent == null)
          return;
        EQualityExamDataSet.GetQuaExamResultRowChangeEventHandler rowDeletingEvent = this.GetQuaExamResultRowDeletingEvent;
        if (rowDeletingEvent == null)
          return;
        rowDeletingEvent((object) this, new EQualityExamDataSet.GetQuaExamResultRowChangeEvent((EQualityExamDataSet.GetQuaExamResultRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveGetQuaExamResultRow(EQualityExamDataSet.GetQuaExamResultRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        EQualityExamDataSet equalityExamDataSet = new EQualityExamDataSet();
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
          FixedValue = equalityExamDataSet.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "GetQuaExamResultDataTable"
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = equalityExamDataSet.GetSchemaSerializable();
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
    public class GetQuaExamResultRow : DataRow
    {
      private EQualityExamDataSet.GetQuaExamResultDataTable tableGetQuaExamResult;

      [DebuggerNonUserCode]
      public string RuleDr
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableGetQuaExamResult.RuleDrColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"GetQuaExamResult\"中列\"RuleDr\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableGetQuaExamResult.RuleDrColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string RuleDesc
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableGetQuaExamResult.RuleDescColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"GetQuaExamResult\"中列\"RuleDesc\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableGetQuaExamResult.RuleDescColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string SectionDr
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableGetQuaExamResult.SectionDrColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"GetQuaExamResult\"中列\"SectionDr\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableGetQuaExamResult.SectionDrColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string SectionDesc
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableGetQuaExamResult.SectionDescColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"GetQuaExamResult\"中列\"SectionDesc\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableGetQuaExamResult.SectionDescColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string EntryDr
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableGetQuaExamResult.EntryDrColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"GetQuaExamResult\"中列\"EntryDr\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableGetQuaExamResult.EntryDrColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string EntryDesc
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableGetQuaExamResult.EntryDescColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"GetQuaExamResult\"中列\"EntryDesc\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableGetQuaExamResult.EntryDescColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string ExamItem
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableGetQuaExamResult.ExamItemColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"GetQuaExamResult\"中列\"ExamItem\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableGetQuaExamResult.ExamItemColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string ACRDesc
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableGetQuaExamResult.ACRDescColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"GetQuaExamResult\"中列\"ACRDesc\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableGetQuaExamResult.ACRDescColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      internal GetQuaExamResultRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableGetQuaExamResult = (EQualityExamDataSet.GetQuaExamResultDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public bool IsRuleDrNull()
      {
        return this.IsNull(this.tableGetQuaExamResult.RuleDrColumn);
      }

      [DebuggerNonUserCode]
      public void SetRuleDrNull()
      {
        this[this.tableGetQuaExamResult.RuleDrColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsRuleDescNull()
      {
        return this.IsNull(this.tableGetQuaExamResult.RuleDescColumn);
      }

      [DebuggerNonUserCode]
      public void SetRuleDescNull()
      {
        this[this.tableGetQuaExamResult.RuleDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsSectionDrNull()
      {
        return this.IsNull(this.tableGetQuaExamResult.SectionDrColumn);
      }

      [DebuggerNonUserCode]
      public void SetSectionDrNull()
      {
        this[this.tableGetQuaExamResult.SectionDrColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsSectionDescNull()
      {
        return this.IsNull(this.tableGetQuaExamResult.SectionDescColumn);
      }

      [DebuggerNonUserCode]
      public void SetSectionDescNull()
      {
        this[this.tableGetQuaExamResult.SectionDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsEntryDrNull()
      {
        return this.IsNull(this.tableGetQuaExamResult.EntryDrColumn);
      }

      [DebuggerNonUserCode]
      public void SetEntryDrNull()
      {
        this[this.tableGetQuaExamResult.EntryDrColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsEntryDescNull()
      {
        return this.IsNull(this.tableGetQuaExamResult.EntryDescColumn);
      }

      [DebuggerNonUserCode]
      public void SetEntryDescNull()
      {
        this[this.tableGetQuaExamResult.EntryDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsExamItemNull()
      {
        return this.IsNull(this.tableGetQuaExamResult.ExamItemColumn);
      }

      [DebuggerNonUserCode]
      public void SetExamItemNull()
      {
        this[this.tableGetQuaExamResult.ExamItemColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsACRDescNull()
      {
        return this.IsNull(this.tableGetQuaExamResult.ACRDescColumn);
      }

      [DebuggerNonUserCode]
      public void SetACRDescNull()
      {
        this[this.tableGetQuaExamResult.ACRDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GetQuaExamResultRowChangeEvent : EventArgs
    {
      private EQualityExamDataSet.GetQuaExamResultRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public EQualityExamDataSet.GetQuaExamResultRow Row
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
      public GetQuaExamResultRowChangeEvent(EQualityExamDataSet.GetQuaExamResultRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }
  }
}
