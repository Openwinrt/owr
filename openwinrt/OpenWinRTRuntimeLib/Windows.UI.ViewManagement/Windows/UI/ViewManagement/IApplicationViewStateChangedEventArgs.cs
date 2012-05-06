namespace Windows.UI.ViewManagement
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ApplicationViewStateChangedEventArgs)), Guid(0x7eddac86, 0xd8b1, 0x4cf2, 0x90, 0xba, 0x79, 0x42, 0xe1, 0xcf, 0x33, 0xc5)]
    internal interface IApplicationViewStateChangedEventArgs
    {
        ApplicationViewState ViewState { get; }
    }
}

