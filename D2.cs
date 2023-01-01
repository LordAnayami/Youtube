////using System;
////using System.Collections.Generic;
////using System.Text;


////    class D2
////    {
////        // Instantiate delegate to reference UppercaseString method
////        Func<string, string> convertMethod = UppercaseString;
////        string name = "Dakota";
////        // Use delegate instance to call UppercaseString method
////        Console.WriteLine(convertMethod(name));

////        string UppercaseString(string inputString)
////        {
////            return inputString.ToUpper();
////        }

////        // This code example produces the following output:
////        //
////        //    DAKOTA
////    }


////class D3
////{
////    Func<string, string> convert = delegate (string s)
////    { return s.ToUpper(); };

////    string name = "Dakota";
////    Console.WriteLine(convert(name));

////// This code example produces the following output:
//////
//////    DAKOTA
////}


////class D4
////{
////    Func<string, string> convert = s => s.ToUpper();

////    string name = "Dakota";
////    Console.WriteLine(convert(name));

////// This code example produces the following output:
//////
//////    DAKOTA
////}

//class D5
//{
//    string[] words = { "bot", "apple", "apricot" };
//    int minimalLength = words
//      .Where(w => w.StartsWith("a"))
//      .Min(w => w.Length);
//    Console.WriteLine(minimalLength);   // output: 5

//int[] numbers = { 4, 7, 10 };
//    int product = numbers.Aggregate(1, (interim, next) => interim * next);
//    Console.WriteLine(product);   // output: 280
//}