using System;
using Fibonacci;
using Task3;
using Task4;
using Task5;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var VC = new CalculoFaturamento();
            VC.Calcular();

            //var distribuicao = new Distribuicao();
            //distribuicao.CalcularPercentuais();
            /*ar t5 = new Reversor();
            var s = t5.MyReverse("Caro");*/

            
            /*var F = new Tarefa2();
            F.Resolve();
            Console.WriteLine("Hello World!");*/
        }
    }
}