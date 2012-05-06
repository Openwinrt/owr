namespace Windows.UI.Text
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Flags]
    public enum FindOptions : uint
    {
        Case = 4,
        None = 0,
        Word = 2
    }
}

