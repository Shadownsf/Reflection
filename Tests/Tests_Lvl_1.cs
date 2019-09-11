using NUnit.Framework;
using ExercicesReflection;
using Models;
using System;
using ExerciceBateau;
using System.Reflection;

namespace Tests
{
    public class Tests_Lvl_1
    {

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
            Bateau bateau = new Bateau();
            PropertyInfo[] props = Exercice1.GetPropertiesByCutomAttribute(bateau, "Property_bateau_name");
            Assert.That("" + props[0], Is.EqualTo("System.String Name"));
        }

        [Test]
        public void t5_sets_name()
        {
            Person person = new Person();
            Type type = Exercice1.SetName(person, "Titi");
            Assert.That(person.Name, Is.EqualTo("Titi"));
        }

        [Test]
        public void t6_gets_method()
        {
            Person person = new Person();
            MethodInfo method = Exercice1.GetMethod(person, "IncrementAge");
            method.Invoke(person, null);
            Assert.That(person.Age, Is.EqualTo(16));
        }

        [Test]
        public void t7_gets_return_type()
        {
            Person person = new Person();
            Type type = Exercice1.GetReturnType(person, "IncrementAge");
            Assert.That(type, Is.EqualTo(typeof(int)));
        }

        [Test]
        public void t8_gets_method_parameters()
        {
            Person person = new Person();
            ParameterInfo[] parameters = Exercice1.GetMethodParameters(person, "SetAge");
            Assert.That("" + parameters[0], Is.EqualTo("Int32 age"));
        }

        [Test]
        public void t9_gets_base_type()
        {
            Person person = new Person();
            Type type = Exercice1.GetBaseType(person);
            Assert.That(type, Is.EqualTo(typeof(object)));
        }

        [Test]
        public void tA_gets_interface()
        {
            Person person = new Person();
            Type theInterface = Exercice1.GetInterface(person, "IncrementAge");
            Assert.That(theInterface, Is.EqualTo(null));
        }

        [Test]
        public void tB_invokes_a_method()
        {
            Person person = new Person();
            object[] parameters = new object[1];
            parameters[0] = 25;
            Exercice1.InvokeMethod(person, "SetAge", parameters);
            Assert.That(person.Age, Is.EqualTo(25));
        }

        [Test]
        public void tC_get_instance()
        {
            Type type = typeof(Person);
            object instance = Exercice1.GetIstance(type);
            Assert.That(instance is Person);
        }
    }
}