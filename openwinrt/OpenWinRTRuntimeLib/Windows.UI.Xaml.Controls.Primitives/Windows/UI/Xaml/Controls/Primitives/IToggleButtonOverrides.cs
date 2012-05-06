namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(ToggleButton)), Guid(0xd20e4c28, 0xf18b, 0x491a, 0x9a, 0x45, 0xf1, 160, 0x4a, 0x93, 0x69, 0xa4)]
    internal interface IToggleButtonOverrides
    {
        void OnToggle();
    }
}

