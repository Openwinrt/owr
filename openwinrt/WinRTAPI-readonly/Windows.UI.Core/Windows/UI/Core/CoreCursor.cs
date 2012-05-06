namespace Windows.UI.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Activatable(typeof(ICoreCursorFactory), 0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class CoreCursor : ICoreCursor
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CoreCursor([In] CoreCursorType type, [In] uint id);

        public uint Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CoreCursorType Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.UI.Core.ICoreCursor.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CoreCursorType Windows.UI.Core.ICoreCursor.Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

