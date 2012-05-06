namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PlayToManager)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xf56a206e, 0x1b77, 0x42ef, 0x8f, 13, 0xb9, 0x49, 0xf8, 0xd9, 0xb2, 0x60)]
    internal interface IPlayToManager
    {
        event TypedEventHandler<PlayToManager, PlayToSourceRequestedEventArgs> SourceRequested;

        event TypedEventHandler<PlayToManager, PlayToSourceSelectedEventArgs> SourceSelected;

        bool DefaultSourceSelection { get; [param: In] set; }
    }
}

