using System;
using System.Collections.Generic;
using System.Text;

namespace Trenirovka_koda
{
    class Animals
    {
        public int Age;
        public string Name;
        public string Country;


        public virtual void PrintAnima()
        {
            Console.WriteLine(Age);
            Console.WriteLine(Name);
            Console.WriteLine(Country);
        }

        protected string tipical;
        public virtual string AnimalType
        {
            get
            {
                return tipical; 
            }
        }
    }

}
