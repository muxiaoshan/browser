// Decompiled with JetBrains decompiler
// Type: BOCustomDictory.EDiagnosTypeByTitle
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

namespace BOCustomDictory
{
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [HelpKeyword("vs.data.DataSet")]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [DesignerCategory("code")]
  [XmlRoot("EDiagnosTypeByTitle")]
  [ToolboxItem(true)]
  [Serializable]
  public class EDiagnosTypeByTitle : DataSet
  {
    private EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable tableGetDiagnosTypeByTitle;
    private SchemaSerializationMode _schemaSerializationMode;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable GetDiagnosTypeByTitle
    {
      get
      {
        return this.tableGetDiagnosTypeByTitle;
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
    public EDiagnosTypeByTitle()
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
    protected EDiagnosTypeByTitle(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables["GetDiagnosTypeByTitle"] != null)
            base.Tables.Add((DataTable) new EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable(dataSet.Tables["GetDiagnosTypeByTitle"]));
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
      EDiagnosTypeByTitle ediagnosTypeByTitle = (EDiagnosTypeByTitle) base.Clone();
      ediagnosTypeByTitle.InitVars();
      ediagnosTypeByTitle.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) ediagnosTypeByTitle;
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
        if (dataSet.Tables["GetDiagnosTypeByTitle"] != null)
          base.Tables.Add((DataTable) new EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable(dataSet.Tables["GetDiagnosTypeByTitle"]));
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
      this.tableGetDiagnosTypeByTitle = (EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable) base.Tables["GetDiagnosTypeByTitle"];
      if (!initTable || this.tableGetDiagnosTypeByTitle == null)
        return;
      this.tableGetDiagnosTypeByTitle.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = "EDiagnosTypeByTitle";
      this.Prefix = "";
      this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/EMRDiagnosDataSet";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableGetDiagnosTypeByTitle = new EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable();
      base.Tables.Add((DataTable) this.tableGetDiagnosTypeByTitle);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeGetDiagnosTypeByTitle()
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
      EDiagnosTypeByTitle ediagnosTypeByTitle = new EDiagnosTypeByTitle();
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
      {
        Items = {
          (XmlSchemaObject) new XmlSchemaAny()
          {
            Namespace = ediagnosTypeByTitle.Namespace
          }
        }
      };
      XmlSchema schemaSerializable = ediagnosTypeByTitle.GetSchemaSerializable();
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

    public delegate void GetDiagnosTypeByTitleRowChangeEventHandler(object sender, EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class GetDiagnosTypeByTitleDataTable : DataTable, IEnumerable
    {
      private DataColumn columnADiagnosTypeID;
      private DataColumn columnATitleName;

      [DebuggerNonUserCode]
      public DataColumn ADiagnosTypeIDColumn
      {
        get
        {
          return this.columnADiagnosTypeID;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn ATitleNameColumn
      {
        get
        {
          return this.columnATitleName;
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
      public EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow this[int index]
      {
        get
        {
          return (EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow) this.Rows[index];
        }
      }

      public event EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler GetDiagnosTypeByTitleRowChanging;

      public event EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler GetDiagnosTypeByTitleRowChanged;

      public event EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler GetDiagnosTypeByTitleRowDeleting;

      public event EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler GetDiagnosTypeByTitleRowDeleted;

      [DebuggerNonUserCode]
      public GetDiagnosTypeByTitleDataTable()
      {
        this.TableName = "GetDiagnosTypeByTitle";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal GetDiagnosTypeByTitleDataTable(DataTable table)
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
      protected GetDiagnosTypeByTitleDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public void AddGetDiagnosTypeByTitleRow(EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow AddGetDiagnosTypeByTitleRow(string ADiagnosTypeID, string ATitleName)
      {
        EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow diagnosTypeByTitleRow = (EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow) this.NewRow();
        object[] objArray = new object[2]
        {
          (object) ADiagnosTypeID,
          (object) ATitleName
        };
        diagnosTypeByTitleRow.ItemArray = objArray;
        this.Rows.Add((DataRow) diagnosTypeByTitleRow);
        return diagnosTypeByTitleRow;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator()
      {
        return this.Rows.GetEnumerator();
      }

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable byTitleDataTable = (EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable) base.Clone();
        byTitleDataTable.InitVars();
        return (DataTable) byTitleDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnADiagnosTypeID = this.Columns["ADiagnosTypeID"];
        this.columnATitleName = this.Columns["ATitleName"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnADiagnosTypeID = new DataColumn("ADiagnosTypeID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnADiagnosTypeID);
        this.columnATitleName = new DataColumn("ATitleName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnATitleName);
        this.Namespace = "";
      }

      [DebuggerNonUserCode]
      public EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow NewGetDiagnosTypeByTitleRow()
      {
        return (EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType()
      {
        return typeof (EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow);
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.GetDiagnosTypeByTitleRowChangedEvent == null)
          return;
        EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler titleRowChangedEvent = this.GetDiagnosTypeByTitleRowChangedEvent;
        if (titleRowChangedEvent == null)
          return;
        titleRowChangedEvent((object) this, new EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEvent((EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.GetDiagnosTypeByTitleRowChangingEvent == null)
          return;
        EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler rowChangingEvent = this.GetDiagnosTypeByTitleRowChangingEvent;
        if (rowChangingEvent == null)
          return;
        rowChangingEvent((object) this, new EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEvent((EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.GetDiagnosTypeByTitleRowDeletedEvent == null)
          return;
        EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler titleRowDeletedEvent = this.GetDiagnosTypeByTitleRowDeletedEvent;
        if (titleRowDeletedEvent == null)
          return;
        titleRowDeletedEvent((object) this, new EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEvent((EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.GetDiagnosTypeByTitleRowDeletingEvent == null)
          return;
        EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEventHandler rowDeletingEvent = this.GetDiagnosTypeByTitleRowDeletingEvent;
        if (rowDeletingEvent == null)
          return;
        rowDeletingEvent((object) this, new EDiagnosTypeByTitle.GetDiagnosTypeByTitleRowChangeEvent((EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveGetDiagnosTypeByTitleRow(EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        EDiagnosTypeByTitle ediagnosTypeByTitle = new EDiagnosTypeByTitle();
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
          FixedValue = ediagnosTypeByTitle.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "GetDiagnosTypeByTitleDataTable"
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = ediagnosTypeByTitle.GetSchemaSerializable();
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
    public class GetDiagnosTypeByTitleRow : DataRow
    {
      private EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable tableGetDiagnosTypeByTitle;

      [DebuggerNonUserCode]
      public string ADiagnosTypeID
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableGetDiagnosTypeByTitle.ADiagnosTypeIDColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"GetDiagnosTypeByTitle\"中列\"ADiagnosTypeID\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableGetDiagnosTypeByTitle.ADiagnosTypeIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string ATitleName
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableGetDiagnosTypeByTitle.ATitleNameColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"GetDiagnosTypeByTitle\"中列\"ATitleName\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableGetDiagnosTypeByTitle.ATitleNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      internal GetDiagnosTypeByTitleRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableGetDiagnosTypeByTitle = (EDiagnosTypeByTitle.GetDiagnosTypeByTitleDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public bool IsADiagnosTypeIDNull()
      {
        return this.IsNull(this.tableGetDiagnosTypeByTitle.ADiagnosTypeIDColumn);
      }

      [DebuggerNonUserCode]
      public void SetADiagnosTypeIDNull()
      {
        this[this.tableGetDiagnosTypeByTitle.ADiagnosTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsATitleNameNull()
      {
        return this.IsNull(this.tableGetDiagnosTypeByTitle.ATitleNameColumn);
      }

      [DebuggerNonUserCode]
      public void SetATitleNameNull()
      {
        this[this.tableGetDiagnosTypeByTitle.ATitleNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class GetDiagnosTypeByTitleRowChangeEvent : EventArgs
    {
      private EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow Row
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
      public GetDiagnosTypeByTitleRowChangeEvent(EDiagnosTypeByTitle.GetDiagnosTypeByTitleRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }
  }
}
