namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;
    using Windows.UI.Xaml.Navigation;

    [ExclusiveTo(typeof(Frame)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x68ea500b, 0x3fe9, 0x4735, 0xb6, 160, 0xe7, 0x60, 0x19, 0x33, 0xb0, 0x89)]
    internal interface IFrame
    {
        event NavigatedEventHandler Navigated;

        event NavigatingCancelEventHandler Navigating;

        event NavigationFailedEventHandler NavigationFailed;

        event NavigationStoppedEventHandler NavigationStopped;

        string GetNavigationState();
        void GoBack();
        void GoForward();
        bool Navigate([In] TypeName sourcePageType, [In] object parameter);
        void SetNavigationState([In] string navigationState);
        void StopLoading();

        int CacheSize { get; [param: In] set; }

        bool CanGoBack { get; }

        bool CanGoForward { get; }

        TypeName CurrentSourcePageType { get; }

        TypeName SourcePageType { get; [param: In] set; }
    }
}

