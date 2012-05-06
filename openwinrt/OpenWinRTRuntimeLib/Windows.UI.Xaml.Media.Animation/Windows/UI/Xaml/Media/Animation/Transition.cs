namespace Windows.UI.Xaml.Media.Animation
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Composable(typeof(ITransitionFactory), CompositionType.Public, 0x6020000)]
    public class Transition : DependencyObject, ITransition
    {
    }
}

