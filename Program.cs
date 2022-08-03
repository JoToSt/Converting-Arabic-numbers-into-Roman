using System;

namespace ConvertingArabicToRoman
{
    class Program
    {
        // the function adds to the string with a roman number (reference rome) the next letter (lett)
        // and subtracts from number (ref count) the Arabic value of the letter war_let
        static public void ar_ro(ref ushort licz, ref string rom, ushort war_let, string lett)
        {
            licz -= war_let;
            rom += lett;
        }
       

        static void Main(string[] args)
        {
            Console.WriteLine("  \n");
            Console.WriteLine("     I  -     1                        V  -  5    ");
            Console.WriteLine("     X  -    10                        L -  50     ");
            Console.WriteLine("     C  -   100                        D - 500    ");
            Console.WriteLine("     M  -  1000              ");
            Console.WriteLine("\n ");
            Random generator = new Random();    //  random number generator
            int points = 0;

            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine(" You  will  get 10 random  arabic  numbers  to  convert\n\n\n");
            Console.WriteLine(" !!!!    P L E A S E    C O N V E R T    A R A B I C  number TO    R O M A N  number     !!!!\n\n");
            Console.ResetColor();
            for (int i = 1; i <= 10; i++)
            {
                ushort arabic = (ushort)generator.Next(1, 4000);   //  grandom number generator from 1 to 3999
                Console.Write(" \n Convert " + arabic + "    into roman number:   ");

                string answer = Console.ReadLine(); //  
                string roman = "";

                while (arabic >= 1000)
                    ar_ro(ref arabic, ref roman, 1000, "M");
                if (arabic >= 900)
                    ar_ro(ref arabic, ref roman, 900, "CM");
                if (arabic >= 500)
                    ar_ro(ref arabic, ref roman, 500, "D");
                if (arabic >= 400)
                    ar_ro(ref arabic, ref roman, 400, "CD");
                while (arabic >= 100)
                    ar_ro(ref arabic, ref roman, 100, "C");
                if (arabic >= 90)
                    ar_ro(ref arabic, ref roman, 90, "XC");
                if (arabic >= 50)
                    ar_ro(ref arabic, ref roman, 50, "L");
                if (arabic >= 40)
                    ar_ro(ref arabic, ref roman, 40, "XL");
                while (arabic >= 10)
                    ar_ro(ref arabic, ref roman, 10, "X");
                if (arabic == 9)
                    ar_ro(ref arabic, ref roman, 9, "IX");
                if (arabic >= 5)
                    ar_ro(ref arabic, ref roman, 5, "V");
                if (arabic == 4)
                    ar_ro(ref arabic, ref roman, 4, "IV");
                while (arabic >= 1)
                    ar_ro(ref arabic, ref roman, 1, "I");

                //  LICZBA RZYMSKA  JEST  JUZ  WYZNACZONA

                if (roman == answer)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("    !!! CONGRATULATIONS     !!!!!!!");
                    Console.ResetColor();
                    points++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("    !!! UNFORTUNATELY   !!!  ");
                    Console.ResetColor();
                    Console.WriteLine("correct Roman number: " + roman);
                }
            }
            Console.WriteLine("\n     You scored  " + points + "  points");
        }   
    }
}



