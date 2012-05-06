namespace Windows.UI.WebUI
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ActivatedOperation)), Guid(0xb6a0b4bc, 0xc6ca, 0x42fd, 0x98, 0x18, 0x71, 0x90, 0x4e, 0x45, 0xfe, 0xd7), Version(0x6020000)]
    internal interface IActivatedOperation
    {
        ActivatedDeferral GetDeferral();
    }
}

