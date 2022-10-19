namespace XInputSharp.InterfacesFactories.Delegates
{
    using XInputSharp.Interfaces.Delegates;
    using XInputSharp.Interfaces.Libraries;

    public interface IXInputDelegatesFactory
    {
        IXInputDelegates Create(
            IXInputDelegateSupport XInputDelegateSupport,
            IXInputLibrary XInputLibrary);
    }
}