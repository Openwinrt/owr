namespace System2
{
    [AttributeUsage(0x7fff, Inherited=true, AllowMultiple=false)]
    ///HACK  till we wire up attributes
    public abstract class Attribute : System.Attribute 
    {
        protected Attribute()
        {
            //base..ctor();
            //return;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj) ;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

