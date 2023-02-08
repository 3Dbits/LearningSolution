using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.EnumExamples
{
    public enum MenuList : int
    {
        [Description("Object-oriented programming")]
        OOP = 1,
        Inheritance,
        Generic,
        Enum,
        Abstract,
        Linq,
        Files,
        Exit,
    }
}
