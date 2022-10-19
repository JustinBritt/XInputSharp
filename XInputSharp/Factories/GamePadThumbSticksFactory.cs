namespace XInputSharp.Factories
{
    using XInputSharp.InterfacesFactories;
    using XInputSharp.Structs;

    internal sealed class GamePadThumbSticksFactory : IGamePadThumbSticksFactory
    {
        public GamePadThumbSticksFactory()
        {
        }

        public GamePadThumbSticks Create(
            GamePadThumbSticks.StickValue left,
            GamePadThumbSticks.StickValue right)
        {
            GamePadThumbSticks gamePadThumbSticks = default;

            try
            {
                gamePadThumbSticks = new GamePadThumbSticks(
                    left: left,
                    right: right);
            }
            finally
            {
            }

            return gamePadThumbSticks;
        }
    }
}