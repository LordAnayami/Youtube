//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Metody
//{
//    class Delegaty
//    {
//        public delegate int Delegata1(int arg1, int arg2);

//        public int Dodawanie(int arg1, int arg2)
//        {
//            return arg1 + arg2;
//        }

//        public int Odejmowanie(int arg1, int arg2)
//        {
//            return arg1 - arg2;
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            Delegaty d = new Delegaty();

//            Delegaty.Delegata1 dodawanie = new Delegaty.Delegata1(d.Dodawanie);
//            int wynikDodawania = dodawanie(2, 2);
//            System.Console.WriteLine("Wynik dodawania: {0}.", wynikDodawania.ToString());

//            Delegaty.Delegata1 odejmowanie = new Delegaty.Delegata1(d.Odejmowanie);
//            int wynikOdejmowania = dodawanie(2, 2);
//            System.Console.WriteLine("Wynik odejmowania: {0}.", wynikOdejmowania.ToString());
//        }
//    }
//}

