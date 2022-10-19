namespace XInputSharp.Interfaces.Libraries
{
    using System;

    using XInputSharp.Enums.Libraries;

    public interface IXInputLibraryLoaderResult
    {
        IntPtr hModule { get; }

        XInputLibraryVersion XInputLibraryVersion { get; }
    }
}