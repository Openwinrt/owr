namespace Windows.UI.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x188f20d6, 0x9873, 0x464a, 0xac, 0xe5, 0x57, 0xe0, 0x10, 0xf4, 0x65, 230)]
    public interface IInitializeWithCoreWindow
    {
        void Initialize([In] CoreWindow window);
    }
}

