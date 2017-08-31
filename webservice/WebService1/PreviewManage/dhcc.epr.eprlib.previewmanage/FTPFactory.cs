using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace dhcc.epr.eprlib.previewmanage
{
	public class FTPFactory
	{
		private string remoteHost;

		private string remotePath;

		private string remoteUser;

		private string remotePass;

		private string mes;

		private int remotePort;

		private int bytes;

		private Socket clientSocket;

		private int retValue;

		private bool debug;

		private bool logined;

		private string reply;

		private static int BLOCK_SIZE = 512;

		private byte[] buffer = new byte[FTPFactory.BLOCK_SIZE];

		private Encoding ASCII = Encoding.ASCII;

		private int delayTime;

		public FTPFactory(string _remoteHost, string _port, string _remoteUser, string _remotePass, string _delayTime)
		{
			this.remoteHost = _remoteHost;
			this.remotePath = ".";
			this.remoteUser = _remoteUser;
			this.remotePass = _remotePass;
			this.remotePort = Convert.ToInt32(_port);
			this.debug = true;
			this.logined = false;
			if (_delayTime != "")
			{
				this.delayTime = Convert.ToInt32(_delayTime);
			}
		}

		public void setRemoteHost(string remoteHost)
		{
			this.remoteHost = remoteHost;
		}

		public string getRemoteHost()
		{
			return this.remoteHost;
		}

		public void setRemotePort(int remotePort)
		{
			this.remotePort = remotePort;
		}

		public int getRemotePort()
		{
			return this.remotePort;
		}

		public void setRemotePath(string remotePath)
		{
			this.remotePath = remotePath;
		}

		public string getRemotePath()
		{
			return this.remotePath;
		}

		public void setRemoteUser(string remoteUser)
		{
			this.remoteUser = remoteUser;
		}

		public void setRemotePass(string remotePass)
		{
			this.remotePass = remotePass;
		}

		public string[] getFileList(string mask)
		{
			if (!this.logined)
			{
				this.login();
			}
			Socket socket = this.createDataSocket();
			this.sendCommand("NLST " + mask);
			if (this.retValue != 150 && this.retValue != 125)
			{
				throw new IOException(this.reply.Substring(4));
			}
			this.mes = "";
			int num;
			do
			{
				num = socket.Receive(this.buffer, this.buffer.Length, SocketFlags.None);
				this.mes += this.ASCII.GetString(this.buffer, 0, num);
			}
			while (num >= this.buffer.Length);
			char[] separator = new char[]
			{
				'\n'
			};
			string[] result = this.mes.Split(separator);
			socket.Close();
			this.readReply();
			if (this.retValue != 226)
			{
				throw new IOException(this.reply.Substring(4));
			}
			return result;
		}

		public long getFileSize(string fileName)
		{
			if (!this.logined)
			{
				this.login();
			}
			this.sendCommand("SIZE " + fileName);
			if (this.retValue == 213)
			{
				return long.Parse(this.reply.Substring(4));
			}
			throw new IOException(this.reply.Substring(4));
		}

		public void login()
		{
			this.clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(this.remoteHost), this.remotePort);
			try
			{
				this.clientSocket.Connect(remoteEP);
			}
			catch (Exception)
			{
				throw new IOException("Couldn't connect to remote server");
			}
			this.readReply();
			if (this.retValue != 220)
			{
				this.close();
				throw new IOException(this.reply.Substring(4));
			}
			if (this.debug)
			{
				this.sendCommand("USER " + this.remoteUser);
			}
			if (this.retValue != 331 && this.retValue != 230)
			{
				this.cleanup();
				throw new IOException(this.reply.Substring(4));
			}
			if (this.retValue != 230)
			{
				if (this.debug)
				{
					this.sendCommand("PASS " + this.remotePass);
				}
				if (this.retValue != 230 && this.retValue != 202)
				{
					this.cleanup();
					throw new IOException(this.reply.Substring(4));
				}
			}
			this.logined = true;
			this.chdir(this.remotePath);
		}

		public void setBinaryMode(bool mode)
		{
			if (mode)
			{
				this.sendCommand("TYPE I");
			}
			else
			{
				this.sendCommand("TYPE A");
			}
			if (this.retValue != 200)
			{
				throw new IOException(this.reply.Substring(4));
			}
		}

		public void download(string remFileName)
		{
			this.download(remFileName, "", false);
		}

		public void download(string remFileName, bool resume)
		{
			this.download(remFileName, "", resume);
		}

		public void download(string remFileName, string locFileName)
		{
			this.download(remFileName, locFileName, false);
		}

		public void download(string remFileName, string locFileName, bool resume)
		{
			if (!this.logined)
			{
				this.login();
			}
			this.setBinaryMode(true);
			if (locFileName.Equals(""))
			{
				locFileName = remFileName;
			}
			if (!File.Exists(locFileName))
			{
				Stream stream = File.Create(locFileName);
				stream.Close();
			}
			FileStream fileStream = new FileStream(locFileName, FileMode.Open);
			Socket socket = this.createDataSocket();
			if (resume)
			{
				long num = fileStream.Length;
				if (num > 0L)
				{
					this.sendCommand("REST " + num);
					if (this.retValue != 350)
					{
						num = 0L;
					}
				}
				if (num > 0L)
				{
					bool arg_8C_0 = this.debug;
					fileStream.Seek(num, SeekOrigin.Begin);
				}
			}
			this.sendCommand("RETR " + remFileName);
			if (this.retValue != 150 && this.retValue != 125 && this.retValue != 226)
			{
				fileStream.Close();
				throw new IOException(this.reply.Substring(4));
			}
			do
			{
				this.bytes = socket.Receive(this.buffer, this.buffer.Length, SocketFlags.None);
				fileStream.Write(this.buffer, 0, this.bytes);
			}
			while (this.bytes > 0);
			fileStream.Close();
			if (socket.Connected)
			{
				socket.Close();
			}
			if (this.retValue == 150 || this.retValue == 125)
			{
				this.readReply();
			}
			if (this.retValue != 226 && this.retValue != 250)
			{
				throw new IOException(this.reply.Substring(4));
			}
		}

		public void upload(string fileName)
		{
			this.upload(fileName, false);
		}

		public void upload(string fileName, bool resume)
		{
			if (!this.logined)
			{
				this.login();
			}
			Socket socket = this.createDataSocket();
			long num = 0L;
			if (resume)
			{
				try
				{
					this.setBinaryMode(true);
					num = this.getFileSize(fileName);
				}
				catch (Exception)
				{
					num = 0L;
				}
			}
			if (num > 0L)
			{
				this.sendCommand("REST " + num);
				if (this.retValue != 350)
				{
					num = 0L;
				}
			}
			this.sendCommand("STOR " + Path.GetFileName(fileName));
			if (this.retValue != 125 && this.retValue != 150)
			{
				throw new IOException(this.reply.Substring(4));
			}
			FileStream fileStream = new FileStream(fileName, FileMode.Open);
			if (num != 0L)
			{
				bool arg_AF_0 = this.debug;
				fileStream.Seek(num, SeekOrigin.Begin);
			}
			while ((this.bytes = fileStream.Read(this.buffer, 0, this.buffer.Length)) > 0)
			{
				socket.Send(this.buffer, this.bytes, SocketFlags.None);
			}
			fileStream.Close();
			if (socket.Connected)
			{
				socket.Close();
			}
			this.readReply();
			if (this.retValue != 226 && this.retValue != 250)
			{
				throw new IOException(this.reply.Substring(4));
			}
		}

		public void deleteRemoteFile(string fileName)
		{
			if (!this.logined)
			{
				this.login();
			}
			this.sendCommand("DELE " + fileName);
			if (this.retValue != 250)
			{
				throw new IOException(this.reply.Substring(4));
			}
		}

		public void renameRemoteFile(string oldFileName, string newFileName)
		{
			if (!this.logined)
			{
				this.login();
			}
			this.sendCommand("RNFR " + oldFileName);
			if (this.retValue != 350)
			{
				throw new IOException(this.reply.Substring(4));
			}
			this.sendCommand("RNTO " + newFileName);
			if (this.retValue != 250)
			{
				throw new IOException(this.reply.Substring(4));
			}
		}

		public void mkdir(string dirName)
		{
			if (!this.logined)
			{
				this.login();
			}
			this.sendCommand("MKD " + dirName);
			if (this.retValue != 257 && this.retValue != 550)
			{
				throw new IOException(this.reply.Substring(4));
			}
		}

		public void rmdir(string dirName)
		{
			if (!this.logined)
			{
				this.login();
			}
			this.sendCommand("RMD " + dirName);
			if (this.retValue != 250)
			{
				throw new IOException(this.reply.Substring(4));
			}
		}

		public void chdir(string dirName)
		{
			if (dirName.Equals("."))
			{
				return;
			}
			if (!this.logined)
			{
				this.login();
			}
			this.sendCommand("CWD " + dirName);
			if (this.retValue != 250)
			{
				throw new IOException(this.reply.Substring(4));
			}
			this.remotePath = dirName;
		}

		public void close()
		{
			if (this.clientSocket != null)
			{
				byte[] array = Encoding.ASCII.GetBytes("QUIT\r\n".ToCharArray());
				SocketError socketError;
				this.clientSocket.Send(array, array.Length, 0, SocketFlags.None, out socketError);
			}
			this.cleanup();
		}

		public void setDebug(bool debug)
		{
			this.debug = debug;
		}

		private void readReply()
		{
			this.mes = "";
			if (this.delayTime > 0 && this.delayTime <= 100)
			{
				Thread.Sleep(this.delayTime);
			}
			this.reply = this.readLine();
			this.retValue = int.Parse(this.reply.Substring(0, 3));
		}

		private void cleanup()
		{
			if (this.clientSocket != null)
			{
				this.clientSocket.Close();
				this.clientSocket = null;
			}
			this.logined = false;
		}

		private string readLine()
		{
			do
			{
				this.bytes = this.clientSocket.Receive(this.buffer, this.buffer.Length, SocketFlags.None);
				this.mes += this.ASCII.GetString(this.buffer, 0, this.bytes);
			}
			while (this.bytes >= this.buffer.Length);
			char[] separator = new char[]
			{
				'\n'
			};
			string[] array = this.mes.Split(separator);
			if (array.Length > 2)
			{
				this.mes = array[array.Length - 2];
			}
			else
			{
				this.mes = array[0];
			}
			if (!this.mes.Substring(3, 1).Equals(" "))
			{
				return this.readLine();
			}
			return this.mes;
		}

		private void sendCommand(string command)
		{
			byte[] array = Encoding.ASCII.GetBytes((command + "\r\n").ToCharArray());
			this.clientSocket.Send(array, array.Length, SocketFlags.None);
			this.readReply();
		}

		private Socket createDataSocket()
		{
			this.sendCommand("PASV");
			if (this.retValue != 227)
			{
				throw new IOException(this.reply.Substring(4));
			}
			int num = this.reply.IndexOf('(');
			int num2 = this.reply.IndexOf(')');
			string text = this.reply.Substring(num + 1, num2 - num - 1);
			int[] array = new int[6];
			int length = text.Length;
			int num3 = 0;
			string text2 = "";
			int num4 = 0;
			while (num4 < length && num3 <= 6)
			{
				char c = char.Parse(text.Substring(num4, 1));
				if (char.IsDigit(c))
				{
					text2 += c;
				}
				else if (c != ',')
				{
					throw new IOException("Malformed PASV reply: " + this.reply);
				}
				if (c == ',')
				{
					goto IL_D0;
				}
				if (num4 + 1 == length)
				{
					goto Block_5;
				}
				IL_100:
				num4++;
				continue;
				Block_5:
				try
				{
					IL_D0:
					array[num3++] = int.Parse(text2);
					text2 = "";
				}
				catch (Exception)
				{
					throw new IOException("Malformed PASV reply: " + this.reply);
				}
				goto IL_100;
			}
			string.Concat(new object[]
			{
				array[0],
				".",
				array[1],
				".",
				array[2],
				".",
				array[3]
			});
			int port = (array[4] << 8) + array[5];
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(this.remoteHost), port);
			try
			{
				socket.Connect(remoteEP);
			}
			catch (Exception)
			{
				throw new IOException("Can't connect to remote server");
			}
			return socket;
		}
	}
}
