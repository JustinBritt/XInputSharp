namespace XInputSharp.Classes
{
    using System;

    using XInputSharp.Enums;
    using XInputSharp.InterfacesFactories;
    using XInputSharp.Licensing;
    using XInputSharp.Structs;

    [XInputDotNetLicensedCode(
        boilerplate: XInputDotNetLicensedCodeAttribute.MITLicenseBoilerplate,
        copyrightOwner: XInputDotNetLicensedCodeAttribute.XInputDotNetCopyrightOwner,
        copyrightYears: XInputDotNetLicensedCodeAttribute.XInputDotNetCopyrightYears,
        source: "https://github.com/speps/XInputDotNet/blob/master/XInputDotNetPure/Utils.cs")]
    internal static class Utilities
    {
        public const uint Success = 0x000;
        public const uint NotConnected = 0x000;

        private const int LeftStickDeadZone = 7849;
        private const int RightStickDeadZone = 8689;
        private const int TriggerDeadZone = 30;

        public static float ApplyTriggerDeadZone(
            byte value,
            GamePadDeadZone deadZoneMode)
        {
            if (deadZoneMode == GamePadDeadZone.None)
            {
                return ApplyDeadZone(
                    value,
                    byte.MaxValue,
                    0.0f);
            }
            else
            {
                return ApplyDeadZone(
                    value,
                    byte.MaxValue,
                    TriggerDeadZone);
            }
        }

        public static GamePadThumbSticks.StickValue ApplyLeftStickDeadZone(
            IStickValueFactory stickValueFactory,
            short valueX,
            short valueY,
            GamePadDeadZone deadZoneMode)
        {
            return ApplyStickDeadZone(
                stickValueFactory,
                valueX,
                valueY,
                deadZoneMode,
                LeftStickDeadZone);
        }

        public static GamePadThumbSticks.StickValue ApplyRightStickDeadZone(
            IStickValueFactory stickValueFactory,
            short valueX,
            short valueY,
            GamePadDeadZone deadZoneMode)
        {
            return ApplyStickDeadZone(
                stickValueFactory,
                valueX,
                valueY,
                deadZoneMode,
                RightStickDeadZone);
        }

        private static GamePadThumbSticks.StickValue ApplyStickDeadZone(
            IStickValueFactory stickValueFactory,
            short valueX,
            short valueY,
            GamePadDeadZone deadZoneMode,
            int deadZoneSize)
        {
            if (deadZoneMode == GamePadDeadZone.Circular)
            {
                // Cast to long to avoid int overflow if valueX and valueY are both 32768, which would result in a negative number and Sqrt returns NaN
                float distanceFromCenter = (float)Math.Sqrt((long)valueX * (long)valueX + (long)valueY * (long)valueY);
                
                float coefficient = ApplyDeadZone(
                    distanceFromCenter,
                    short.MaxValue,
                    deadZoneSize);
                
                coefficient = coefficient > 0.0f ? coefficient / distanceFromCenter : 0.0f;
                
                return stickValueFactory.Create(
                    x: Clamp(
                        valueX * coefficient),
                    y: Clamp(
                        valueY * coefficient));
            }
            else if (deadZoneMode == GamePadDeadZone.IndependentAxes)
            {
                return stickValueFactory.Create(
                    x: ApplyDeadZone(
                        valueX,
                        short.MaxValue,
                        deadZoneSize),
                    y: ApplyDeadZone(
                        valueY,
                        short.MaxValue,
                        deadZoneSize));
            }
            else
            {
                return stickValueFactory.Create(
                    x: ApplyDeadZone(
                        valueX,
                        short.MaxValue,
                        0.0f),
                    y: ApplyDeadZone(
                        valueY,
                        short.MaxValue,
                        0.0f));
            }
        }

        private static float Clamp(
            float value)
        {
            return value < -1.0f ? -1.0f : (value > 1.0f ? 1.0f : value);
        }

        private static float ApplyDeadZone(
            float value,
            float maxValue,
            float deadZoneSize)
        {
            if (value < -deadZoneSize)
            {
                value += deadZoneSize;
            }
            else if (value > deadZoneSize)
            {
                value -= deadZoneSize;
            }
            else
            {
                return 0.0f;
            }

            value /= maxValue - deadZoneSize;

            return Clamp(
                value);
        }
    }
}