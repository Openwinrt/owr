namespace Windows.UI.Core
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000)]
    public enum CoreAcceleratorKeyEventType
    {
        KeyDown,
        KeyUp,
        Character,
        DeadCharacter,
        SystemKeyDown,
        SystemKeyUp,
        SystemCharacter,
        SystemDeadCharacter,
        UnicodeCharacter
    }
}

