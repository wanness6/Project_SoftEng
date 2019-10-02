using System;
using System.Collections.Generic;

namespace Software_Engineering
{
    class Functions
    {


        static public int AverageFuntion()
        {
            int Result = 0;
            List<int> MijnGetallen = new List<int>();

            string UserInput = "";
            int counter = 1;
            Console.WriteLine("Average Calculator 1");
            Console.WriteLine($"je geeft alle getallen op en geeft een Q als je alle getallen hebt toegevoegd");
            Console.ReadKey();
            Console.Clear();


            while (UserInput != "q")
            {

                Console.Write($" \n Getal {counter}:  ");
                counter++;
                UserInput = Console.ReadLine();

                if (UserInput != "q")
                {
                    MijnGetallen.Add(Convert.ToInt32(UserInput));
                }
            }


            Console.WriteLine("Berekenen....");

            foreach (int Getal in MijnGetallen)
            {
                Result += Getal;
            }

            Result = Result / MijnGetallen.Count;


            Console.Clear();


            Console.WriteLine("########################");
            Console.WriteLine($"Uw Uitkomst = {Result}");

            Console.ReadKey();











            return Result;


        }



    }
}
