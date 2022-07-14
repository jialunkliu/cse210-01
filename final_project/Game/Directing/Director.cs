using System.Collections.Generic;
using Unit04.Game.Casting;
using Unit04.Game.Services;


namespace Unit04.Game.Directing
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private KeyboardService keyboardService = null;
        private VideoService videoService = null;
        private Point Velocity_a = new Point(0, 1);
        private CreateArtift CreateArtFt = new CreateArtift();
        private int score = 0;
        private int DEFAULT_ARTIFACTS = 0;
        private string level = "0";
        private int life = 3;
        private int deathLine = 730;
        private bool isGameOver = false;

        /// <summary>
        /// Constructs a new instance of Director using the given KeyboardService and VideoService.
        /// </summary>
        /// <param name="keyboardService">The given KeyboardService.</param>
        /// <param name="videoService">The given VideoService.</param>
        public Director(KeyboardService keyboardService, VideoService videoService, int DEFAULT_ARTIFACTS)
        {
            this.keyboardService = keyboardService;
            this.videoService = videoService;
            this.DEFAULT_ARTIFACTS = DEFAULT_ARTIFACTS;
        }

        /// <summary>
        /// Starts the game by running the main game loop for the given cast.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void StartGame(Cast cast, int COLS, int ROWS, int CELL_SIZE, int FONT_SIZE)
        {
            videoService.OpenWindow();
            while (videoService.IsWindowOpen())
            {
                
                    GetInputs(cast);
                    DoUpdates(cast, COLS, ROWS, CELL_SIZE, FONT_SIZE);
                    DoOutputs(cast);
                    GameOver(cast);
            }
            videoService.CloseWindow();
        }

        /// <summary>
        /// Gets directional input from the keyboard and applies it to the robot.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void GetInputs(Cast cast)
        {
            // Actor robot = cast.GetFirstActor("robot");
            // Point velocity = keyboardService.GetDirection();
            // robot.SetVelocity(velocity);

            List<Actor> artifacts = cast.GetActors("artifacts");
            Actor bar = cast.GetFirstActor("bar");
            foreach (Actor actor in artifacts)
            {
                actor.SetVelocity(Velocity_a);
            }

            // level up based on score 
            if (score > 500 && score <= 1000)
            {
                level = "1";
                Velocity_a = new Point(0, 2);
            }
            else if (score > 1000 && score <= 2500)
            {
                level = "2";
                Velocity_a = new Point(0, 3);
                DEFAULT_ARTIFACTS = 15;
                deathLine = 700;
                bar.SetPosition(new Point(0, deathLine));
            }
            else if (score > 2500 && score <= 5000)
            {
                level = "3";
                Velocity_a = new Point(0, 5);
            }
            else if (score > 5000 && score <= 10000)
            {
                level = "4";
                CreateArtFt.UpdateIndex(35);
                deathLine = 650;
                bar.SetPosition(new Point(0, deathLine));

            }
            else if (score > 10000)
            {
                level = "MAX";
                Velocity_a = new Point(0, 7);
                deathLine = 550;
                bar.SetPosition(new Point(0, deathLine));
            }     
        }

        /// <summary>
        /// Updates the robot's position and resolves any collisions with artifacts.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast, int COLS, int ROWS, int CELL_SIZE, int FONT_SIZE)
        {
            // Actor banner = cast.GetFirstActor("banner");
            // Actor robot = cast.GetFirstActor("robot");
            List<Actor> artifacts = cast.GetActors("artifacts");
        
            string key = keyboardService.GetUserInput();

            // banner.SetText("Score: ");
            int maxX = videoService.GetWidth();
            int maxY = videoService.GetHeight();
            // robot.MoveNext(maxX, maxY);

            foreach (Actor actor in artifacts)
            {
                actor.MoveNext(maxX, maxY);
                Artifact artifact = (Artifact) actor;
                string text = artifact.GetText();

                if (key == text)
                {
                    score += 25;
                    cast.RemoveActor("artifacts", actor);
                }

                // if (robot.GetPosition().Equals(actor.GetPosition()))
                // {
                //     Artifact artifact = (Artifact) actor;
                //     string message = artifact.GetMessage();
                //     if (message == "-50")
                //     {
                //         score -= 50;
                //     }
                //     else if (message == "+25")
                //     {
                //         score += 25;
                //     }
                //     // banner.SetText($"Score: {score.ToString()}");
                //     cast.RemoveActor("artifacts", actor);
                // }
                // if the actor hit the bottom line, remove it
                
                if (life == 0)
                {
                    isGameOver = true;
                    Velocity_a = new Point(0, 0);
                }
                else
                {
                    int y = actor.GetPosition().GetY();
                    if (y >= deathLine)
                    {   
                        // score -= 500;
                        life -= 1;
                        cast.RemoveActor("artifacts", actor);
                    }
                }
            }
            // Count how many of the artifacts left, create more if needed
                int len = artifacts.Count;
                if (len < DEFAULT_ARTIFACTS)
                {
                    int newArtFts = DEFAULT_ARTIFACTS - len;
                    CreateArtFt.NewArtFts(cast, newArtFts, COLS, ROWS, CELL_SIZE, FONT_SIZE);
                }
        }

        /// <summary>
        /// Draws the actors on the screen.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void DoOutputs(Cast cast)
        {
            List<Actor> actors = cast.GetAllActors();
            Actor banner = cast.GetFirstActor("banner");
            Actor Level = cast.GetFirstActor("level");
            Actor Life = cast.GetFirstActor("life");
            banner.SetText($"Score: {score}");
            Level.SetText($"Level: {level}");
            Life.SetText($"Life: {life}");
            videoService.ClearBuffer();
            videoService.DrawActors(actors);
            videoService.FlushBuffer();
            // if (life == 0)
            //         {
            //             GameOver(cast);
            //         }
        }

        public void GameOver(Cast cast)
        {
            if (isGameOver == true)
            {
                Actor gameover = new Actor();
                gameover.SetText("Game Over!");
                gameover.SetPosition(new Point(475, 375));
                gameover.SetFontSize(25);
                cast.AddActor("gameover", gameover);

                List<Actor> actors = cast.GetAllActors();
                foreach (Actor actor in actors)
                {
                    actor.SetColor(Program.WHITE);
                }
                gameover.SetColor(Program.RED);
            }
        }

    }
}