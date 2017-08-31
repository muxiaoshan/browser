using dhcc.epr.eprlib.dataaccess;
using dhcc.epr.systemframework;
using InterfaceTemplateData;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.design.printlink
{
	public class TemplateList : ListBox
	{
		private IContainer components;

		private string _CategoryID;

		private string _TemplateID;

		private string _TemplateName;

		private string _EpisodeID;

		private ETempForSltDataset ds;

		public string CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if (value.Equals(string.Empty))
				{
					Interaction.MsgBox("模板CategoryID不能为空。", MsgBoxStyle.OkOnly, null);
					return;
				}
				this._CategoryID = value;
				this.InitAfterPropertiesSet();
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

		public string EpisodeID
		{
			get
			{
				return this._EpisodeID;
			}
			set
			{
				if (value.Equals(string.Empty))
				{
					Interaction.MsgBox("病人EpisodeID不能为空。", MsgBoxStyle.OkOnly, null);
					return;
				}
				this._EpisodeID = value;
				this.InitAfterPropertiesSet();
			}
		}

		public TemplateList()
		{
			base.SelectedIndexChanged += new EventHandler(this.TemplateList_SelectedIndexChanged);
			this._CategoryID = "";
			this._TemplateID = "";
			this._TemplateName = "";
			this._EpisodeID = "";
			this.InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		private void initTemplateList()
		{
			checked
			{
				try
				{
					this.ds = WebServiceLayer.InterfaceTemplateAccess.GetTemplateAllForSlt(this._CategoryID, this._EpisodeID);
					int arg_35_0 = 0;
					int num = this.ds.SelectForSltByCId.Rows.Count - 1;
					for (int i = arg_35_0; i <= num; i++)
					{
						this.Items.Add(RuntimeHelpers.GetObjectValue(this.ds.SelectForSltByCId.Rows[i][this.ds.SelectForSltByCId.NameColumn.ColumnName]));
					}
				}
				catch (Exception expr_83)
				{
					ProjectData.SetProjectError(expr_83);
					Exception ex = expr_83;
					MessageManager.ShowErrorMessage(ex.Message + ex.StackTrace);
					ProjectData.ClearProjectError();
				}
			}
		}

		private void InitAfterPropertiesSet()
		{
			if (this.CategoryID != null)
			{
				if (this.CategoryID.Equals(string.Empty))
				{
					return;
				}
				if (this.EpisodeID != null)
				{
					if (this.EpisodeID.Equals(string.Empty))
					{
						return;
					}
					this.initTemplateList();
					if (this.Items.Count > 0)
					{
						this.SelectedIndex = 0;
					}
				}
			}
		}

		private void TemplateList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.SelectedIndex > -1)
			{
				this._TemplateID = Conversions.ToString(this.ds.SelectForSltByCId.Rows[this.SelectedIndex][this.ds.SelectForSltByCId.IDColumn.ColumnName]);
				this._TemplateName = Conversions.ToString(this.ds.SelectForSltByCId.Rows[this.SelectedIndex][this.ds.SelectForSltByCId.NameColumn.ColumnName]);
			}
		}
	}
}
