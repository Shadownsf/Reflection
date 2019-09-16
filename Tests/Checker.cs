using System.Linq;
using System.Reflection;


namespace Tests
{
    class Checker
    {
        // Verify If Student Use Reflection
        public static bool IsCheating(object o)
        {
            var assembly = Assembly.GetAssembly(o.GetType());
            var refAssembliesNames = assembly.GetReferencedAssemblies();
            if (refAssembliesNames.Where(a => a.Name == "ITI.Reflection.Models").ToArray().Length > 0)
                return true;

            foreach (var assemblyName in refAssembliesNames)
            {
                var currentassembly = Assembly.Load(assemblyName);
                var types = currentassembly.GetTypes()
                    .SelectMany(t => t.GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                    .Where(f => f.FieldType.Name == "Assembly"))
                    .ToArray();

                if (types.Length > 0)
                    return true;
            }

            return false;
        }
    }
}
