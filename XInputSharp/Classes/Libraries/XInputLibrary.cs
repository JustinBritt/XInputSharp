namespace XInputSharp.Classes.Libraries
{
    using System;

    using XInputSharp.Enums.Libraries;
    using XInputSharp.Interfaces.Libraries;
    using XInputSharp.InterfacesFactories.Libraries;

    internal sealed class XInputLibrary : IXInputLibrary
    {
        public XInputLibrary(
            IXInputLibraryLoaderFactory XInputLibraryLoaderFactory,
            IXInputLibraryLoaderResultFactory XInputLibraryLoaderResultFactory,
            IXInputLibraryUnloaderFactory XInputLibraryUnloaderFactory)
        {
            IXInputLibraryLoader XInputLibraryLoader = XInputLibraryLoaderFactory.Create();

            IXInputLibraryLoaderResult XInputLibraryLoaderResult = XInputLibraryLoader.LoadOrDefault(
                XInputLibraryLoaderResultFactory);

            this.hModule = XInputLibraryLoaderResult.hModule;

            this.XInputLibraryVersion = XInputLibraryLoaderResult.XInputLibraryVersion;

            this.XInputLibraryUnloader = XInputLibraryUnloaderFactory.Create();
        }

        public IntPtr hModule { get; }

        public bool IsLoaded => this.hModule != default;

        private IXInputLibraryUnloader XInputLibraryUnloader { get; }

        public XInputLibraryVersion XInputLibraryVersion { get; }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                if (this.IsLoaded)
                {
                    this.XInputLibraryUnloader.Unload(
                        this.hModule);
                }
            }
        }
    }
}