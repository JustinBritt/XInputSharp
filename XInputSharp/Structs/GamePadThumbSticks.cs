namespace XInputSharp.Structs
{
    using XInputSharp.Licensing;

    [XInputDotNetLicensedCode(
        boilerplate: XInputDotNetLicensedCodeAttribute.MITLicenseBoilerplate,
        copyrightOwner: XInputDotNetLicensedCodeAttribute.XInputDotNetCopyrightOwner,
        copyrightYears: XInputDotNetLicensedCodeAttribute.XInputDotNetCopyrightYears,
        source: "https://github.com/speps/XInputDotNet/blob/master/XInputDotNetPure/GamePad.cs")]
    public struct GamePadThumbSticks
    {
        public struct StickValue
        {
            public StickValue(
                float x,
                float y)
            {
                this.X = x;

                this.Y = y;
            }

            public float X { get; }

            public float Y { get; }
        }

        public GamePadThumbSticks(
            StickValue left,
            StickValue right)
        {
            this.Left = left;
            
            this.Right = right;
        }

        public StickValue Left { get; }

        public StickValue Right { get; }
    }
}