namespace XInputSharp.Factories
{
    using XInputSharp.Enums;
    using XInputSharp.InterfacesFactories;
    using XInputSharp.Structs;

    internal sealed class GamePadButtonsFactory : IGamePadButtonsFactory
    {
        public GamePadButtonsFactory()
        {
        }

        public GamePadButtons Create(
            ButtonState start,
            ButtonState back,
            ButtonState leftStick,
            ButtonState rightStick,
            ButtonState leftShoulder,
            ButtonState rightShoulder,
            ButtonState guide,
            ButtonState a,
            ButtonState b,
            ButtonState x,
            ButtonState y)
        {
            GamePadButtons gamePadButtons = default;

            try
            {
                gamePadButtons = new GamePadButtons(
                    start: start,
                    back: back,
                    leftStick: leftStick,
                    rightStick: rightStick,
                    leftShoulder: leftShoulder,
                    rightShoulder: rightShoulder,
                    guide: guide,
                    a: a,
                    b: b,
                    x: x,
                    y: y);
            }
            finally
            {
            }

            return gamePadButtons;
        }
    }
}