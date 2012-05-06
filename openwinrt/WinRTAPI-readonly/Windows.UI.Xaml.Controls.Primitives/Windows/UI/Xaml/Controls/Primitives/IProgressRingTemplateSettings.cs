namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, ExclusiveTo(typeof(ProgressRingTemplateSettings)), Guid(0xb9b675ec, 0xc723, 0x42e6, 0x83, 0xe9, 0x98, 0x26, 0x27, 0x2b, 220, 14), Version(0x6020000)]
    internal interface IProgressRingTemplateSettings
    {
        double EllipseDiameter { get; }

        Thickness EllipseOffset { get; }

        double MaxSideLength { get; }
    }
}

