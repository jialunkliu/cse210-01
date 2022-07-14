using Raylib_cs;
using Unit04.Game.Casting;


namespace Unit04.Game.Services
{
    /// <summary>
    /// <para>Detects player input.</para>
    /// <para>
    /// The responsibility of a KeyboardService is to detect player key presses and translate them 
    /// into a point representing a direction.
    /// </para>
    /// </summary>
    public class KeyboardService
    {
        // private int cellSize = 15;
        private Dictionary<string, KeyboardKey> keys 
                = new Dictionary<string, KeyboardKey>();

        /// <summary>
        /// Constructs a new instance of KeyboardService using the given cell size.
        /// </summary>
        /// <param name="cellSize">The cell size (in pixels).</param>
        public KeyboardService()
        {
            
        }

        public String GetUserInput()
        {
            string key = "";

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_A))
            {
                key = "A";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_B))
            {
                key = "B";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_C))
            {
                key = "C";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_D))
            {
                key = "D";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                key = "E";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_F))
            {
                key = "F";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_G))
            {
                key = "G";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_H))
            {
                key = "H";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_I))
            {
                key = "I";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_J))
            {
                key = "J";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_K))
            {
                key = "K";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_L))
            {
                key = "L";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_M))
            {
                key = "M";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_N))
            {
                key = "N";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_O))
            {
                key = "O";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_P))
            {
                key = "P";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_Q))
            {
                key = "Q";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_R))
            {
                key = "R";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_S))
            {
                key = "S";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_T))
            {
                key = "T";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_U))
            {
                key = "U";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_V))
            {
                key = "V";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_W))
            {
                key = "W";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_X))
            {
                key = "X";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_Y))
            {
                key = "Y";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_Z))
            {
                key = "Z";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_ZERO))
            {
                key = "0";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
            {
                key = "1";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
            {
                key = "2";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE))
            {
                key = "3";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_FOUR))
            {
                key = "4";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_FIVE))
            {
                key = "5";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_SIX))
            {
                key = "6";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_SEVEN))
            {
                key = "7";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_EIGHT))
            {
                key = "8";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_NINE))
            {
                key = "9";
            }

            return key;
        }

        /// <summary>
        /// Gets the selected direction based on the currently pressed keys.
        /// </summary>
        /// <returns>The direction as an instance of Point.</returns>
        // public Point GetDirection()
        // {
        //     int dx = 0;
        //     int dy = 0;

        //     if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        //     {
        //         dx = -1;
        //     }

        //     if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        //     {
        //         dx = 1;
        //     }

        //     if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
        //     {
        //         dy = -1;
        //     }

        //     if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        //     {
        //         dy = 1;
        //     }

        //     Point direction = new Point(dx, dy);
        //     direction = direction.Scale(cellSize);

        //     return direction;
        // }
    }
}