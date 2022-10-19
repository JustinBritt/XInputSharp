namespace XInputSharp.Structs
{
    using XInputSharp.Licensing;

    [XInputDotNetLicensedCode(
        boilerplate: XInputDotNetLicensedCodeAttribute.MITLicenseBoilerplate,
        copyrightOwner: XInputDotNetLicensedCodeAttribute.XInputDotNetCopyrightOwner,
        copyrightYears: XInputDotNetLicensedCodeAttribute.XInputDotNetCopyrightYears,
        source: "https://github.com/speps/XInputDotNet/blob/master/XInputDotNetPure/GamePad.cs")]
    public struct GamePadTriggers
    {
        public GamePadTriggers(
            float left,
            float right)
        {
            this.Left = left;
        
            this.Right = right;
        }

        public float Left { get; }

        public float Right { get; }
    }
}