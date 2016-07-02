using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DaiSoTuyenTinh
{
    [System.Security.SuppressUnmanagedCodeSecurity]
    internal class NativeMethods
    {
        private NativeMethods()
        {
        }

        [DllImport("MimeTex.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int CreateGifFromEq(string expr, string fileName);

        [DllImport("kernel32.dll")]
        internal extern static IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal extern static bool FreeLibrary(IntPtr hLibModule);
    }
}
