namespace XInputSharp.Enums
{
    // https://learn.microsoft.com/en-us/windows/win32/api/xinput/ns-xinput-xinput_capabilities
    public enum Capabilities
    {
        VoiceSupported = 0x0004,
        ForceFeedbackSupported = 0x0001,
        Wireless = 0x0002,
        PluginModulesSupported = 0x0008,
        NoNavigation = 0x0010
    }
}