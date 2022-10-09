using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intro.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){

            Console.WriteLine($"{x}+{y} = {x+y}");

        }

        public void Subtrair(int x, int y){

            Console.WriteLine($"{x}-{y} = {x-y}");

        }

        public void Multiplicar(int x, int y){

            Console.WriteLine($"{x}*{y} = {x*y}");

        }
        public void Dividir(int x, int y){

            Console.WriteLine($"{x}/{y} = {x/y}");

        }

        public void Potencia(int x, int y){

              double pote=  Math.Pow(x,y);
            Console.WriteLine($"{x} ^ {y} = {pote}" );
        }

        public void Seno(double angulo){

                double radiano = angulo * Math.PI / 180;
                double seno = Math.Sin(radiano);
                
                Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }

        public void Coseno(double angulo){

                double radiano = angulo * Math.PI / 180;
                double cos = Math.Cos(radiano);
                
                Console.WriteLine($"Coseno de {angulo} = {Math.Round(cos,4)}");
        }

        public void Tan(double angulo){

                double radiano = angulo * Math.PI / 180;
                double tan = Math.Tan(radiano);
                
                Console.WriteLine($"Tangente de {angulo} = {Math.Round(tan,4)}");
        }

        public void Raiz(double x){

                double raiz = Math.Sqrt(x);
                Console.WriteLine($"A Raiz quadrada de {x} é: {Math.Round(raiz,4)}");
        }
    }
}