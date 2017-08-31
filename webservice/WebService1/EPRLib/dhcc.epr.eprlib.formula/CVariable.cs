using dhcc.epr.eprlib.instancedata;
using System;

namespace dhcc.epr.eprlib.formula
{
	public class CVariable : CValue
	{
		protected string _TemplateID;

		protected string _ItemCode;

		protected string _ItemVType;

		protected string _admid;

		protected NInstanceItem _BindNInstanceItem;

		public string ItemCode
		{
			get
			{
				return this._ItemCode;
			}
			set
			{
				this._ItemCode = value;
			}
		}

		public string ItemVType
		{
			get
			{
				return this._ItemVType;
			}
			set
			{
				this._ItemVType = value;
			}
		}

		public NInstanceItem BindNInstanceItem
		{
			get
			{
				return this._BindNInstanceItem;
			}
			set
			{
				this._BindNInstanceItem = value;
			}
		}

		public CVariable(string strTID, string strCode, string strVType, string admid)
		{
		}

		public CVariable(string strCode, string strVType, NInstanceItem item)
		{
			this._ItemCode = strCode;
			this._ItemVType = strVType;
			this._BindNInstanceItem = item;
		}

		public override string GetValue()
		{
			return this._BindNInstanceItem.GetByVType(this._ItemVType);
		}

		public override void SetValue(string strValue)
		{
			this._BindNInstanceItem.SetByVType(strValue, this._ItemVType);
		}
	}
}
