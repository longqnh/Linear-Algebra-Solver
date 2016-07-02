using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows;

namespace DaiSoTuyenTinh
{
    class OpenMaple
    {
        public static string result = "";
        public static string status = "";
        public static string error = "";

        MapleEngine.MapleCallbacks cb;
        IntPtr kv;
        string[] argv = new string[2];
        byte[] err = new byte[2048];

        public void Open()
        {
            argv[0] = "maple";
            argv[1] = "2";

            cb.TextCallBack = cbText;
            cb.ErrorCallBack = cbError;
            cb.StatusCallBack = cbStatus;
            cb.ReadlineCallBack = null;
            cb.RedirectCallBack = null;
            cb.StreamCallBack = null;
            cb.QueryInterrupt = null;
            cb.CallbackCallBack = null;

            try
            {
                kv = MapleEngine.StartMaple(2, argv, ref cb, IntPtr.Zero, IntPtr.Zero, err);
            }
            catch (DllNotFoundException e)
            {
                MessageBox.Show(e.ToString());
                return;
            }
            catch (EntryPointNotFoundException e)
            {
                MessageBox.Show(e.ToString());
                return;
            }

            if (kv.ToInt64() == 0)
            {
                MessageBox.Show("Fatal Error, could not start Maple: "
                        + System.Text.Encoding.ASCII.GetString(err, 0, Array.IndexOf(err, (byte)0))
                    );
                return;
            }
        }

        public void Run(string querry)
        {
            IntPtr val = MapleEngine.EvalMapleStatement(kv, Encoding.ASCII.GetBytes(querry + ';'));

            if (MapleEngine.IsMapleStop(kv, val).ToInt32() != 0)
            {
                MapleEngine.StopMaple(kv);
            }
        }

        public static void cbText(IntPtr data, int tag, IntPtr output)
        {
            result = Marshal.PtrToStringAnsi(output);
        }

        public static void cbError(IntPtr data, IntPtr offset, IntPtr msg)
        {
            result = Marshal.PtrToStringAnsi(msg);
        }

        public static void cbStatus(IntPtr data, IntPtr used, IntPtr alloc, double time)
        {
            result = "cputime=" + time
              + "; memory used=" + used.ToInt64() + "kB"
              + " alloc=" + alloc.ToInt64() + "kB";
        }
    }
}
