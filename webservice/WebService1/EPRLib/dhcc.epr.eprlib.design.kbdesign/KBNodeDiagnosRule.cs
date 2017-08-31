using dhcc.epr.eprlib.dataaccess;
using DictionaryData;
using KBDiagnos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace dhcc.epr.eprlib.design.kbdesign
{
	public struct KBNodeDiagnosRule
	{
		public string DiagnosID;

		public string KBNodeDiagnosID;

		public Dictionary<string, List<DictionaryEntry>> DiagnosRulePairs;

		public override string ToString()
		{
			string text = string.Empty;
			checked
			{
				if (!string.IsNullOrEmpty(this.DiagnosID))
				{
					EKBDiagnos diagnosByID = WebServiceLayer.KBDiagnosAccess.GetDiagnosByID(this.DiagnosID);
					if (diagnosByID != null)
					{
						text = diagnosByID.Description;
						if (this.DiagnosRulePairs != null && this.DiagnosRulePairs.Count > 0)
						{
							try
							{
								Dictionary<string, List<DictionaryEntry>>.KeyCollection.Enumerator enumerator = this.DiagnosRulePairs.Keys.GetEnumerator();
								while (enumerator.MoveNext())
								{
									string current = enumerator.Current;
									List<DictionaryEntry> list = this.DiagnosRulePairs[current];
									EStdDictionary stdDicitonaryByID = WebServiceLayer.DictionaryAccess.GetStdDicitonaryByID(current);
									string description = stdDicitonaryByID.Description;
									string text2 = string.Empty;
									int arg_A8_0 = 0;
									int num = list.Count - 1;
									for (int i = arg_A8_0; i <= num; i++)
									{
										DictionaryEntry dictionaryEntry = list[i];
										if (i > 0)
										{
											text2 += " + ";
										}
										text2 += string.Format("{0}.{1}", description, RuntimeHelpers.GetObjectValue(dictionaryEntry.Value));
									}
									if (!string.IsNullOrEmpty(text2))
									{
										text += string.Format(" + {0}", text2);
									}
								}
							}
							finally
							{
								Dictionary<string, List<DictionaryEntry>>.KeyCollection.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
					}
				}
				return text;
			}
		}
	}
}
