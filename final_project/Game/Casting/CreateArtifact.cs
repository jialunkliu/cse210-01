using System.Collections.Generic;
namespace Unit04.Game.Casting
{
    public class CreateArtift
    {
        private List<string> letters = new List<string> {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","0","1","2","3","4","5","6","7","8","9"};
        private string message = "";
        private int defultIndex = 25;
        public CreateArtift()
        {

        }

        public void UpdateList(string newletter)
        {
            letters.Add(newletter);
        }

        /// <summary>
        /// Defult index number is 25(All Alphabets). Add 10 for extra number letters.
        /// </summary>
        /// <param name="x">The given x value.</param>
        public void UpdateIndex(int newIndex)
        {
            defultIndex = newIndex;
        }

        public void CreateDefult(Cast cast, int number, int COLS, int ROWS, int CELL_SIZE, int FONT_SIZE)
        {
            Random random = new Random();
            for (int i = 0; i < number; i++)
            {
                // string text = ((char)random.Next(33, 126)).ToString();
                int index = random.Next(0, defultIndex);
                string text = letters[index];
                // if (index == 1)
                // {
                //     message = "+25";
                // }
                // else
                // {
                //     message = "-50";
                // }
                // message = "+25";

                int x = random.Next(1, COLS);
                int y = random.Next(1, 10);
                Point position = new Point(x, y);
                position = position.Scale(CELL_SIZE);

                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 256);
                Color color = new Color(r, g, b);

                Artifact artifact = new Artifact();
                artifact.SetText(text);
                artifact.SetFontSize(FONT_SIZE);
                artifact.SetColor(color);
                artifact.SetPosition(position);
                artifact.SetMessage(message);
                cast.AddActor("artifacts", artifact);
            }
        }

        public void NewArtFts(Cast cast, int number, int COLS, int ROWS, int CELL_SIZE, int FONT_SIZE)
        {
            Random random = new Random();
            for (int i = 0; i < number; i++)
            {
                int index = random.Next(0,defultIndex);
                string text = letters[index];
                // if (index == 1)
                // {
                //     message = "+25";
                // }
                // else
                // {
                //     message = "-50";
                // }
                message = "+25";

                int x = random.Next(1, COLS);
                int y = 1;
                Point position = new Point(x, y);
                position = position.Scale(CELL_SIZE);

                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 0);
                Color color = new Color(r, g, b);

                Artifact artifact = new Artifact();
                artifact.SetText(text);
                artifact.SetFontSize(FONT_SIZE);
                artifact.SetColor(color);
                artifact.SetPosition(position);
                artifact.SetMessage(message);
                cast.AddActor("artifacts", artifact);
            }
        }
    }
}