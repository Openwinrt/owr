namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.MTA), Static(typeof(IStandardPrintTaskOptionsStatic), 0x6020000)]
    public static class StandardPrintTaskOptions
    {
        public static string Binding { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Collation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string ColorMode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Copies { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Duplex { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string HolePunch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string InputBin { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string MediaSize { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string MediaType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string NUp { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Orientation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string PrintQuality { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Staple { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

