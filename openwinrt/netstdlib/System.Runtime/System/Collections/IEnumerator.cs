namespace System.Collections
{
    using System;

    public interface IEnumerator
    {
        bool MoveNext();
        void Reset();

        object Current { get; }
    }
}

