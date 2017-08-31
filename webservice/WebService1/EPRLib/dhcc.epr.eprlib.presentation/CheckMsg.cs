using System;
using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace dhcc.epr.eprlib.presentation
{
	public class CheckMsg
	{
		private ECheckType _CheckType;

		private string _ErrorDesc;

		private Hashtable _RelatedElements;

		private object _RelatedObject;

		public static Color ErrorColor
		{
			get
			{
				return Color.Red;
			}
		}

		public ECheckType CheckType
		{
			get
			{
				return this._CheckType;
			}
			set
			{
				this._CheckType = value;
			}
		}

		public string ErrorType
		{
			get
			{
				if (this._CheckType == ECheckType.Formula)
				{
					return "公式错误";
				}
				if (this._CheckType == ECheckType.Null)
				{
					return "不能为空";
				}
				if (this._CheckType == ECheckType.Special)
				{
					return "专项检查";
				}
				return null;
			}
			set
			{
			}
		}

		public string ErrorDesc
		{
			get
			{
				return this._ErrorDesc;
			}
			set
			{
				this._ErrorDesc = value;
			}
		}

		public Hashtable RelatedElements
		{
			get
			{
				return this._RelatedElements;
			}
			set
			{
				this._RelatedElements = value;
			}
		}

		public object RelatedObject
		{
			get
			{
				return this._RelatedObject;
			}
			set
			{
				this._RelatedObject = RuntimeHelpers.GetObjectValue(value);
			}
		}

		public CheckMsg()
		{
			this._RelatedElements = new Hashtable();
		}
	}
}
