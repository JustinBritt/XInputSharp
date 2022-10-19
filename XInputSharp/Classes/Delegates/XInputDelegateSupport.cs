namespace XInputSharp.Classes.Delegates
{
    using XInputSharp.Enums.Delegates;
    using XInputSharp.Enums.Libraries;
    using XInputSharp.Interfaces.Delegates;

    internal sealed class XInputDelegateSupport : IXInputDelegateSupport
    {
        public XInputDelegateSupport()
        {
        }

        public bool IsDelegateSupportedByLibraryVersion(
            XInputDelegate XInputDelegate,
            XInputLibraryVersion XInputLibraryVersion)
        {
            return XInputDelegate switch
            {
                XInputDelegate.XInputEnableDelegate => XInputLibraryVersion switch
                {
                    XInputLibraryVersion.XInput1_3 => true,

                    XInputLibraryVersion.XInput1_4 => true,

                    XInputLibraryVersion.XInput9_1_0 => false,

                    _ => false
                },

                XInputDelegate.XInputGetAudioDeviceIdsDelegate => XInputLibraryVersion switch
                {
                    XInputLibraryVersion.XInput1_3 => true,

                    XInputLibraryVersion.XInput1_4 => true,

                    XInputLibraryVersion.XInput9_1_0 => true,

                    _ => false
                },

                XInputDelegate.XInputGetBatteryInformationDelegate => XInputLibraryVersion switch
                {
                    XInputLibraryVersion.XInput1_3 => true,

                    XInputLibraryVersion.XInput1_4 => true,

                    XInputLibraryVersion.XInput9_1_0 => false,

                    _ => false
                },

                XInputDelegate.XInputGetCapabilitiesDelegate => XInputLibraryVersion switch
                {
                    XInputLibraryVersion.XInput1_3 => true,

                    XInputLibraryVersion.XInput1_4 => true,

                    XInputLibraryVersion.XInput9_1_0 => true,

                    _ => false
                },

                XInputDelegate.XInputGetKeystrokeDelegate => XInputLibraryVersion switch
                {
                    XInputLibraryVersion.XInput1_3 => true,

                    XInputLibraryVersion.XInput1_4 => true,

                    XInputLibraryVersion.XInput9_1_0 => false,

                    _ => false
                },

                XInputDelegate.XInputGetStateDelegate => XInputLibraryVersion switch
                {
                    XInputLibraryVersion.XInput1_3 => true,

                    XInputLibraryVersion.XInput1_4 => true,

                    XInputLibraryVersion.XInput9_1_0 => true,

                    _ => false
                },

                XInputDelegate.XInputSetStateDelegate => XInputLibraryVersion switch
                {
                    XInputLibraryVersion.XInput1_3 => true,

                    XInputLibraryVersion.XInput1_4 => true,

                    XInputLibraryVersion.XInput9_1_0 => true,

                    _ => false
                },

                _ => false
            };
        }
    }
}