using System.Text;
namespace System
{
    public class BadImageFormatException : Exception
    {
        const int Result = unchecked((int)0x8007000B);

        // Fields
        private string fileName;
        private string fusionLog;

        // Constructors
        public BadImageFormatException()
            : base(Locale.GetText("Format of the executable (.exe) or library (.dll) is invalid."))
        {
            HResult = Result;
        }

        public BadImageFormatException(string message)
            : base(message)
        {
            HResult = Result;
        }


        //Mono ?
        //protected BadImageFormatException(SerializationInfo info, StreamingContext context)
        //    : base(info, context)
        //{
        //    fileName = info.GetString("BadImageFormat_FileName");
        //    fusionLog = info.GetString("BadImageFormat_FusionLog");
        //}


        public BadImageFormatException(string message, Exception inner)
            : base(message, inner)
        {
            HResult = Result;
        }

        public BadImageFormatException(string message, string fileName)
            : base(message)
        {
            this.fileName = fileName;
            HResult = Result;
        }


        public BadImageFormatException(string message, string fileName, Exception inner)
            : base(message, inner)
        {
            this.fileName = fileName;
            HResult = Result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(GetType().FullName);
            sb.AppendFormat(": {0}", Message);

            if (fileName != null && fileName.Length > 0)
            {
                sb.Append(Environment.NewLine);
                sb.AppendFormat("File name: '{0}'", fileName);
            }

            if (this.InnerException != null)
                sb.AppendFormat(" ---> {0}", InnerException);

            if (this.StackTrace != null)
            {
                sb.Append(Environment.NewLine);
                sb.Append(StackTrace);
            }

            return sb.ToString();
        }

        // Properties
        public override string Message
        {
            get
            {
                if (base.message == null)
                {
                    return string.Format(CultureInfo.CurrentCulture,
                        "Could not load file or assembly '{0}' or one of"
                        + " its dependencies. An attempt was made to load"
                        + " a program with an incorrect format.", fileName);
                }
                return base.Message;
            }
        }

        public string FileName
        {
            get { return fileName; }
        }

    }
}

