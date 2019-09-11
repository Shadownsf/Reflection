using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Models;

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

        public static Assembly Get_Assembly_By_Name(string name) // return null if assembly do not exists
        {
            var Person = new Person();
            Assembly currentAssembly = typeof(Exercices_Lvl_2).Assembly;
            var referencedAssemblies = currentAssembly.GetReferencedAssemblies();

            foreach (AssemblyName assembly in referencedAssemblies)
            {
                if (assembly.Name.Equals(name))
                    return Assembly.Load(assembly.Name);
            }
            return null;
        }


    }
}
