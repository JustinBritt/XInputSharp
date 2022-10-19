namespace XInputSharp.InterfacesFactories
{
    using XInputSharp.Structs;

    public interface IStickValueFactory
    {
        GamePadThumbSticks.StickValue Create(
            float x,
            float y);
    }
}