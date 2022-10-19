namespace XInputSharp.Factories
{
    using XInputSharp.InterfacesFactories;
    using XInputSharp.Structs;

    internal sealed class GamePadVibrationFactory : IGamePadVibrationFactory
    {
        public GamePadVibrationFactory()
        {
        }

        public GamePadVibration Create(
            ushort wLeftMotorSpeed,
            ushort wRightMotorSpeed)
        {
            GamePadVibration gamePadVibration = default;

            try
            {
                gamePadVibration = new GamePadVibration(
                    wLeftMotorSpeed: wLeftMotorSpeed,
                    wRightMotorSpeed: wRightMotorSpeed);
            }
            finally
            {
            }

            return gamePadVibration;
        }
    }
}