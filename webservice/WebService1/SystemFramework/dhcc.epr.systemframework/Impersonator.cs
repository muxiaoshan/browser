using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace dhcc.epr.systemframework
{
	public class Impersonator : IDisposable
	{
		private const int LOGON32_LOGON_INTERACTIVE = 2;

		private const int LOGON32_PROVIDER_DEFAULT = 0;

		private WindowsImpersonationContext impersonationContext;

		public Impersonator(string userName, string domainName, string password)
		{
			if (domainName == "")
			{
				domainName = Environment.MachineName;
			}
			this.ImpersonateValidUser(userName, domainName, password);
		}

		public void Dispose()
		{
			this.UndoImpersonation();
		}

		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern int LogonUser(string lpszUserName, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, ref IntPtr phToken);

		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int DuplicateToken(IntPtr hToken, int impersonationLevel, ref IntPtr hNewToken);

		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool RevertToSelf();

		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		private static extern bool CloseHandle(IntPtr handle);

		private void ImpersonateValidUser(string userName, string domain, string password)
		{
			IntPtr zero = IntPtr.Zero;
			IntPtr zero2 = IntPtr.Zero;
			try
			{
				if (!Impersonator.RevertToSelf())
				{
					throw new Win32Exception(Marshal.GetLastWin32Error());
				}
				if (Impersonator.LogonUser(userName, domain, password, 2, 0, ref zero) == 0)
				{
					throw new Win32Exception(Marshal.GetLastWin32Error());
				}
				if (Impersonator.DuplicateToken(zero, 2, ref zero2) == 0)
				{
					throw new Win32Exception(Marshal.GetLastWin32Error());
				}
				WindowsIdentity windowsIdentity = new WindowsIdentity(zero2);
				this.impersonationContext = windowsIdentity.Impersonate();
			}
			finally
			{
				if (zero != IntPtr.Zero)
				{
					Impersonator.CloseHandle(zero);
				}
				if (zero2 != IntPtr.Zero)
				{
					Impersonator.CloseHandle(zero2);
				}
			}
		}

		private void UndoImpersonation()
		{
			if (this.impersonationContext != null)
			{
				this.impersonationContext.Undo();
			}
		}
	}
}
