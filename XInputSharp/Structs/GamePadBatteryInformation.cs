namespace XInputSharp.Structs
{
    public struct GamePadBatteryInformation
    {
        public GamePadBatteryInformation(
            byte batteryType,
            byte batteryLevel)
        {
            this.BatteryType = batteryType;

            this.BatteryLevel = batteryLevel;
        }

        public byte BatteryType { get; }

        public byte BatteryLevel { get; }
    }
}