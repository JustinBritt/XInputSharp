namespace XInputSharp.Factories
{
    using XInputSharp.Classes;
    using XInputSharp.Interfaces;
    using XInputSharp.InterfacesFactories;
    using XInputSharp.InterfacesFactories.Delegates;
    using XInputSharp.InterfacesFactories.Libraries;

    internal sealed class GamePadFactory : IGamePadFactory
    {
        public GamePadFactory()
        {
        }

        public IGamePad Create(
            IXInputDelegatesFactory XInputDelegatesFactory,
            IXInputDelegateSupportFactory XInputDelegateSupportFactory,
            IXInputLibraryFactory XInputLibraryFactory,
            IXInputLibraryLoaderFactory XInputLibraryLoaderFactory,
            IXInputLibraryLoaderResultFactory XInputLibraryLoaderResultFactory,
            IXInputLibraryUnloaderFactory XInputLibraryUnloaderFactory)
        {
            return new GamePad(
                XInputDelegatesFactory,
                XInputDelegateSupportFactory,
                XInputLibraryFactory,
                XInputLibraryLoaderFactory,
                XInputLibraryLoaderResultFactory,
                XInputLibraryUnloaderFactory);
        }
    }
}