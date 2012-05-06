namespace Windows.UI.Xaml.Automation.Peers
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden]
    public enum AutomationEvents
    {
        ToolTipOpened,
        ToolTipClosed,
        MenuOpened,
        MenuClosed,
        AutomationFocusChanged,
        InvokePatternOnInvoked,
        SelectionItemPatternOnElementAddedToSelection,
        SelectionItemPatternOnElementRemovedFromSelection,
        SelectionItemPatternOnElementSelected,
        SelectionPatternOnInvalidated,
        TextPatternOnTextSelectionChanged,
        TextPatternOnTextChanged,
        AsyncContentLoaded,
        PropertyChanged,
        StructureChanged,
        DragStart,
        DragCancel,
        DragComplete,
        DragEnter,
        DragLeave,
        Dropped
    }
}

