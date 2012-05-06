namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x7f138a08, 0xfbb7, 0x4b09, 0x83, 0x56, 170, 0x5f, 0x4e, 0x33, 0x5c, 0x31), ExclusiveTo(typeof(PlayToSource))]
    internal interface IPlayToSource
    {
        void PlayNext();

        PlayToConnection Connection { get; }

        PlayToSource Next { get; [param: In] set; }
    }
}

