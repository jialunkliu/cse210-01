using System;
// 1 = rock, 2 = paper, 3 = scissors
namespace rock_paper_scissors.classes
{
    
    public class player_1
    {
        private int wins_1 = 0;
        public string winner_player = "";
        public int p1_choice = 0;
        public player_1()
        {}
        public int getChoice()
        {
            Console.Write("Choose rock(1), paper(2), or scissors(3):");
            return int.Parse(Console.ReadLine());
        }
        public void determineWinner()
        {
            winner_player = rules.winner(p1_choice, p2_choice);
            if (winner_player == player_1)
            {
                wins_1 += 1;
            }
        }

    }
    
    public class player_2
    {
        private int wins_2 = 0;
        public string winner_player = "";
        public int p2_choice = 0;
        winner_player = winner(2,1);
        if (winner_player == player_2)
        {
            wins_2 += 1;
        }
    }

}
