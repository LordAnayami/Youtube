
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Metody
//{
//    class Obwod
//    {

//        public int _bok1;
//        public int _bok2;
//        public double _bok3;

//        public Obwod(int bok1, int bok2, double bok3)
//        {
//            _bok1 = bok1;
//            _bok2 = bok2;
//            _bok3 = bok3;
//        }

//        public static implicit operator double(Obwod f)
//        {
//            return f._bok1 * f._bok2 * f._bok3;
//        }
//    }

//    //class Wyswietl
//    {
//        public static void Main()
//        {
//            Obwod fig1 = new Obwod(3, 4, 4.34);
//            Obwod fig2 = new Obwod(4, 5, 4.34);
//            Obwod fig3 = new Obwod(5, 6, 4.34);

//            double obwod = fig1;

//            Console.WriteLine("Obwód wynosi: " + obwod);
//        }
//    }
//}
