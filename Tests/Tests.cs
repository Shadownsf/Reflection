using NUnit.Framework;
using ExercicesReflection;
using Models;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void t1_returns_name()
        {
            Person person = new Person();
            string name = Exercices.ReturnName(person);
            Assert.That(name, Is.EqualTo(person.Name));
        }

        [Test]
        public void t2_returns_age()
        {
            Person person = new Person();
            int age = Exercices.ReturnAge(person);
            Assert.That(age, Is.EqualTo(person.Age));
        }

        [Test]
        public void t3_returns_numero_de_secu()
        {
            Person person = new Person();
            string numeroDeSecu = Exercices.ReturnNumeroDeSecu(person);
            Assert.That(numeroDeSecu, Is.EqualTo(person.NumeroDeSecu));
        }    
    }
}