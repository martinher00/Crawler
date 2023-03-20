using System;
using System.Collections.Generic;

namespace Programmeringsoppgave___alle_mulige_IP_adresser___del_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alle mulige IP-adresser:");
            ipListGenerator();

            // hei


            Console.ReadKey();
        }

        static IEnumerable<string> ipListGenerator()
        {
            for (int a = 0; a < 256; a++)
            {
                for (int b = 0; b < 256; b++)
                {
                    for (int c = 0; c < 256; c++)
                    {
                        for (int d = 0; d < 256; d++)
                        {
                            yield return $"{a}.{b}.{c}.{d}";
                        }
                    }
                }
            }
        }
    }
}