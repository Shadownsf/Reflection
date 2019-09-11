using Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using ExercicesReflection;
using Models;

namespace Tests
{
    public class Tests_Lvl_3
    {
        [Test]
        public void instanciate_With_Generic_Type()
        {
            object o = Exercices_Lvl_3.instanciate_With_Generic_Type(typeof(GenericType<>) , typeof(int));
            Assert.IsTrue(o is GenericType<int>);
        }
    }
}
