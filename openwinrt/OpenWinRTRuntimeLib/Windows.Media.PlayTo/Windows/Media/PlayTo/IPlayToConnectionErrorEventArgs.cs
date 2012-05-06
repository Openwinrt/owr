namespace Windows.Media.PlayTo
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xbf5eada6, 0x88e6, 0x445f, 0x9d, 0x40, 0xd9, 0xb9, 0xf8, 0x93, 0x98, 150), ExclusiveTo(typeof(PlayToConnectionErrorEventArgs))]
    internal interface IPlayToConnectionErrorEventArgs
    {
        PlayToConnectionError Code { get; }

        string Message { get; }
    }
}

