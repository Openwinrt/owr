namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xc4a9f225, 0x9db7, 0x4a7d, 0xb6, 0xd1, 0xf7, 0x4e, 0xdb, 0x92, 0x93, 0xc2), ExclusiveTo(typeof(Style))]
    internal interface IStyle
    {
        void Seal();

        Style BasedOn { get; [param: In] set; }

        bool IsSealed { get; }

        SetterBaseCollection Setters { get; }

        TypeName TargetType { get; [param: In] set; }
    }
}

