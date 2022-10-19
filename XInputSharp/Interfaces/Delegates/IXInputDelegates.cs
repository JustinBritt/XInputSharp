namespace XInputSharp.Interfaces.Delegates
{
    using System;

    using XInputSharp.Delegates;

    public interface IXInputDelegates
    {
        XInputEnableDelegate XInputEnable { get; }

        XInputGetAudioDeviceIdsDelegate XInputGetAudioDeviceIds { get; }

        XInputGetBatteryInformationDelegate XInputGetBatteryInformation { get; }

        XInputGetCapabilitiesDelegate XInputGetCapabilities { get; }

        XInputGetKeystrokeDelegate XInputGetKeystroke { get; }

        XInputGetStateDelegate XInputGetState { get; }

        XInputSetStateDelegate XInputSetState { get; }
    }
}