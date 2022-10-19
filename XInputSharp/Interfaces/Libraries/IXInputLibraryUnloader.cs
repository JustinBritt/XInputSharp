namespace XInputSharp.Interfaces.Libraries
{
    using System;

    public interface IXInputLibraryUnloader
    {
        void Unload(
            IntPtr hModule);
    }
}