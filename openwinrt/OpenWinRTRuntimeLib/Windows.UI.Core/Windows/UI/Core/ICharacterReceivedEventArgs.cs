namespace Windows.UI.Core
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(CharacterReceivedEventArgs)), Guid(0xc584659f, 0x99b2, 0x4bcc, 0xbd, 0x33, 4, 230, 0x3f, 0x42, 0x90, 0x2e), Version(0x6020000), WebHostHidden]
    internal interface ICharacterReceivedEventArgs : ICoreWindowEventArgs
    {
        uint KeyCode { get; }

        CorePhysicalKeyStatus KeyStatus { get; }
    }
}

