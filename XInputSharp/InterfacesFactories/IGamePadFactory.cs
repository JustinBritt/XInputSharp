namespace XInputSharp.InterfacesFactories
{
    using XInputSharp.Interfaces;
    using XInputSharp.InterfacesFactories.Delegates;
    using XInputSharp.InterfacesFactories.Libraries;

    public interface IGamePadFactory
    {
        IGamePad Create(
            IXInputDelegatesFactory XInputDelegatesFactory,
            IXInputDelegateSupportFactory XInputDelegateSupportFactory,
            IXInputLibraryFactory XInputLibraryFactory,
            IXInputLibraryLoaderFactory XInputLibraryLoaderFactory,
            IXInputLibraryLoaderResultFactory XInputLibraryLoaderResultFactory,
            IXInputLibraryUnloaderFactory XInputLibraryUnloaderFactory);
    }
}