namespace XInputSharp.Enums
{
    // https://learn.microsoft.com/en-us/windows/win32/xinput/xinput-and-controller-subtypes
    public enum DeviceSubType
    {
        Unknown = 0x00,
        GamePad = 0x01,
        Wheel = 0x02,
        ArcadeStick = 0x03,
        FlightStick = 0x04,
        DancePad = 0x05,
        Guitar = 0x06,
        GuitarAlternate = 0x07,
        DrumKit = 0x08,
        GuitarBass = 0x0B,
        ArcadePad = 0x13
    }
}