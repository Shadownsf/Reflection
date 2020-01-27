using System;

namespace Models
{
    public class GenericType<T>
    {
        public Type GetBaseType<U>(U t)
        {
            return t.GetType().BaseType;
        }
    }
}
