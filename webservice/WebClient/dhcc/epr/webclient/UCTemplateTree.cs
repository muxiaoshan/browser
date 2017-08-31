// Decompiled with JetBrains decompiler
// Type: dhcc.epr.webclient.UCTemplateTree
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
  public class UCTemplateTree : UserControl
  {
    private IContainer components;
    [AccessedThroughProperty("TemplateTree")]
    private TemplateTree _TemplateTree;
    private string _TemplateID;
    private string _TemplateName;

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

    public string TemplateID
    {
      get
      {
        return this._TemplateID;
      }
      set
      {
        this._TemplateID = value;
      }
    }

    public string TemplateName
    {
      get
      {
        return this._TemplateName;
      }
      set
      {
        this._TemplateName = value;
      }
    }

    public UCTemplateTree()
    {
      this._TemplateID = "";
      this._TemplateName = "";
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
      this.Name = "UCTemplateTree";
      this.Size = new Size(250, 300);
    }

    public void Init()
    {
      this.TemplateTree = new TemplateTree((TemplateTree.ShowLevel) 2);
      this.TemplateTree.Init();
      ((Control) this.TemplateTree).Dock = DockStyle.Fill;
      this.Controls.Add((Control) this.TemplateTree);
    }

    private void TemplateTree_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (((TreeView) this.TemplateTree).SelectedNode == null)
        return;
      if (Operators.CompareString(this.TemplateTree.GetNodeType(((TreeView) this.TemplateTree).SelectedNode), "LF", false) == 0)
      {
        this._TemplateID = this.TemplateTree.GetNodeId(((TreeView) this.TemplateTree).SelectedNode);
        this._TemplateName = ((TreeView) this.TemplateTree).SelectedNode.Text;
      }
      else
      {
        this._TemplateID = "";
        this._TemplateName = "";
      }
    }
  }
}
