namespace XInputSharp.InterfacesFactories
{
    using XInputSharp.Enums;
    using XInputSharp.Structs;

    public interface IGamePadStateFactory
    {
        GamePadState Create(
            IGamePadButtonsFactory gamePadButtonsFactory,
            IGamePadDPadFactory gamePadDPadFactory,
            IGamePadThumbSticksFactory gamePadThumbSticksFactory,
            IGamePadTriggersFactory gamePadTriggersFactory,
            IStickValueFactory stickValueFactory,
            bool isConnected,
            GamePadState.RawState rawState,
            GamePadDeadZone deadZone);
    }
}