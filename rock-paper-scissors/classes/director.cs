using System;
// 1 = rock, 2 = paper, 3 = scissors
namespace rock_paper_scissors.classes
{
    public class Director
    {
        public Director()
        {

        }

        public void StartGame()
        {
            private string keepPlay = "";
            Console.WriteLine("Welcome to our rock paper scissors game!");
            
            while (keepPlay.ToLower() != "n")
            {
                
                Console.WriteLine("Player 1's turn: ");
                player_1 player1 = new player_1();
                p1_choice = player1.getChoice();
            } 
        }

    }
}