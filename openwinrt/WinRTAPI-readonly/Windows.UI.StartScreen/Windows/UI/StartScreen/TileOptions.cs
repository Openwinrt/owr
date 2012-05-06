namespace Windows.UI.StartScreen
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Flags]
    public enum TileOptions : uint
    {
        CopyOnDeployment = 4,
        None = 0,
        ShowNameOnLogo = 1,
        ShowNameOnWideLogo = 2
    }
}

