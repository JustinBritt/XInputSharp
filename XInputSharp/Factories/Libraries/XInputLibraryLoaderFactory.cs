namespace XInputSharp.Factories.Libraries
{
    using XInputSharp.Classes.Libraries;
    using XInputSharp.Interfaces.Libraries;
    using XInputSharp.InterfacesFactories.Libraries;

    internal sealed class XInputLibraryLoaderFactory : IXInputLibraryLoaderFactory
    {
        public XInputLibraryLoaderFactory()
        {
        }

        public IXInputLibraryLoader Create()
        {
            IXInputLibraryLoader XInputLibraryLoader = null;

            try
            {
                XInputLibraryLoader = new XInputLibraryLoader();
            }
            finally
            {
            }

            return XInputLibraryLoader;
        }
    }
}