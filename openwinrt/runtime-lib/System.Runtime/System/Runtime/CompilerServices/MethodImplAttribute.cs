

namespace System2.Runtime.CompilerServices
{
    
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
    public sealed class MethodImplAttribute : Attribute
    {

        public MethodImplAttribute(MethodImplOptions methodImplOptions)
        {
        }


        public MethodImplOptions Value { get; private set; }
    }
}
