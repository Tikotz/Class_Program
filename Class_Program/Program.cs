using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myarr = new int[3];
            //myarr[0] = 1;
            //myarr[1] = 10;
            //myarr[2] = 100;

            //int[] myarr2 = new int[3];
            //Car myCar = new Car();
            //myCar._year = 2021;
            //myCar._brand = "Lamburgini";
            //myCar._isActive = true;
            //myCar.Drive();
            //myCar.GetSpeed();
            //Console.WriteLine(myCar._isDrive);


            //Car myfoo = new Car
            //{
            //    _year = 2019,
            //    _brand = "Mini Cooper",
            //    _isActive = true
            //};
            //myfoo.GetSpeed();

            //Console.WriteLine(myfoo);
            //Console.WriteLine(myfoo._brand);


            #region HM9
            //Random rnd = new Random();
            //Console.WriteLine("enter number for the arr");
            //int size = int.Parse(Console.ReadLine());

            //string[] namesArr = new string[size];
            //int[] IntArray = new int[size];

            //for ( int i = 0; i < size; i++)
            //{
            //    Console.WriteLine("enter name: ");
            //    person myperson = new person(Console.ReadLine());
            //    namesArr[i] = myperson._Name;

            //    person myperson2 = new person(namesArr[i],rnd.Next(1,101));
            //    IntArray[i] = myperson2._age;
            //}
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"Name: {namesArr[i]}. Age: {IntArray[i]}");
            //}

            #endregion

            //Table table1 = new Table();
            //table1._legs = 4;
            //table1._color = "brown";
            //table1._brand = "alon";


            //Table table2 = new Table(4, "white", "oren");

            //Table table3 = new Table
            //{
            //    _legs = 4,
            //    _color = "blue",
            //    _brand = "erez"
            //};

            //Table table4 = table2;
            //table2._color = "black";


            ConsolePlus bloop = new ConsolePlus("bloop1", 2, 3);

        }
    }

    class ConsolePlus
    {
        public ConsolePlus()
        {
            Console.WriteLine("i'm diffault...");
        }

        public ConsolePlus(string str) : this ()
        {
            Console.WriteLine(str);
        }

        public ConsolePlus(string str, int num1, int num2) : this(str)
        {
            Console.WriteLine(num1 + num2);
        }
    }

    #region HM_CONSTRACTORS
    class person
    {
        public string _Name;
        public int _age;

        public person(string Name)
        {
            _Name = Name;
        }
        public person(string Name, int age) : this(Name)
        {
            _age = age;
        }
    }
    #endregion


    class Table
    {
        public int _legs;
        public string _color;
        public string _brand;

        public Table()
        {

        }

        public Table(int legs, string color, string brand)
        {
            _legs = legs;
            _color = color;
            _brand = brand;
        }
    }
    

    class Car
    {
        public int _year;
        public string _brand;
        public bool _isActive;
        public bool _isDrive;
        public int _Speed;
        
        public void Drive()
        {
            if(_isActive)
            {
                _isDrive = true;
                for(int i = 100; i > _Speed;)
                {
                    _Speed += 20;
                    Console.WriteLine(_Speed);
                }
                
            }
            else
            {
                Console.WriteLine("you Can't drive while car is NOT on !");
            }
        }

        public int GetSpeed()
        {
            if (_isDrive)
            {
                return _Speed;
            }
            else
            {
                return -1;
            }
        }
    }
}
