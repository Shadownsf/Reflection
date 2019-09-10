using System;
using System.Linq;
using System.Reflection;
using Models;

namespace Constructor
{
    class Program
    {
    //    static void Main(string[] args)
    //    {
    //        Person p = new Person();
    //        Assembly a = typeof(Program).Assembly;
    //        var referencedAssemblies = a.GetReferencedAssemblies();
    //        Assembly models = null;
    //        foreach (AssemblyName assembly in referencedAssemblies)
    //        {
    //            if (assembly.Name.Equals("Models"))
    //                models = Assembly.Load(assembly.Name);
    //        }

    //        Type PersonType = models.GetTypes().First();

    //        object ClassInstance = Activator.CreateInstance(PersonType);

    //        PropertyInfo property = PersonType.GetProperty("Age");
    //        MethodInfo method = PersonType.GetMethod("IncrementAge");


    //        Console.WriteLine("{0}: {1}", property.Name, PersonType.GetProperty("Age").GetValue(ClassInstance));
    //        Console.WriteLine("Apply method {0}", method.Name);
    //        method.Invoke(ClassInstance, null);
    //        Console.WriteLine("Age: {0}", PersonType.GetProperty("Age").GetValue(ClassInstance));
    //    }
    //}
}
