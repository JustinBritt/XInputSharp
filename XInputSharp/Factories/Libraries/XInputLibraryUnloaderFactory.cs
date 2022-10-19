namespace XInputSharp.Factories.Libraries
{
    using XInputSharp.Classes.Libraries;
    using XInputSharp.Interfaces.Libraries;
    using XInputSharp.InterfacesFactories.Libraries;

    internal sealed class XInputLibraryUnloaderFactory : IXInputLibraryUnloaderFactory
    {
        public XInputLibraryUnloaderFactory()
        {
        }

        public IXInputLibraryUnloader Create()
        {
            IXInputLibraryUnloader XInputLibraryUnloader = null;

            try
            {
                XInputLibraryUnloader = new XInputLibraryUnloader();
            }
            finally
            {
            }

            return XInputLibraryUnloader;
        }
    }
}