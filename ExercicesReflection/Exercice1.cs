using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Models;

namespace ExercicesReflection
{
    public class Exercice1
    {
        public static int ReturnAge(object o)
        {
            Type type = o.GetType();

            var age = (int)type.GetProperty("Age").GetValue(o);
            return age;
        }

        public static string ReturnNumeroDeSecu(object o)
        {
            Type type = o.GetType();

            var numeroDeSecu = type.GetProperty("NumeroDeSecu").GetValue(o).ToString();
            return numeroDeSecu;
        }
        public static int returAgeincremented(object o)
        {
            Type type = o.GetType();

            // recupere la method specifier en parametre de GetMethod()
            var method = type.GetMethod("IncrementAge");

            //fait un appel a la method getMethod
            var age = (int)method.Invoke(o, null);
            return age;
        }

        public static string ReturnName(object o)
        {
            Type type = o.GetType();

            var name = type.GetProperty("Name").GetValue(o).ToString();
            return name;
        }

        public static Type SetName(object o, string s)
        {
            Type type = o.GetType();

            type.GetProperty("Name").SetValue(o, s);
            return type;
        }

        public static MethodInfo GetMethod(object o, string s)
        {
            Type type = o.GetType();

            MethodInfo method = type.GetMethod(s);
            return method;
        }

        public static Type GetReturnType(object o, string s)
        {
            Type type = o.GetType();

            MethodInfo method = type.GetMethod(s);
            return method.ReturnType;
        }

        public static ParameterInfo[] GetMethodParameters(object o, string s)
        {
            Type type = o.GetType();

            MethodInfo method = type.GetMethod(s);
            return method.GetParameters();
        }

        public static Type GetBaseType(object o)
        {
            Type type = o.GetType();

            return type.BaseType;
        }

        public static Type GetInterface(object o, string s)
        {
            Type type = o.GetType();

            return type.GetInterface(s);
        }

        public static void InvokeMethod(object o, string s, object[] parameters)
        {
            Type type = o.GetType();

            MethodInfo method = type.GetMethod(s);
            method.Invoke(o, parameters);
        }

        public static PropertyInfo[] GetPropertiesByCutomAttribute(object o, string s)
        {
            Type type = o.GetType();

            PropertyInfo[] allProps = type.GetProperties();
            PropertyInfo[] matchingProps = new PropertyInfo[0];

            foreach(PropertyInfo prop in allProps)
            {
                Array.Resize(ref matchingProps, matchingProps.Length + 1);
                matchingProps[matchingProps.GetUpperBound(0)] = prop;
            }

            return matchingProps;
        }
    }
}
