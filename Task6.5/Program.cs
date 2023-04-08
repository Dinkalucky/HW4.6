using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task6._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;
            try
            {
                assembly = Assembly.LoadFile("C:\\Users\\Dina_Nevhod\\source\\repos\\HW4.6\\ClassLibrary1\\bin\\Debug\\ClassLibrary1.dll"); //не знала, як обрати файл dll без абсолютного шляху
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("СПИСОК ВСЕХ ТИПОВ В СБОРКЕ: " + assembly.FullName + Environment.NewLine);

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine("Тип:  " + type);
                var methods = type.GetMethods();
                if (methods != null)
                {
                    foreach (var method in methods)
                    {
                        string methStr = "Метод:" + method.Name + "\n";
                        var methodBody = method.GetMethodBody();
                        if (methodBody != null)
                        {
                            var byteArray = methodBody.GetILAsByteArray();

                            foreach (var b in byteArray)
                            {
                                methStr += b + ":";
                            }
                        }

                        Console.WriteLine(methStr);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
