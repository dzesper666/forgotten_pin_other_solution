using System;

namespace Kacper_pin_final
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(calculate(35));

            // 1 < N < 10^9
            // valA + valB + valC = N
            // a < b < c
            // restFromBdivA = b/a <- dzielenie calkowite
            // restFromCdivB = c/b <- dzielenie calkowite
            // restFromCdivA = c/a <- dzielenie calkowite
            int calculate(int N)
            {
                int count = 0;
                for (int valA = 1; valA < N; valA++)
                {
                    for (int valB = valA + 1; valB < N; valB++)
                    {
                        for (int valC = valB + 1; valC < N; valC++)
                        {
                            if (valA + valB + valC != N)
                            {
                                continue;
                            }

                            int restFromCdivB = valC % valB;
                            int restFromCdivA = valC % valA;
                            int restFromBdivA = valB % valA;
                            if (restFromCdivB == 0 && restFromCdivA == 0 && restFromBdivA == 0)
                            {
                                count++;
                                Console.WriteLine(valA + " " + valB + " " + valC);
                            }
                        }
                    }
                }
                return count;
            }
        }
    }
}
