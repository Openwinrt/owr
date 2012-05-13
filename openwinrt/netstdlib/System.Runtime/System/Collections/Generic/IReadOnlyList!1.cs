namespace System.Collections.Generic
{
    using System;
    using System.Collections;
    using System.Reflection;

    public interface IReadOnlyList<out T> : IEnumerable<T>, IEnumerable
    {
        int Count { get; }

        T this[int index] { get; }
    }
}

