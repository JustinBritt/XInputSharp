namespace XInputSharp.Interfaces.Delegates
{
    using XInputSharp.Enums.Delegates;
    using XInputSharp.Enums.Libraries;

    public interface IXInputDelegateSupport
    {
        bool IsDelegateSupportedByLibraryVersion(
            XInputDelegate XInputDelegate,
            XInputLibraryVersion XInputLibraryVersion);
    }
}