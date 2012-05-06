namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Static(typeof(IGeneratorPositionHelperStatics), 0x6020000), Version(0x6020000)]
    public sealed class GeneratorPositionHelper : IGeneratorPositionHelper
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static GeneratorPosition FromIndexAndOffset([In] int index, [In] int offset);
    }
}

