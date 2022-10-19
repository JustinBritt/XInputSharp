namespace XInputSharp.Structs
{
    using XInputSharp.Enums;
    using XInputSharp.Licensing;

    [XInputDotNetLicensedCode(
        boilerplate: XInputDotNetLicensedCodeAttribute.MITLicenseBoilerplate,
        copyrightOwner: XInputDotNetLicensedCodeAttribute.XInputDotNetCopyrightOwner,
        copyrightYears: XInputDotNetLicensedCodeAttribute.XInputDotNetCopyrightYears,
        source: "https://github.com/speps/XInputDotNet/blob/master/XInputDotNetPure/GamePad.cs")]
    public struct GamePadButtons
    {
        public GamePadButtons(
            ButtonState start,
            ButtonState back,
            ButtonState leftStick,
            ButtonState rightStick,
            ButtonState leftShoulder,
            ButtonState rightShoulder,
            ButtonState guide,
            ButtonState a,
            ButtonState b,
            ButtonState x,
            ButtonState y)
        {
            this.Start = start;

            this.Back = back;
            
            this.LeftStick = leftStick;
            
            this.RightStick = rightStick;
            
            this.LeftShoulder = leftShoulder;
            
            this.RightShoulder = rightShoulder;
            
            this.Guide = guide;
            
            this.A = a;
            
            this.B = b;
            
            this.X = x;
            
            this.Y = y;
        }

        public ButtonState Start { get; }

        public ButtonState Back { get; }

        public ButtonState LeftStick { get; }

        public ButtonState RightStick { get; }

        public ButtonState LeftShoulder { get; }

        public ButtonState RightShoulder { get; }

        public ButtonState Guide { get; }

        public ButtonState A { get; }

        public ButtonState B { get; }

        public ButtonState X { get; }

        public ButtonState Y { get; }
    }
}