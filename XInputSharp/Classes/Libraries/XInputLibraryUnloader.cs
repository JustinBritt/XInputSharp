namespace XInputSharp.Classes.Libraries
{
    using System;

    using XInputSharp.Interfaces.Libraries;

    internal sealed class XInputLibraryUnloader : IXInputLibraryUnloader
    {
        public XInputLibraryUnloader()
        {
        }

        public void Unload(
            IntPtr hModule)
        {
            NativeMethods.FreeLibrary(
                hModule);
        }
    }
}