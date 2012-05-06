namespace Windows.ApplicationModel.Search
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class SearchPaneQueryLinguisticDetails : ISearchPaneQueryLinguisticDetails
    {
        public IVectorView<string> QueryTextAlternatives { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint QueryTextCompositionLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint QueryTextCompositionStart { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<string> Windows.ApplicationModel.Search.ISearchPaneQueryLinguisticDetails.QueryTextAlternatives { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.ApplicationModel.Search.ISearchPaneQueryLinguisticDetails.QueryTextCompositionLength { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.ApplicationModel.Search.ISearchPaneQueryLinguisticDetails.QueryTextCompositionStart { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

