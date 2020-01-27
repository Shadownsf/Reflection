using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ClassContainGenericMethod
    {
        public Type GetBaseType<T>(T t)
        {
            var type = t.GetType();
            return t.GetType().BaseType;
        }
    }
}
