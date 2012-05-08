﻿namespace Windows.Foundation.Metadata
{
    using System;
    using System.Runtime.CompilerServices;

    [Windows.Foundation.Metadata.AttributeUsage(Windows.Foundation.Metadata.AttributeTargets.RuntimeClass), Version(0x6020000), AllowMultiple]
    public sealed class ComposableAttribute : Attribute
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ComposableAttribute(Type type, CompositionType compositionType, uint version);
    }
}

