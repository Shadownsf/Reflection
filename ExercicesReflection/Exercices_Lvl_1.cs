using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Models;

namespace ExercicesReflection
{
    public class Exercices_Lvl_1
    {

        [Custom("Method_ReturnName")]
        public static string ReturnName(object o)
        {
            Type type = o.GetType();
            
            var name = type.GetProperty("Name").GetValue(o).ToString();
            return name;
        }

        [Custom("Method_returnAgeincremented")]
        public static int returnAgeincremented(object o)
        {
            Type type = o.GetType();

            // recupere la method specifier en parametre de GetMethod()
            var method = type.GetMethod("IncrementAge");

            //fait un appel a la method getMethod
            var age = (int)method.Invoke(o, null);
            return age;
        }
    }
}
