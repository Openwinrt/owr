namespace Windows.ApplicationModel.Resources.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ResourceContext)), Windows.Foundation.Metadata.Guid(0x2fa22f4b, 0x707e, 0x4b27, 0xad, 13, 0xd0, 0xd8, 0xcd, 70, 0x8f, 210)]
    internal interface IResourceContext
    {
        ResourceContext Clone();
        void OverrideToMatch([In] IIterable<ResourceQualifier> result);
        [Overload("Reset")]
        void Reset();
        [Overload("ResetQualifierValues")]
        void Reset([In] IIterable<string> qualifierNames);

        IVectorView<string> Languages { get; [param: In] set; }

        IObservableMap<string, string> QualifierValues { get; }
    }
}

