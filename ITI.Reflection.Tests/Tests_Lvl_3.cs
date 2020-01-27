using NUnit.Framework;
using System;
using Models;
using ExercicesReflection;
using System.Reflection;


namespace Tests
{
    public class Tests_Lvl_3
    {
        [SetUp]
        public void Setup()
        {
            Checker();
        }

        [Test]
        public void should_instanciate_generic_type()
        {
            object o = Exercices_Lvl_3.instanciate_GenericType(typeof(GenericType<>) , typeof(int));
            Assert.IsTrue(o is GenericType<int>);
        }

        [Test]
        public void should_invoke_generic_method()
        {
            string parameter = "StephanieDeMonaco";
            string nameOfMethod = "GetBaseType";
            var type = typeof(ClassContainGenericMethod);
            Type result = Exercices_Lvl_3.Invoke_GenericMethod(type, parameter, nameOfMethod);
            Assert.IsTrue( result.Name == "Object");
        }

        private void Checker()
        {
            var AssemblyName = Assembly.GetAssembly((new Exercices_Lvl_3()).GetType()).GetName();
            if (Tests.Checker.IsCheating(AssemblyName))

                Assert.IsTrue(false);
        }
    }
}
