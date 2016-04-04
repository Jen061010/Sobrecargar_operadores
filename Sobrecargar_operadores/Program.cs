using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargar_operadores
{
    public class Program
    {
        static void Main(string[] args)
        {

            var totalTemperatura = new Pan() + new Lasania();
            Console.WriteLine(totalTemperatura.Temperatura);
            Console.ReadLine();
        }
    }
}
