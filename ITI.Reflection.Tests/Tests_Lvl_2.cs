using NUnit.Framework;
using ExercicesReflection;
using Models;
using Web;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace Tests
{
    public class Tests_Lvl_2
    {
        [SetUp]
        public void Setup()
        {
            Checker();
        }

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
            var exemples = new List<string>() { "ITI.Reflection.Models", "ITI.Reflection.Web" };
            AssemblyName[] assembiesReturned = Exercices_Lvl_2.Get_AssembliesName_Referenced(this);

            assembiesReturned = assembiesReturned.Where(a => exemples.Any(e => a.Name == e)).ToArray();
            Assert.IsTrue(assembiesReturned.Length == exemples.Count);
        }

        [Test]
        public void Get_Object_That_Implements_Interface()
        {
            string nameOfInterface = "IVehicule";
            var assembly = Assembly.GetAssembly(typeof(Voiture));
            var o = Exercices_Lvl_2.Get_Object_That_Implements_Interface(assembly, nameOfInterface);
            Assert.IsTrue(o is Voiture);
        }

        [Test]
        public void Get_Object_With_Partern()
        {
            string pattern = "Controller";
            var exemples = new List<string>() { "PersonController", "VoitureController" };

            var assembly = Assembly.GetAssembly(typeof(PersonService));
            var olist = Exercices_Lvl_2.Get_Object_With_Partern(assembly, pattern);
            olist = olist.Where(p => exemples.Any(e => p.GetType().Name == e)).ToList();
            Assert.IsTrue(olist.Count == exemples.Count);
        }

        private void Checker()
        {
            if (Tests.Checker.IsCheating(new Exercices_Lvl_2()))
                Assert.IsTrue(false);
        }
    }
}