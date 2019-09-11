using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Models;

namespace ExercicesReflection
{
    public class Exercices
    {
        public static Type GetTypeByReflection()
        {
            Assembly currentAssembly = typeof(Exercices).Assembly;
            var referencedAssemblies = currentAssembly.GetReferencedAssemblies();
            Assembly models = null;
            foreach (AssemblyName assembly in referencedAssemblies)
            {
                if (assembly.Name.Equals("Models"))
                    models = Assembly.Load(assembly.Name);
            }

            Type PersonType = models.GetType("Models.Person");
            return PersonType;
        }

        public static object GetObjectInstanceByReflection()
        {
            Type type = GetTypeByReflection();
            object ClassInstance = Activator.CreateInstance(type);
            return ClassInstance;
        }

        public static string ReturnName(object o)
        {
            Type type = o.GetType();
            
            var name = type.GetProperty("Name").GetValue(o).ToString();
            return name;
        }

 	    public static int ReturnAge(object o)
        {
            Type type = o.GetType();

            var age = (int)type.GetProperty("Age").GetValue(o);
            return age;
        }

        public static string ReturnNumeroDeSecu(object o)
        {
            Type type = o.GetType();

            var numeroDeSecu = type.GetProperty("NumeroDeSecu").GetValue(o).ToString();
            return numeroDeSecu;
        }

        public static int returAgeincremented(object o)
        {
            Type type = o.GetType();

            // recupere la method specifier en parametre de GetMethod()
            var method = type.GetMethod("IncrementAge");

            //fait un appel a la method getMethod
            var age = (int)method.Invoke(o, null);
            return age;
        }
    }
}
