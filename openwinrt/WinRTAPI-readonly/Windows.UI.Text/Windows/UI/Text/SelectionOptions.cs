namespace Windows.UI.Text
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Flags]
    public enum SelectionOptions : uint
    {
        Active = 8,
        AtEndOfLine = 2,
        Overtype = 4,
        Replace = 0x10,
        StartActive = 1
    }
}

