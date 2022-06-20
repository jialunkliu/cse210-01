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
        private Point Velocity_a = new Point(0, 5);
        private int score = 0;
        private int DEFAULT_ARTIFACTS = 0;

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
            }
            videoService.CloseWindow();
        }

        /// <summary>
        /// Gets directional input from the keyboard and applies it to the robot.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void GetInputs(Cast cast)
        {
            Actor robot = cast.GetFirstActor("robot");
            Point velocity = keyboardService.GetDirection();
            robot.SetVelocity(velocity);
            List<Actor> artifacts = cast.GetActors("artifacts");
            foreach (Actor actor in artifacts)
            {
                actor.SetVelocity(Velocity_a);
            }     
        }

        /// <summary>
        /// Updates the robot's position and resolves any collisions with artifacts.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast, int COLS, int ROWS, int CELL_SIZE, int FONT_SIZE)
        {
            Actor banner = cast.GetFirstActor("banner");
            Actor robot = cast.GetFirstActor("robot");
            List<Actor> artifacts = cast.GetActors("artifacts");
            CreateArtift CreateArtFt = new CreateArtift();

            banner.SetText("Score: ");
            int maxX = videoService.GetWidth();
            int maxY = videoService.GetHeight();
            robot.MoveNext(maxX, maxY);

            foreach (Actor actor in artifacts)
            {
                actor.MoveNext(maxX, maxY);
                if (robot.GetPosition().Equals(actor.GetPosition()))
                {
                    Artifact artifact = (Artifact) actor;
                    string message = artifact.GetMessage();
                    if (message == "-50")
                    {
                        score -= 50;
                    }
                    else if (message == "+25")
                    {
                        score += 25;
                    }
                    // banner.SetText($"Score: {score.ToString()}");
                    cast.RemoveActor("artifacts", actor);
                }
                // if the actor hit the bottom line, remove it
                int y = actor.GetPosition().GetY();
                if (y == maxY-10)
                {
                    cast.RemoveActor("artifacts", actor);
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
            banner.SetText($"Score: {score}");
            videoService.ClearBuffer();
            videoService.DrawActors(actors);
            videoService.FlushBuffer();
        }

    }
}