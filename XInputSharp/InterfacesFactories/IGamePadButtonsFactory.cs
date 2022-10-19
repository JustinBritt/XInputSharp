namespace XInputSharp.InterfacesFactories
{
    using XInputSharp.Enums;
    using XInputSharp.Structs;

    public interface IGamePadButtonsFactory
    {
        GamePadButtons Create(
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
            ButtonState y);
    }
}