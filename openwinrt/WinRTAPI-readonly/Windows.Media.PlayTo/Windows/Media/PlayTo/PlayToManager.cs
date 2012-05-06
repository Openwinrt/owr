namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), Static(typeof(IPlayToManagerStatics), 0x6020000)]
    public sealed class PlayToManager : IPlayToManager
    {
        public event TypedEventHandler<PlayToManager, PlayToSourceRequestedEventArgs> SourceRequested;

        public event TypedEventHandler<PlayToManager, PlayToSourceSelectedEventArgs> SourceSelected;

        public event TypedEventHandler<PlayToManager, PlayToSourceRequestedEventArgs> Windows.Media.PlayTo.IPlayToManager.SourceRequested;

        public event TypedEventHandler<PlayToManager, PlayToSourceSelectedEventArgs> Windows.Media.PlayTo.IPlayToManager.SourceSelected;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static PlayToManager GetForCurrentView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void ShowPlayToUI();

        public bool DefaultSourceSelection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.Media.PlayTo.IPlayToManager.DefaultSourceSelection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

