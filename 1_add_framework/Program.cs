using System;
using System.IO;
using System.Reflection;

namespace _1_add_framework
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("2_Lib_framework"); // загрузка библиотеки
                Console.WriteLine("Сборка CarLibrary - успешно загружена.");
                Console.WriteLine("Все типы в сборке {0} \n", assembly.FullName);
                Type[] types = assembly.GetTypes();  //будет массив всех типов включая internal
                foreach (Type t in types)
                    Console.WriteLine("Тип: {0}", t);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Environment.Exit(1);
            }
            Console.ReadKey();
        }
    }
}
