using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace UsingLoadFrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly privateAss = Assembly.LoadFrom("SimpleAssembly.dll");
            MethodInfo info = privateAss.GetTypes()[0].GetMethod("HelloWorld");
            Object obj = info.Invoke(null, null);
            Console.WriteLine("Результат выполнения метода: {0}", obj);
            Console.Read();
        }
    }
}
