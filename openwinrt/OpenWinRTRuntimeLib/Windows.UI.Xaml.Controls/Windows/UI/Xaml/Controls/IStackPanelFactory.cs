namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x63d8248a, 0x8b34, 0x445a, 0x80, 0x8f, 0xb6, 0xec, 0xd6, 0x2a, 0x27, 0xd9), Version(0x6020000), ExclusiveTo(typeof(StackPanel))]
    internal interface IStackPanelFactory
    {
        StackPanel CreateInstance([In] object outer, out object inner);
    }
}

