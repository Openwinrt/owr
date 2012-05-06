namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(GroupItem)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xd9a1d53e, 0xb1e0, 0x4319, 0x98, 8, 0x7a, 0x9e, 0x88, 0x7e, 0x13, 0xb0)]
    internal interface IGroupItemFactory
    {
        GroupItem CreateInstance([In] object outer, out object inner);
    }
}

