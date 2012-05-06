namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, ExclusiveTo(typeof(ContentControl)), Guid(0x116982a4, 0x5cf5, 0x4c05, 0xa5, 0x3f, 0x15, 0xe4, 0x87, 0x6c, 0x85, 0xec), Version(0x6020000)]
    internal interface IContentControlStatics
    {
        DependencyProperty ContentProperty { get; }

        DependencyProperty ContentTemplateProperty { get; }

        DependencyProperty ContentTemplateSelectorProperty { get; }

        DependencyProperty ContentTransitionsProperty { get; }
    }
}

