namespace Windows.UI.Core
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x80371d4f, 0x2fd8, 0x4c24, 170, 0x86, 0x31, 0x63, 0xa8, 0x7b, 0x4e, 90), WebHostHidden, ExclusiveTo(typeof(InputEnabledEventArgs)), Version(0x6020000)]
    internal interface IInputEnabledEventArgs : ICoreWindowEventArgs
    {
        bool InputEnabled { get; }
    }
}

