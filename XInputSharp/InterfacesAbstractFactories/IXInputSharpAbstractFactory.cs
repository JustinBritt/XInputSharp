namespace XInputSharp.InterfacesAbstractFactories
{
    using XInputSharp.InterfacesFactories;
    using XInputSharp.InterfacesFactories.Delegates;
    using XInputSharp.InterfacesFactories.Libraries;

    public interface IXInputSharpAbstractFactory
    {
        IGamePadButtonsFactory CreateGamePadButtonsFactory();

        IGamePadDPadFactory CreateGamePadDPadFactory();

        IGamePadFactory CreateGamePadFactory();

        IGamePadStateFactory CreateGamePadStateFactory();

        IGamePadThumbSticksFactory CreateGamePadThumbSticksFactory();

        IGamePadTriggersFactory CreateGamePadTriggersFactory();

        IGamePadVibrationFactory CreateGamePadVibrationFactory();

        IStickValueFactory CreateStickValueFactory();

        IXInputDelegatesFactory CreateXInputDelegatesFactory();

        IXInputDelegateSupportFactory CreateXInputDelegateSupportFactory();

        IXInputLibraryFactory CreateXInputLibraryFactory();

        IXInputLibraryLoaderFactory CreateXInputLibraryLoaderFactory();

        IXInputLibraryLoaderResultFactory CreateXInputLibraryLoaderResultFactory();

        IXInputLibraryUnloaderFactory CreateXInputLibraryUnloaderFactory();
    }
}