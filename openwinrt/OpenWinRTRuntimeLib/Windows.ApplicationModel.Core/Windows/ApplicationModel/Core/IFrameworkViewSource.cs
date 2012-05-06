namespace Windows.ApplicationModel.Core
{
    using Windows.Foundation.Metadata;

    [WebHostHidden, Guid(0xcd770614, 0x65c4, 0x426c, 0x94, 0x94, 0x34, 0xfc, 0x43, 0x55, 0x48, 0x62), Version(0x6020000)]
    public interface IFrameworkViewSource
    {
        IFrameworkView CreateView();
    }
}

