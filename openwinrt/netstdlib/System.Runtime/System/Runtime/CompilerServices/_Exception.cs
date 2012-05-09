﻿
//
// System.Runtime.InteropServices._Attribute interface
//
// Author:
//	Sebastien Pouliot  <sebastien@ximian.com>
//
// Copyright (C) 2005 Novell, Inc (http://www.novell.com)
//
//   Ben Kloosterman
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

using System;


namespace System.Runtime.CompilerServices
{


    [Guid("b36b5c63-42ef-38bc-a07e-0b34c98f164a")]
    [CLSCompliant(false)]
    public interface _Exception
    {
        Exception GetBaseException();
        string HelpLink { get; set; }
        System.Int32 HResult { get; }
        Exception InnerException { get; }
        string Message { get; }
        string Source { get; set; }
        string StackTrace { get; }
        string ToString();


  

        //MethodBase TargetSite { get; }


        //bool Equals(object obj);

     

        //int GetHashCode();

      
        //Type GetType();

     
    }
}



