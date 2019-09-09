using System;
using System.Linq;
using System.Reflection;
using Models;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //Assembly a = typeof(Program).Assembly;
            //var referencedAssemblies = a.GetReferencedAssemblies();
            //Console.WriteLine("a :{0}", a);
            //Assembly ReflectionData = null;
            //foreach (AssemblyName assembly in referencedAssemblies)
            //{
            //    if (assembly.Name.Equals("ReflectionData"))
            //        ReflectionData = Assembly.Load(assembly.Name);
            //    Console.WriteLine("assembly : {0}", assembly);
            //}

            //Type PersonType = ReflectionData.GetTypes().First();

            //object ClassInstance = Activator.CreateInstance(PersonType);

            //PropertyInfo property = PersonType.GetProperty("Age");
            //MethodInfo method = PersonType.GetMethod("IncrementAge");


            //Console.WriteLine("{0}: {1}", property.Name, PersonType.GetProperty("Age").GetValue(ClassInstance));
            //Console.WriteLine("Apply method {0}", method.Name);
            //method.Invoke(ClassInstance, null);
            //Console.WriteLine("Age: {0}", PersonType.GetProperty("Age").GetValue(ClassInstance));
        }
    }
}
