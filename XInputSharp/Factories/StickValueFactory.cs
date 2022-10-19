namespace XInputSharp.Factories
{
    using XInputSharp.InterfacesFactories;
    using XInputSharp.Structs;

    internal sealed class StickValueFactory : IStickValueFactory
    {
        public StickValueFactory()
        {
        }

        public GamePadThumbSticks.StickValue Create(
            float x,
            float y)
        {
            GamePadThumbSticks.StickValue stickValue = default;

            try
            {
                stickValue = new GamePadThumbSticks.StickValue(
                    x: x,
                    y: y);
            }
            finally
            {
            }

            return stickValue;
        }
    }
}