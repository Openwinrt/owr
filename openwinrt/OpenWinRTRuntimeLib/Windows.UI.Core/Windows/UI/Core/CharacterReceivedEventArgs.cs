namespace Windows.UI.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000)]
    public sealed class CharacterReceivedEventArgs : ICharacterReceivedEventArgs, ICoreWindowEventArgs
    {
        public bool Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint KeyCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CorePhysicalKeyStatus KeyStatus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.UI.Core.ICharacterReceivedEventArgs.KeyCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CorePhysicalKeyStatus Windows.UI.Core.ICharacterReceivedEventArgs.KeyStatus { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Core.ICoreWindowEventArgs.Handled { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

