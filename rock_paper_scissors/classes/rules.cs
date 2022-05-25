using System;
// 1 = rock, 2 = paper, 3 = scissors
namespace rock_paper_scissors.classes
{
    class rules
    {
        private int player_1;
        private int player_2;
        private int play_again;
        public rules()
        {
          
        }
        
        public int winner(int player_1, int player_2, int play_again)
        {
        
    
        if (player_1 == 1 && player_2 == 3 ||
            player_1 == 2 && player_2 == 1 || 
            player_1 == 3 && player_2 == 2 )
        {
            return player_1;
        }    
        else if (player_2 == 1 && player_1 == 3 ||
                player_2 == 2 && player_1 == 1 || 
                player_2 == 3 && player_1 == 2 )
        {
            return player_2;
        }  
        else
        {
            return play_again;
        }
        
        
        }
        
    }
}

