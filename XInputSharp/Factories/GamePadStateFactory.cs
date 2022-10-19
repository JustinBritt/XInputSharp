namespace XInputSharp.Factories
{
    using XInputSharp.Enums;
    using XInputSharp.InterfacesFactories;
    using XInputSharp.Structs;

    internal sealed class GamePadStateFactory : IGamePadStateFactory
    {
        public GamePadStateFactory()
        {
        }

        public GamePadState Create(
            IGamePadButtonsFactory gamePadButtonsFactory,
            IGamePadDPadFactory gamePadDPadFactory,
            IGamePadThumbSticksFactory gamePadThumbSticksFactory,
            IGamePadTriggersFactory gamePadTriggersFactory,
            IStickValueFactory stickValueFactory,
            bool isConnected,
            GamePadState.RawState rawState,
            GamePadDeadZone deadZone)
        {
            GamePadState gamePadState = default;

            try
            {
                gamePadState = new GamePadState(
                    gamePadButtonsFactory: gamePadButtonsFactory,
                    gamePadDPadFactory: gamePadDPadFactory,
                    gamePadThumbSticksFactory: gamePadThumbSticksFactory,
                    gamePadTriggersFactory: gamePadTriggersFactory,
                    stickValueFactory: stickValueFactory,
                    isConnected: isConnected,
                    rawState: rawState,
                    deadZone: deadZone);
            }
            finally
            {
            }

            return gamePadState;
        }
    }
}