using System;
using System.Collections.Generic; // Для коллекций


namespace Trenirovka_koda
{
    class Program
    {
        static Snake GetSnake()
        {
            Snake snake = new Snake
            {
                Age = 33,
                Name = "Greg",
                Country = "Africa"
            };

            return snake;
        }

        static Tiger GetTiger()
        {
            Tiger tiger = new Tiger
            {
                Age = 15,
                Name = "Gosha",
                Country = "London"
            };

            return tiger;
        }
        static void Main(string[] args)
        {
            //Тренировка задавания значений 
            int x;//We are use this array in calculator
            int y;//We are use this array in calculator
            int sum;//We are use this array in calculator
            // decimal t;
            string middlename;
            string lastname;
            string name;//We are use this number in string method
            //  long p;//Never not use
            // short a;//Never not use

            Console.WriteLine("Write your first number in this console");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write your next number in this console");
            y = Convert.ToInt32(Console.ReadLine());

            sum = x + y;
            Console.WriteLine($"first plus next will be {sum} ");

            Method method = new Method();
            Method.percent = 3949;//Вызвали наш метод со статическим переменной
            method.Print();

            Console.WriteLine();

            Console.WriteLine("Write a new string this your name");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Hello, {name}");

            Console.WriteLine();

            Console.WriteLine("Write your lastname ");
            lastname = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Helllloooooo, {name} {lastname}");

            Console.WriteLine();

            Console.WriteLine("Write your midlename");
            middlename = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"EBAAAT WHO IS HERE!!! HELLO, {name} {middlename} {lastname} ");
            Console.WriteLine();
            //Downer will be a methods static 

            Method met = new Method();
            Method.percent = 1555;
            met.Print();

            ClassStat stat = new ClassStat();
            ClassStat.number = 10000;
            ClassStat.Kola = "Kolokolchik";
            stat.Printer();
            
            //КОЛЛЕКЦИИ
            //Коллекции-это класс, предназначенный для группировки связанных обьектов

            //Их стоит применять, если :
            //Отдельные элементы используются для одинаковых целей и одинаково важны
            //На момент компиляции число элеменов не известно и не зафиксировано
            //Необходима поддержка операции перебора всех элементов
            //Необходимо использовать элементы из библиотеки, от которой потребитель ожидает наличия типа коллекции

            List<int> col1 = new List<int>();//List - экземпляр класса коллектион генерик для интов
            col1.Add(2);
            col1.Add(5);
            col1.Add(7);
            col1.Add(9);

            foreach(var item in col1)// пробегаемся по всей коллекции
            {
                Console.WriteLine(item);
            }
            //-----------------------------------------------------------
            List<string> col2 = new List<string> //Делаем коллекции стрингов
            {
                "Hello ",
                "World"
            };
            foreach(var item in col2)
            {
                Console.WriteLine(item);
            }
            //----------------------------------------------------------

            Dictionary<int, string> col3 = new Dictionary<int, string>() //То же, что и лист, но для пар значений
            {
                {1, "John" },
                {2, "Bill" },
                {3, "Greg" }
            };
            col3.Add(4, "Max");

            foreach (var item in col3)
            {
                Console.WriteLine(item);
            }
            //**********************************************************************
            //Classes
  

            Tiger tiger = GetTiger();
            Console.WriteLine();
            Snake snake = GetSnake();
            Console.WriteLine();

            Animals animals = new Animals();
            animals.PrintAnima();

            Animals someanimal = GetAnimal("Tigerr");
            Console.WriteLine(someanimal.AnimalType);

            tiger.PrintAnima();
            Console.WriteLine();
            snake.PrintAnima();
            Console.WriteLine();

        }

        static Animals GetAnimal(string AnimalType)
        {
            switch (AnimalType)
            {
                case "Tigerr":
                    return new Tiger();
                case "Snakee":
                    return new Snake();
                default:
                    return new Animals();
            }
        }
    }
}
