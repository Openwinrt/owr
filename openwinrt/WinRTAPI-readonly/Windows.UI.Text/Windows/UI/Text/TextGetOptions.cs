namespace Windows.UI.Text
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Flags]
    public enum TextGetOptions : uint
    {
        AdjustCrlf = 1,
        AllowFinalEop = 8,
        FormatRtf = 0x2000,
        IncludeNumbering = 0x40,
        NoHidden = 0x20,
        None = 0,
        UseCrlf = 2,
        UseObjectText = 4
    }
}

