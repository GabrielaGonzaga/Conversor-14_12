using System;

namespace Cotação_14_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamamos nossa classe estatica, sem precisar instaciar
            Console.WriteLine(Conversor.DolarParaReal(4f) );
            Console.WriteLine(Conversor.RealParaDolar(50f) );

            //Exemplo: Classe Math
            Console.WriteLine( Math.Pow(2, 4) );
        }
    }
}
