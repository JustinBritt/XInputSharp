namespace XInputSharp.InterfacesFactories.Libraries
{
    using XInputSharp.Interfaces.Libraries;

    public interface IXInputLibraryFactory
    {
        IXInputLibrary Create(
            IXInputLibraryLoaderFactory XInputLibraryLoaderFactory,
            IXInputLibraryLoaderResultFactory XInputLibraryLoaderResultFactory,
            IXInputLibraryUnloaderFactory XInputLibraryUnloaderFactory);
    }
}