using System;
using System.Collections.Generic;
using System.Text;

namespace Trenirovka_koda
{
    class Tiger:Animals
    {
        public override void PrintAnima()
        {
            base.PrintAnima();
        }
        public override string AnimalType
        {
            get
            {
                return "Tigerr";
            }
        }
    }
}
