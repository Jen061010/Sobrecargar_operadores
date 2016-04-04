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
            // sumar temp de los dos alimentos
            //var totalTemperatura = new Pan() + new Lasania();
            //Console.WriteLine(totalTemperatura.Temperatura);


            //sumar 12+ temp pan+ 15
            var totalTemperatura = 12 + new Pan().Temperatura + 15;
            
            Console.WriteLine(totalTemperatura);
            Console.ReadLine();
        }
    }
}
