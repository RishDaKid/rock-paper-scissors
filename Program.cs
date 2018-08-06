using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {

            bool keepPlaying = true;
            while (keepPlaying)
            {

                Console.WriteLine("Rock ,paper or Scissor?");
                string weapon = Console.ReadLine();

                Random rnd = new Random();
                int computer = rnd.Next(1, 3);

                if (computer == 1)
                {
                    if (weapon == "Rock")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("It is a tie ");
                    }
                    else if (weapon == "Paper")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("It is a tie ");
                    }
                    else if (weapon == "Scissor")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("It is a tie ");
                    }
                    else
                    {
                        Console.WriteLine("No Rock, Paper or Scissor");
                    }
                }

                else if (computer == 2)
                {
                    if (weapon == "Rock")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("Sorry you lose,paper beat rock");
                    }
                    else if (weapon == "Paper")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("Sorry you lose,scissors beat paper ");
                    }
                    else if (weapon == "Scissor")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("Sorry you lose,rock beats scissors");
                    }
                    else
                    {
                        Console.WriteLine("Choose Rock,Paper or Scissor");
                    }
                }
                else if (computer == 3)
                {
                    if (weapon == "Rock")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("You win,rock beats scissors");
                    }
                    else if (weapon == "Paper")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("You win,paper beats rock");
                    }
                    else if (weapon == "Scissor")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("You win,scissors beat paper");
                    }
                    else
                    {
                        Console.WriteLine("Choose Rock Paper or Scissor");
                    }
                }

                Console.WriteLine("New game? y/n");
                ConsoleKeyInfo cki = Console.ReadKey(); //wait for player to press a key
                keepPlaying = cki.KeyChar == 'y' ; //continue only if y was pressed
                Console.WriteLine('\n');
            }
        }
    }
}
