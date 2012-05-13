namespace System.Collections.ObjectModel
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;

    public class ReadOnlyCollection<T> : IList<T>, ICollection<T>, IReadOnlyList<T>, IEnumerable<T>, IList, ICollection, IEnumerable
    {
        public ReadOnlyCollection(IList<T> list)
        {
            base..ctor();
            return;
        }

        public bool Contains(T value)
        {
            return 0;
        }

        public void CopyTo(T[] array, int index)
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            return null;
        }

        public int IndexOf(T value)
        {
            return 0;
        }

        void ICollection<T>.Add(T value)
        {
        }

        void ICollection<T>.Clear()
        {
        }

        bool ICollection<T>.Remove(T value)
        {
            return 0;
        }

        void IList<T>.Insert(int index, T value)
        {
        }

        void IList<T>.RemoveAt(int index)
        {
        }

        void ICollection.CopyTo(Array array, int index)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }

        int IList.Add(object value)
        {
            return 0;
        }

        void IList.Clear()
        {
        }

        bool IList.Contains(object value)
        {
            return 0;
        }

        int IList.IndexOf(object value)
        {
            return 0;
        }

        void IList.Insert(int index, object value)
        {
        }

        void IList.Remove(object value)
        {
        }

        void IList.RemoveAt(int index)
        {
        }

        public int Count
        {
            get
            {
                return 0;
            }
        }

        public T this[int index]
        {
            get
            {
                T local;
                return default(T);
            }
        }

        protected IList<T> Items
        {
            get
            {
                return null;
            }
        }

        bool ICollection<T>.IsReadOnly
        {
            get
            {
                return 0;
            }
        }

        T IList<T>.this[int index]
        {
            get
            {
                T local;
                return default(T);
            }
            set
            {
            }
        }

        bool ICollection.IsSynchronized
        {
            get
            {
                return 0;
            }
        }

        object ICollection.SyncRoot
        {
            get
            {
                return null;
            }
        }

        bool IList.IsFixedSize
        {
            get
            {
                return 0;
            }
        }

        bool IList.IsReadOnly
        {
            get
            {
                return 0;
            }
        }

        object IList.this[int index]
        {
            get
            {
                return null;
            }
            set
            {
            }
        }
    }
}

