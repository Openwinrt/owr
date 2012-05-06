namespace Windows.UI.Core
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(InvokedHandlerArgs)), Version(0x6020000), Guid(0x63f62086, 0x85b5, 0x4f56, 0x83, 0xaf, 0xb2, 0xba, 0x71, 0x22, 0xf9, 200), WebHostHidden]
    internal interface IInvokedHandlerArgs
    {
        object Context { [return: Variant] get; }
    }
}

