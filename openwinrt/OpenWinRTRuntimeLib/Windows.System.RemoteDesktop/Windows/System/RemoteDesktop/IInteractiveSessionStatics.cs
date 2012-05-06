namespace Windows.System.RemoteDesktop
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x60884631, 0xdd3a, 0x4576, 0x9c, 0x8d, 0xe8, 2, 0x76, 0x18, 0xbd, 0xce), ExclusiveTo(typeof(InteractiveSession))]
    internal interface IInteractiveSessionStatics
    {
        bool IsRemote { get; }
    }
}

