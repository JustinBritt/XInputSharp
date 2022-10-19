namespace XInputSharp.InterfacesFactories
{
    using XInputSharp.Structs;

    public interface IGamePadTriggersFactory
    {
        GamePadTriggers Create(
            float left,
            float right);
    }
}