namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x7b8eaeaf, 0xf92f, 0x439d, 0x9e, 0xbf, 0xe9, 0x91, 0x9f, 0x56, 0xc9, 0x4d), ExclusiveTo(typeof(OrientedVirtualizingPanel))]
    internal interface IOrientedVirtualizingPanelFactory
    {
        OrientedVirtualizingPanel CreateInstance([In] object outer, out object inner);
    }
}

