namespace XInputSharp.InterfacesFactories.Libraries
{
    using System;

    using XInputSharp.Enums.Libraries;
    using XInputSharp.Interfaces.Libraries;

    public interface IXInputLibraryLoaderResultFactory
    {
        IXInputLibraryLoaderResult Create(
            IntPtr hModule,
            XInputLibraryVersion XInputLibraryVersion);
    }
}