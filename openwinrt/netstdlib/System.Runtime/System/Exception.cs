using System.Runtime.InteropServices;

namespace System
{
    public class Exception : _Exception
    {
#pragma warning disable 169, 649
        #region Sync with object-internals.h
        /* Stores the IPs and the generic sharing infos
		   (vtable/MRGCTX) of the frames. */
        IntPtr[] trace_ips;
        Exception inner_exception;
        internal string message;
        string help_link;
        string class_name;
        string stack_trace;
        // formerly known as remote_stack_trace (see #425512):
        string _remoteStackTraceString;
        int remote_stack_index;
        internal int hresult = -2146233088;
        string source;
        IDictionary _data;
        StackTrace[] captured_traces;
        #endregion
#pragma warning restore 169, 649

        /* Don't add fields here, the runtime depends on the layout of subclasses */



        public Exception()
        {
          
        }

        public Exception(string message) 
        {
            this.message = message;
        }

        public Exception(string message, Exception innerException)
        {
            inner_exception = innerException;
            this.message = message;

        }

        public virtual Exception GetBaseException()
        {
            Exception inner = inner_exception;

            while (inner != null)
            {
                if (inner.InnerException != null)
                    inner = inner.InnerException;
                else
                    return inner;
            }

            return this;

        }

        public override string ToString()
        {
            System.Text.StringBuilder result = new System.Text.StringBuilder(ClassName);
            result.Append(": ").Append(Message);

            if (null != _remoteStackTraceString)
                result.Append(_remoteStackTraceString);

            if (inner_exception != null)
            {
                result.Append(" ---> ").Append(inner_exception.ToString());
                result.Append(Environment.NewLine);
                result.Append(Locale.GetText("  --- End of inner exception stack trace ---"));
            }

            if (StackTrace != null)
                result.Append(Environment.NewLine).Append(StackTrace);
            return result.ToString();
        }

        internal Exception FixRemotingException()
        {
            string message = (0 == remote_stack_index) ?
                Locale.GetText("{0}{0}Server stack trace: {0}{1}{0}{0}Exception rethrown at [{2}]: {0}") :
                Locale.GetText("{1}{0}{0}Exception rethrown at [{2}]: {0}");
            string tmp = String.Format(message, Environment.NewLine, StackTrace, remote_stack_index);

            _remoteStackTraceString = tmp;
            remote_stack_index++;

            stack_trace = null;

            return this;

        }

        public virtual string HelpLink
        {
            get { return help_link; }
            set { help_link = value; }

        }

        public int HResult
        {
            get { return hresult; }
            set { hresult = value; }

        }

        public Exception InnerException
        {
            get { return inner_exception; }
        }


        public virtual string Message
        {
            get
            {
                if (message == null)
                    message = string.Format(Locale.GetText("Exception of type '{0}' was thrown."),
                        ClassName);

                return message;
            }
        }


        //public MethodBase TargetSite
        //{
        //    get
        //    {
        //        StackTrace st = new StackTrace(this, true);
        //        if (st.FrameCount > 0)
        //            return st.GetFrame(0).GetMethod();

        //        return null;
        //    }
        //}



        internal void SetMessage(string s)
        {
            message = s;
        }


        public virtual string Source
        {
            get
            {
                if (source == null)
                {
                    StackTrace st = new StackTrace(this, true);
                    if (st.FrameCount > 0)
                    {
                        StackFrame sf = st.GetFrame(0);
                        if (st != null)
                        {
                            MethodBase method = sf.GetMethod();
                            if (method != null)
                            {
                                source = method.DeclaringType.Assembly.UnprotectedGetName().Name;
                            }
                        }
                    }
                }

                // source can be null
                return source;
            }

            set
            {
                source = value;
            }
        }


        void AddFrames(StringBuilder sb, string newline, string unknown, StackTrace st)
        {
            for (int i = 0; i < st.FrameCount; i++)
            {
                StackFrame frame = st.GetFrame(i);
                if (i == 0)
                    sb.AppendFormat("  {0} ", Locale.GetText("at"));
                else
                    sb.Append(newline);

                if (frame.GetMethod() == null)
                {
                    string internal_name = frame.GetInternalMethodName();
                    if (internal_name != null)
                        sb.Append(internal_name);
                    else
                        sb.AppendFormat("<0x{0:x5}> {1}", frame.GetNativeOffset(), unknown);
                }
                else
                {
                    GetFullNameForStackTrace(sb, frame.GetMethod());

                    if (frame.GetILOffset() == -1)
                        sb.AppendFormat(" <0x{0:x5}> ", frame.GetNativeOffset());
                    else
                        sb.AppendFormat(" [0x{0:x5}] ", frame.GetILOffset());

                    sb.AppendFormat("in {0}:{1} ", frame.GetSecureFileName(),
                                     frame.GetFileLineNumber());
                }
            }
        }

        public virtual string StackTrace
        {
            get
            {
                if (stack_trace != null)
                    return stack_trace;

                if (trace_ips == null)
                    /* Not thrown yet */
                    return null;

                StringBuilder sb = new StringBuilder();

                string newline = String.Format("{0}  {1} ", Environment.NewLine, Locale.GetText("at"));
                string unknown = Locale.GetText("<unknown method>");

                // Add traces captured using ExceptionDispatchInfo
                if (captured_traces != null)
                {
                    foreach (var t in captured_traces)
                    {
                        AddFrames(sb, newline, unknown, t);
                        sb.Append(Environment.NewLine);
                        sb.Append("--- End of stack trace from previous location where exception was thrown ---");
                        sb.Append(Environment.NewLine);
                    }
                }

                StackTrace st = new StackTrace(this, 0, true, true);
                AddFrames(sb, newline, unknown, st);

                stack_trace = sb.ToString();

                return stack_trace;
            }
        }

        internal void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi)
        {
            ParameterInfo[] p = mi.GetParameters();
            sb.Append(mi.DeclaringType.ToString());
            sb.Append(".");
            sb.Append(mi.Name);

            if (mi.IsGenericMethod)
            {
                Type[] gen_params = mi.GetGenericArguments();
                sb.Append("[");
                for (int j = 0; j < gen_params.Length; j++)
                {
                    if (j > 0)
                        sb.Append(",");
                    sb.Append(gen_params[j].Name);
                }
                sb.Append("]");
            }

            sb.Append(" (");
            for (int i = 0; i < p.Length; ++i)
            {
                if (i > 0)
                    sb.Append(", ");
                Type pt = p[i].ParameterType;
                if (pt.IsClass && !String.IsNullOrEmpty(pt.Namespace))
                {
                    sb.Append(pt.Namespace);
                    sb.Append(".");
                }
                sb.Append(pt.Name);
                if (p[i].Name != null)
                {
                    sb.Append(" ");
                    sb.Append(p[i].Name);
                }
            }
            sb.Append(")");
        }

        // For ExceptionDispatchInfo
        internal void CaptureTrace()
        {
            if (captured_traces != null)
            {
                StackTrace[] new_traces = new StackTrace[captured_traces.Length + 1];
                Array.Copy(captured_traces, new_traces, captured_traces.Length);
                captured_traces = new_traces;
            }
            else
            {
                captured_traces = new StackTrace[1];
            }
            captured_traces[captured_traces.Length - 1] = new StackTrace(this, 0, true, true);

            trace_ips = null;
        }

    } //Exception
} //System

