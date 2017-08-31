// Decompiled with JetBrains decompiler
// Type: PrivRule.EPivRuleStatusDataSet
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
  [ToolboxItem(true)]
  [DesignerCategory("code")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [XmlRoot("EPivRuleStatusDataSet")]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class EPivRuleStatusDataSet : DataSet
  {
    private EPivRuleStatusDataSet.SelectPrivRuleAllDataTable tableSelectPrivRuleAll;
    private SchemaSerializationMode _schemaSerializationMode;

    [Browsable(false)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public EPivRuleStatusDataSet.SelectPrivRuleAllDataTable SelectPrivRuleAll
    {
      get
      {
        return this.tableSelectPrivRuleAll;
      }
    }

    [DebuggerNonUserCode]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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
    public EPivRuleStatusDataSet()
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
    protected EPivRuleStatusDataSet(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables["SelectPrivRuleAll"] != null)
            base.Tables.Add((DataTable) new EPivRuleStatusDataSet.SelectPrivRuleAllDataTable(dataSet.Tables["SelectPrivRuleAll"]));
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
      EPivRuleStatusDataSet ruleStatusDataSet = (EPivRuleStatusDataSet) base.Clone();
      ruleStatusDataSet.InitVars();
      ruleStatusDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) ruleStatusDataSet;
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
        if (dataSet.Tables["SelectPrivRuleAll"] != null)
          base.Tables.Add((DataTable) new EPivRuleStatusDataSet.SelectPrivRuleAllDataTable(dataSet.Tables["SelectPrivRuleAll"]));
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
      this.tableSelectPrivRuleAll = (EPivRuleStatusDataSet.SelectPrivRuleAllDataTable) base.Tables["SelectPrivRuleAll"];
      if (!initTable || this.tableSelectPrivRuleAll == null)
        return;
      this.tableSelectPrivRuleAll.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = "EPivRuleStatusDataSet";
      this.Prefix = "";
      this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EPivRuleStatusDataSet";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableSelectPrivRuleAll = new EPivRuleStatusDataSet.SelectPrivRuleAllDataTable();
      base.Tables.Add((DataTable) this.tableSelectPrivRuleAll);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeSelectPrivRuleAll()
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
      EPivRuleStatusDataSet ruleStatusDataSet = new EPivRuleStatusDataSet();
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
      {
        Items = {
          (XmlSchemaObject) new XmlSchemaAny()
          {
            Namespace = ruleStatusDataSet.Namespace
          }
        }
      };
      XmlSchema schemaSerializable = ruleStatusDataSet.GetSchemaSerializable();
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

    public delegate void SelectPrivRuleAllRowChangeEventHandler(object sender, EPivRuleStatusDataSet.SelectPrivRuleAllRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class SelectPrivRuleAllDataTable : DataTable, IEnumerable
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
      public EPivRuleStatusDataSet.SelectPrivRuleAllRow this[int index]
      {
        get
        {
          return (EPivRuleStatusDataSet.SelectPrivRuleAllRow) this.Rows[index];
        }
      }

      public event EPivRuleStatusDataSet.SelectPrivRuleAllRowChangeEventHandler SelectPrivRuleAllRowChanging;

      public event EPivRuleStatusDataSet.SelectPrivRuleAllRowChangeEventHandler SelectPrivRuleAllRowChanged;

      public event EPivRuleStatusDataSet.SelectPrivRuleAllRowChangeEventHandler SelectPrivRuleAllRowDeleting;

      public event EPivRuleStatusDataSet.SelectPrivRuleAllRowChangeEventHandler SelectPrivRuleAllRowDeleted;

      [DebuggerNonUserCode]
      public SelectPrivRuleAllDataTable()
      {
        this.TableName = "SelectPrivRuleAll";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal SelectPrivRuleAllDataTable(DataTable table)
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
      protected SelectPrivRuleAllDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public void AddSelectPrivRuleAllRow(EPivRuleStatusDataSet.SelectPrivRuleAllRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public EPivRuleStatusDataSet.SelectPrivRuleAllRow AddSelectPrivRuleAllRow(string ID, string Name, string Code, string Valid, string ValidDesc, string IsUsed, string IsUsedDesc, string PrivRuleTypeDR, string PrivRuleTypeDesc)
      {
        EPivRuleStatusDataSet.SelectPrivRuleAllRow selectPrivRuleAllRow = (EPivRuleStatusDataSet.SelectPrivRuleAllRow) this.NewRow();
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
        selectPrivRuleAllRow.ItemArray = objArray;
        this.Rows.Add((DataRow) selectPrivRuleAllRow);
        return selectPrivRuleAllRow;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator()
      {
        return this.Rows.GetEnumerator();
      }

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        EPivRuleStatusDataSet.SelectPrivRuleAllDataTable ruleAllDataTable = (EPivRuleStatusDataSet.SelectPrivRuleAllDataTable) base.Clone();
        ruleAllDataTable.InitVars();
        return (DataTable) ruleAllDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new EPivRuleStatusDataSet.SelectPrivRuleAllDataTable();
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
      public EPivRuleStatusDataSet.SelectPrivRuleAllRow NewSelectPrivRuleAllRow()
      {
        return (EPivRuleStatusDataSet.SelectPrivRuleAllRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new EPivRuleStatusDataSet.SelectPrivRuleAllRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType()
      {
        return typeof (EPivRuleStatusDataSet.SelectPrivRuleAllRow);
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.SelectPrivRuleAllRowChangedEvent == null)
          return;
        EPivRuleStatusDataSet.SelectPrivRuleAllRowChangeEventHandler allRowChangedEvent = this.SelectPrivRuleAllRowChangedEvent;
        if (allRowChangedEvent == null)
          return;
        allRowChangedEvent((object) this, new EPivRuleStatusDataSet.SelectPrivRuleAllRowChangeEvent((EPivRuleStatusDataSet.SelectPrivRuleAllRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.SelectPrivRuleAllRowChangingEvent == null)
          return;
        EPivRuleStatusDataSet.SelectPrivRuleAllRowChangeEventHandler rowChangingEvent = this.SelectPrivRuleAllRowChangingEvent;
        if (rowChangingEvent == null)
          return;
        rowChangingEvent((object) this, new EPivRuleStatusDataSet.SelectPrivRuleAllRowChangeEvent((EPivRuleStatusDataSet.SelectPrivRuleAllRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.SelectPrivRuleAllRowDeletedEvent == null)
          return;
        EPivRuleStatusDataSet.SelectPrivRuleAllRowChangeEventHandler allRowDeletedEvent = this.SelectPrivRuleAllRowDeletedEvent;
        if (allRowDeletedEvent == null)
          return;
        allRowDeletedEvent((object) this, new EPivRuleStatusDataSet.SelectPrivRuleAllRowChangeEvent((EPivRuleStatusDataSet.SelectPrivRuleAllRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.SelectPrivRuleAllRowDeletingEvent == null)
          return;
        EPivRuleStatusDataSet.SelectPrivRuleAllRowChangeEventHandler rowDeletingEvent = this.SelectPrivRuleAllRowDeletingEvent;
        if (rowDeletingEvent == null)
          return;
        rowDeletingEvent((object) this, new EPivRuleStatusDataSet.SelectPrivRuleAllRowChangeEvent((EPivRuleStatusDataSet.SelectPrivRuleAllRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveSelectPrivRuleAllRow(EPivRuleStatusDataSet.SelectPrivRuleAllRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        EPivRuleStatusDataSet ruleStatusDataSet = new EPivRuleStatusDataSet();
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
          FixedValue = ruleStatusDataSet.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "SelectPrivRuleAllDataTable"
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = ruleStatusDataSet.GetSchemaSerializable();
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
    public class SelectPrivRuleAllRow : DataRow
    {
      private EPivRuleStatusDataSet.SelectPrivRuleAllDataTable tableSelectPrivRuleAll;

      [DebuggerNonUserCode]
      public string ID
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleAll.IDColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleAll\"中列\"ID\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleAll.IDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string Name
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleAll.NameColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleAll\"中列\"Name\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleAll.NameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string Code
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleAll.CodeColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleAll\"中列\"Code\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleAll.CodeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string Valid
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleAll.ValidColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleAll\"中列\"Valid\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleAll.ValidColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string ValidDesc
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleAll.ValidDescColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleAll\"中列\"ValidDesc\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleAll.ValidDescColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string IsUsed
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleAll.IsUsedColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleAll\"中列\"IsUsed\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleAll.IsUsedColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string IsUsedDesc
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleAll.IsUsedDescColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleAll\"中列\"IsUsedDesc\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleAll.IsUsedDescColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string PrivRuleTypeDR
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleAll.PrivRuleTypeDRColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleAll\"中列\"PrivRuleTypeDR\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleAll.PrivRuleTypeDRColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string PrivRuleTypeDesc
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectPrivRuleAll.PrivRuleTypeDescColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectPrivRuleAll\"中列\"PrivRuleTypeDesc\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectPrivRuleAll.PrivRuleTypeDescColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      internal SelectPrivRuleAllRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSelectPrivRuleAll = (EPivRuleStatusDataSet.SelectPrivRuleAllDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public bool IsIDNull()
      {
        return this.IsNull(this.tableSelectPrivRuleAll.IDColumn);
      }

      [DebuggerNonUserCode]
      public void SetIDNull()
      {
        this[this.tableSelectPrivRuleAll.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsNameNull()
      {
        return this.IsNull(this.tableSelectPrivRuleAll.NameColumn);
      }

      [DebuggerNonUserCode]
      public void SetNameNull()
      {
        this[this.tableSelectPrivRuleAll.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsCodeNull()
      {
        return this.IsNull(this.tableSelectPrivRuleAll.CodeColumn);
      }

      [DebuggerNonUserCode]
      public void SetCodeNull()
      {
        this[this.tableSelectPrivRuleAll.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsValidNull()
      {
        return this.IsNull(this.tableSelectPrivRuleAll.ValidColumn);
      }

      [DebuggerNonUserCode]
      public void SetValidNull()
      {
        this[this.tableSelectPrivRuleAll.ValidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsValidDescNull()
      {
        return this.IsNull(this.tableSelectPrivRuleAll.ValidDescColumn);
      }

      [DebuggerNonUserCode]
      public void SetValidDescNull()
      {
        this[this.tableSelectPrivRuleAll.ValidDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsIsUsedNull()
      {
        return this.IsNull(this.tableSelectPrivRuleAll.IsUsedColumn);
      }

      [DebuggerNonUserCode]
      public void SetIsUsedNull()
      {
        this[this.tableSelectPrivRuleAll.IsUsedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsIsUsedDescNull()
      {
        return this.IsNull(this.tableSelectPrivRuleAll.IsUsedDescColumn);
      }

      [DebuggerNonUserCode]
      public void SetIsUsedDescNull()
      {
        this[this.tableSelectPrivRuleAll.IsUsedDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsPrivRuleTypeDRNull()
      {
        return this.IsNull(this.tableSelectPrivRuleAll.PrivRuleTypeDRColumn);
      }

      [DebuggerNonUserCode]
      public void SetPrivRuleTypeDRNull()
      {
        this[this.tableSelectPrivRuleAll.PrivRuleTypeDRColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsPrivRuleTypeDescNull()
      {
        return this.IsNull(this.tableSelectPrivRuleAll.PrivRuleTypeDescColumn);
      }

      [DebuggerNonUserCode]
      public void SetPrivRuleTypeDescNull()
      {
        this[this.tableSelectPrivRuleAll.PrivRuleTypeDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SelectPrivRuleAllRowChangeEvent : EventArgs
    {
      private EPivRuleStatusDataSet.SelectPrivRuleAllRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public EPivRuleStatusDataSet.SelectPrivRuleAllRow Row
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
      public SelectPrivRuleAllRowChangeEvent(EPivRuleStatusDataSet.SelectPrivRuleAllRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }
  }
}
