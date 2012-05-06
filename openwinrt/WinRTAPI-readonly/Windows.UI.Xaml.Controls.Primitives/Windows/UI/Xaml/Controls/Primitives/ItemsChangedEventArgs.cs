namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class ItemsChangedEventArgs : IItemsChangedEventArgs
    {
        public int Action { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int ItemCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int ItemUICount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public GeneratorPosition OldPosition { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public GeneratorPosition Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Controls.Primitives.IItemsChangedEventArgs.Action { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Controls.Primitives.IItemsChangedEventArgs.ItemCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.UI.Xaml.Controls.Primitives.IItemsChangedEventArgs.ItemUICount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public GeneratorPosition Windows.UI.Xaml.Controls.Primitives.IItemsChangedEventArgs.OldPosition { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public GeneratorPosition Windows.UI.Xaml.Controls.Primitives.IItemsChangedEventArgs.Position { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

