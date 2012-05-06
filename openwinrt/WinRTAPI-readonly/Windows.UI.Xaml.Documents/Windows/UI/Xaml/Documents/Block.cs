namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Composable(typeof(IBlockFactory), CompositionType.Protected, 0x6020000), Version(0x6020000), Static(typeof(IBlockStatics), 0x6020000), WebHostHidden, Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class Block : TextElement, IBlock
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected Block();

        public double LineHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty LineHeightProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.LineStackingStrategy LineStackingStrategy { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty LineStackingStrategyProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.TextAlignment TextAlignment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty TextAlignmentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Documents.IBlock.LineHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.LineStackingStrategy Windows.UI.Xaml.Documents.IBlock.LineStackingStrategy { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.TextAlignment Windows.UI.Xaml.Documents.IBlock.TextAlignment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

