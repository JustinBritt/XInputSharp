namespace XInputSharp.Interfaces.Libraries
{
    using System;

    using XInputSharp.Enums.Libraries;

    public interface IXInputLibrary : IDisposable
    {
        IntPtr hModule { get; }

        bool IsLoaded { get; }

        XInputLibraryVersion XInputLibraryVersion { get; }
    }
}