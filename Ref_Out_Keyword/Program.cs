using System;

namespace Ref_Out_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 3;
            int number2 = 15;
            int number3;
            int number4 = 50;

           var result=Topla(ref number1, number2);

            Console.WriteLine("Ref Kullanımı Topla Methodu  : {0} ",result);

            var result2 = Topla2(out number3, number4);


            Console.WriteLine("Out Kullanımı Topla2 Methodu : {0}",result2);


        }

        static int Topla(ref int number1, int number2)
        {
            number1 = 30;

            var result = number1 + number2;

            return result;

        }



        static int Topla2(out int number1, int number2)
        {
            number1 = 100;

            var result = number1 + number2;
            return result;
        }



    }
}
