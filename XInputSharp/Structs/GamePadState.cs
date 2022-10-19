namespace XInputSharp.Structs
{
    using System.Runtime.InteropServices;

    using XInputSharp.Classes;
    using XInputSharp.Enums;
    using XInputSharp.Extensions;
    using XInputSharp.InterfacesFactories;
    using XInputSharp.Licensing;

    [XInputDotNetLicensedCode(
        boilerplate: XInputDotNetLicensedCodeAttribute.MITLicenseBoilerplate,
        copyrightOwner: XInputDotNetLicensedCodeAttribute.XInputDotNetCopyrightOwner,
        copyrightYears: XInputDotNetLicensedCodeAttribute.XInputDotNetCopyrightYears,
        source: "https://github.com/speps/XInputDotNet/blob/master/XInputDotNetPure/GamePad.cs")]
    public struct GamePadState
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct RawState
        {
            public uint dwPacketNumber;

            public GamePad Gamepad;

            [StructLayout(LayoutKind.Sequential)]
            public struct GamePad
            {
                public ushort wButtons;
            
                public byte bLeftTrigger;
                
                public byte bRightTrigger;
                
                public short sThumbLX;
                
                public short sThumbLY;
                
                public short sThumbRX;
                
                public short sThumbRY;
            }
        }

        public GamePadState(
            IGamePadButtonsFactory gamePadButtonsFactory,
            IGamePadDPadFactory gamePadDPadFactory,
            IGamePadThumbSticksFactory gamePadThumbSticksFactory,
            IGamePadTriggersFactory gamePadTriggersFactory,
            IStickValueFactory stickValueFactory,
            bool isConnected,
            RawState rawState,
            GamePadDeadZone deadZone)
        {
            this.IsConnected = isConnected;

            if (!isConnected)
            {
                rawState.dwPacketNumber = 0;

                rawState.Gamepad.wButtons = 0;
                
                rawState.Gamepad.bLeftTrigger = 0;
                
                rawState.Gamepad.bRightTrigger = 0;
                
                rawState.Gamepad.sThumbLX = 0;
                
                rawState.Gamepad.sThumbLY = 0;
                
                rawState.Gamepad.sThumbRX = 0;
                
                rawState.Gamepad.sThumbRY = 0;
            }

            this.PacketNumber = rawState.dwPacketNumber;

            this.Buttons = gamePadButtonsFactory.Create(
                start: rawState.GetButtonState(
                    GamePadButton.Start),
                back: rawState.GetButtonState(
                    GamePadButton.Back),
                leftStick: rawState.GetButtonState(
                    GamePadButton.LeftThumb),
                rightStick: rawState.GetButtonState(
                    GamePadButton.RightThumb),
                leftShoulder: rawState.GetButtonState(
                    GamePadButton.LeftShoulder),
                rightShoulder: rawState.GetButtonState(
                    GamePadButton.RightShoulder),
                guide: rawState.GetButtonState(
                    GamePadButton.Guide),
                a: rawState.GetButtonState(
                    GamePadButton.A),
                b: rawState.GetButtonState(
                    GamePadButton.B),
                x: rawState.GetButtonState(
                    GamePadButton.X),
                y: rawState.GetButtonState(
                    GamePadButton.Y));

            this.DPad = gamePadDPadFactory.Create(
                up: rawState.GetButtonState(
                    GamePadButton.DPadUp),
                down: rawState.GetButtonState(
                    GamePadButton.DPadDown),
                left: rawState.GetButtonState(
                    GamePadButton.DPadLeft),
                right: rawState.GetButtonState(
                    GamePadButton.DPadRight));

            this.ThumbSticks = gamePadThumbSticksFactory.Create(
                left: Utilities.ApplyLeftStickDeadZone(
                    stickValueFactory: stickValueFactory,
                    valueX: rawState.Gamepad.sThumbLX,
                    valueY: rawState.Gamepad.sThumbLY,
                    deadZoneMode: deadZone),
                right: Utilities.ApplyRightStickDeadZone(
                    stickValueFactory: stickValueFactory,
                    valueX: rawState.Gamepad.sThumbRX,
                    valueY: rawState.Gamepad.sThumbRY,
                    deadZoneMode: deadZone));

            this.Triggers = gamePadTriggersFactory.Create(
                left: Utilities.ApplyTriggerDeadZone(
                    value: rawState.Gamepad.bLeftTrigger,
                    deadZoneMode: deadZone),
                right: Utilities.ApplyTriggerDeadZone(
                    value: rawState.Gamepad.bRightTrigger,
                    deadZoneMode: deadZone));
        }

        public uint PacketNumber { get; }

        public bool IsConnected { get; }

        public GamePadButtons Buttons { get; }

        public GamePadDPad DPad { get; }

        public GamePadThumbSticks ThumbSticks { get; }

        public GamePadTriggers Triggers { get; }
    }
}