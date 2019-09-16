using System;
using System.Reflection;

namespace ExercicesReflection
{
    public class Exercices_Lvl_3
    {
        public static object instanciate_GenericType(Type GenericType, Type ToinstanciateType)
        {
            Type[] typeArgs = { ToinstanciateType };
            var craftedType = GenericType.MakeGenericType(typeArgs);
            object o = Activator.CreateInstance(craftedType);
            return o;
        }

        public static Type Invoke_GenericMethod(Type t, string s, string nameOfMethod)
        {
            var stringArray = new object[1] { s };
            MethodInfo method = t.GetMethod(nameOfMethod);
            MethodInfo generic = method.MakeGenericMethod(t);
            return (Type)generic.Invoke(Activator.CreateInstance(t), stringArray);
        }
    }
}
