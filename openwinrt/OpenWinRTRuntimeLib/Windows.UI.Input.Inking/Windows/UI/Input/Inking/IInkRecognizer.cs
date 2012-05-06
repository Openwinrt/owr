namespace Windows.UI.Input.Inking
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x77ccea3, 0x904d, 0x442a, 0xb1, 0x51, 170, 0xca, 0x36, 0x31, 0xc4, 0x3b)]
    public interface IInkRecognizer
    {
        string Name { get; }
    }
}

