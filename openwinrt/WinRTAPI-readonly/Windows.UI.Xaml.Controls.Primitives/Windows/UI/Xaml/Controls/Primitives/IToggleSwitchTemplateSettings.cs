namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ToggleSwitchTemplateSettings)), WebHostHidden, Version(0x6020000), Guid(0x2b7bdcd, 0x628a, 0x4363, 0x86, 0xe0, 0x51, 0xd6, 0xe2, 0xe8, 0x9e, 0x58)]
    internal interface IToggleSwitchTemplateSettings
    {
        double CurtainCurrentToOffOffset { get; }

        double CurtainCurrentToOnOffset { get; }

        double CurtainOffToOnOffset { get; }

        double CurtainOnToOffOffset { get; }

        double KnobCurrentToOffOffset { get; }

        double KnobCurrentToOnOffset { get; }

        double KnobOffToOnOffset { get; }

        double KnobOnToOffOffset { get; }
    }
}

