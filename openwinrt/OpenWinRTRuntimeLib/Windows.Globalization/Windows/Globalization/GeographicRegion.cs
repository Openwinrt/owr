namespace Windows.Globalization
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IGeographicRegionStatics), 0x6020000), Activatable(typeof(IGeographicRegionFactory), 0x6020000), DualApiPartition(version=0x6020000), Activatable(0x6020000), Version(0x6020000)]
    public sealed class GeographicRegion : IGeographicRegion
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GeographicRegion();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public GeographicRegion([In] string geographicRegionCode);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool IsSupported([In] string geographicRegionCode);

        public string Code { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string CodeThreeDigit { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string CodeThreeLetter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string CodeTwoLetter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> CurrenciesInUse { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string DisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string NativeName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.IGeographicRegion.Code { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.IGeographicRegion.CodeThreeDigit { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.IGeographicRegion.CodeThreeLetter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.IGeographicRegion.CodeTwoLetter { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> Windows.Globalization.IGeographicRegion.CurrenciesInUse { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.IGeographicRegion.DisplayName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.IGeographicRegion.NativeName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

