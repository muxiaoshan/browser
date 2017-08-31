using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.formula
{
	public class CDateDiff : CFunction
	{
		private ArrayList m_alValues;

		[DebuggerNonUserCode]
		public CDateDiff()
		{
		}

		public override CFunction CreateInstance(ArrayList alValues)
		{
			CDateDiff cDateDiff = new CDateDiff();
			cDateDiff.SetParameters(alValues);
			return cDateDiff;
		}

		public override void SetParameters(ArrayList alValues)
		{
			this.CheckParms(alValues, 3);
			this.m_alValues = alValues;
		}

		public override string GetValue()
		{
			checked
			{
				string result;
				try
				{
					string value = ((CValue)this.m_alValues[0]).GetValue();
					string value2 = ((CValue)this.m_alValues[1]).GetValue();
					if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(value2))
					{
						result = string.Empty;
					}
					else
					{
						DateTime value3 = DateTime.Parse(value);
						DateTime dateTime = DateTime.Parse(value2);
						string value4 = ((CValue)this.m_alValues[2]).GetValue();
						TimeSpan timeSpan = dateTime.Subtract(value3);
						if (!string.IsNullOrEmpty(value4))
						{
							string[] array = value4.Split(new char[]
							{
								','
							});
							string[] array2 = array;
							for (int i = 0; i < array2.Length; i++)
							{
								string text = array2[i];
								string[] array3 = text.Split(new char[]
								{
									':'
								});
								if (array3.Length == 2 && timeSpan.Days == int.Parse(array3[0]))
								{
									result = array3[1];
									return result;
								}
							}
						}
						result = timeSpan.Days.ToString();
					}
				}
				catch (FormatException expr_10B)
				{
					ProjectData.SetProjectError(expr_10B);
					throw new Exception("日期格式错误");
				}
				catch (ArgumentNullException expr_11E)
				{
					ProjectData.SetProjectError(expr_11E);
					throw new Exception("日期格式错误");
				}
				return result;
			}
		}

		public override string GetFunction()
		{
			return "datediff";
		}
	}
}
