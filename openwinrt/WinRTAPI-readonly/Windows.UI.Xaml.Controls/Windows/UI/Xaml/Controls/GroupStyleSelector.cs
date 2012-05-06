namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Composable(typeof(IGroupStyleSelectorFactory), CompositionType.Public, 0x6020000), Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class GroupStyleSelector : IGroupStyleSelector, IGroupStyleSelectorOverrides
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GroupStyleSelector();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GroupStyle SelectGroupStyle([In] object group, [In] uint level);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual GroupStyle SelectGroupStyleCore([In] object group, [In] uint level);
    }
}

