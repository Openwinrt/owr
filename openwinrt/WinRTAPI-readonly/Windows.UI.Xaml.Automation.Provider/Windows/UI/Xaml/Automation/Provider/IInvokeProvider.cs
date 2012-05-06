namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Guid(0xf7d1a187, 0xb13c, 0x4540, 0xb0, 0x9e, 0x67, 120, 0xe2, 220, 0x9b, 0xa5), Version(0x6020000)]
    public interface IInvokeProvider
    {
        void Invoke();
    }
}

