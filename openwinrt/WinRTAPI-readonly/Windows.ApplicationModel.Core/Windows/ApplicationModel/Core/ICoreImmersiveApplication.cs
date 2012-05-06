namespace Windows.ApplicationModel.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(CoreApplication)), Windows.Foundation.Metadata.Guid(0x1ada0e3e, 0xe4a2, 0x4123, 180, 0x51, 220, 150, 0xbf, 0x80, 4, 0x19), Version(0x6020000), WebHostHidden]
    internal interface ICoreImmersiveApplication
    {
        CoreApplicationView CreateNewView([In] string runtimeType, [In] string entryPoint);

        CoreApplicationView MainView { get; }

        IVectorView<CoreApplicationView> Views { get; }
    }
}

