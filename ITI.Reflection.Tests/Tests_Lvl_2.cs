using NUnit.Framework;
using Exercices;
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
        public void should_get_assembly_from_object()
        {
            Person person = new Person();

            var assembly = Assembly.GetAssembly(person.GetType());
            Assembly assemblyReturned = Exercices_Lvl_2.Get_Assembly_From_Object(person);
            Assert.That(assembly, Is.EqualTo(assemblyReturned));
        }

        [Test]
        public void should_get_assemblyname_referenced()
        {
            var exemples = new List<string>() { "ITI.Reflection.Models", "ITI.Reflection.Web" };
            AssemblyName[] assembiesReturned = Exercices_Lvl_2.Get_AssembliesName_Referenced(this);

            assembiesReturned = assembiesReturned.Where(a => exemples.Any(e => a.Name == e)).ToArray();
            Assert.IsTrue(assembiesReturned.Length == exemples.Count);
        }

        [Test]
        public void should_get_object_that_implements_interface()
        {
            string nameOfInterface = "IVehicule";
            var assembly = Assembly.GetAssembly(typeof(Voiture));
            var o = Exercices_Lvl_2.Get_Object_That_Implements_Interface(assembly, nameOfInterface);
            Assert.IsTrue(o is Voiture);
        }

        [Test]
        public void should_get_object_with_pattern()
        {
            string pattern = "Controller";
            var exemples = new List<string>() { "PersonController", "VoitureController" };

            var assembly = Assembly.GetAssembly(typeof(PersonService));
            var olist = Exercices_Lvl_2.Get_Object_With_Pattern(assembly, pattern);
            olist = olist.Where(p => exemples.Any(e => p.GetType().Name == e)).ToList();
            Assert.IsTrue(olist.Count == exemples.Count);
        }

        private void Checker()
        {
            var AssemblyName = Assembly.GetAssembly((new Exercices_Lvl_2()).GetType()).GetName();
            if (Tests.Checker.IsCheating(AssemblyName))

                Assert.IsTrue(false);
        }
    }
}