namespace XInputSharp.Interfaces
{
    using System;

    using XInputSharp.Enums;
    using XInputSharp.InterfacesFactories;
    using XInputSharp.Structs;

    public interface IGamePad : IDisposable
    {
        GamePadBatteryInformation GetGamePadBatteryInformationOrDefault(
            UserIndex userIndex);

        GamePadCapabilities GetGamePadCapabilitiesOrDefault(
            UserIndex userIndex);

        GamePadKeystroke GetGamePadKeystrokeOrDefault(
            UserIndex userIndex);

        GamePadState GetGamePadStateOrDefault(
            IGamePadButtonsFactory gamePadButtonsFactory,
            IGamePadDPadFactory gamePadDPadFactory,
            IGamePadStateFactory gamePadStateFactory,
            IGamePadThumbSticksFactory gamePadThumbSticksFactory,
            IGamePadTriggersFactory gamePadTriggersFactory,
            IStickValueFactory stickValueFactory,
            UserIndex userIndex);

        GamePadState GetGamePadStateOrDefault(
            IGamePadButtonsFactory gamePadButtonsFactory,
            IGamePadDPadFactory gamePadDPadFactory,
            IGamePadStateFactory gamePadStateFactory,
            IGamePadThumbSticksFactory gamePadThumbSticksFactory,
            IGamePadTriggersFactory gamePadTriggersFactory,
            IStickValueFactory stickValueFactory,
            UserIndex userIndex,
            GamePadDeadZone deadZone);

        void SetGamePadEnable(
            bool enable);

        void SetGamePadVibration(
            IGamePadVibrationFactory gamePadVibrationFactory,
            UserIndex userIndex,
            ushort leftMotor,
            ushort rightMotor);
    }
}