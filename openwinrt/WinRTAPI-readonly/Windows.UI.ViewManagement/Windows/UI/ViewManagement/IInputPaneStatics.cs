namespace Windows.UI.ViewManagement
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x95f4af3a, 0xef47, 0x424a, 0x97, 0x41, 0xfd, 40, 0x15, 0xeb, 0xa2, 0xbd), ExclusiveTo(typeof(InputPane))]
    internal interface IInputPaneStatics
    {
        InputPane GetForCurrentView();
    }
}

