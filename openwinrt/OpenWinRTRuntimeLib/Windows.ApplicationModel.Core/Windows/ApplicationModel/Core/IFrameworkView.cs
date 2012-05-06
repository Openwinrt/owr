namespace Windows.ApplicationModel.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Core;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xfaab5cd0, 0x8924, 0x45ac, 0xad, 15, 160, 0x8f, 0xae, 0x5d, 3, 0x24), WebHostHidden]
    public interface IFrameworkView
    {
        void Initialize([In] CoreApplicationView applicationView);
        void Load([In] string entryPoint);
        void Run();
        void SetWindow([In] CoreWindow window);
        void Uninitialize();
    }
}

