namespace XInputSharp.Factories.Libraries
{
    using XInputSharp.Classes.Libraries;
    using XInputSharp.Interfaces.Libraries;
    using XInputSharp.InterfacesFactories.Libraries;

    internal sealed class XInputLibraryFactory : IXInputLibraryFactory
    {
        public XInputLibraryFactory()
        {
        }

        public IXInputLibrary Create(
            IXInputLibraryLoaderFactory XInputLibraryLoaderFactory,
            IXInputLibraryLoaderResultFactory XInputLibraryLoaderResultFactory,
            IXInputLibraryUnloaderFactory XInputLibraryUnloaderFactory)
        {
            IXInputLibrary XInputLibrary = null;

            try
            {
                XInputLibrary = new XInputLibrary(
                    XInputLibraryLoaderFactory,
                    XInputLibraryLoaderResultFactory,
                    XInputLibraryUnloaderFactory);
            }
            finally
            {
            }

            return XInputLibrary;
        }
    }
}