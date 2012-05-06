namespace Windows.UI.Xaml.Documents
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [ExclusiveTo(typeof(Run)), WebHostHidden, Version(0x6020000), Guid(0xe9303cef, 0x65a0, 0x4b8d, 0xa7, 0xf7, 0x8f, 0xdb, 40, 0x7b, 70, 0xf3)]
    internal interface IRunStatics
    {
        DependencyProperty FlowDirectionProperty { get; }
    }
}

