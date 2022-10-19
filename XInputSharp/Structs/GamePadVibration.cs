namespace XInputSharp.Structs
{
    public struct GamePadVibration
    {
        public GamePadVibration(
            ushort wLeftMotorSpeed,
            ushort wRightMotorSpeed)
        {
            this.wLeftMotorSpeed = wLeftMotorSpeed;

            this.wRightMotorSpeed = wRightMotorSpeed;
        }

        public ushort wLeftMotorSpeed { get; }

        public ushort wRightMotorSpeed { get; }
    }
}