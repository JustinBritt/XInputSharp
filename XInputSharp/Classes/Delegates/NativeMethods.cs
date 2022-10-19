namespace XInputSharp.Classes.Delegates
{
    using System;
    using System.Runtime.InteropServices;

    internal static class NativeMethods
    {
        [DllImport("kernel32")]
        public static extern IntPtr GetProcAddress(
            IntPtr hModule,
            string procName);
    }
}