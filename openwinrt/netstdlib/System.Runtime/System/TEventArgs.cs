using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    //HACK where is it supposed to go ?
    public class TEventArgs<T>: EventArgs
    {
        T param;

        public TEventArgs(T param)
        {
            this.param = param;
        }

        /// <summary>
        /// Gets the param.
        /// </summary>
        /// <value>The param.</value>
        public T Param
        {
            get { return param; }
        }
    }
}
