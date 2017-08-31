using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.previewmanage
{
	public class UCImageLoader : UserControl
	{
		private const char CHAR_SHARP = '#';

		private const char CHAR_ARROW = '^';

		private const char CHAR_DOLLAR = '$';

		private const char CHAR_SLASH = '/';

		private const char CHAR_BACKSLASH = '\\';

		private Container components;

		public UCImageLoader()
		{
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

		private void InitializeComponent()
		{
			this.components = new Container();
		}

		public string GetPreviewImage(string patientID, string episodeID, string eprLogsIDs, int startIndex, int endIndex)
		{
			string result = "";
			string optionValue = OptionManager.GetOptionValue("SavePrintImage", "");
			string[] array = optionValue.Split(new char[]
			{
				'^'
			});
			if (array.Length != 6)
			{
				return result;
			}
			if (patientID == "" || episodeID == "" || eprLogsIDs == "" || startIndex.ToString() == "" || endIndex.ToString() == "")
			{
				return result;
			}
			if (eprLogsIDs.Split(new char[]
			{
				'$'
			}).Length != 2 || eprLogsIDs.Split(new char[]
			{
				'$'
			})[0] == "0")
			{
				return result;
			}
			ArrayList arrFile = this.FilterImages(patientID, episodeID, eprLogsIDs.Split(new char[]
			{
				'$'
			})[1], startIndex, endIndex);
			FTPFactory fTPFactory;
			try
			{
				string remoteHost = array[1];
				string port = array[2];
				string remoteUser = array[3];
				string remotePass = array[4];
				string delayTime = array[5];
				fTPFactory = new FTPFactory(remoteHost, port, remoteUser, remotePass, delayTime);
				fTPFactory.login();
			}
			catch (Exception ex)
			{
				MessageBox.Show("获取病历图片错误！\r\n" + ex.Message + "\r\n" + ex.StackTrace);
				return result;
			}
			try
			{
				result = this.GetImages(arrFile, ref fTPFactory);
			}
			catch (Exception ex2)
			{
				MessageBox.Show("获取病历图片错误！\r\n" + ex2.Message + "\r\n" + ex2.StackTrace);
			}
			try
			{
				fTPFactory.close();
			}
			catch (Exception ex3)
			{
				MessageBox.Show("关闭FTP连接错误！" + ex3.Message + ex3.StackTrace);
			}
			return result;
		}

		private ArrayList FilterImages(string patId, string episodeId, string logsIDs, int startIndex, int endIndex)
		{
			ArrayList arrayList = new ArrayList();
			int num = endIndex - startIndex + 1;
			if (num <= 0)
			{
				return arrayList;
			}
			string environmentVariable = Environment.GetEnvironmentVariable("Temp");
			string a = "";
			int num2 = 0;
			string[] array = logsIDs.Split(new char[]
			{
				'#'
			});
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Split(new char[]
				{
					'^'
				})[0];
				string text2 = array[i].Split(new char[]
				{
					'^'
				})[1];
				string a2 = array[i].Split(new char[]
				{
					'^'
				})[2];
				int num3 = Convert.ToInt32(array[i].Split(new char[]
				{
					'^'
				})[3]);
				string a3 = array[i].Split(new char[]
				{
					'^'
				})[4];
				if (a != text && a2 == "M" && a3 == "1")
				{
					string text3 = text + ".gif";
					string remotePath = this.GetRemotePath(patId, episodeId, text3, string.Empty, "M");
					string str = string.Concat(new object[]
					{
						environmentVariable,
						'\\',
						patId,
						"-",
						episodeId,
						"-title-",
						text3
					});
					arrayList.Add(str + "^" + remotePath);
				}
				a = text;
				for (int j = 1; j <= num3; j++)
				{
					num2++;
					if (num2 >= startIndex && num2 <= endIndex)
					{
						string text3 = j.ToString() + ".gif";
						string remotePath = this.GetRemotePath(patId, episodeId, text3, text2, string.Empty);
						string str = string.Concat(new object[]
						{
							environmentVariable,
							'\\',
							patId,
							"-",
							episodeId,
							"-",
							text2,
							"-",
							text3
						});
						arrayList.Add(str + "^" + remotePath);
					}
					else if (num2 > endIndex)
					{
						break;
					}
				}
				if (num2 > endIndex)
				{
					return arrayList;
				}
			}
			return arrayList;
		}

		private string GetRemotePath(string patId, string episodeId, string imageFile, string logsId, string type)
		{
			string result = string.Empty;
			int num = (int)Math.Truncate(Convert.ToInt32(patId) / 10000m);
			num++;
			if (type == "M")
			{
				result = string.Concat(new object[]
				{
					"dhcepr/vol",
					num,
					"/",
					patId,
					'/',
					episodeId,
					'/',
					"title",
					'/',
					imageFile
				});
			}
			else
			{
				result = string.Concat(new object[]
				{
					"dhcepr/vol",
					num,
					"/",
					patId,
					'/',
					episodeId,
					'/',
					logsId,
					'/',
					imageFile
				});
			}
			return result;
		}

		private string GetImages(ArrayList arrFile, ref FTPFactory ff)
		{
			string text = "";
			if (arrFile.Count == 0)
			{
				return text;
			}
			try
			{
				for (int i = 0; i < arrFile.Count; i++)
				{
					string[] array = Convert.ToString(arrFile[i]).ToString().Split(new char[]
					{
						'^'
					});
					string remFileName = array[1];
					string text2 = array[0];
					try
					{
						ff.download(remFileName, text2);
						text = text + "^" + text2;
					}
					catch (Exception ex)
					{
						text += "^";
						ex.Message + "\r\n" + ex.StackTrace;
					}
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("从FTP获取图片失败！\r\n" + ex2.Message + "\r\n" + ex2.StackTrace);
			}
			if (text != "")
			{
				text = text.Substring(1, text.Length - 1);
			}
			return text;
		}
	}
}
