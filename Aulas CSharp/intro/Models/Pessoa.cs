using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intro.Models
{
    public class Pessoa
    {
       public string Nome { get; set; } 
       public int Idade {get; set;}

       public string Cidade { get; set; }
       public string Habitantes { get; set; }
        public void Apresentar()
       {

        Console.WriteLine($"Ola, meu nome é {Nome}, e tenho {Idade} anos");

       }

       public void Morar()
       {

       
            Console.WriteLine($"Ola, meu nome é {Nome}, e tenho {Idade} anos, moro na {Cidade} com {Habitantes} Habitantes");
       }
    }
}