namespace XInputSharp.Enums
{
    // https://learn.microsoft.com/en-us/windows/win32/api/xinput/ns-xinput-xinput_battery_information
    public enum BatteryType
    {
        Disconnected = 0x00,
        Wired = 0x01,
        Alkaline = 0x02,
        NIMH = 0x03,
        Unknown = 0xFF
    }
}