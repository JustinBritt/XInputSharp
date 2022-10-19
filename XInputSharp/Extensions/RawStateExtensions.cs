namespace XInputSharp.Extensions
{
    using XInputSharp.Enums;
    using XInputSharp.Structs;

    public static class RawStateExtensions
    {
        public static ButtonState GetButtonState(
            this GamePadState.RawState rawState,
            GamePadButton gamePadButton)
        {
            return (rawState.Gamepad.wButtons & (uint)gamePadButton) != 0 ? ButtonState.Pressed : ButtonState.Released;
        }
    }
}