namespace System.Collections.Generic
{
    using System;
    using System.Collections;

    public interface IEnumerator<out T> : IEnumerator, IDisposable
    {
        T Current { get; }
    }
}

