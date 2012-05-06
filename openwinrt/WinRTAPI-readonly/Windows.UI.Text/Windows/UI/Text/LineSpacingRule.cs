namespace Windows.UI.Text
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum LineSpacingRule
    {
        Undefined,
        Single,
        OneAndHalf,
        Double,
        AtLeast,
        Exactly,
        Multiple,
        Percent
    }
}

