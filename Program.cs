using System;

namespace switch_case
{

    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {

                case 5:
                    Console.WriteLine("Mayis Ayindasiniz");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayindasiniz");
                    break;
                case 4:
                    Console.WriteLine("Nisan Ayindasiniz");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayindasiniz");
                    break;
                default:
                    Console.WriteLine("Yanliş veri girdiniz");
                    break;
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kiş ayindasiniz");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilkbahar ayindasiniz");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz ayindasiniz");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar ayindasiniz");
                    break;

                default:  //default un sırası önemli değil ama mutlaka olmak zorunda.
                    Console.WriteLine("Yanliş veri girdiniz");
                    break;
            }
        }
    }
}