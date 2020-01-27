using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace ExercicesReflection
{
    public class Exercices_Lvl_2
    {
        public static Assembly Get_Assembly_From_Object(object o)
        {
            Assembly assembly = o.GetType().Assembly;
            return assembly;
        }

        public static AssemblyName[] Get_AssembliesName_Referenced(object o)
        {
            Assembly assembly = o.GetType().Assembly;
            AssemblyName[] NameOfreferencedAssemblies = assembly.GetReferencedAssemblies();
            return NameOfreferencedAssemblies;
        }

        public static object Get_Object_That_Implements_Interface(Assembly a, string interfaceName)
        {
            Type[] types = a.GetTypes();
            foreach (Type type in types)
            {
                if(type.GetInterface(interfaceName) != null)
                    return Activator.CreateInstance(type);
            }
            return null;
        }

        public static List<object> Get_Object_With_Partern(Assembly a, string pattern)
        {
            Type[] types = a.GetTypes();
            List<object> ObjectsMatched = new List<object>();
            types = types.Where(t => t.Name.Contains(pattern)).ToArray();

            foreach (Type type in types)
            {
               ObjectsMatched.Add(Activator.CreateInstance(type));
            }
            return ObjectsMatched;
        }
    }
}
