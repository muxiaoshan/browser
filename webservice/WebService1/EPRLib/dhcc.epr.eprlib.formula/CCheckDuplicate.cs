using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CCheckDuplicate : CFunction
	{
		private ArrayList m_alValues;

		[DebuggerNonUserCode]
		public CCheckDuplicate()
		{
		}

		public override CFunction CreateInstance(ArrayList alValues)
		{
			CCheckDuplicate cCheckDuplicate = new CCheckDuplicate();
			cCheckDuplicate.SetParameters(alValues);
			return cCheckDuplicate;
		}

		public override void SetParameters(ArrayList alValues)
		{
			this.CheckParms(alValues, 2, 50);
			this.m_alValues = alValues;
		}

		public override string GetValue()
		{
			int count = this.m_alValues.Count;
			ArrayList arrayList = new ArrayList();
			int arg_18_0 = 1;
			int num = count;
			checked
			{
				for (int i = arg_18_0; i <= num; i++)
				{
					CValue cValue = (CValue)this.m_alValues[i - 1];
					if (i > 1)
					{
						int arg_39_0 = 1;
						int num2 = i - 1;
						for (int j = arg_39_0; j <= num2; j++)
						{
							CValue cValue2 = (CValue)arrayList[j - 1];
							if (cValue2.GetValue().Equals(cValue.GetValue()))
							{
								return "false";
							}
						}
					}
					arrayList.Add((CValue)this.m_alValues[i - 1]);
				}
				return "true";
			}
		}

		public override string GetFunction()
		{
			return "duplicate";
		}
	}
}
