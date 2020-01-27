using System.Linq;
using System.Reflection;


namespace ITI.Reflection.Tests
{
    public class Checker
    {
        public static bool IsCheating(AssemblyName assemblyName)
        {
            var assembly = Assembly.Load(assemblyName);
            var refAssembliesNames = assembly.GetReferencedAssemblies();
            if (refAssembliesNames.Where(a => a.Name == Constants.AssemblyModelName).ToArray().Length > 0)
                return true;

            foreach (var assemblyNameItem in refAssembliesNames)
            {
                if (IsCheating(assemblyNameItem) == true)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
