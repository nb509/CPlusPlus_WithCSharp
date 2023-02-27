using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace TheBaseCSharpLib
{
    public static class AravisHelper
    {
        static AravisHelper()
        {
            DLLRegister.RegisterNativePath();
        }

        [DllImport("TheCPlusPlusLib.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void UpdateDeviceList();


        [DllImport("TheCPlusPlusLib.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetNDevices(out int result);

    }
}
