using System;

namespace _99_bottles_of_beer_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sing along!");

            int beerLeft = 100;
            //declare variable to keep track of countdown of number of bottles of beer, since total will always be total - 1,
            //start at 100 since song starts at 99

            do
            {
                beerLeft = beerLeft - 1;
                Console.WriteLine($"{beerLeft} bottles of beer on the wall. {beerLeft} bottles of beer. " +
                    $"You take one down, pass it around, {beerLeft - 1} bottles of beer on the wall.");

                

            } while (beerLeft >= 2);



            Console.ReadLine();
        }
    }
}
