namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Static(typeof(IStandardDataFormatsStatics), 0x6020000), Version(0x6020000), DualApiPartition(version=0x6020000)]
    public static class StandardDataFormats
    {
        public static string Bitmap { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Html { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Rtf { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string StorageItems { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Text { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Uri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

