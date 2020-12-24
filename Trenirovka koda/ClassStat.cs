using System;
using System.Collections.Generic;
using System.Text;

namespace Trenirovka_koda
{
    class ClassStat
    {
           
        public static int number;
        public static string Kola;
        public void Printer()
        {
            Console.WriteLine(number);
            Console.WriteLine(Kola);
        }
    }
}


//СТатическая переменная-это общая переменная для всех экземпляров класса.
