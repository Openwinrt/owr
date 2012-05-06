namespace Windows.UI.Xaml.Input
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x4a40bb52, 0x4bd7, 0x4e54, 0x86, 0x17, 0x1c, 0xda, 0x8a, 30, 0xda, 0x7f), Version(0x6020000), ExclusiveTo(typeof(InputScopeName))]
    internal interface IInputScopeNameFactory
    {
        InputScopeName CreateInstance([In] InputScopeNameValue nameValue);
    }
}

