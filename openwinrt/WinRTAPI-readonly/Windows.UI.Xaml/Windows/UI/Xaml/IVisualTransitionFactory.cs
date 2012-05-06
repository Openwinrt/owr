namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xea75864f, 0xd1e0, 0x4dae, 180, 0x29, 0x89, 0xfc, 50, 0x27, 0x24, 0xf4), ExclusiveTo(typeof(VisualTransition))]
    internal interface IVisualTransitionFactory
    {
        VisualTransition CreateInstance([In] object outer, out object inner);
    }
}

