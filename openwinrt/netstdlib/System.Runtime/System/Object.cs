﻿
//
// System.Object.cs
//
// Author:
//   Miguel de Icaza (miguel@ximian.com)
//
// (C) Ximian, Inc.  http://www.ximian.com
//
//    Ben Kloosterman

//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
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

//using System.Runtime.InteropServices;
//using System.Runtime.CompilerServices;
//using System.Runtime.ConstrainedExecution;

using System.Security;

namespace System
{

    public class Object
    {

        // <summary>
        //   Initializes a new instance of the object class.
        // </summary>
        
        //    [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)] //removed , does mono need ?
        public Object()
        {
        }


        // <summary>
        //   Object destructor. 
        // </summary>
        public ~Object()
        {
        }

        protected virtual void Finalize()
        {
        }


        // <summary>
        //   Compares this object to the specified object.
        //   Returns true if they are equal, false otherwise.
        // </summary>
        public virtual bool Equals(object obj)
        {
            return this == obj;
        }



        // <summary>
        //   Compares two objects for equality
        // </summary>
        public static bool Equals(object objA, object objB)
        {
            if (objA == objB)
                return true;

            if (objA == null || objB == null)
                return false;

            return objA.Equals(objB);
        }



        // <summary>
        //   Returns a hashcode for this object.  Each derived
        //   class should return a hash code that makes sense
        //   for that particular implementation of the object.
        // </summary>
        public virtual int GetHashCode()
        {

            return InternalGetHashCode(this);

        }

       ///TODO [SecuritySafeCritical]
        public extern Type GetType();

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        internal static extern int InternalGetHashCode(object o);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        internal extern IntPtr obj_address();

        ///TODO  [SecuritySafeCritical]
        // <summary>
        //   Shallow copy of the object.
        // </summary>
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        protected extern object MemberwiseClone();



        // <summary>
        //   Tests whether a is equal to b.
        //   Can not figure out why this even exists
        // </summary>
        public static bool ReferenceEquals(object objA, object objB)
        {
            return (objA == objB);
        }

        // <summary>
        //   Returns a stringified representation of the object.
        //   This is not supposed to be used for user presentation,
        //   use Format() for that and IFormattable.
        //
        //   ToString is mostly used for debugging purposes. 
        // </summary>
        public virtual string ToString()
        {
            return GetType().ToString();
        }


    } //Object
} //System
