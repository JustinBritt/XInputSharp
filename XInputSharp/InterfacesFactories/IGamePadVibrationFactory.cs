namespace XInputSharp.InterfacesFactories
{
    using XInputSharp.Structs;

    public interface IGamePadVibrationFactory
    {
        GamePadVibration Create(
            ushort wLeftMotorSpeed,
            ushort wRightMotorSpeed);
    }
}