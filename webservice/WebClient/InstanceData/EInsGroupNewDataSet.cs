// Decompiled with JetBrains decompiler
// Type: InstanceData.EInsGroupNewDataSet
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

namespace InstanceData
{
  [HelpKeyword("vs.data.DataSet")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [XmlRoot("EInsGroupNewDataSet")]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [ToolboxItem(true)]
  [DesignerCategory("code")]
  [Serializable]
  public class EInsGroupNewDataSet : DataSet
  {
    private EInsGroupNewDataSet.SELECTGroupListNewDataTable tableSELECTGroupListNew;
    private SchemaSerializationMode _schemaSerializationMode;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public EInsGroupNewDataSet.SELECTGroupListNewDataTable SELECTGroupListNew
    {
      get
      {
        return this.tableSELECTGroupListNew;
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
    public EInsGroupNewDataSet()
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
    protected EInsGroupNewDataSet(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables["SELECTGroupListNew"] != null)
            base.Tables.Add((DataTable) new EInsGroupNewDataSet.SELECTGroupListNewDataTable(dataSet.Tables["SELECTGroupListNew"]));
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
      EInsGroupNewDataSet einsGroupNewDataSet = (EInsGroupNewDataSet) base.Clone();
      einsGroupNewDataSet.InitVars();
      einsGroupNewDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) einsGroupNewDataSet;
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
        if (dataSet.Tables["SELECTGroupListNew"] != null)
          base.Tables.Add((DataTable) new EInsGroupNewDataSet.SELECTGroupListNewDataTable(dataSet.Tables["SELECTGroupListNew"]));
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
      this.tableSELECTGroupListNew = (EInsGroupNewDataSet.SELECTGroupListNewDataTable) base.Tables["SELECTGroupListNew"];
      if (!initTable || this.tableSELECTGroupListNew == null)
        return;
      this.tableSELECTGroupListNew.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = "EInsGroupNewDataSet";
      this.Prefix = "";
      this.Namespace = "http://www.dhcc.com.cn/epr/metaservice/SELECTGroupListNew";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableSELECTGroupListNew = new EInsGroupNewDataSet.SELECTGroupListNewDataTable();
      base.Tables.Add((DataTable) this.tableSELECTGroupListNew);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeSELECTGroupListNew()
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
      EInsGroupNewDataSet einsGroupNewDataSet = new EInsGroupNewDataSet();
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
      {
        Items = {
          (XmlSchemaObject) new XmlSchemaAny()
          {
            Namespace = einsGroupNewDataSet.Namespace
          }
        }
      };
      XmlSchema schemaSerializable = einsGroupNewDataSet.GetSchemaSerializable();
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

    public delegate void SELECTGroupListNewRowChangeEventHandler(object sender, EInsGroupNewDataSet.SELECTGroupListNewRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class SELECTGroupListNewDataTable : DataTable, IEnumerable
    {
      private DataColumn columnID;
      private DataColumn columnGroupItemName;
      private DataColumn columnGroupItemID;
      private DataColumn columnItemStatus;

      [DebuggerNonUserCode]
      public DataColumn IDColumn
      {
        get
        {
          return this.columnID;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn GroupItemNameColumn
      {
        get
        {
          return this.columnGroupItemName;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn GroupItemIDColumn
      {
        get
        {
          return this.columnGroupItemID;
        }
      }

      [DebuggerNonUserCode]
      public DataColumn ItemStatusColumn
      {
        get
        {
          return this.columnItemStatus;
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
      public EInsGroupNewDataSet.SELECTGroupListNewRow this[int index]
      {
        get
        {
          return (EInsGroupNewDataSet.SELECTGroupListNewRow) this.Rows[index];
        }
      }

      public event EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler SELECTGroupListNewRowChanging;

      public event EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler SELECTGroupListNewRowChanged;

      public event EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler SELECTGroupListNewRowDeleting;

      public event EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler SELECTGroupListNewRowDeleted;

      [DebuggerNonUserCode]
      public SELECTGroupListNewDataTable()
      {
        this.TableName = "SELECTGroupListNew";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal SELECTGroupListNewDataTable(DataTable table)
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
      protected SELECTGroupListNewDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public void AddSELECTGroupListNewRow(EInsGroupNewDataSet.SELECTGroupListNewRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      public EInsGroupNewDataSet.SELECTGroupListNewRow AddSELECTGroupListNewRow(string ID, string GroupItemName, string GroupItemID, string ItemStatus)
      {
        EInsGroupNewDataSet.SELECTGroupListNewRow selectGroupListNewRow = (EInsGroupNewDataSet.SELECTGroupListNewRow) this.NewRow();
        object[] objArray = new object[4]
        {
          (object) ID,
          (object) GroupItemName,
          (object) GroupItemID,
          (object) ItemStatus
        };
        selectGroupListNewRow.ItemArray = objArray;
        this.Rows.Add((DataRow) selectGroupListNewRow);
        return selectGroupListNewRow;
      }

      [DebuggerNonUserCode]
      public virtual IEnumerator GetEnumerator()
      {
        return this.Rows.GetEnumerator();
      }

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        EInsGroupNewDataSet.SELECTGroupListNewDataTable listNewDataTable = (EInsGroupNewDataSet.SELECTGroupListNewDataTable) base.Clone();
        listNewDataTable.InitVars();
        return (DataTable) listNewDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new EInsGroupNewDataSet.SELECTGroupListNewDataTable();
      }

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnID = this.Columns["ID"];
        this.columnGroupItemName = this.Columns["GroupItemName"];
        this.columnGroupItemID = this.Columns["GroupItemID"];
        this.columnItemStatus = this.Columns["ItemStatus"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnID = new DataColumn("ID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnID);
        this.columnGroupItemName = new DataColumn("GroupItemName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGroupItemName);
        this.columnGroupItemID = new DataColumn("GroupItemID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGroupItemID);
        this.columnItemStatus = new DataColumn("ItemStatus", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnItemStatus);
        this.Namespace = "";
      }

      [DebuggerNonUserCode]
      public EInsGroupNewDataSet.SELECTGroupListNewRow NewSELECTGroupListNewRow()
      {
        return (EInsGroupNewDataSet.SELECTGroupListNewRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new EInsGroupNewDataSet.SELECTGroupListNewRow(builder);
      }

      [DebuggerNonUserCode]
      protected override Type GetRowType()
      {
        return typeof (EInsGroupNewDataSet.SELECTGroupListNewRow);
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.SELECTGroupListNewRowChangedEvent == null)
          return;
        EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler newRowChangedEvent = this.SELECTGroupListNewRowChangedEvent;
        if (newRowChangedEvent == null)
          return;
        newRowChangedEvent((object) this, new EInsGroupNewDataSet.SELECTGroupListNewRowChangeEvent((EInsGroupNewDataSet.SELECTGroupListNewRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.SELECTGroupListNewRowChangingEvent == null)
          return;
        EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler rowChangingEvent = this.SELECTGroupListNewRowChangingEvent;
        if (rowChangingEvent == null)
          return;
        rowChangingEvent((object) this, new EInsGroupNewDataSet.SELECTGroupListNewRowChangeEvent((EInsGroupNewDataSet.SELECTGroupListNewRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.SELECTGroupListNewRowDeletedEvent == null)
          return;
        EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler newRowDeletedEvent = this.SELECTGroupListNewRowDeletedEvent;
        if (newRowDeletedEvent == null)
          return;
        newRowDeletedEvent((object) this, new EInsGroupNewDataSet.SELECTGroupListNewRowChangeEvent((EInsGroupNewDataSet.SELECTGroupListNewRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.SELECTGroupListNewRowDeletingEvent == null)
          return;
        EInsGroupNewDataSet.SELECTGroupListNewRowChangeEventHandler rowDeletingEvent = this.SELECTGroupListNewRowDeletingEvent;
        if (rowDeletingEvent == null)
          return;
        rowDeletingEvent((object) this, new EInsGroupNewDataSet.SELECTGroupListNewRowChangeEvent((EInsGroupNewDataSet.SELECTGroupListNewRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveSELECTGroupListNewRow(EInsGroupNewDataSet.SELECTGroupListNewRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        EInsGroupNewDataSet einsGroupNewDataSet = new EInsGroupNewDataSet();
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
          FixedValue = einsGroupNewDataSet.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "SELECTGroupListNewDataTable"
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = einsGroupNewDataSet.GetSchemaSerializable();
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
    public class SELECTGroupListNewRow : DataRow
    {
      private EInsGroupNewDataSet.SELECTGroupListNewDataTable tableSELECTGroupListNew;

      [DebuggerNonUserCode]
      public string ID
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSELECTGroupListNew.IDColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SELECTGroupListNew\"中列\"ID\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSELECTGroupListNew.IDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string GroupItemName
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSELECTGroupListNew.GroupItemNameColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SELECTGroupListNew\"中列\"GroupItemName\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSELECTGroupListNew.GroupItemNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string GroupItemID
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSELECTGroupListNew.GroupItemIDColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SELECTGroupListNew\"中列\"GroupItemID\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSELECTGroupListNew.GroupItemIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      public string ItemStatus
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tableSELECTGroupListNew.ItemStatusColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("表\"SELECTGroupListNew\"中列\"ItemStatus\"的值为 DBNull。", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSELECTGroupListNew.ItemStatusColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      internal SELECTGroupListNewRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSELECTGroupListNew = (EInsGroupNewDataSet.SELECTGroupListNewDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public bool IsIDNull()
      {
        return this.IsNull(this.tableSELECTGroupListNew.IDColumn);
      }

      [DebuggerNonUserCode]
      public void SetIDNull()
      {
        this[this.tableSELECTGroupListNew.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsGroupItemNameNull()
      {
        return this.IsNull(this.tableSELECTGroupListNew.GroupItemNameColumn);
      }

      [DebuggerNonUserCode]
      public void SetGroupItemNameNull()
      {
        this[this.tableSELECTGroupListNew.GroupItemNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsGroupItemIDNull()
      {
        return this.IsNull(this.tableSELECTGroupListNew.GroupItemIDColumn);
      }

      [DebuggerNonUserCode]
      public void SetGroupItemIDNull()
      {
        this[this.tableSELECTGroupListNew.GroupItemIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }

      [DebuggerNonUserCode]
      public bool IsItemStatusNull()
      {
        return this.IsNull(this.tableSELECTGroupListNew.ItemStatusColumn);
      }

      [DebuggerNonUserCode]
      public void SetItemStatusNull()
      {
        this[this.tableSELECTGroupListNew.ItemStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SELECTGroupListNewRowChangeEvent : EventArgs
    {
      private EInsGroupNewDataSet.SELECTGroupListNewRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public EInsGroupNewDataSet.SELECTGroupListNewRow Row
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
      public SELECTGroupListNewRowChangeEvent(EInsGroupNewDataSet.SELECTGroupListNewRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }
  }
}
