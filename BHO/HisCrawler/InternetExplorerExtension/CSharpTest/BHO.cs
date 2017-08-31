using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Web.Services;
using Microsoft.Win32;
using SHDocVw;

namespace DiagnoseAssistant1
{
	
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	/// 
	[ComVisible(true)]
	[Guid("20C718C8-0D8C-42dc-B0CD-C7C53A23F116")]
	public class BHO	: IObjectWithSite
	{
		#region Member Variables
		protected SHDocVw.IWebBrowser2 m_pIWebBrowser2; // the browser class object
		protected SHDocVw.DWebBrowserEvents2_Event  m_pDWebBrowserEvents2; // browser events
//		private ComImports KeyHook= new ComImports();
		
		#endregion

		#region Hook Variables

		public struct KeyboardHookStruct
		{
			public long vkCode;
			public long scanCode;
			public int flags;
			public long time;
			public long dwExtraInfo;

		};
		private const int HC_ACTION = 0;
		private const int LLKHF_EXTENDED = 0x01;
		private const int LLKHF_ALTDOWN = 0x20;
		private const long VK_T = 0x54;
		private const long VK_P = 0x50;
		private const long VK_W	= 0x57;
		private const int VK_TAB = 0x9;
	    private const int VK_CONTROL = 0x11; // tecla Ctrl
		//Private Const VK_MENU As Long = &H12        ' tecla Alt
		private const int VK_ESCAPE = 0x1B;

		private const int WH_KEYBOARD_LL=13;

		protected IntPtr KeyboardHandle = IntPtr.Zero;
		private static int mHook;
		#endregion

		
		public BHO()
		{
	
			MessageBox.Show("inside BHO's constructor");
		}


		#region COM interfaces
		#region IObjectWithSite Members

		public void SetSite(object newSite)
		{
			MessageBox.Show("inside SetSite");
			object site=newSite;
			string explorer= null;
			
			if (m_pIWebBrowser2!=null)
				Release();

			if( site != null )
				Marshal.ReleaseComObject( site );

			site = newSite;
			
			if( site != null )
			{
				MessageBox.Show("inside if site!=null");
				IServiceProvider sp = site as IServiceProvider;
				m_pIWebBrowser2 = site as SHDocVw.IWebBrowser2;
				Guid guid = ExplorerGUIDs.IID_IWebBrowserApp;
				Guid riid = ExplorerGUIDs.IID_IUnknown;

				object wba;
				sp.QueryService(ref guid,ref riid,out wba );
		
				/*explorer = (WebBrowserClass)Marshal.CreateWrapperOfType(
					wba as SHDocVw.IWebBrowser2,
					typeof(WebBrowserClass));*/

				explorer=m_pIWebBrowser2.FullName.ToUpper();

				if(explorer.EndsWith("IEXPLORE.EXE"))
				{
					MessageBox.Show("inside the IEXPLORE.EXE");
//					KeyHook.Install();
					Install();
					MessageBox.Show("hooking");

				}
			}
			else
			{
				if ( explorer != null )
				{
					IServiceProvider sp = site as IServiceProvider;
					m_pIWebBrowser2 = site as SHDocVw.IWebBrowser2;
					Guid guid = ExplorerGUIDs.IID_IWebBrowserApp;
					Guid riid = ExplorerGUIDs.IID_IUnknown;

					object wba;
					sp.QueryService(ref guid,ref riid,out wba );

					explorer=m_pIWebBrowser2.FullName.ToUpper();
					//Marshal.ReleaseComObject( explorer );

					//explorer is about to close, freeing resources
					if(explorer.EndsWith("IEXPLORE.EXE"))
					{
						//KeyHook.UnInstall();
						UnInstall();
						MessageBox.Show("UnHookMe");
					}

					explorer = null;
				}
				MessageBox.Show("end of setsite");
				return;
			}

		}

		public int GetSite(ref Guid guid, out IntPtr ppvSite)
		{
			// TODO:  Add BHO.GetSite implementation
			MessageBox.Show("inside getsite");
			ppvSite = new IntPtr ();
			return 0;
		}

