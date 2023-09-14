using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicijalno_ponavljanje_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite niz brojeva, nakn što ste gotovi upišite, 'gotovo'");
            string answer = Console.ReadLine();
            List <double> list = new List<double>();
            while (answer != "gotovo")
            {
                list.Add(Convert.ToDouble(answer));
                answer = Console.ReadLine();
            }
            double zbroj= 0;
            foreach (double number in list)
            {
                zbroj = zbroj + number;
            }

            Console.WriteLine("Summa brojeva sa liste je " + zbroj);
            Console.ReadKey();
        }
    }
}
