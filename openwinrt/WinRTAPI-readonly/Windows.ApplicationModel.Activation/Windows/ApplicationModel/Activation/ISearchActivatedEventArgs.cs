namespace Windows.ApplicationModel.Activation
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x8cb36951, 0x58c8, 0x43e3, 0x94, 0xbc, 0x41, 0xd3, 0x3f, 0x8b, 0x63, 14), Version(0x6020000)]
    public interface ISearchActivatedEventArgs : IActivatedEventArgs
    {
        string Language { get; }

        string QueryText { get; }
    }
}

