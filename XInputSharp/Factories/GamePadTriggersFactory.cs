namespace XInputSharp.Factories
{
    using XInputSharp.InterfacesFactories;
    using XInputSharp.Structs;

    internal sealed class GamePadTriggersFactory : IGamePadTriggersFactory
    {
        public GamePadTriggersFactory()
        {
        }

        public GamePadTriggers Create(
            float left,
            float right)
        {
            GamePadTriggers gamePadTriggers = default;

            try
            {
                gamePadTriggers = new GamePadTriggers(
                    left: left,
                    right: right);
            }
            finally
            {
            }

            return gamePadTriggers;
        }
    }
}