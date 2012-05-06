namespace Windows.UI.Text
{
    using System;
    using Windows.Foundation.Metadata;

    [Flags, Version(0x6020000)]
    public enum TextSetOptions : uint
    {
        ApplyRtfDocumentDefaults = 0x4000,
        CheckTextLimit = 0x20,
        FormatRtf = 0x2000,
        None = 0,
        Unhide = 0x10,
        UnicodeBidi = 1,
        Unlink = 8
    }
}

