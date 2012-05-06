namespace Windows.UI.Input.Inking
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class InkRecognizer : IInkRecognizer
    {
        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Input.Inking.IInkRecognizer.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

