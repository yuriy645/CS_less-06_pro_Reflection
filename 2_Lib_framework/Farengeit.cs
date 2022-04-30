using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Lib_framework
{
    class Farengeit
    { //Создайте свою пользовательскую сборку по примеру сборки CarLibrary из урока, сборка будет
     //   использоваться для работы с конвертером температуры.
        protected double tempFar;
        protected double tempC;
        public double TempFar
        {
            get { return tempFar; }
        }
        public double TempC
        {
            set { tempC = value; }
        }
        [ObsoleteAttribute("Метод устарел")]
        public double GetFarengeitTemp(double tempC)
        {
            return 1.8 * tempC + 32;
        }
        [Conditional("DEBUG")]
        public void Method1()
        {
            Console.WriteLine("u");
        }
    }
}
