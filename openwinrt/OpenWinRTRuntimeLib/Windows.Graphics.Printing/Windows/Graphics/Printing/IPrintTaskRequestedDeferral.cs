namespace Windows.Graphics.Printing
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xcfefb3f0, 0xce3e, 0x42c7, 0x94, 150, 100, 0x80, 12, 0x62, 0x2c, 0x44), Version(0x6020000), ExclusiveTo(typeof(PrintTaskRequestedDeferral))]
    internal interface IPrintTaskRequestedDeferral
    {
        void Complete();
    }
}

