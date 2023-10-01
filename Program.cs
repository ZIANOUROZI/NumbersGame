using System.Numerics;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 21); //My random number

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök"); // askin user för a number
            int num = 0; 
            int attempds = 5; // The user hav five attempds to guess
            while (num != number && attempds != 0) // As long as the condition become tru while the races will run
            {
                
               if(int.TryParse(Console.ReadLine(), out num))
                {
                    attempds--;
                    num = MySecondInt(num, number, attempds); // Declare my method here 
                }
                Console.WriteLine("skriv in ett tal");
            }
            
        }
        static int MySecondInt(int num, int number, int attempds) //create a new method here and that method check if the number by user is equal to the random number
        {

            if(num < number)
            {
                Console.WriteLine($"Gissa högre! Du har {attempds} försök kvar");
            }
           
            if (num > number)

            {
                Console.WriteLine($"Gissa lägre! Du har {attempds} försök kvar");
            }
            else if (num == number)
            {
                Console.WriteLine("Wohoo! Du klarade det!");
            }
            return num;

        }
       
            
    }
}