namespace XInputSharp.InterfacesFactories
{
    using XInputSharp.Enums;
    using XInputSharp.Structs;

    public interface IGamePadDPadFactory
    {
        GamePadDPad Create(
            ButtonState up,
            ButtonState down,
            ButtonState left,
            ButtonState right);
    }
}