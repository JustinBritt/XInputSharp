namespace XInputSharp.Extensions
{
    using System;

    using XInputSharp.Enums;
    using XInputSharp.Structs;

    public static class GamePadBatteryInformationExtensions
    {
        public static BatteryLevel GetBatteryLevel(
            this GamePadBatteryInformation gamePadBatteryInformation)
        {
            return (BatteryLevel)Enum.Parse(
                typeof(BatteryLevel),
                gamePadBatteryInformation.BatteryLevel.ToString());
        }

        public static BatteryType GetBatteryType(
            this GamePadBatteryInformation gamePadBatteryInformation)
        {
            return (BatteryType)Enum.Parse(
                typeof(BatteryType),
                gamePadBatteryInformation.BatteryType.ToString());
        }
    }
}