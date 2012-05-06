namespace Windows.Graphics.Printing
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PrintTaskSourceRequestedDeferral)), Guid(0x4a1560d1, 0x6992, 0x4d9d, 0x85, 0x55, 0x4c, 0xa4, 0x56, 0x3f, 0xb1, 0x66), Version(0x6020000)]
    internal interface IPrintTaskSourceRequestedDeferral
    {
        void Complete();
    }
}

