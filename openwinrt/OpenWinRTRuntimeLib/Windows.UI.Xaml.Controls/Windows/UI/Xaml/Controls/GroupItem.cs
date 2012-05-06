namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Composable(typeof(IGroupItemFactory), CompositionType.Public, 0x6020000)]
    public class GroupItem : ContentControl, IGroupItem
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GroupItem();
    }
}

