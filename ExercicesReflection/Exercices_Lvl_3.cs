using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicesReflection
{
    public class Exercices_Lvl_3
    {
        public static object instanciate_With_Generic_Type(Type GenericType, Type ToinstanciateType)
        {
            Type[] typeArgs = { ToinstanciateType };
            var craftedType = GenericType.MakeGenericType(typeArgs);
            object o = Activator.CreateInstance(craftedType);
            return o;
        }
    }
}
