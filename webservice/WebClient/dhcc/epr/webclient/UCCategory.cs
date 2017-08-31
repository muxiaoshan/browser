// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.UCCategory
// Assembly: WebClient, Version=2012.3.9.13, Culture=neutral, PublicKeyToken=b0f069a1fbc17dc8
// MVID: 7F524E30-59BB-45BA-A07F-589D0C7B7906
// Assembly location: D:\qqLog\375715707\FileRecv\WebClient.dll

using dhcc.epr.eprlib.design.printlink;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.webclient
{
  public class UCCategory : UserControl
  {
    private IContainer components;
    [AccessedThroughProperty("TemplateTree")]
    private TemplateTree _TemplateTree;
    private string _CategoryID;
    private string _CategoryName;
    private string _CategoryType;
    private string _CategoryProperty;

    private virtual TemplateTree TemplateTree
    {
      [DebuggerNonUserCode] get
      {
        return this._TemplateTree;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        TreeViewEventHandler viewEventHandler = new TreeViewEventHandler(this.TemplateTree_AfterSelect);
        if (this._TemplateTree != null)
          ((TreeView) this._TemplateTree).AfterSelect -= viewEventHandler;
        this._TemplateTree = value;
        if (this._TemplateTree == null)
          return;
        ((TreeView) this._TemplateTree).AfterSelect += viewEventHandler;
      }
    }

    public string CategoryID
    {
      get
      {
        return this._CategoryID;
      }
      set
      {
        this._CategoryID = value;
      }
    }

    public string CategoryName
    {
      get
      {
        return this._CategoryName;
      }
      set
      {
        this._CategoryName = value;
      }
    }

    public string CategoryType
    {
      get
      {
        return this._CategoryType;
      }
      set
      {
        this._CategoryType = value;
      }
    }

    public string CategoryProperty
    {
      get
      {
        return this._CategoryProperty;
      }
      set
      {
        this._CategoryProperty = value;
      }
    }

    public UCCategory()
    {
      this._CategoryID = "";
      this._CategoryName = "";
      this._CategoryType = "";
      this._CategoryProperty = "";
      this.InitializeComponent();
      this.Init();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.Name = "UCCategory";
      this.Size = new Size(250, 300);
    }

    public void Init()
    {
      this.TemplateTree = new TemplateTree((TemplateTree.ShowLevel) 1);
      this.TemplateTree.Init();
      ((Control) this.TemplateTree).Dock = DockStyle.Fill;
      this.Controls.Add((Control) this.TemplateTree);
    }

    private void TemplateTree_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (((TreeView) this.TemplateTree).SelectedNode == null)
        return;
      if (Operators.CompareString(this.TemplateTree.GetNodeType(((TreeView) this.TemplateTree).SelectedNode), "CG", false) == 0)
      {
        this._CategoryID = this.TemplateTree.GetNodeId(((TreeView) this.TemplateTree).SelectedNode);
        this._CategoryProperty = this.TemplateTree.GetNodeProperty(((TreeView) this.TemplateTree).SelectedNode);
        this._CategoryType = this.TemplateTree.GetNodeCategoryType(((TreeView) this.TemplateTree).SelectedNode);
        this._CategoryName = ((TreeView) this.TemplateTree).SelectedNode.Text;
      }
      else
      {
        this._CategoryID = "";
        this._CategoryProperty = "";
        this._CategoryType = "";
        this._CategoryName = "";
      }
    }
  }
}
