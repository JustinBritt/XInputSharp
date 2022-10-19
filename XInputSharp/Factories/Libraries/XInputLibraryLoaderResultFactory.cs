namespace XInputSharp.Factories.Libraries
{
    using System;

    using XInputSharp.Classes.Libraries;
    using XInputSharp.Enums.Libraries;
    using XInputSharp.Interfaces.Libraries;
    using XInputSharp.InterfacesFactories.Libraries;

    internal sealed class XInputLibraryLoaderResultFactory : IXInputLibraryLoaderResultFactory
    {
        public XInputLibraryLoaderResultFactory()
        {
        }

        public IXInputLibraryLoaderResult Create(
            IntPtr hModule,
            XInputLibraryVersion XInputLibraryVersion)
        {
            IXInputLibraryLoaderResult XInputLibraryLoaderResult = null;

            try
            {
                XInputLibraryLoaderResult = new XInputLibraryLoaderResult(
                    hModule,
                    XInputLibraryVersion);
            }
            finally
            {
            }

            return XInputLibraryLoaderResult;
        }
    }
}