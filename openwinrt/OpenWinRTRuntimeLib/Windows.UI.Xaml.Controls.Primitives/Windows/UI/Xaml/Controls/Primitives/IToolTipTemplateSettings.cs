namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ToolTipTemplateSettings)), Guid(0xd4388247, 0xec4, 0x4506, 0xaf, 0xfd, 0xaf, 0xac, 0x22, 0x25, 180, 140), WebHostHidden]
    internal interface IToolTipTemplateSettings
    {
        double FromHorizontalOffset { get; }

        double FromVerticalOffset { get; }

        double ToHorizontalOffset { get; }

        double ToVerticalOffset { get; }
    }
}