		#endregion

		protected void Release()
		{
			if (m_pDWebBrowserEvents2!=null)
			{
				Marshal.ReleaseComObject(m_pDWebBrowserEvents2);
				m_pDWebBrowserEvents2=null;
			}

			if (m_pIWebBrowser2 != null)
			{
				Marshal.ReleaseComObject(m_pIWebBrowser2);
				m_pIWebBrowser2 = null;
			}
		}
		
		#endregion

		#region Hook Functions

		private delegate int KeyboardHookProcDelegate(int nCode, int wParam, int lParam); 

		public void Install()
		{
			MessageBox.Show("inside Install");
			
			mHook=SetWindowsHookEx(WH_KEYBOARD_LL,new KeyboardHookProcDelegate(KeyboardHookProc),((Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0])).ToInt32()),0);
			if(mHook!=0)
			{
				MessageBox.Show("unable to install");
			}
			else
				MessageBox.Show("Success in Installing!");
		}


		public static int KeyboardHookProc(int nCode, int wParam, int lParam) 
		{
			KeyboardHookStruct HookStruct;
			int ret = 0;
			MessageBox.Show("inside HookProc");

			HookStruct = ((KeyboardHookStruct) Marshal.PtrToStructure(new IntPtr(lParam), typeof(KeyboardHookStruct)));
			long vkCode= HookStruct.vkCode;
			int flag = HookStruct.flags;

			if(nCode==HC_ACTION)
			{
				MessageBox.Show("inside nCode==HC_ACTION");
				//System.Windows.Forms.Keys  KeyPressed = (Keys)wParam.ToInt32();

				// Insert + T  OR Alt + T
				if(vkCode == VK_T )
				{
					MessageBox.Show(" found T ");
					if((GetAsyncKeyState(VK_CONTROL) & 0x8000) != 0)
					{
						MessageBox.Show("Play");
						ret=1;
					}
					else if((flag & LLKHF_ALTDOWN)!=0)
					{
						MessageBox.Show("Stop");
						ret=1;
					}
				}
				else if(vkCode == VK_P)
				{
					MessageBox.Show(" found P ");
					if((GetAsyncKeyState(VK_CONTROL) & 0x8000) != 0)
					{ //Insert + P
						MessageBox.Show("pause");
						ret = 1 ;
					}
				}
				else if(vkCode == VK_W) 
				{
					MessageBox.Show(" found W ");
					if((GetAsyncKeyState(VK_CONTROL) & 0x8000) != 0)
					{
						// Alt + S
						MessageBox.Show("Save");
						ret = 1 ;
					}
				}
            	
				/*/	CopyMemory(HookStruct,lParam,sizeof(HookStruct);
					if(IsHooked(HookStruct))
						{
							MyKeyboardProc=1;
						}*/

				//	MyKeyboardProc=1;
			}
			if( ret == 0 )
			{
				ret = CallNextHookEx(mHook,nCode,wParam,lParam);
			}
			return ret;
		}
		

		public void UnInstall()
		{
			MessageBox.Show("inside UnInstall");
			if(mHook!=0)
			{
				MessageBox.Show("inside mHook!=0 ");
				UnhookWindowsHookEx(mHook);
			}
		}


		#endregion

		#region Hook Win32Imports

			// Win32: SetWindowsHookEx()
			[DllImport("user32.dll")]
			private static extern int SetWindowsHookEx(int code, 
				KeyboardHookProcDelegate func,
				int hInstance,
			int threadID);

			// Win32: UnhookWindowsHookEx()
			[DllImport("user32.dll")]
			protected static extern bool UnhookWindowsHookEx(int hhook); 


			// Win32: CallNextHookEx()
			[DllImport("user32.dll")]
			protected static extern int CallNextHookEx(int hhook, 
				int code, int wParam, int lParam);

			// Win32 : GetAsyncKeyState
			[DllImport("user32.dll")]
			private static extern short GetAsyncKeyState(int vKey);  
 
		#endregion


	}
}
