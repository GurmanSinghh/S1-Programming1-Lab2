using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int depreciation = 4000;
            int year = 0;
            int endValue = 28000;
            int accumulatedDepreciation = 0;
            Console.WriteLine(" YEAR        DEPRECIATION    END-OF-THE YEAR      ACCUMULATED ");
            Console.WriteLine("                                  VALUE           DEPRECIATION");
            Console.WriteLine("------       -------------    ---------------    --------------");
            do
            {
                year++;
                endValue = endValue - depreciation;
                accumulatedDepreciation = year * depreciation;

                Console.WriteLine($"{year,3}{depreciation,19}{endValue,17}{accumulatedDepreciation,20}");

            } while (year < 7);
            Console.ReadKey();
        }
    } 
}
