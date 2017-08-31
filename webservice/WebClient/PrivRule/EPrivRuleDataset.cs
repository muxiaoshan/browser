// Decompiled with JetBrains decompiler
// Type: PrivRule.EPrivRuleDataset
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [HelpKeyword("vs.data.DataSet")]
  [XmlRoot("EPrivRuleDataset")]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [ToolboxItem(true)]
  [DesignerCategory("code")]
  [Serializable]
  public class EPrivRuleDataset : DataSet
  {
    private EPrivRuleDataset.SelectAllDataTable tableSelectAll;
    private SchemaSerializationMode _schemaSerializationMode;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    public EPrivRuleDataset.SelectAllDataTable SelectAll
    {
      get
      {
        return this.tableSelectAll;
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
    public EPrivRuleDataset()
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
    protected EPrivRuleDataset(SerializationInfo info, StreamingContext context)
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
            base.Tables.Add((DataTable) new EPrivRuleDataset.SelectAllDataTable(dataSet.Tables["SelectAll"]));
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
      EPrivRuleDataset eprivRuleDataset = (EPrivRuleDataset) base.Clone();
      eprivRuleDataset.InitVars();
      eprivRuleDataset.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) eprivRuleDataset;
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
          base.Tables.Add((DataTable) new EPrivRuleDataset.SelectAllDataTable(dataSet.Tables["SelectAll"]));
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
      this.tableSelectAll = (EPrivRuleDataset.SelectAllDataTable) base.Tables["SelectAll"];
      if (!initTable || this.tableSelectAll == null)
        return;
      this.tableSelectAll.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = "EPrivRuleDataset";
      this.Prefix = "";
      this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EPrivRuleDataset";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableSelectAll = new EPrivRuleDataset.SelectAllDataTable();
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
      EPrivRuleDataset eprivRuleDataset = new EPrivRuleDataset();
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
      {
        Items = {
          (XmlSchemaObject) new XmlSchemaAny()
          {
            Namespace = eprivRuleDataset.Namespace
          }
        }
      };
      XmlSchema schemaSerializable = eprivRuleDataset.GetSchemaSerializable();
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

    public delegate void SelectAllRowChangeEventHandler(object sender, EPrivRuleDataset.SelectAllRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class SelectAllDataTable : DataTable, IEnumerable
    {
      private DataColumn columnID;
      private DataColumn columnName;
      private DataColumn columnCode;
      private DataColumn columnValid;
      private DataColumn columnPrivRuleTypeDR;

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
      public DataColumn PrivRuleTypeDRColumn
      {
        get
        {
          return this.columnPrivRuleTypeDR;
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
      public EPrivRuleDataset.SelectAllRow this[int index]
      {
        get
        {
          return (EPrivRuleDataset.SelectAllRow) this.Rows[index];
        }
      }

      public event EPrivRuleDataset.SelectAllRowChangeEventHandler SelectAllRowChanging;

      public event EPrivRuleDataset.SelectAllRowChangeEventHandler SelectAllRowChanged;

      public event EPrivRuleDataset.SelectAllRowChangeEventHandler SelectAllRowDeleting;

      public event EPrivRuleDataset.SelectAllRowChangeEventHandler SelectAllRowDeleted;

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
      public void AddSelectAllRow(EPrivRuleDataset.SelectAllRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public EPrivRuleDataset.SelectAllRow AddSelectAllRow(string ID, string Name, string Code, string Valid, string PrivRuleTypeDR)
      {
        EPrivRuleDataset.SelectAllRow selectAllRow = (EPrivRuleDataset.SelectAllRow) this.NewRow();
        object[] objArray = new object[5]
        {
          (object) ID,
          (object) Name,
          (object) Code,
          (object) Valid,
          (object) PrivRuleTypeDR
        };
        selectAllRow.ItemArray = objArray;
        this.Rows.Add((DataRow) selectAllRow);
        return selectAllRow;
      }

      [DebuggerNonUserCode]
      public EPrivRuleDataset.SelectAllRow FindByID(string ID)
      {
        return (EPrivRuleDataset.SelectAllRow) this.Rows.Find(new object[1]
        {
          (object) ID
        });
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator()
      {
        return this.Rows.GetEnumerator();
      }

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        EPrivRuleDataset.SelectAllDataTable selectAllDataTable = (EPrivRuleDataset.SelectAllDataTable) base.Clone();
        selectAllDataTable.InitVars();
        return (DataTable) selectAllDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new EPrivRuleDataset.SelectAllDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnName = this.Columns["Name"];
        this.columnCode = this.Columns["Code"];
        this.columnValid = this.Columns["Valid"];
        this.columnPrivRuleTypeDR = this.Columns["PrivRuleTypeDR"];
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
        this.columnPrivRuleTypeDR = new DataColumn("PrivRuleTypeDR", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnPrivRuleTypeDR);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnID
        }, true));
        this.columnID.AllowDBNull = false;
        this.columnID.Unique = true;
        this.Namespace = "";
      }

      [DebuggerNonUserCode]
      public EPrivRuleDataset.SelectAllRow NewSelectAllRow()
      {
        return (EPrivRuleDataset.SelectAllRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new EPrivRuleDataset.SelectAllRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType()
      {
        return typeof (EPrivRuleDataset.SelectAllRow);
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.SelectAllRowChangedEvent == null)
          return;
        EPrivRuleDataset.SelectAllRowChangeEventHandler allRowChangedEvent = this.SelectAllRowChangedEvent;
        if (allRowChangedEvent == null)
          return;
        allRowChangedEvent((object) this, new EPrivRuleDataset.SelectAllRowChangeEvent((EPrivRuleDataset.SelectAllRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.SelectAllRowChangingEvent == null)
          return;
        EPrivRuleDataset.SelectAllRowChangeEventHandler rowChangingEvent = this.SelectAllRowChangingEvent;
        if (rowChangingEvent == null)
          return;
        rowChangingEvent((object) this, new EPrivRuleDataset.SelectAllRowChangeEvent((EPrivRuleDataset.SelectAllRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.SelectAllRowDeletedEvent == null)
          return;
        EPrivRuleDataset.SelectAllRowChangeEventHandler allRowDeletedEvent = this.SelectAllRowDeletedEvent;
        if (allRowDeletedEvent == null)
          return;
        allRowDeletedEvent((object) this, new EPrivRuleDataset.SelectAllRowChangeEvent((EPrivRuleDataset.SelectAllRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.SelectAllRowDeletingEvent == null)
          return;
        EPrivRuleDataset.SelectAllRowChangeEventHandler rowDeletingEvent = this.SelectAllRowDeletingEvent;
        if (rowDeletingEvent == null)
          return;
        rowDeletingEvent((object) this, new EPrivRuleDataset.SelectAllRowChangeEvent((EPrivRuleDataset.SelectAllRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveSelectAllRow(EPrivRuleDataset.SelectAllRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        EPrivRuleDataset eprivRuleDataset = new EPrivRuleDataset();
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
          FixedValue = eprivRuleDataset.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "SelectAllDataTable"
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = eprivRuleDataset.GetSchemaSerializable();
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
      private EPrivRuleDataset.SelectAllDataTable tableSelectAll;

      [DebuggerNonUserCode]
      public string ID
      {
        get
        {
          return Conversions.ToString(this[this.tableSelectAll.IDColumn]);
        }
        set
        {
          this[this.tableSelectAll.IDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string Name
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectAll.NameColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectAll\"中列\"Name\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectAll.NameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string Code
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectAll.CodeColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectAll\"中列\"Code\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectAll.CodeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string Valid
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectAll.ValidColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectAll\"中列\"Valid\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectAll.ValidColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string PrivRuleTypeDR
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSelectAll.PrivRuleTypeDRColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SelectAll\"中列\"PrivRuleTypeDR\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSelectAll.PrivRuleTypeDRColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      internal SelectAllRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSelectAll = (EPrivRuleDataset.SelectAllDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public bool IsNameNull()
      {
        return this.IsNull(this.tableSelectAll.NameColumn);
      }

      [DebuggerNonUserCode]
      public void SetNameNull()
      {
        this[this.tableSelectAll.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsCodeNull()
      {
        return this.IsNull(this.tableSelectAll.CodeColumn);
      }

      [DebuggerNonUserCode]
      public void SetCodeNull()
      {
        this[this.tableSelectAll.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsValidNull()
      {
        return this.IsNull(this.tableSelectAll.ValidColumn);
      }

      [DebuggerNonUserCode]
      public void SetValidNull()
      {
        this[this.tableSelectAll.ValidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsPrivRuleTypeDRNull()
      {
        return this.IsNull(this.tableSelectAll.PrivRuleTypeDRColumn);
      }

      [DebuggerNonUserCode]
      public void SetPrivRuleTypeDRNull()
      {
        this[this.tableSelectAll.PrivRuleTypeDRColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SelectAllRowChangeEvent : EventArgs
    {
      private EPrivRuleDataset.SelectAllRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public EPrivRuleDataset.SelectAllRow Row
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
      public SelectAllRowChangeEvent(EPrivRuleDataset.SelectAllRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }
  }
}
