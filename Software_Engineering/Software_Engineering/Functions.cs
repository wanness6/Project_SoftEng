using System;
using System.Collections.Generic;

namespace Software_Engineering
{
    class Functions
    {


        static public int AverageFuntion()
        {
            int Resultaat = 0;
            int oplossing=0;
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
                Resultaat += Getal;
            }

            Resultaat = Resultaat / MijnGetallen.Count;
            oplossing = MijnGetallen[Resultaat];

            Console.Clear();


            Console.WriteLine("########################");
            Console.WriteLine($"Uw Uitkomst = {oplossing}");

            Console.ReadKey();











            return oplossing;


        }



    }
}
