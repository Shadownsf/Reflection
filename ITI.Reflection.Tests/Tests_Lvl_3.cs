using NUnit.Framework;
using System;
using Models;
using ExercicesReflection;
using System.Reflection;


namespace ITI.Reflection.Tests
{
    public class Tests_Lvl_3
    {
        [SetUp]
        public void Setup()
        {
            Checker();
        }

        [Test]
        public void instanciate_Generic_Type()
        {
            object o = Exercices_Lvl_3.instanciate_GenericType(typeof(GenericType<>) , typeof(int));
            Assert.IsTrue(o is GenericType<int>);
        }

        [Test]
        public void Invoke_GenericMethod()
        {
            string motif = "StephanieDeMonaco";
            string nameOfMethod = "GetBaseTYpe";
            object type = typeof(GenericType<>);
            Type result = Exercices_Lvl_3.Invoke_GenericMethod(typeof(GenericType<>), motif, nameOfMethod);
            Assert.IsTrue( result.Name == "object");
        }

        private void Checker()
        {
            var AssemblyName = Assembly.GetAssembly((new Exercices_Lvl_3()).GetType()).GetName();
            if (Tests.Checker.IsCheating(AssemblyName))

                Assert.IsTrue(false);
        }
    }
}
