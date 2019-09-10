﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Models;

namespace ExercicesReflection
{
    public class Exercice1
    {
        [Custom("Method_ReturnAge")]
        public static int ReturnAge(object o)
        {
            Type type = o.GetType();

            var age = (int)type.GetProperty("Age").GetValue(o);
            return age;
        }

        [Custom("Method_ReturnNumeroDeSecu")]
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

        [Custom("Method_ReturnName")]
        public static string ReturnName(object o)
        {
            Type type = o.GetType();

            var name = type.GetProperty("Name").GetValue(o).ToString();
            return name;
        }
        [Custom("Method_SetName")]
        public static Type SetName(object o, string s)
        {
            Type type = o.GetType();

            type.GetProperty("Name").SetValue(o, s);
            return type;
        }
        [Custom("Method_GetMethod")]
        public static MethodInfo GetMethod(object o, string s)
        {
            Type type = o.GetType();

            MethodInfo method = type.GetMethod(s);
            return method;
        }
        [Custom("Method_GetReturnType")]
        public static Type GetReturnType(object o, string s)
        {
            Type type = o.GetType();

            MethodInfo method = type.GetMethod(s);
            return method.ReturnType;
        }
        [Custom("Method_GetMethodParameters")]
        public static ParameterInfo[] GetMethodParameters(object o, string s)
        {
            Type type = o.GetType();

            MethodInfo method = type.GetMethod(s);
            return method.GetParameters();
        }
        [Custom("Method_GetBaseType")]
        public static Type GetBaseType(object o)
        {
            Type type = o.GetType();

            return type.BaseType;
        }
        [Custom("Method_GetInterface")]
        public static Type GetInterface(object o, string s)
        {
            Type type = o.GetType();

            return type.GetInterface(s);
        }

    }
}