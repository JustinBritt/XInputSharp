namespace XInputSharp.Factories
{
    using XInputSharp.Enums;
    using XInputSharp.InterfacesFactories;
    using XInputSharp.Structs;

    internal sealed class GamePadDPadFactory : IGamePadDPadFactory
    {
        public GamePadDPadFactory()
        {
        }

        public GamePadDPad Create(
            ButtonState up,
            ButtonState down,
            ButtonState left,
            ButtonState right)
        {
            GamePadDPad gamePadDPad = default;

            try
            {
                gamePadDPad = new GamePadDPad(
                    up: up,
                    down: down,
                    left: left,
                    right: right);
            }
            finally
            {
            }

            return gamePadDPad;
        }
    }
}