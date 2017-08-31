// Decompiled with JetBrains decompiler
// Type: SysOption.ESysOptionDataset
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

namespace SysOption
{
  [XmlRoot("ESysOptionDataset")]
  [DesignerCategory("code")]
  [HelpKeyword("vs.data.DataSet")]
  [ToolboxItem(true)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [Serializable]
  public class ESysOptionDataset : DataSet
  {
    private ESysOptionDataset.SELECTALLDataTable tableSELECTALL;
    private SchemaSerializationMode _schemaSerializationMode;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public ESysOptionDataset.SELECTALLDataTable SELECTALL
    {
      get
      {
        return this.tableSELECTALL;
      }
    }

    [Browsable(true)]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
    public ESysOptionDataset()
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
    protected ESysOptionDataset(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables["SELECTALL"] != null)
            base.Tables.Add((DataTable) new ESysOptionDataset.SELECTALLDataTable(dataSet.Tables["SELECTALL"]));
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
      ESysOptionDataset esysOptionDataset = (ESysOptionDataset) base.Clone();
      esysOptionDataset.InitVars();
      esysOptionDataset.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) esysOptionDataset;
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
        if (dataSet.Tables["SELECTALL"] != null)
          base.Tables.Add((DataTable) new ESysOptionDataset.SELECTALLDataTable(dataSet.Tables["SELECTALL"]));
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
      this.tableSELECTALL = (ESysOptionDataset.SELECTALLDataTable) base.Tables["SELECTALL"];
      if (!initTable || this.tableSELECTALL == null)
        return;
      this.tableSELECTALL.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = "ESysOptionDataset";
      this.Prefix = "";
      this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/ESysOptionDataset";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableSELECTALL = new ESysOptionDataset.SELECTALLDataTable();
      base.Tables.Add((DataTable) this.tableSELECTALL);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeSELECTALL()
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
      ESysOptionDataset esysOptionDataset = new ESysOptionDataset();
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
      {
        Items = {
          (XmlSchemaObject) new XmlSchemaAny()
          {
            Namespace = esysOptionDataset.Namespace
          }
        }
      };
      XmlSchema schemaSerializable = esysOptionDataset.GetSchemaSerializable();
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

    public delegate void SELECTALLRowChangeEventHandler(object sender, ESysOptionDataset.SELECTALLRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class SELECTALLDataTable : DataTable, IEnumerable
    {
      private DataColumn columnID;
      private DataColumn columnName;
      private DataColumn columnOptionValue;
      private DataColumn columnDescription;

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
      public DataColumn OptionValueColumn
      {
        get
        {
          return this.columnOptionValue;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn DescriptionColumn
      {
        get
        {
          return this.columnDescription;
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
      public ESysOptionDataset.SELECTALLRow this[int index]
      {
        get
        {
          return (ESysOptionDataset.SELECTALLRow) this.Rows[index];
        }
      }

      public event ESysOptionDataset.SELECTALLRowChangeEventHandler SELECTALLRowChanging;

      public event ESysOptionDataset.SELECTALLRowChangeEventHandler SELECTALLRowChanged;

      public event ESysOptionDataset.SELECTALLRowChangeEventHandler SELECTALLRowDeleting;

      public event ESysOptionDataset.SELECTALLRowChangeEventHandler SELECTALLRowDeleted;

      [DebuggerNonUserCode]
      public SELECTALLDataTable()
      {
        this.TableName = "SELECTALL";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal SELECTALLDataTable(DataTable table)
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
      protected SELECTALLDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public void AddSELECTALLRow(ESysOptionDataset.SELECTALLRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public ESysOptionDataset.SELECTALLRow AddSELECTALLRow(long ID, string Name, string OptionValue, string Description)
      {
        ESysOptionDataset.SELECTALLRow selectallRow = (ESysOptionDataset.SELECTALLRow) this.NewRow();
        object[] objArray = new object[4]
        {
          (object) ID,
          (object) Name,
          (object) OptionValue,
          (object) Description
        };
        selectallRow.ItemArray = objArray;
        this.Rows.Add((DataRow) selectallRow);
        return selectallRow;
      }

      [DebuggerNonUserCode]
      public ESysOptionDataset.SELECTALLRow FindByID(long ID)
      {
        return (ESysOptionDataset.SELECTALLRow) this.Rows.Find(new object[1]
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
        ESysOptionDataset.SELECTALLDataTable selectallDataTable = (ESysOptionDataset.SELECTALLDataTable) base.Clone();
        selectallDataTable.InitVars();
        return (DataTable) selectallDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new ESysOptionDataset.SELECTALLDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnName = this.Columns["Name"];
        this.columnOptionValue = this.Columns["OptionValue"];
        this.columnDescription = this.Columns["Description"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (long), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnName);
        this.columnOptionValue = new DataColumn("OptionValue", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnOptionValue);
        this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescription);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnID
        }, true));
        this.columnID.AllowDBNull = false;
        this.columnID.Unique = true;
        this.Namespace = "";
      }

      [DebuggerNonUserCode]
      public ESysOptionDataset.SELECTALLRow NewSELECTALLRow()
      {
        return (ESysOptionDataset.SELECTALLRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new ESysOptionDataset.SELECTALLRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType()
      {
        return typeof (ESysOptionDataset.SELECTALLRow);
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.SELECTALLRowChangedEvent == null)
          return;
        ESysOptionDataset.SELECTALLRowChangeEventHandler selectallRowChangedEvent = this.SELECTALLRowChangedEvent;
        if (selectallRowChangedEvent == null)
          return;
        selectallRowChangedEvent((object) this, new ESysOptionDataset.SELECTALLRowChangeEvent((ESysOptionDataset.SELECTALLRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.SELECTALLRowChangingEvent == null)
          return;
        ESysOptionDataset.SELECTALLRowChangeEventHandler rowChangingEvent = this.SELECTALLRowChangingEvent;
        if (rowChangingEvent == null)
          return;
        rowChangingEvent((object) this, new ESysOptionDataset.SELECTALLRowChangeEvent((ESysOptionDataset.SELECTALLRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.SELECTALLRowDeletedEvent == null)
          return;
        ESysOptionDataset.SELECTALLRowChangeEventHandler selectallRowDeletedEvent = this.SELECTALLRowDeletedEvent;
        if (selectallRowDeletedEvent == null)
          return;
        selectallRowDeletedEvent((object) this, new ESysOptionDataset.SELECTALLRowChangeEvent((ESysOptionDataset.SELECTALLRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.SELECTALLRowDeletingEvent == null)
          return;
        ESysOptionDataset.SELECTALLRowChangeEventHandler rowDeletingEvent = this.SELECTALLRowDeletingEvent;
        if (rowDeletingEvent == null)
          return;
        rowDeletingEvent((object) this, new ESysOptionDataset.SELECTALLRowChangeEvent((ESysOptionDataset.SELECTALLRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveSELECTALLRow(ESysOptionDataset.SELECTALLRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        ESysOptionDataset esysOptionDataset = new ESysOptionDataset();
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
          FixedValue = esysOptionDataset.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "SELECTALLDataTable"
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = esysOptionDataset.GetSchemaSerializable();
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
    public class SELECTALLRow : DataRow
    {
      private ESysOptionDataset.SELECTALLDataTable tableSELECTALL;

      [DebuggerNonUserCode]
      public long ID
      {
        get
        {
          return Conversions.ToLong(this[this.tableSELECTALL.IDColumn]);
        }
        set
        {
          this[this.tableSELECTALL.IDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string Name
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSELECTALL.NameColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SELECTALL\"中列\"Name\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSELECTALL.NameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string OptionValue
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSELECTALL.OptionValueColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SELECTALL\"中列\"OptionValue\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSELECTALL.OptionValueColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string Description
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSELECTALL.DescriptionColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SELECTALL\"中列\"Description\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSELECTALL.DescriptionColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      internal SELECTALLRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSELECTALL = (ESysOptionDataset.SELECTALLDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public bool IsNameNull()
      {
        return this.IsNull(this.tableSELECTALL.NameColumn);
      }

      [DebuggerNonUserCode]
      public void SetNameNull()
      {
        this[this.tableSELECTALL.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsOptionValueNull()
      {
        return this.IsNull(this.tableSELECTALL.OptionValueColumn);
      }

      [DebuggerNonUserCode]
      public void SetOptionValueNull()
      {
        this[this.tableSELECTALL.OptionValueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsDescriptionNull()
      {
        return this.IsNull(this.tableSELECTALL.DescriptionColumn);
      }

      [DebuggerNonUserCode]
      public void SetDescriptionNull()
      {
        this[this.tableSELECTALL.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SELECTALLRowChangeEvent : EventArgs
    {
      private ESysOptionDataset.SELECTALLRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public ESysOptionDataset.SELECTALLRow Row
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
      public SELECTALLRowChangeEvent(ESysOptionDataset.SELECTALLRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }
  }
}
