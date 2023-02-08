using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ExampleOfCS.EnumExamples;

namespace ExampleOfCS.ExtensionMetExamples
{
    public static class Extensions
    {
        public static string GetEnumDescription(this MenuList m)
        {
            FieldInfo fi = m.GetType().GetField(m.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes != null && attributes.Length > 0 ? attributes[0].Description : m.ToString();
        }
    }
}
