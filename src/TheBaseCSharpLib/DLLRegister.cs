using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace TheBaseCSharpLib
{
    /// <summary>
    /// This class only has one purpose: to set the correct path for the binaries that should be loaded.
    /// Currently we are only set up for windows in the debug folder.
    /// </summary>
    internal static class DLLRegister
    {
        [DllImport("kernel32", SetLastError = true)] 
        private static extern bool SetDllDirectory(string lpPathName); // See https://learn.microsoft.com/en-us/windows/win32/api/winbase/nf-winbase-setdlldirectorya

        private static bool Registered;

        public static void RegisterNativePath()
        {
            if (Registered) return;
            string path = string.Empty;
            string currentValue = string.Empty;
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                    path = Path.Combine("binaries", "win", Environment.Is64BitProcess ? "x64" : "x86", "Debug");
                    SetDllDirectory(path);
                    break;
            }
            Registered = true;
        }
    }
}
