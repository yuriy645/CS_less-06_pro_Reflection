using System;
using System.IO;
using System.Reflection;

namespace _3_temperature
{// Создайте программу, в которой предоставьте пользователю доступ к сборке из Задания 2.
 //   Реализуйте использование метода конвертации значения температуры из шкалы Цельсия в
 //шкалу Фаренгейта.Выполняя задание используйте только рефлексию.
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("2_Lib_framework"); // загрузка библиотеки
                Console.WriteLine("Сборка CarLibrary - успешно загружена.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(1);
            }


            Console.WriteLine("Все типы в сборке {0} \n", assembly.FullName);
            Type[] types = assembly.GetTypes();  //будет массив всех типов включая internal
            foreach (Type t in types)
                Console.WriteLine("Тип: {0}", t);


            Type typeFar = assembly.GetType("_2_Lib_framework.Farengeit"); // получили класс внутри сборки
            Console.WriteLine($"Контрольный вывод типа: {typeFar} ");

            object instance = Activator.CreateInstance(typeFar);   // получили экземпляр класса сборки
            MethodInfo method = typeFar.GetMethod("GetFarengeitTemp"); // получили метод класса

            //2-й способ
            // dynamic instance = Activator.CreateInstance(typeFar);   // получили экземпляр класса сборки // на типе object нельзя вызывать метод
            // double tempC = instance.GetFarengeitTemp(30);

            object[] parameters = { 30 }; // получили параметры для метода (внесли 30 градусов)

            double tempC = (double)method.Invoke(instance, parameters); //запуск метода экземпляра с входным параметром
            
            Console.WriteLine($" 30 по Фарингейту - {tempC} по Цельсию");
           

            Console.ReadKey();
        }
    }
}
