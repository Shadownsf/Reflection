using NUnit.Framework;
using ExercicesReflection;
using Models;
using System;
using System.Reflection;

namespace ITI.Reflection.Tests
{
    public class Tests_Lvl_1
    {
        [SetUp]
        public void Setup()
        {
            Checker();
        }

        [Test]
        public void t1_returns_name()
        {
            Person person = new Person();
            string name = Exercices_Lvl_1.ReturnName(person);
            Assert.That(name, Is.EqualTo(person.Name));
        }

        [Test]
        public void t4_returns_attribute()
        {
            Exercices_Lvl_1 ExAttribute = new Exercices_Lvl_1();

            var attribute = Attribute.GetCustomAttribute(typeof(Exercices_Lvl_1), typeof(CustomAttribute));
            /* Person person = new Person();
            string name = Exercices.ReturnName();
            Assert.That(name, Is.EqualTo(person.Name)); */
        }

        [Test]
        public void t5_sets_name()
        {
            Person person = new Person();
            Type type = Exercices_Lvl_1.SetName(person, "Titi");
            Assert.That(person.Name, Is.EqualTo("Titi"));
        }

        [Test]
        public void t6_gets_method()
        {
            Person person = new Person();
            MethodInfo method = Exercices_Lvl_1.GetMethod(person, "IncrementAge");
            method.Invoke(person, null);
            Assert.That(person.Age, Is.EqualTo(16));
        }

        [Test]
        public void t7_gets_return_type()
        {
            Person person = new Person();
            Type type = Exercices_Lvl_1.GetReturnType(person, "IncrementAge");
            Assert.That(type, Is.EqualTo(typeof(int)));
        }

        [Test]
        public void t8_gets_method_parameters()
        {
            Person person = new Person();
            ParameterInfo[] parameters = Exercices_Lvl_1.GetMethodParameters(person, "SetAge");
            Assert.That("" + parameters[0], Is.EqualTo("Int32 age"));
        }

        [Test]
        public void t9_gets_base_type()
        {
            Person person = new Person();
            Type type = Exercices_Lvl_1.GetBaseType(person);
            Assert.That(type, Is.EqualTo(typeof(object)));
        }

        [Test]
        public void tA_gets_interface()
        {
            Person person = new Person();
            Type theInterface = Exercices_Lvl_1.GetInterface(person, "IncrementAge");
            Assert.That(theInterface, Is.EqualTo(null));
        }

        [Test]
        public void tB_invokes_a_method()
        {
            Person person = new Person();
            object[] parameters = new object[1];
            parameters[0] = 25;
            Exercices_Lvl_1.InvokeMethod(person, "SetAge", parameters);
            Assert.That(person.Age, Is.EqualTo(25));
        }

        [Test]
        public void tC_get_instance()
        {
            Type type = typeof(Person);
            object instance = Exercices_Lvl_1.GetInstance(type);
            Assert.That(instance, Is.InstanceOf(typeof(Person)));
        }

        private void Checker()
        {
            var AssemblyName = Assembly.GetAssembly((new Exercices_Lvl_1()).GetType()).GetName();
            if (Tests.Checker.IsCheating(AssemblyName))
                Assert.IsTrue(false);
        }
    }
}