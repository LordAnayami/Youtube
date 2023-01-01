using System;
using System.Collections.Generic;
using System.Text;


namespace Metody
{
    class Zadanie 
    {
        static void Main(string[] args)
        {
           

            Func<string, string, string> dzialanie = (a, b) =>
            {
                int znak = a.IndexOf(b);

                string x = a.Substring(0, znak);
                string y = a.Substring(znak + 1);
                double X = Convert.ToDouble(x);
                double Y = Convert.ToDouble(y);
                double wynik = 0;
                string z = null;

                if (b == "+") wynik = X + Y;
                else if (b == "-") wynik = X - Y;
                else if (b == "*") wynik = X * Y;
                else if (Y != 0 && b == "/") wynik = X / Y;
                else { Console.WriteLine("Error - dzielenie przez 0!!!"); z = "Error!!!"; };

                switch (z)
                {
                    case null:
                        z = wynik.ToString(); return z;
                    default:
                        return z;
                }

            };
            string q;
            var a = dzialanie(q = "10,5*20", "*");
            Console.WriteLine($"Wynik mnożenia {q} wynosi: {a}");

            var b = dzialanie(q = "10,5+20", "+");
            Console.WriteLine($"Wynik dodawania {q} wynosi: {b}");

            var c = dzialanie(q = "10,5-20", "-");
            Console.WriteLine($"Wynik odejmowania {q} wynosi: {c}");

            var e = dzialanie(q = "10,5/20", "/");
            Console.WriteLine($"Wynik dzielenia {q} wynosi: {e}");

            var f = dzialanie(q = "10,5/0", "/");
            Console.WriteLine($"Wynik dzielenia {q} wynosi: {f}");

        }

        private var Dzialanie(string kod, int* typ)
        {
            /// index
            var index = 0;
            var list = new List<string> { "A", "B", "C" };
            var c = list[index];

            unsafe
            {
                int* ip;
                int i = 2;

                ip = &i;

            }
            



            return string.Empty;
        }


        private void Obliczenia(int x)
        {
            unsafe
            {
                int* p = x;
           


            var a = Dzialanie("kod", *p);
            }
        }

    }
}











