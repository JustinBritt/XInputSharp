namespace XInputSharp.Structs
{
    // https://learn.microsoft.com/en-us/windows/win32/api/xinput/ns-xinput-xinput_keystroke
    public struct GamePadKeystroke
    {
        public GamePadKeystroke(
            ushort virtualKey,
            string unicode,
            ushort flags,
            byte userIndex,
            byte hidCode)
        {
            this.VirtualKey = virtualKey;

            this.Unicode = unicode;

            this.Flags = flags;

            this.UserIndex = userIndex;

            this.HidCode = hidCode;
        }

        public ushort VirtualKey { get; }

        public string Unicode { get; }

        public ushort Flags { get; }

        public byte UserIndex { get; }

        public byte HidCode { get; }
    }
}