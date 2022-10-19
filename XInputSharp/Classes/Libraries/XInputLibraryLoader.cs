namespace XInputSharp.Classes.Libraries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using XInputSharp.Enums.Libraries;
    using XInputSharp.Interfaces.Libraries;
    using XInputSharp.InterfacesFactories.Libraries;

    internal sealed class XInputLibraryLoader : IXInputLibraryLoader
    {
        public XInputLibraryLoader()
        {
        }

        private static readonly Dictionary<XInputLibraryVersion, string> XInputLibraryLibraryVersionFileNameDictionary = new Dictionary<XInputLibraryVersion, string>()
        {
            {  XInputLibraryVersion.XInput1_4, "xinput1_4" },
            {  XInputLibraryVersion.XInput1_3, "xinput1_3" },
            {  XInputLibraryVersion.XInput9_1_0, "xinput9_1_0" }
        };

        public IXInputLibraryLoaderResult LoadOrDefault(
            IXInputLibraryLoaderResultFactory XInputLibraryLoaderResultFactory)
        {
            IntPtr hModule = default;

            for (int i = 0; i < XInputLibraryLibraryVersionFileNameDictionary.Count; i = i + 1)
            {
                hModule = NativeMethods.LoadLibrary(
                    XInputLibraryLibraryVersionFileNameDictionary.ElementAt(i).Value);

                if (hModule != default)
                {
                    return XInputLibraryLoaderResultFactory.Create(
                        hModule,
                        XInputLibraryLibraryVersionFileNameDictionary.ElementAt(i).Key);
                }
            }

            return default;
        }
    }
}