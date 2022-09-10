using System;
using System.Runtime.InteropServices;

namespace TheBaseCSharpLib
{
    public class LibWrapper
    {
        static LibWrapper()
        {
            DLLRegister.RegisterNativePath();
        }

        [DllImport("TheCPlusPlusLib.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Sum([In] int number1, [In] int number2, out int result);
    }
}
