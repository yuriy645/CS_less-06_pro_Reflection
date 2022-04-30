using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Lib_framework
{// Создайте свою пользовательскую сборку по примеру сборки CarLibrary из урока, сборка будет
 //   использоваться для работы с конвертером температуры.
    
        [Serializable]
    class Cels
    {
        protected double tempFar;
        protected double tempC;

        public double TempC
        {
            get { return tempC; }
        }
        public double TempFar
        {
            set { tempFar = value; }
        }
        public double GetCelsTemp(double tempFar)
        {
            return 0.55 * (tempFar - 32);
        }
        
    }
}
