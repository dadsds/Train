using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleNamespace
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            //double a = Convert.ToDouble(s);
            try
            {
                Triangle t = new Triangle(5, 12, 6);
                Console.WriteLine("S = " + t.S);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
