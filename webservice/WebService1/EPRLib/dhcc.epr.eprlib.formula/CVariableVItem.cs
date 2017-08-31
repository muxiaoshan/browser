using dhcc.epr.eprlib.instancedata;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace dhcc.epr.eprlib.formula
{
	public class CVariableVItem : CVariable
	{
		public CVariableVItem(string strTID, string strCode, string strVType, string admid) : base(strTID, strCode, strVType, admid)
		{
		}

		public CVariableVItem(string strCode, string strVType, NInstanceItem item) : base(strCode, strVType, item)
		{
		}

		public override string GetValue()
		{
			if (Operators.CompareString(this._ItemVType, "ItemSgIsAbNormal", false) == 0)
			{
				return ((NISegment)this._BindNInstanceItem).IsAbNormal.ToString().ToLower();
			}
			if (Operators.CompareString(this._ItemVType, "ItemSgAbNormal", false) == 0)
			{
				return "ItemSgABNormal";
			}
			if (Operators.CompareString(this._ItemVType, "ItemSgNormal", false) == 0)
			{
				return "ItemSgNormal";
			}
			throw new AppException(string.Format("{0}单元：{1}，值类型：{2}。", "错误的公式系统值类型。", this.ItemCode, this.ItemVType));
		}

		public override void SetValue(string strValue)
		{
			if (Operators.CompareString(this._ItemVType, "ItemSg", false) == 0)
			{
				if (!(this._BindNInstanceItem is NISegment))
				{
					throw new AppException("公式系统中值类型与单元不匹配。" + this._ItemVType);
				}
				if (Operators.CompareString(strValue, "ItemSgAbNormal", false) == 0)
				{
					((NISegment)this._BindNInstanceItem).SwitchToAbNormalValue();
				}
				if (Operators.CompareString(strValue, "ItemSgNormal", false) == 0)
				{
					((NISegment)this._BindNInstanceItem).SwitchToNormalValue();
				}
				return;
			}
			else
			{
				if (Operators.CompareString(this._ItemVType, "ItemSgIsAbNormal", false) == 0)
				{
					throw new AppException(string.Format("{0}单元：{1}，值类型：{2}。", "只读的公式系统值类型。", this.ItemCode, this.ItemVType));
				}
				if (Operators.CompareString(this._ItemVType, "ItemSgAbNormal", false) == 0)
				{
					throw new AppException(string.Format("{0}单元：{1}，值类型：{2}。", "只读的公式系统值类型。", this.ItemCode, this.ItemVType));
				}
				if (Operators.CompareString(this._ItemVType, "ItemSgNormal", false) == 0)
				{
					throw new AppException(string.Format("{0}单元：{1}，值类型：{2}。", "只读的公式系统值类型。", this.ItemCode, this.ItemVType));
				}
				throw new AppException(string.Format("{0}单元：{1}，值类型：{2}。", "错误的公式系统值类型。", this.ItemCode, this.ItemVType));
			}
		}
	}
}
