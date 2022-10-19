namespace XInputSharp.Interfaces.Libraries
{
    using XInputSharp.InterfacesFactories.Libraries;

    public interface IXInputLibraryLoader
    {
        IXInputLibraryLoaderResult LoadOrDefault(
            IXInputLibraryLoaderResultFactory XInputLibraryLoaderResultFactory);
    }
}