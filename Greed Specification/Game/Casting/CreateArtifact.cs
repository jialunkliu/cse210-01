namespace Unit04.Game.Casting
{
    public class CreateArtift
    {
        private string[] rAg = {"@", "*"};
        private string message = "";
        public CreateArtift()
        {

        }

        public void CreateDefult(Cast cast, int number, int COLS, int ROWS, int CELL_SIZE, int FONT_SIZE)
        {
            Random random = new Random();
            for (int i = 0; i < number; i++)
            {
                // string text = ((char)random.Next(33, 126)).ToString();
                int index = random.Next(0,2);
                string text = rAg[index];
                if (index == 1)
                {
                    message = "+25";
                }
                else
                {
                    message = "-50";
                }

                int x = random.Next(1, COLS);
                int y = random.Next(1, ROWS);
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
                int index = random.Next(0,2);
                string text = rAg[index];
                if (index == 1)
                {
                    message = "+25";
                }
                else
                {
                    message = "-50";
                }

                int x = random.Next(1, COLS);
                int y = 1;
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
    }
}