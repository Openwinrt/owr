namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x6499997, 0xf7b4, 0x45fe, 0xb7, 0x63, 0x75, 0x77, 0xd1, 0xd3, 0xcb, 0x4a), Version(0x6020000), ExclusiveTo(typeof(Application))]
    internal interface IApplicationStatics
    {
        [DefaultOverload, Overload("LoadComponent")]
        void LoadComponent([In] object component, [In] Uri resourceLocator);
        [Overload("LoadComponentWithResourceLocation")]
        void LoadComponent([In] object component, [In] Uri resourceLocator, [In] ComponentResourceLocation componentResourceLocation);
        void Start([In] ApplicationInitializationCallback callback);

        Application Current { get; }
    }
}

