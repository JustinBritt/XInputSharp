namespace XInputSharp.Delegates
{
    using System;

    using XInputSharp.Structs;

    // https://learn.microsoft.com/en-us/windows/win32/api/xinput/nf-xinput-xinputenable
    public delegate uint XInputEnableDelegate(
        bool enable);

    public delegate uint XInputGetAudioDeviceIdsDelegate(
        uint dwUserIndex,
        out IntPtr pRenderDeviceId,
        out IntPtr pRenderCount,
        out IntPtr pCaptureDeviceId,
        out IntPtr pCaptureCount);

    public delegate uint XInputGetBatteryInformationDelegate(
        uint dwUserIndex,
        byte devType,
        out GamePadBatteryInformation pBatteryInformation);

    public delegate uint XInputGetCapabilitiesDelegate(
        uint dwUserIndex,
        uint dwFlags,
        out GamePadCapabilities pCapabilities);

    public delegate uint XInputGetKeystrokeDelegate(
        uint dwUserIndex,
        uint dwReserved,
        out GamePadKeystroke pKeystroke);

    public delegate uint XInputGetStateDelegate(
        uint dwUserIndex,
        out GamePadState.RawState pState);

    public delegate uint XInputSetStateDelegate(
        uint dwUserIndex,
        in GamePadVibration pVibration);
}