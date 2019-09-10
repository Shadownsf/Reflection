using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

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

        public static string ReturnName()
        {
            Type type = GetTypeByReflection();
            object objectInstance = GetObjectInstanceByReflection();

            var name = type.GetProperty("Name").GetValue(objectInstance).ToString();
            return name;
        }
        public static int ReturnAge()
        {
            Type type = GetTypeByReflection();
            object objectInstance = GetObjectInstanceByReflection();

            throw new NotImplementedException();
        }
        public static string ReturnNumeroDeSecu()
        {
            Type type = GetTypeByReflection();
            object objectInstance = GetObjectInstanceByReflection();

            throw new NotImplementedException();
        }
    }
}
