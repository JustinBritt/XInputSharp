namespace XInputSharp.Classes.Delegates
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using XInputSharp.Delegates;
    using XInputSharp.Enums.Delegates;
    using XInputSharp.Interfaces.Delegates;
    using XInputSharp.Interfaces.Libraries;

    internal sealed class XInputDelegates : IXInputDelegates
    {
        public XInputDelegates(
            IXInputDelegateSupport XInputDelegateSupport,
            IXInputLibrary XInputLibrary)
        {
            if (XInputDelegateSupport.IsDelegateSupportedByLibraryVersion(XInputDelegate.XInputEnableDelegate, XInputLibrary.XInputLibraryVersion))
            {
                this.XInputEnable = (XInputEnableDelegate)GetDelegateForFunctionName<XInputEnableDelegate>(
                    XInputLibrary.hModule,
                    XInputDelegateFunctionNameDictionary[XInputDelegate.XInputEnableDelegate]);
            }

            if (XInputDelegateSupport.IsDelegateSupportedByLibraryVersion(XInputDelegate.XInputGetAudioDeviceIdsDelegate, XInputLibrary.XInputLibraryVersion))
            {
                this.XInputGetAudioDeviceIds = (XInputGetAudioDeviceIdsDelegate)GetDelegateForFunctionName<XInputGetAudioDeviceIdsDelegate>(
                    XInputLibrary.hModule,
                    XInputDelegateFunctionNameDictionary[XInputDelegate.XInputGetAudioDeviceIdsDelegate]);
            }

            if (XInputDelegateSupport.IsDelegateSupportedByLibraryVersion(XInputDelegate.XInputGetBatteryInformationDelegate, XInputLibrary.XInputLibraryVersion))
            {
                this.XInputGetBatteryInformation = (XInputGetBatteryInformationDelegate)GetDelegateForFunctionName<XInputGetBatteryInformationDelegate>(
                    XInputLibrary.hModule,
                    XInputDelegateFunctionNameDictionary[XInputDelegate.XInputGetBatteryInformationDelegate]);
            }

            if (XInputDelegateSupport.IsDelegateSupportedByLibraryVersion(XInputDelegate.XInputGetCapabilitiesDelegate, XInputLibrary.XInputLibraryVersion))
            {
                this.XInputGetCapabilities = (XInputGetCapabilitiesDelegate)GetDelegateForFunctionName<XInputGetCapabilitiesDelegate>(
                    XInputLibrary.hModule,
                    XInputDelegateFunctionNameDictionary[XInputDelegate.XInputGetCapabilitiesDelegate]);
            }

            if (XInputDelegateSupport.IsDelegateSupportedByLibraryVersion(XInputDelegate.XInputGetKeystrokeDelegate, XInputLibrary.XInputLibraryVersion))
            {
                this.XInputGetKeystroke = (XInputGetKeystrokeDelegate)GetDelegateForFunctionName<XInputGetKeystrokeDelegate>(
                    XInputLibrary.hModule,
                    XInputDelegateFunctionNameDictionary[XInputDelegate.XInputGetKeystrokeDelegate]);
            }

            if (XInputDelegateSupport.IsDelegateSupportedByLibraryVersion(XInputDelegate.XInputGetStateDelegate, XInputLibrary.XInputLibraryVersion))
            {
                this.XInputGetState = (XInputGetStateDelegate)GetDelegateForFunctionName<XInputGetStateDelegate>(
                    XInputLibrary.hModule,
                    XInputDelegateFunctionNameDictionary[XInputDelegate.XInputGetStateDelegate]);
            }

            if (XInputDelegateSupport.IsDelegateSupportedByLibraryVersion(XInputDelegate.XInputSetStateDelegate, XInputLibrary.XInputLibraryVersion))
            {
                this.XInputSetState = (XInputSetStateDelegate)GetDelegateForFunctionName<XInputSetStateDelegate>(
                    XInputLibrary.hModule,
                    XInputDelegateFunctionNameDictionary[XInputDelegate.XInputSetStateDelegate]);
            }
        }

        private static readonly Dictionary<XInputDelegate, string> XInputDelegateFunctionNameDictionary = new Dictionary<XInputDelegate, string>()
        {
            { XInputDelegate.XInputEnableDelegate, "XInputEnable" },
            { XInputDelegate.XInputGetAudioDeviceIdsDelegate, "XInputGetAudioDeviceIds" },
            { XInputDelegate.XInputGetBatteryInformationDelegate, "XInputGetBatteryInformation" },
            { XInputDelegate.XInputGetCapabilitiesDelegate, "XInputGetCapabilities" },
            { XInputDelegate.XInputGetKeystrokeDelegate, "XInputGetKeystroke" },
            { XInputDelegate.XInputGetStateDelegate, "XInputGetState" },
            { XInputDelegate.XInputSetStateDelegate, "XInputSetState" },
        };

        public XInputEnableDelegate XInputEnable { get; }

        public XInputGetAudioDeviceIdsDelegate XInputGetAudioDeviceIds { get; }

        public XInputGetBatteryInformationDelegate XInputGetBatteryInformation { get; }

        public XInputGetCapabilitiesDelegate XInputGetCapabilities { get; }

        public XInputGetKeystrokeDelegate XInputGetKeystroke { get; }

        public XInputGetStateDelegate XInputGetState { get; }

        public XInputSetStateDelegate XInputSetState { get; }

        // https://stackoverflow.com/a/8836228
        public Delegate GetDelegateForFunctionName<T>(
            IntPtr hModule,
            string functionName)
        {
            return Marshal.GetDelegateForFunctionPointer(
                ptr: NativeMethods.GetProcAddress(
                    hModule,
                    functionName),
                t: typeof(T));
        }
    }
}