using NUnit.Framework;
using ExercicesReflection;
using Models;
using System;
//using CustomAttribute = Models.CustomAttribute;
using System.Reflection;

namespace Tests
{
    public class Tests_Lvl_2
    {
        [Test]
        public void Get_Assembly_From_Object()
        {
            Person person = new Person();
            var assembly = Assembly.GetAssembly(person.GetType());
            Assembly assemblyReturned = Exercices_Lvl_2.Get_Assembly_From_Object(person);

            Assert.That(assembly, Is.EqualTo(assemblyReturned));
        }

        [Test]
        public void Get_AssemblyName_Referenced()
        {
            Person person = new Person();
            var assemblies = new string[2] {"", "" };
            AssemblyName[] assembiesReturned = Exercices_Lvl_2.Get_AssembliesName_Referenced(person);

            CollectionAssert.AreEquivalent(assemblies, assembiesReturned);
        }

        [Test]
        public void Get_Assembly_By_Name()
        {
            string nameOfAssembly = "Models";
            var assembly = Assembly.GetAssembly(typeof(Person));
            var assemblyReturned = Exercices_Lvl_2.Get_Assembly_By_Name(nameOfAssembly);

            Assert.That(assembly, Is.EqualTo(assemblyReturned));
        }
    }
}