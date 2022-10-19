namespace XInputSharp.Classes.Libraries
{
    using System;

    using XInputSharp.Enums.Libraries;
    using XInputSharp.Interfaces.Libraries;

    internal sealed class XInputLibraryLoaderResult : IXInputLibraryLoaderResult
    {
        public XInputLibraryLoaderResult(
            IntPtr hModule,
            XInputLibraryVersion XInputLibraryVersion)
        {
            this.hModule = hModule;

            this.XInputLibraryVersion = XInputLibraryVersion;
        }

        public IntPtr hModule { get; }

        public XInputLibraryVersion XInputLibraryVersion { get; }
    }
}