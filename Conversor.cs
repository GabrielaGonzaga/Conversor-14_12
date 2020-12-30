namespace Cotação_14_12
{
    public class Conversor
    {
        private static float cotacaoDolar = 5.17f;

         public static float RealParaDolar(float valorRS){
             return valorRS / cotacaoDolar;
         }

        public static float DolarParaReal(float valorDolar){
            return valorDolar *  cotacaoDolar;
        }
    }
}