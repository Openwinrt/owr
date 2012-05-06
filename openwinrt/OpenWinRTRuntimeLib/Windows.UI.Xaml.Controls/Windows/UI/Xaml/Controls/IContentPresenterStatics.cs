namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Guid(0x18c2893b, 0xda2e, 0x4426, 0xb8, 90, 0x2c, 0x7e, 0x21, 0x71, 190, 0xdf), ExclusiveTo(typeof(ContentPresenter)), Version(0x6020000), WebHostHidden]
    internal interface IContentPresenterStatics
    {
        DependencyProperty CharacterSpacingProperty { get; }

        DependencyProperty ContentProperty { get; }

        DependencyProperty ContentTemplateProperty { get; }

        DependencyProperty ContentTemplateSelectorProperty { get; }

        DependencyProperty ContentTransitionsProperty { get; }

        DependencyProperty FontFamilyProperty { get; }

        DependencyProperty FontSizeProperty { get; }

        DependencyProperty FontStretchProperty { get; }

        DependencyProperty FontStyleProperty { get; }

        DependencyProperty FontWeightProperty { get; }

        DependencyProperty ForegroundProperty { get; }
    }
}

