// Keep track of lives the player has, and shows the status graph of player

public class Player
{
    public Player()
    {

    }

    private int life = 5;

    private void GraphPlayer(int life)
    {
        if (life == 5)
        {
            Console.WriteLine("");
            Console.WriteLine("  _____");
            Console.WriteLine(@" /_____\");
            Console.WriteLine(@" \     /");
            Console.WriteLine(@"  \   /");
            Console.WriteLine("    O");
            Console.WriteLine(@"   /|\");
            Console.WriteLine(@"   / \");
            Console.WriteLine("");
            Console.WriteLine("^^^^^^^^^");
        }
        else if (life == 4)
        {
            Console.WriteLine("");
            Console.WriteLine(@" /_____\");
            Console.WriteLine(@" \     /");
            Console.WriteLine(@"  \   /");
            Console.WriteLine("    O");
            Console.WriteLine(@"   /|\");
            Console.WriteLine(@"   / \");
            Console.WriteLine("");
            Console.WriteLine("^^^^^^^^^");
        }
        else if (life == 3)
        {
            Console.WriteLine("");
            Console.WriteLine(@"  _____ ");
            Console.WriteLine(@" \     /");
            Console.WriteLine(@"  \   /");
            Console.WriteLine("    O");
            Console.WriteLine(@"   /|\");
            Console.WriteLine(@"   / \");
            Console.WriteLine("");
            Console.WriteLine("^^^^^^^^^");
        }
        else if (life == 2)
        {
            Console.WriteLine("");
            Console.WriteLine(@" \     /");
            Console.WriteLine(@"  \   /");
            Console.WriteLine("    O");
            Console.WriteLine(@"   /|\");
            Console.WriteLine(@"   / \");
            Console.WriteLine("");
            Console.WriteLine("^^^^^^^^^");
        }

        else if (life == 1)
        {
            Console.WriteLine("");
            Console.WriteLine(@"  \   /");
            Console.WriteLine("    O");
            Console.WriteLine(@"   /|\");
            Console.WriteLine(@"   / \");
            Console.WriteLine("");
            Console.WriteLine("^^^^^^^^^");
        }

        else if (life == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("    X");
            Console.WriteLine(@"   \|/");
            Console.WriteLine(@"   / \");
            Console.WriteLine("");
            Console.WriteLine("^^^^^^^^^");
            Console.WriteLine("GAME OVER");
        }
    }

    public void UpdateLife(bool answer=true)
    {
        if (answer == false)
        {
            life -= 1;
        }
        GraphPlayer(life);
    }

    public int Life()
    {
        return life;
    }

    
}