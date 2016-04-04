using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sobrecargar_operadores
{
    public class Alimentos
    {
        
        public int Temperatura { get; protected set; }
        public static Alimentos operator +(Alimentos a1, Alimentos a2) {
            
            return new Alimentos(){Temperatura=a1.Temperatura+a2.Temperatura};
        }
    }
}