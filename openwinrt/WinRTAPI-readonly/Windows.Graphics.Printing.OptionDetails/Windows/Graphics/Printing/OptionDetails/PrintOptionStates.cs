namespace Windows.Graphics.Printing.OptionDetails
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Flags]
    public enum PrintOptionStates : uint
    {
        Constrained = 2,
        Enabled = 1,
        None = 0
    }
}

