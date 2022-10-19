namespace XInputSharp.Classes.Libraries
{
    using System;
    using System.Runtime.InteropServices;

    internal static class NativeMethods
    {
        [DllImport("kernel32", SetLastError = true)]
        public static extern bool FreeLibrary(
            IntPtr hModule);

        [DllImport("kernel32", SetLastError = true)]
        public static extern IntPtr LoadLibrary(
            string lpFileName);
    }
}