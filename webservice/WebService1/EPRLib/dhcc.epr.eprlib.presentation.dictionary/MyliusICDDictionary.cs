using dhcc.epr.eprlib.instancedata;
using dhcc.epr.eprlib.metadata;
using dhcc.epr.systemframework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace dhcc.epr.eprlib.presentation.dictionary
{
	public class MyliusICDDictionary : IDictionary
	{
		[DebuggerNonUserCode]
		public MyliusICDDictionary()
		{
		}

		public DicContent GetDicContent(MIDictionary midic, Point screenPoint, NISimple niDic, string strQuery, string strCondition)
		{
			DicContent dicContent = null;
			try
			{
				string text = "";
				string text2 = "";
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("mycos.mycosgui", ""));
				NewLateBinding.LateCall(objectValue, null, "ActiveGUI", new object[0], null, null, null, true);
				object arg_77_0 = objectValue;
				Type arg_77_1 = null;
				string arg_77_2 = "GetGraphDiagText";
				object[] array = new object[]
				{
					0,
					text2
				};
				object[] arg_77_3 = array;
				string[] arg_77_4 = null;
				Type[] arg_77_5 = null;
				bool[] array2 = new bool[]
				{
					false,
					true
				};
				NewLateBinding.LateCall(arg_77_0, arg_77_1, arg_77_2, arg_77_3, arg_77_4, arg_77_5, array2, true);
				if (array2[1])
				{
					text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
				}
				object arg_DD_0 = objectValue;
				Type arg_DD_1 = null;
				string arg_DD_2 = "GetGraphDiagCode";
				object[] array3 = new object[]
				{
					0,
					text
				};
				object[] arg_DD_3 = array3;
				string[] arg_DD_4 = null;
				Type[] arg_DD_5 = null;
				array2 = new bool[]
				{
					false,
					true
				};
				NewLateBinding.LateCall(arg_DD_0, arg_DD_1, arg_DD_2, arg_DD_3, arg_DD_4, arg_DD_5, array2, true);
				if (array2[1])
				{
					text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(string));
				}
				dicContent = new DicContent();
				dicContent.Code = text;
				dicContent.Description = text2;
			}
			catch (Exception expr_120)
			{
				ProjectData.SetProjectError(expr_120);
				MessageManager.ShowErrorMessage("三维图形调用失败，请与开发人员联系");
				ProjectData.ClearProjectError();
			}
			return dicContent;
		}
	}
}
