namespace Windows.Storage
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ApplicationDataContainer)), Windows.Foundation.Metadata.Guid(0xc5aefd1e, 0xf467, 0x40ba, 0x85, 0x66, 0xab, 100, 10, 0x44, 30, 0x1d)]
    internal interface IApplicationDataContainer
    {
        ApplicationDataContainer CreateContainer([In] string name, [In] ApplicationDataCreateDisposition disposition);
        void DeleteContainer([In] string name);

        IMapView<string, ApplicationDataContainer> Containers { get; }

        ApplicationDataLocality Locality { get; }

        string Name { get; }

        IPropertySet Values { get; }
    }
}

