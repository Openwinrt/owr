namespace Windows.UI.Text
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), Static(typeof(IFontWeightsStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden]
    public sealed class FontWeights : IFontWeights
    {
        public static FontWeight Black { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static FontWeight Bold { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static FontWeight ExtraBlack { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static FontWeight ExtraBold { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static FontWeight ExtraLight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static FontWeight Light { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static FontWeight Medium { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static FontWeight Normal { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static FontWeight SemiBold { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static FontWeight SemiLight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static FontWeight Thin { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

