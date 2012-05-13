namespace System
{
    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
    ///HACK  till we wire up attributes
    public abstract class Attribute : System.Attribute , System.Runtime.CompilerServices._Attribute 
    {
        protected Attribute()
        {
         
        }

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj) ;
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}
    }
}

