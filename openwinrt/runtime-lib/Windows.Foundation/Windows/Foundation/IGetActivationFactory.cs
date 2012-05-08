namespace Windows.Foundation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x4edb8ee2, 0x96dd, 0x49a7, 0x94, 0xf7, 70, 7, 0xdd, 0xab, 0x8e, 60), WebHostHidden]
    public interface IGetActivationFactory
    {
        object GetActivationFactory([In] string activatableClassId);
    }
}

