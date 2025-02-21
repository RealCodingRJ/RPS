using System;

namespace RPS
{
    class Program
    {

        public static async Task Main()
        {

            Console.WriteLine("Enter Rock Paper or Scissors: ");
            String? RPS = Console.ReadLine();

            List<string> choice = new List<string>();
            choice.Add("Rock");
            choice.Add("Paper");
            choice.Add("Scissors");

            string randomChoice = SelectedPerson();
            string random2 = SelectedPerson2();

            if (RPS == null) return;

            if (random2 == randomChoice)
            {
                Console.WriteLine("TIE...");
            }

            if (RPS.Equals(randomChoice))
            {
                Console.WriteLine("Computer has Chosen: " + random2);

                Task<string> dataMessage = GetMessage("Your Correct");
                string dataMessages = await dataMessage;
                Console.WriteLine("Data: " + dataMessages);
                Console.ReadLine();
            } 
            else
            {
                Console.WriteLine("Computer has Chosen: " + random2);
                
                Task<string> dataMessage = GetMessage
                    ("The Correct Answer was: " + randomChoice);
                string dataMessages = await dataMessage;
                Console.WriteLine("Data: " + dataMessages);
                

                Console.ReadLine();
            }

        }

        public static string SelectedPerson()
        {
            List<string> c = new List<string>();
            c.Add("Rock");
            c.Add("Paper");
            c.Add("Scissors");
            Random r = new Random();
            return c[r.Next(0, 3)];
        }

        static string SelectedPerson2()
        {
            List<string> c = new List<string>();
            c.Add("Rock");
            c.Add("Paper");
            c.Add("Scissors");
            Random r = new Random();
            return c[r.Next(0, 3)];
        } 

        static async Task<string> GetMessage(string message)
        {
            await Task.Delay(5000);
            return message;
            

        }

    }
}