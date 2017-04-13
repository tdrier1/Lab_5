using System;


namespace R
{
    class Program
    {
        static void Main(string[] args)
        {

            bool run = true;

            Console.Write("Welcome to the Grand Circus Casino! Roll the dice?(y/n)");
            string input = Console.ReadLine();
            do
            {
                Console.Write("\nPlease enter number of sides: ");
                int dicesides = Convert.ToInt32(Console.ReadLine());

                Roll(dicesides);

                Console.WriteLine("\nContinue?(y/n) ");
                string cont = Console.ReadLine();


                if (cont == "n")
                {
                    Console.WriteLine("\nThank you!");

                    run = false;
                }
            } while (run == true);

        }

        public static void Roll(int dicesides)
        {
            int i;
            int result;

            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            for (i = 1; i <= 2; i++)
            {

                result = rnd.Next(2, dicesides);

                Console.Write(result);
                Console.WriteLine("\t");

            }
        }
    }
}

