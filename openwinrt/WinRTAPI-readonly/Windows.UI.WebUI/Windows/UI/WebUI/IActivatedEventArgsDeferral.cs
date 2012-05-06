namespace Windows.UI.WebUI
{
    using Windows.Foundation.Metadata;

    [Guid(0xca6d5f74, 0x63c2, 0x44a6, 0xb9, 0x7b, 0xd9, 160, 60, 0x20, 0xbc, 0x9b), Version(0x6020000)]
    public interface IActivatedEventArgsDeferral
    {
        Windows.UI.WebUI.ActivatedOperation ActivatedOperation { get; }
    }
}

