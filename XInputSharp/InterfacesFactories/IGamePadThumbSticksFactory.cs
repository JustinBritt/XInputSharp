namespace XInputSharp.InterfacesFactories
{
    using XInputSharp.InterfacesFactories;
    using XInputSharp.Structs;

    public interface IGamePadThumbSticksFactory
    {
        GamePadThumbSticks Create(
            GamePadThumbSticks.StickValue left,
            GamePadThumbSticks.StickValue right);
    }
}