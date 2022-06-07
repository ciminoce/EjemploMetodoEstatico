using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMetodoEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Temperatura(10);
            var t2=new Temperatura(15);
            
            Console.WriteLine(Temperatura.GetCantidad());
            Console.ReadLine();
        }
    }
}
