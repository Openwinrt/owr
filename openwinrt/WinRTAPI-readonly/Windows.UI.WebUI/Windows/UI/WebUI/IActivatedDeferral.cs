namespace Windows.UI.WebUI
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xc3bd1978, 0xa431, 0x49d8, 0xa7, 0x6a, 0x39, 90, 0x4e, 3, 220, 0xf3), Version(0x6020000), ExclusiveTo(typeof(ActivatedDeferral))]
    internal interface IActivatedDeferral
    {
        void Complete();
    }
}

