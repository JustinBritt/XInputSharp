namespace XInputSharp.Factories.Delegates
{
    using XInputSharp.Classes.Delegates;
    using XInputSharp.Interfaces.Delegates;
    using XInputSharp.Interfaces.Libraries;
    using XInputSharp.InterfacesFactories.Delegates;

    internal sealed class XInputDelegatesFactory : IXInputDelegatesFactory
    {
        public XInputDelegatesFactory()
        {
        }

        public IXInputDelegates Create(
            IXInputDelegateSupport XInputDelegateSupport,
            IXInputLibrary XInputLibrary)
        {
            IXInputDelegates XInputDelegates = null;

            try
            {
                XInputDelegates = new XInputDelegates(
                    XInputDelegateSupport,
                    XInputLibrary);
            }
            finally
            {
            }

            return XInputDelegates;
        }
    }
}