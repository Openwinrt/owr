namespace Windows.ApplicationModel.Resources.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ResourceMapMapViewIterator : IIterator<IKeyValuePair<string, ResourceMap>>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint GetMany([Out] IKeyValuePair<string, ResourceMap>[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool MoveNext();

        public IKeyValuePair<string, ResourceMap> Current { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool HasCurrent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

