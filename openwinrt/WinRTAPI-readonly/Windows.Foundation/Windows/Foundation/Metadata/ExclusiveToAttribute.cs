﻿namespace Windows.Foundation.Metadata
{
    using System;
    using System.Runtime.CompilerServices;

    [Version(0x6020000), Windows.Foundation.Metadata.AttributeUsage(Windows.Foundation.Metadata.AttributeTargets.Interface)]
    public sealed class ExclusiveToAttribute : Attribute
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ExclusiveToAttribute(Type typeName);
    }
}

