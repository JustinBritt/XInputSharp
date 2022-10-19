namespace XInputSharp.Classes
{
    using System;

    using XInputSharp.Enums;
    using XInputSharp.Enums.Delegates;
    using XInputSharp.Interfaces;
    using XInputSharp.Interfaces.Delegates;
    using XInputSharp.Interfaces.Libraries;
    using XInputSharp.InterfacesFactories;
    using XInputSharp.InterfacesFactories.Delegates;
    using XInputSharp.InterfacesFactories.Libraries;
    using XInputSharp.Licensing;
    using XInputSharp.Structs;

    [XInputDotNetLicensedCode(
        boilerplate: XInputDotNetLicensedCodeAttribute.MITLicenseBoilerplate,
        copyrightOwner: XInputDotNetLicensedCodeAttribute.XInputDotNetCopyrightOwner,
        copyrightYears: XInputDotNetLicensedCodeAttribute.XInputDotNetCopyrightYears,
        source: "https://github.com/speps/XInputDotNet/blob/master/XInputDotNetPure/GamePad.cs")]
    internal sealed class GamePad : IGamePad
    {
        public GamePad(
            IXInputDelegatesFactory XInputDelegatesFactory,
            IXInputDelegateSupportFactory XInputDelegateSupportFactory,
            IXInputLibraryFactory XInputLibraryFactory,
            IXInputLibraryLoaderFactory XInputLibraryLoaderFactory,
            IXInputLibraryLoaderResultFactory XInputLibraryLoaderResultFactory,
            IXInputLibraryUnloaderFactory XInputLibraryUnloaderFactory)
        {
            this.XInputLibrary = XInputLibraryFactory.Create(
                XInputLibraryLoaderFactory,
                XInputLibraryLoaderResultFactory,
                XInputLibraryUnloaderFactory);

            this.XInputDelegateSupport = XInputDelegateSupportFactory.Create();

            if (this.XInputLibrary.IsLoaded)
            {
                this.XInputDelegates = XInputDelegatesFactory.Create(
                    this.XInputDelegateSupport,
                    this.XInputLibrary);
            }
            else
            {
                throw new Exception();
            }
        }

        private IXInputDelegates XInputDelegates { get; }

        private IXInputDelegateSupport XInputDelegateSupport { get; }

        private IXInputLibrary XInputLibrary { get; }

        public GamePadBatteryInformation GetGamePadBatteryInformationOrDefault(
            UserIndex userIndex)
        {
            if (XInputDelegateSupport.IsDelegateSupportedByLibraryVersion(XInputDelegate.XInputGetBatteryInformationDelegate, this.XInputLibrary.XInputLibraryVersion))
            {
                GamePadBatteryInformation gamePadBatteryInformation;

                uint result = XInputDelegates.XInputGetBatteryInformation(
                    (uint)userIndex,
                    (byte)BatteryDeviceType.GamePad,
                    out gamePadBatteryInformation);

                return gamePadBatteryInformation;
            }

            return default;
        }

        public GamePadCapabilities GetGamePadCapabilitiesOrDefault(
            UserIndex userIndex)
        {
            if (XInputDelegateSupport.IsDelegateSupportedByLibraryVersion(XInputDelegate.XInputGetCapabilitiesDelegate, this.XInputLibrary.XInputLibraryVersion))
            {
                GamePadCapabilities gamePadCapabilities;

                uint result = XInputDelegates.XInputGetCapabilities(
                    (uint)userIndex,
                    (uint)0,
                    out gamePadCapabilities);

                return gamePadCapabilities;
            }

            return default;
        }

        public GamePadKeystroke GetGamePadKeystrokeOrDefault(
            UserIndex userIndex)
        {
            if (XInputDelegateSupport.IsDelegateSupportedByLibraryVersion(XInputDelegate.XInputGetKeystrokeDelegate, this.XInputLibrary.XInputLibraryVersion))
            {
                GamePadKeystroke gamePadKeystroke;

                uint result = XInputDelegates.XInputGetKeystroke(
                    (uint)userIndex,
                    (uint)0,
                    out gamePadKeystroke);

                return gamePadKeystroke;
            }

            return default;
        }

        public GamePadState GetGamePadStateOrDefault(
            IGamePadButtonsFactory gamePadButtonsFactory,
            IGamePadDPadFactory gamePadDPadFactory,
            IGamePadStateFactory gamePadStateFactory,
            IGamePadThumbSticksFactory gamePadThumbSticksFactory,
            IGamePadTriggersFactory gamePadTriggersFactory,
            IStickValueFactory stickValueFactory,
            UserIndex userIndex)
        {
            return this.GetGamePadStateOrDefault(
                gamePadButtonsFactory,
                gamePadDPadFactory,
                gamePadStateFactory,
                gamePadThumbSticksFactory,
                gamePadTriggersFactory,
                stickValueFactory,
                userIndex,
                GamePadDeadZone.IndependentAxes);
        }

        public GamePadState GetGamePadStateOrDefault(
            IGamePadButtonsFactory gamePadButtonsFactory,
            IGamePadDPadFactory gamePadDPadFactory,
            IGamePadStateFactory gamePadStateFactory,
            IGamePadThumbSticksFactory gamePadThumbSticksFactory,
            IGamePadTriggersFactory gamePadTriggersFactory,
            IStickValueFactory stickValueFactory,
            UserIndex userIndex,
            GamePadDeadZone deadZone)
        {
            if (XInputDelegateSupport.IsDelegateSupportedByLibraryVersion(XInputDelegate.XInputGetStateDelegate, this.XInputLibrary.XInputLibraryVersion))
            {
                GamePadState.RawState state;

                uint result = XInputDelegates.XInputGetState(
                    (uint)userIndex,
                    out state);

                GamePadState gamePadState = gamePadStateFactory.Create(
                    gamePadButtonsFactory,
                    gamePadDPadFactory,
                    gamePadThumbSticksFactory,
                    gamePadTriggersFactory,
                    stickValueFactory,
                    result == Utilities.Success,
                    state,
                    deadZone);

                return gamePadState;
            }

            return default;
        }

        public void SetGamePadEnable(
            bool enable)
        {
            if (XInputDelegateSupport.IsDelegateSupportedByLibraryVersion(XInputDelegate.XInputEnableDelegate, this.XInputLibrary.XInputLibraryVersion))
            {
                uint result = XInputDelegates.XInputEnable(
                    enable);
            }
        }

        public void SetGamePadVibration(
            IGamePadVibrationFactory gamePadVibrationFactory,
            UserIndex userIndex,
            ushort leftMotor,
            ushort rightMotor)
        {
            if (XInputDelegateSupport.IsDelegateSupportedByLibraryVersion(XInputDelegate.XInputSetStateDelegate, this.XInputLibrary.XInputLibraryVersion))
            {
                GamePadVibration gamePadVibration = gamePadVibrationFactory.Create(
                    leftMotor,
                    rightMotor);

                uint result = XInputDelegates.XInputSetState(
                    (uint)userIndex,
                    in gamePadVibration);
            }
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.XInputLibrary.Dispose();
            }
        }
    }
}