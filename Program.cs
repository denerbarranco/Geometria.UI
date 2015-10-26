using System;
using Geometria.BO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variável criada para receber a escolha da figura geometrica, digitada pelo usuário.
            int escolha ;

            Console.WriteLine("Escolha uma FIGURA GEOMÉTRICA: ");
            Console.WriteLine("1 - TRIANGULO \n2 - QUADRADO \n3 - RETÂNGULO \n7 - CIRCULO");
            Console.WriteLine("5 - LOSANGO \n6 - PARALELOGRAMO \n7 - TRAPÉZIO \n");
            escolha = int.Parse(Console.ReadLine());//Recebendo a escolha do usuário e convertendo para inteiro.

            //Instânciando o objeto CalcularFiguras, para poder utilizar os seus métodos.
            CalcularFigura calc1 = new CalcularFigura();

            //Enquanto o usuário escolher os números acima referente as figuras, vai executar os seguintes métodos abaixo.
            switch (escolha)
            {
                case 1: calc1.Triangulo(); break;//Se usuário digitar 1, vai executar este médoto que faz o calculo do triângulo.
                case 2: calc1.Quadrado(); break;//E assim por diante...
                case 3: calc1.Retangulo(); break;
                case 4: calc1.Circulo(); break;
                case 5:calc1.Losango();break;
                case 6: calc1.Paralelogramo();break;
                case 7:calc1.Trapezio();break;
                //Caso o usuário digite um número diferente do que o apresentado acima, vai exibir está mensagem:
                default:
                    Console.WriteLine("O número digitado não corresponde a nem uma FIGURA GEOMÉTRICA apresentada acima");
                    Console.ReadKey(); break;
            }
        }
    }
}
