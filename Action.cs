//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Windows.Forms;
//using Xceed.Wpf.Toolkit;

//namespace Metody
//{
    

//    public delegate void ShowValue();

//    public class Name
//    {
//        private string instanceName;

//        public Name(string name)
//        {
//            this.instanceName = name;
//        }

//        public void DisplayToConsole()
//        {
//            Console.WriteLine(this.instanceName);
//        }

//        public void DisplayToWindow()
//        {
//            MessageBox.Show(this.instanceName);
//        }
//    }

//    public class testTestDelegate
//    {
//        public static void Main()
//        {
//            Name testName = new Name("Koani");
//            ShowValue showMethod = testName.DisplayToWindow;
//            showMethod();
//        }
//    }
//}
