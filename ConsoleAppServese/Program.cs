using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppServese
{
    class Program
    {
        static void Main(string[] args)
        {
            MyService.ServiceClient serviceClient = new MyService.ServiceClient();

            string res = serviceClient.GetSum(10.ToString(), 20.ToString());
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
