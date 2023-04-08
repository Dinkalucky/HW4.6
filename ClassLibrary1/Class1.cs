using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Class
    {
        string classString;
        public string ClassProperty { get; set; }
        public abstract void Method();
    }
    public class Class1:Class
    {
        public string Class1Property { get; set; }
        public override void Method()
        {
            Console.WriteLine("Class1");
        }
    }
    public class Class2 : Class
    {
        private string Class2Property { get; set; }
        public override void Method()
        {
            Console.WriteLine("Class2");
        }
    }
}
