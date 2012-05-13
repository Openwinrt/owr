//
// ArraySegment.cs
//
// Authors:
//  Ben Maurer (bmaurer@ximian.com)
//  Jensen Somers <jensen.somers@gmail.com>
//
// Copyright (C) 2004 Novell
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace System
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ArraySegment<T> : IList<T>, ICollection<T>, IReadOnlyList<T>, IEnumerable<T>, IEnumerable
    {
        T[] array;
        int offset, count;

        public ArraySegment(T[] array)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            this.array = array;
            this.offset = 0;
            this.count = array.Length;
        }

        public ArraySegment(T[] array, int offset, int count)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            if (offset < 0)
                throw new ArgumentOutOfRangeException("offset", "Non-negative number required.");

            if (count < 0)
                throw new ArgumentOutOfRangeException("count", "Non-negative number required.");

            if (offset > array.Length)
                throw new ArgumentException("out of bounds");

            // now offset is valid, or just beyond the end.
            // Check count -- do it this way to avoid overflow on 'offset + count'
            if (array.Length - offset < count)
                throw new ArgumentException("out of bounds", "offset");

            this.array = array;
            this.offset = offset;
            this.count = count;
        }
        
        public T[] Array  { get { return array; }  } 
        public int Count  { get { return count; }  }
        public int Offset { get { return offset; } }

        bool ICollection<T>.IsReadOnly
        {
            get
            {
                return false; ///TODO array readonly ?
            }
        }
        T IList<T>.this[int index]
        {
            get
            {
                return array[index]; //CHECK
            }
            set
            {
                array[index] = value; //CHECK
            }
        }

        T IReadOnlyList<T>.this[int index]
        {
            get
            {
                return array[index]; //CHECK arracy throws outof range exception note runtime may not have check.
            }
        }

        public override bool Equals(Object obj)
        {
            if (obj is ArraySegment<T>)
            {
                return this.Equals((ArraySegment<T>)obj);
            }
            return false;
        }

        public bool Equals(ArraySegment<T> obj)
        {
            if ((this.array == obj.Array) && (this.offset == obj.Offset) && (this.count == obj.Count))
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return ((this.array.GetHashCode() ^ this.offset) ^ this.count);

        }

        public static bool operator ==(ArraySegment<T> a, ArraySegment<T> b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(ArraySegment<T> a, ArraySegment<T> b)
        {
            return !(a.Equals(b));
        }

        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException(); 
        }

        void ICollection<T>.Clear()
        {
            throw new NotImplementedException(); 
        }

        bool ICollection<T>.Contains(T item)
        {
            throw new NotImplementedException(); 
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException(); 
        }

        bool ICollection<T>.Remove(T item)
        {
            throw new NotImplementedException(); 
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException(); 
        }

        int IList<T>.IndexOf(T item)
        {
            throw new NotImplementedException(); 
        }

        void IList<T>.Insert(int index, T item)
        {
            throw new NotImplementedException(); 
        }

        void IList<T>.RemoveAt(int index)
        {
            throw new NotImplementedException(); 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException(); 
        }
    }
}

