namespace Windows.UI.Xaml.Controls.Primitives
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Guid(0x5ae3bf1a, 0x6e34, 0x40d6, 0x8a, 0x7f, 0xca, 130, 0x2a, 0xaf, 0x59, 0xe3), ExclusiveTo(typeof(Popup)), WebHostHidden]
    internal interface IPopupStatics
    {
        DependencyProperty ChildProperty { get; }

        DependencyProperty ChildTransitionsProperty { get; }

        DependencyProperty HorizontalOffsetProperty { get; }

        DependencyProperty IsLightDismissEnabledProperty { get; }

        DependencyProperty IsOpenProperty { get; }

        DependencyProperty VerticalOffsetProperty { get; }
    }
}

