using System;
using System.Collections.Generic;
using System.Text;

namespace Trenirovka_koda
{
    class Snake:Animals
    {
        public override void PrintAnima()
        {

            base.PrintAnima();
            Console.WriteLine("Snake can a kill humen for 5 minutes");
        }

        public override string AnimalType
        {
            get
            {
                return "Snakee";
            }
        }
    }
}
