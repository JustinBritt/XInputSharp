namespace XInputSharp.Factories.Delegates
{
    using XInputSharp.Classes.Delegates;
    using XInputSharp.Interfaces.Delegates;
    using XInputSharp.InterfacesFactories.Delegates;

    internal sealed class XInputDelegateSupportFactory : IXInputDelegateSupportFactory
    {
        public XInputDelegateSupportFactory()
        {
        }

        public IXInputDelegateSupport Create()
        {
            IXInputDelegateSupport XInputDelegateSupport = null;

            try
            {
                XInputDelegateSupport = new XInputDelegateSupport();
            }
            finally
            {
            }

            return XInputDelegateSupport;
        }
    }
}