using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;

namespace dhcc.epr.eprlib.design.printdesign
{
	public class FigureLogicBase
	{
		[DebuggerNonUserCode]
		public FigureLogicBase()
		{
		}

		public void InsertRows(Hashtable figureUnitHash, string exceptUnitName, int startRow, int rowCount)
		{
			checked
			{
				try
				{
					IEnumerator enumerator = figureUnitHash.Keys.GetEnumerator();
					while (enumerator.MoveNext())
					{
						string text = Conversions.ToString(enumerator.Current);
						if (Operators.CompareString(text, exceptUnitName, false) != 0)
						{
							FigureUnit figureUnit = (FigureUnit)figureUnitHash[text];
							try
							{
								IEnumerator enumerator2 = figureUnit.RangeItems.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									FigureRange figureRange = (FigureRange)enumerator2.Current;
									if (figureRange.StartRow > startRow)
									{
										figureRange.StartRow += rowCount;
									}
									else
									{
										if (figureRange.ContainPicture && figureRange.PictureRow >= startRow)
										{
											figureRange.PictureRow += rowCount;
										}
										if (figureRange.ContainDesc && figureRange.DescRow >= startRow)
										{
											figureRange.DescRow += rowCount;
										}
									}
									if (figureRange.EndRow >= startRow)
									{
										figureRange.EndRow += rowCount;
									}
								}
							}
							finally
							{
								IEnumerator enumerator2;
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
							figureUnit.ReArrange();
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		public void DeleteRows(Hashtable figureUnitHash, string exceptUnitName, int startRow, int rowCount)
		{
			checked
			{
				try
				{
					IEnumerator enumerator = figureUnitHash.Keys.GetEnumerator();
					while (enumerator.MoveNext())
					{
						string text = Conversions.ToString(enumerator.Current);
						if (Operators.CompareString(text, exceptUnitName, false) != 0)
						{
							FigureUnit figureUnit = (FigureUnit)figureUnitHash[text];
							try
							{
								IEnumerator enumerator2 = figureUnit.RangeItems.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									FigureRange figureRange = (FigureRange)enumerator2.Current;
									if (figureRange.StartRow > startRow)
									{
										figureRange.StartRow -= rowCount;
									}
									else
									{
										if (figureRange.ContainPicture && figureRange.PictureRow > startRow)
										{
											figureRange.PictureRow -= rowCount;
										}
										if (figureRange.ContainDesc && figureRange.DescRow > startRow)
										{
											figureRange.DescRow -= rowCount;
										}
									}
									if (figureRange.EndRow >= startRow)
									{
										figureRange.EndRow -= rowCount;
									}
								}
							}
							finally
							{
								IEnumerator enumerator2;
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
							figureUnit.ReArrange();
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		public void InsertRows(Hashtable figureUnitHash, ArrayList figureRangesList, int startRow, int rowCount)
		{
			checked
			{
				try
				{
					IEnumerator enumerator = figureRangesList.GetEnumerator();
					while (enumerator.MoveNext())
					{
						FigureRange figureRange = (FigureRange)enumerator.Current;
						if (figureRange.StartRow > startRow)
						{
							figureRange.StartRow += rowCount;
						}
						else
						{
							if (figureRange.ContainPicture && figureRange.PictureRow >= startRow)
							{
								figureRange.PictureRow += rowCount;
							}
							if (figureRange.ContainDesc && figureRange.DescRow >= startRow)
							{
								figureRange.DescRow += rowCount;
							}
						}
						if (figureRange.EndRow >= startRow)
						{
							figureRange.EndRow += rowCount;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				try
				{
					IEnumerator enumerator2 = figureUnitHash.Keys.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						string key = Conversions.ToString(enumerator2.Current);
						FigureUnit figureUnit = (FigureUnit)figureUnitHash[key];
						figureUnit.ReArrange();
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
		}

		public void DeleteRows(Hashtable figureUnitHash, ArrayList figureRangesList, int startRow, int rowCount)
		{
			checked
			{
				try
				{
					IEnumerator enumerator = figureRangesList.GetEnumerator();
					while (enumerator.MoveNext())
					{
						FigureRange figureRange = (FigureRange)enumerator.Current;
						if (figureRange.StartRow > startRow)
						{
							figureRange.StartRow -= rowCount;
						}
						else
						{
							if (figureRange.ContainPicture && figureRange.PictureRow >= startRow)
							{
								figureRange.PictureRow -= rowCount;
							}
							if (figureRange.ContainDesc && figureRange.DescRow >= startRow)
							{
								figureRange.DescRow -= rowCount;
							}
						}
						if (figureRange.EndRow >= startRow)
						{
							figureRange.EndRow -= rowCount;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				try
				{
					IEnumerator enumerator2 = figureUnitHash.Keys.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						string key = Conversions.ToString(enumerator2.Current);
						FigureUnit figureUnit = (FigureUnit)figureUnitHash[key];
						figureUnit.ReArrange();
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
		}

		public void InsertColumns(Hashtable figureUnitHash, ArrayList figureRangesList, int startColumn, int columnCount)
		{
			checked
			{
				try
				{
					IEnumerator enumerator = figureRangesList.GetEnumerator();
					while (enumerator.MoveNext())
					{
						FigureRange figureRange = (FigureRange)enumerator.Current;
						if (figureRange.StartColumn > startColumn)
						{
							figureRange.StartColumn += columnCount;
						}
						else
						{
							if (figureRange.ContainPicture && figureRange.PictureColumn >= startColumn)
							{
								figureRange.PictureColumn += columnCount;
							}
							if (figureRange.ContainDesc && figureRange.DescColumn >= startColumn)
							{
								figureRange.DescColumn += columnCount;
							}
						}
						if (figureRange.EndColumn >= startColumn)
						{
							figureRange.EndColumn += columnCount;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				try
				{
					IEnumerator enumerator2 = figureUnitHash.Keys.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						string key = Conversions.ToString(enumerator2.Current);
						FigureUnit figureUnit = (FigureUnit)figureUnitHash[key];
						figureUnit.ReArrange();
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
		}

		public void DeleteColumns(Hashtable figureUnitHash, ArrayList figureRangesList, int startColumn, int columnCount)
		{
			checked
			{
				try
				{
					IEnumerator enumerator = figureRangesList.GetEnumerator();
					while (enumerator.MoveNext())
					{
						FigureRange figureRange = (FigureRange)enumerator.Current;
						if (figureRange.StartColumn > startColumn)
						{
							figureRange.StartColumn -= columnCount;
						}
						else
						{
							if (figureRange.ContainPicture && figureRange.PictureColumn >= startColumn)
							{
								figureRange.PictureColumn -= columnCount;
							}
							if (figureRange.ContainDesc && figureRange.DescColumn >= startColumn)
							{
								figureRange.DescColumn -= columnCount;
							}
						}
						if (figureRange.EndColumn >= startColumn)
						{
							figureRange.EndColumn -= columnCount;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				try
				{
					IEnumerator enumerator2 = figureUnitHash.Keys.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						string key = Conversions.ToString(enumerator2.Current);
						FigureUnit figureUnit = (FigureUnit)figureUnitHash[key];
						figureUnit.ReArrange();
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
		}

		public string GetFigureUnitName(string unitTag)
		{
			int num = unitTag.IndexOf("#TID:");
			int num2 = unitTag.IndexOf("#VTYPE:");
			string result;
			if (num < 0 | num2 < 0)
			{
				result = "";
			}
			else
			{
				result = unitTag.Substring(num, checked(num2 - num));
			}
			return result;
		}

		protected string GetFigureRangeName()
		{
			DateTime dateTime = default(DateTime);
			return "FigureRange-" + DateTime.Now.ToString();
		}

		public string GetFigureMetaType(string unitTag)
		{
			int num = unitTag.IndexOf("#VTYPE:");
			string text = unitTag.Substring(checked(num + 7), 1);
			if (Operators.CompareString(text, "C", false) != 0)
			{
				text = "V";
			}
			return text;
		}
	}
}
