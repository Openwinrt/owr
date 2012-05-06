namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Guid(0x95ba1417, 0x4437, 0x451b, 0x94, 0x61, 5, 10, 0x49, 0xb5, 0x9d, 6)]
    public interface IAnnotationProvider
    {
        int AnnotationTypeId { get; }

        string AnnotationTypeName { get; }

        string Author { get; }

        string DateTime { get; }

        IRawElementProviderSimple Target { get; }
    }
}

