namespace System.Collections
{
    using System;

    public interface ICollection : IEnumerable
    {
        void CopyTo(Array array, int index);

        int Count { get; }

        bool IsSynchronized { get; }

        object SyncRoot { get; }
    }
}

