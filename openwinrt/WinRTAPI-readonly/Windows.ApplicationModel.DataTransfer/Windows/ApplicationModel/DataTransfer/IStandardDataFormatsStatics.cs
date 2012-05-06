namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(StandardDataFormats)), Version(0x6020000), Guid(0x7ed681a1, 0xa880, 0x40c9, 180, 0xed, 11, 0xee, 30, 0x15, 0xf5, 0x49)]
    internal interface IStandardDataFormatsStatics
    {
        string Bitmap { get; }

        string Html { get; }

        string Rtf { get; }

        string StorageItems { get; }

        string Text { get; }

        string Uri { get; }
    }
}

