// Decompiled with JetBrains decompiler
// Type: PrivRule.EPrivRuleByTypeDataSet
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
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [HelpKeyword("vs.data.DataSet")]
  [XmlRoot("EPrivRuleByTypeDataSet")]
  [ToolboxItem(true)]
  [Serializable]
  public class EPrivRuleByTypeDataSet : DataSet
  {
    private EPrivRuleByTypeDataSet.SelectPrivRuleByTypeDataTable tableSelectPrivRuleByType;
    private SchemaSerializationMode _schemaSerializationMode;

    [Browsable(false)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public EPrivRuleByTypeDataSet.SelectPrivRuleByTypeDataTable SelectPrivRuleByType
    {
      get
      {
        return this.tableSelectPrivRuleByType;
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

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataRelationCollection Relations
    {
      get
      {
        return base.Relations;
      }
    }

    [DebuggerNonUserCode]
    public EPrivRuleByTypeDataSet()
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
    protected EPrivRuleByTypeDataSet(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables["SelectPrivRuleByType"] != null)
            base.Tables.Add((DataTable) new EPrivRuleByTypeDataSet.SelectPrivRuleByTypeDataTable(dataSet.Tables["SelectPrivRuleByType"]));
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
      EPrivRuleByTypeDataSet ruleByTypeDataSet = (EPrivRuleByTypeDataSet) base.Clone();
      ruleByTypeDataSet.InitVars();
      ruleByTypeDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) ruleByTypeDataSet;
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
        if (dataSet.Tables["SelectPrivRuleByType"] != null)
          base.Tables.Add((DataTable) new EPrivRuleByTypeDataSet.SelectPrivRuleByTypeDataTable(dataSet.Tables["SelectPrivRuleByType"]));
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
      this.tableSelectPrivRuleByType = (EPrivRuleByTypeDataSet.SelectPrivRuleByTypeDataTable) base.Tables["SelectPrivRuleByType"];
      if (!initTable || this.tableSelectPrivRuleByType == null)
        return;
      this.tableSelectPrivRuleByType.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = "EPrivRuleByTypeDataSet";
      this.Prefix = "";
      this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EPrivRuleByTypeDataSet";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableSelectPrivRuleByType = new EPrivRuleByTypeDataSet.SelectPrivRuleByTypeDataTable();
      base.Tables.Add((DataTable) this.tableSelectPrivRuleByType);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeSelectPrivRuleByType()
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
      EPrivRuleByTypeDataSet ruleByTypeDataSet = new EPrivRuleByTypeDataSet();
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
      {
        Items = {
          (XmlSchemaObject) new XmlSchemaAny()
          {
            Namespace = ruleByTypeDataSet.Namespace
          }
        }
      };
      XmlSchema schemaSerializable = ruleByTypeDataSet.GetSchemaSerializable();
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

    public delegate void SelectPrivRuleByTypeRowChangeEventHandler(object sender, EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class SelectPrivRuleByTypeDataTable : DataTable, IEnumerable
    {
      private DataColumn columnID;
      private DataColumn columnName;
      private DataColumn columnCode;
      private DataColumn columnValid;
      private DataColumn columnValidDesc;
      private DataColumn columnIsUsed;
      private DataColumn columnIsUsedDesc;
      private DataColumn columnPrivRuleTypeDR;
      private DataColumn columnPrivRuleTypeDesc;

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
      public DataColumn CodeColumn
      {
        get
        {
          return this.columnCode;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn ValidColumn
      {
        get
        {
          return this.columnValid;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn ValidDescColumn
      {
        get
        {
          return this.columnValidDesc;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn IsUsedColumn
      {
        get
        {
          return this.columnIsUsed;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn IsUsedDescColumn
      {
        get
        {
          return this.columnIsUsedDesc;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn PrivRuleTypeDRColumn
      {
        get
        {
          return this.columnPrivRuleTypeDR;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn PrivRuleTypeDescColumn
      {
        get
        {
          return this.columnPrivRuleTypeDesc;
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
      public EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow this[int index]
      {
        get
        {
          return (EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow) this.Rows[index];
        }
      }

      public event EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRowChangeEventHandler SelectPrivRuleByTypeRowChanging;

      public event EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRowChangeEventHandler SelectPrivRuleByTypeRowChanged;

      public event EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRowChangeEventHandler SelectPrivRuleByTypeRowDeleting;

      public event EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRowChangeEventHandler SelectPrivRuleByTypeRowDeleted;

      [DebuggerNonUserCode]
      public SelectPrivRuleByTypeDataTable()
      {
        this.TableName = "SelectPrivRuleByType";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal SelectPrivRuleByTypeDataTable(DataTable table)
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
      protected SelectPrivRuleByTypeDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public void AddSelectPrivRuleByTypeRow(EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow AddSelectPrivRuleByTypeRow(string ID, string Name, string Code, string Valid, string ValidDesc, string IsUsed, string IsUsedDesc, string PrivRuleTypeDR, string PrivRuleTypeDesc)
      {
        EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow privRuleByTypeRow = (EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow) this.NewRow();
        object[] objArray = new object[9]
        {
          (object) ID,
          (object) Name,
          (object) Code,
          (object) Valid,
          (object) ValidDesc,
          (object) IsUsed,
          (object) IsUsedDesc,
          (object) PrivRuleTypeDR,
          (object) PrivRuleTypeDesc
        };
        privRuleByTypeRow.ItemArray = objArray;
        this.Rows.Add((DataRow) privRuleByTypeRow);
        return privRuleByTypeRow;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator()
      {
        return this.Rows.GetEnumerator();
      }

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        EPrivRuleByTypeDataSet.SelectPrivRuleByTypeDataTable ruleByTypeDataTable = (EPrivRuleByTypeDataSet.SelectPrivRuleByTypeDataTable) base.Clone();
        ruleByTypeDataTable.InitVars();
        return (DataTable) ruleByTypeDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new EPrivRuleByTypeDataSet.SelectPrivRuleByTypeDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnName = this.Columns["Name"];
        this.columnCode = this.Columns["Code"];
        this.columnValid = this.Columns["Valid"];
        this.columnValidDesc = this.Columns["ValidDesc"];
        this.columnIsUsed = this.Columns["IsUsed"];
        this.columnIsUsedDesc = this.Columns["IsUsedDesc"];
        this.columnPrivRuleTypeDR = this.Columns["PrivRuleTypeDR"];
        this.columnPrivRuleTypeDesc = this.Columns["PrivRuleTypeDesc"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnName);
        this.columnCode = new DataColumn("Code", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCode);
        this.columnValid = new DataColumn("Valid", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnValid);
        this.columnValidDesc = new DataColumn("ValidDesc", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnValidDesc);
        this.columnIsUsed = new DataColumn("IsUsed", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIsUsed);
        this.columnIsUsedDesc = new DataColumn("IsUsedDesc", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIsUsedDesc);
        this.columnPrivRuleTypeDR = new DataColumn("PrivRuleTypeDR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPrivRuleTypeDR);
        this.columnPrivRuleTypeDesc = new DataColumn("PrivRuleTypeDesc", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPrivRuleTypeDesc);
        this.Namespace = "";
      }

      [DebuggerNonUserCode]
      public EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow NewSelectPrivRuleByTypeRow()
      {
        return (EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType()
      {
        return typeof (EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow);
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.SelectPrivRuleByTypeRowChangedEvent == null)
          return;
        EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRowChangeEventHandler typeRowChangedEvent = this.SelectPrivRuleByTypeRowChangedEvent;
        if (typeRowChangedEvent == null)
          return;
        typeRowChangedEvent((object) this, new EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRowChangeEvent((EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.SelectPrivRuleByTypeRowChangingEvent == null)
          return;
        EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRowChangeEventHandler rowChangingEvent = this.SelectPrivRuleByTypeRowChangingEvent;
        if (rowChangingEvent == null)
          return;
        rowChangingEvent((object) this, new EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRowChangeEvent((EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.SelectPrivRuleByTypeRowDeletedEvent == null)
          return;
        EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRowChangeEventHandler typeRowDeletedEvent = this.SelectPrivRuleByTypeRowDeletedEvent;
        if (typeRowDeletedEvent == null)
          return;
        typeRowDeletedEvent((object) this, new EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRowChangeEvent((EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.SelectPrivRuleByTypeRowDeletingEvent == null)
          return;
        EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRowChangeEventHandler rowDeletingEvent = this.SelectPrivRuleByTypeRowDeletingEvent;
        if (rowDeletingEvent == null)
          return;
        rowDeletingEvent((object) this, new EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRowChangeEvent((EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveSelectPrivRuleByTypeRow(EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        EPrivRuleByTypeDataSet ruleByTypeDataSet = new EPrivRuleByTypeDataSet();
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
          FixedValue = ruleByTypeDataSet.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "SelectPrivRuleByTypeDataTable"
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = ruleByTypeDataSet.GetSchemaSerializable();
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
    public class SelectPrivRuleByTypeRow : DataRow
    {
      private EPrivRuleByTypeDataSet.SelectPrivRuleByTypeDataTable tableSelectPrivRuleByType;

      [DebuggerNonUserCode]
      public string ID
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleByType.IDColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleByType\"中列\"ID\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleByType.IDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string Name
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleByType.NameColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleByType\"中列\"Name\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleByType.NameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string Code
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleByType.CodeColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleByType\"中列\"Code\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleByType.CodeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string Valid
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleByType.ValidColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleByType\"中列\"Valid\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleByType.ValidColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string ValidDesc
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleByType.ValidDescColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleByType\"中列\"ValidDesc\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleByType.ValidDescColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string IsUsed
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleByType.IsUsedColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleByType\"中列\"IsUsed\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleByType.IsUsedColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string IsUsedDesc
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleByType.IsUsedDescColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleByType\"中列\"IsUsedDesc\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleByType.IsUsedDescColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string PrivRuleTypeDR
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleByType.PrivRuleTypeDRColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleByType\"中列\"PrivRuleTypeDR\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleByType.PrivRuleTypeDRColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string PrivRuleTypeDesc
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleByType.PrivRuleTypeDescColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleByType\"中列\"PrivRuleTypeDesc\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleByType.PrivRuleTypeDescColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      internal SelectPrivRuleByTypeRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSelectPrivRuleByType = (EPrivRuleByTypeDataSet.SelectPrivRuleByTypeDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public bool IsIDNull()
      {
        return this.IsNull(this.tableSelectPrivRuleByType.IDColumn);
      }

      [DebuggerNonUserCode]
      public void SetIDNull()
      {
        this[this.tableSelectPrivRuleByType.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsNameNull()
      {
        return this.IsNull(this.tableSelectPrivRuleByType.NameColumn);
      }

      [DebuggerNonUserCode]
      public void SetNameNull()
      {
        this[this.tableSelectPrivRuleByType.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsCodeNull()
      {
        return this.IsNull(this.tableSelectPrivRuleByType.CodeColumn);
      }

      [DebuggerNonUserCode]
      public void SetCodeNull()
      {
        this[this.tableSelectPrivRuleByType.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsValidNull()
      {
        return this.IsNull(this.tableSelectPrivRuleByType.ValidColumn);
      }

      [DebuggerNonUserCode]
      public void SetValidNull()
      {
        this[this.tableSelectPrivRuleByType.ValidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsValidDescNull()
      {
        return this.IsNull(this.tableSelectPrivRuleByType.ValidDescColumn);
      }

      [DebuggerNonUserCode]
      public void SetValidDescNull()
      {
        this[this.tableSelectPrivRuleByType.ValidDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsIsUsedNull()
      {
        return this.IsNull(this.tableSelectPrivRuleByType.IsUsedColumn);
      }

      [DebuggerNonUserCode]
      public void SetIsUsedNull()
      {
        this[this.tableSelectPrivRuleByType.IsUsedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsIsUsedDescNull()
      {
        return this.IsNull(this.tableSelectPrivRuleByType.IsUsedDescColumn);
      }

      [DebuggerNonUserCode]
      public void SetIsUsedDescNull()
      {
        this[this.tableSelectPrivRuleByType.IsUsedDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsPrivRuleTypeDRNull()
      {
        return this.IsNull(this.tableSelectPrivRuleByType.PrivRuleTypeDRColumn);
      }

      [DebuggerNonUserCode]
      public void SetPrivRuleTypeDRNull()
      {
        this[this.tableSelectPrivRuleByType.PrivRuleTypeDRColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsPrivRuleTypeDescNull()
      {
        return this.IsNull(this.tableSelectPrivRuleByType.PrivRuleTypeDescColumn);
      }

      [DebuggerNonUserCode]
      public void SetPrivRuleTypeDescNull()
      {
        this[this.tableSelectPrivRuleByType.PrivRuleTypeDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SelectPrivRuleByTypeRowChangeEvent : EventArgs
    {
      private EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow Row
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
      public SelectPrivRuleByTypeRowChangeEvent(EPrivRuleByTypeDataSet.SelectPrivRuleByTypeRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }
  }
}
