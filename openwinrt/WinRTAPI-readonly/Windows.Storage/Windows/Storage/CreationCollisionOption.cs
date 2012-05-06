namespace Windows.Storage
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum CreationCollisionOption
    {
        GenerateUniqueName,
        ReplaceExisting,
        FailIfExists,
        OpenIfExists
    }
}

