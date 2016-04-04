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
        //Sumar dos temperaturas  
        //public static Alimentos operator +(Alimentos a1, Alimentos a2) {
         
          //  return new Alimentos(){Temperatura=a1.Temperatura+a2.Temperatura};

            
            
        //}

        //Sumar 12+ pan+15
         public static Alimentos operator +(int i, Alimentos a2) {
         
            return new Alimentos(){Temperatura=i+a2.Temperatura};

            
            
        }
    }
}