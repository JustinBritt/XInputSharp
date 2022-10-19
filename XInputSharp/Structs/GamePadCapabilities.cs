namespace XInputSharp.Structs
{
    // https://learn.microsoft.com/en-us/windows/win32/api/xinput/ns-xinput-xinput_capabilities
    public struct GamePadCapabilities
    {
        public GamePadCapabilities(
            byte type,
            byte subType,
            ushort flags,
            GamePadState.RawState gamePad,
            GamePadVibration vibration)
        {
            this.Type = type;

            this.SubType = subType;

            this.Flags = flags;

            this.GamePad = gamePad;

            this.Vibration = vibration;
        }

        public byte Type { get; }

        public byte SubType { get; }

        public ushort Flags { get; }

        public GamePadState.RawState GamePad { get; }

        public GamePadVibration Vibration { get; }
    }
}