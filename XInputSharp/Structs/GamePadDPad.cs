namespace XInputSharp.Structs
{
    using XInputSharp.Enums;
    using XInputSharp.Licensing;

    [XInputDotNetLicensedCode(
        boilerplate: XInputDotNetLicensedCodeAttribute.MITLicenseBoilerplate,
        copyrightOwner: XInputDotNetLicensedCodeAttribute.XInputDotNetCopyrightOwner,
        copyrightYears: XInputDotNetLicensedCodeAttribute.XInputDotNetCopyrightYears,
        source: "https://github.com/speps/XInputDotNet/blob/master/XInputDotNetPure/GamePad.cs")]
    public struct GamePadDPad
    {
        public GamePadDPad(
            ButtonState up,
            ButtonState down,
            ButtonState left,
            ButtonState right)
        {
            this.Up = up;
            
            this.Down = down;
            
            this.Left = left;
            
            this.Right = right;
        }

        public ButtonState Up { get; }

        public ButtonState Down { get; }

        public ButtonState Left { get; }

        public ButtonState Right { get; }
    }
}