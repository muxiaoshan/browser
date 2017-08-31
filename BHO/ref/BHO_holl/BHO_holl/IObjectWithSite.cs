using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace BHO_holl
{
    [ComVisible(true), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("FC4801A3-2BA9-11CF-A229-00AA003D7352")]
    public interface IObjectWithSite
    {

        [PreserveSig]
        int Setsite([MarshalAs(UnmanagedType.IUnknown)]Object Site);


        [PreserveSig]
        int Getsite(ref Guid Guid, out IntPtr Ppvsite);
    }
}
