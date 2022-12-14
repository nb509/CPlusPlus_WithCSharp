using System;
using System.Runtime.InteropServices;

namespace TheBaseCSharpLib
{
    /// <summary>
    /// This class is meant to demonstrate interop to static math methods in the cpp library
    /// </summary>
    public class StaticMath
    {
        static StaticMath()
        {
            DLLRegister.RegisterNativePath();
        }

        [DllImport("TheCPlusPlusLib.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Sum([In] int number1, [In] int number2, out int result);

        [DllImport("TheCPlusPlusLib.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Multiply([In] int number1, [In] int number2, out int result);
    }
}
