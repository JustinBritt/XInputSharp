namespace XInputSharp.AbstractFactories
{
    using XInputSharp.Factories;
    using XInputSharp.Factories.Delegates;
    using XInputSharp.Factories.Libraries;
    using XInputSharp.InterfacesAbstractFactories;
    using XInputSharp.InterfacesFactories;
    using XInputSharp.InterfacesFactories.Delegates;
    using XInputSharp.InterfacesFactories.Libraries;

    public sealed class XInputSharpAbstractFactory : IXInputSharpAbstractFactory
    {
        public XInputSharpAbstractFactory()
        {
        }

        public static IXInputSharpAbstractFactory Create()
        {
            return new XInputSharpAbstractFactory();
        }

        public IGamePadButtonsFactory CreateGamePadButtonsFactory()
        {
            IGamePadButtonsFactory factory = null;

            try
            {
                factory = new GamePadButtonsFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IGamePadDPadFactory CreateGamePadDPadFactory()
        {
            IGamePadDPadFactory factory = null;

            try
            {
                factory = new GamePadDPadFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IGamePadFactory CreateGamePadFactory()
        {
            IGamePadFactory factory = null;

            try
            {
                factory = new GamePadFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IGamePadStateFactory CreateGamePadStateFactory()
        {
            IGamePadStateFactory factory = null;

            try
            {
                factory = new GamePadStateFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IGamePadThumbSticksFactory CreateGamePadThumbSticksFactory()
        {
            IGamePadThumbSticksFactory factory = null;

            try
            {
                factory = new GamePadThumbSticksFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IGamePadTriggersFactory CreateGamePadTriggersFactory()
        {
            IGamePadTriggersFactory factory = null;

            try
            {
                factory = new GamePadTriggersFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IGamePadVibrationFactory CreateGamePadVibrationFactory()
        {
            IGamePadVibrationFactory factory = null;

            try
            {
                factory = new GamePadVibrationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IStickValueFactory CreateStickValueFactory()
        {
            IStickValueFactory factory = null;

            try
            {
                factory = new StickValueFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IXInputDelegatesFactory CreateXInputDelegatesFactory()
        {
            IXInputDelegatesFactory factory = null;

            try
            {
                factory = new XInputDelegatesFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IXInputDelegateSupportFactory CreateXInputDelegateSupportFactory()
        {
            IXInputDelegateSupportFactory factory = null;

            try
            {
                factory = new XInputDelegateSupportFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IXInputLibraryFactory CreateXInputLibraryFactory()
        {
            IXInputLibraryFactory factory = null;

            try
            {
                factory = new XInputLibraryFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IXInputLibraryLoaderFactory CreateXInputLibraryLoaderFactory()
        {
            IXInputLibraryLoaderFactory factory = null;

            try
            {
                factory = new XInputLibraryLoaderFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IXInputLibraryLoaderResultFactory CreateXInputLibraryLoaderResultFactory()
        {
            IXInputLibraryLoaderResultFactory factory = null;

            try
            {
                factory = new XInputLibraryLoaderResultFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IXInputLibraryUnloaderFactory CreateXInputLibraryUnloaderFactory()
        {
            IXInputLibraryUnloaderFactory factory = null;

            try
            {
                factory = new XInputLibraryUnloaderFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}