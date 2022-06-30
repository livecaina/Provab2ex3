using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_ex3_
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            double b, h, a;
            int f;

            Console.WriteLine("Escolha uma forma geométrica  \n 1-Triângulo  \n 2-Círculo  \n 3-Pentágono Regular");
            f = int.Parse(Console.ReadLine());

            switch(f)
            {
                case 1:
                    Console.WriteLine("Qual a base desse triângulo");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual a altura desse triângulo");
                    h = double.Parse(Console.ReadLine());
                    a = b * h / 2;
                    Console.WriteLine("A área desse triângulo é " + a + " cemtímetros quadrados");
                    break;
                case 2:
                    Console.WriteLine("Qual o raio desse círculo");
                    b = double.Parse(Console.ReadLine());
                    a = b * b * 3.14;
                    Console.WriteLine("A área desse círculo é " + a +" cemtímetros quadrados"); 
                    break;
                case 3:
                    Console.WriteLine("Qual a base desse pentágono");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o apótema desse pentágono  \n ( apótema é a distância do centro do pentágono até o centro da base)");
                    h = double.Parse(Console.ReadLine());
                    a = b*h/2*5;
                    Console.WriteLine("A área desse pentágono é " + a + " cemtímetros quadrados");
                    break;
            }
            Console.ReadKey();

        }
    }
}
