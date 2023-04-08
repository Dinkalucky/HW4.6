using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("Task6.2");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            int degrees;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Яке значення градусів Цельсія ви хотіли б конвертувати?");
            Int32.TryParse(Console.ReadLine(), out degrees);

            Type type = assembly?.GetType("Task6._2.Fahrenheit");

            object instance = Activator.CreateInstance(type);
 
            MethodInfo method = type.GetMethod("DegreesConverter");
            
            object[] parameters = { degrees };

            method?.Invoke(instance, parameters);

            Console.ReadLine();
        }
    }
}
