namespace XInputSharp.Extensions
{
    using System;

    using XInputSharp.Enums;
    using XInputSharp.Structs;

    public static class GamePadCapabilitiesExtensions
    {
        public static DeviceSubType GetDeviceSubType(
            this GamePadCapabilities gamePadCapabilities)
        {
            return (DeviceSubType)Enum.Parse(
                typeof(DeviceSubType),
                gamePadCapabilities.SubType.ToString());
        }

        public static Capabilities GetFlags(
            this GamePadCapabilities gamePadCapabilities)
        {
            return (Capabilities)Enum.Parse(
                typeof(Capabilities),
                gamePadCapabilities.Flags.ToString());
        }
    }
}