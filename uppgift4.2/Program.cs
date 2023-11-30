using System;
namespace uppgift2
{
    class Program
    {
        static void Main(string []args)
        {
            int maxnummer = int.MinValue;
            bool contineinput =true;
            while(contineinput)
            {
                Console.WriteLine("skriv in ett tal.");
                int tal = int.Parse(Console.ReadLine());
                if (tal > maxnummer) ;
                {
                    maxnummer = tal;
                }
                Console.WriteLine("vill du skriva in ett till tal?");
                string svar=Console.ReadLine();
                if ((svar == "ja") || (svar == "Ja"))
                {
                    contineinput = true;
                }
                else
                {
                    contineinput = false;
                }
            }
            Console.WriteLine("det största talet du skrev var " + maxnummer);
           


        }
    }
}
