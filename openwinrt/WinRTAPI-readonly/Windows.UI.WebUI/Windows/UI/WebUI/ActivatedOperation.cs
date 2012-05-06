namespace Windows.UI.WebUI
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ActivatedOperation : IActivatedOperation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ActivatedDeferral GetDeferral();
    }
}

