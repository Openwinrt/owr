namespace System.Collections.Generic
{
    using System;
    using System.Collections;
    using System.Reflection;

    public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
    {
        int IndexOf(T item);
        void Insert(int index, T item);
        void RemoveAt(int index);

        T this[int index] { get; set; }
    }
}

