using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unit04.Game.Casting;
using Unit04.Game.Directing;
using Unit04.Game.Services;


namespace Unit04
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        private static int FRAME_RATE = 10;
        private static int MAX_X = 1050;
        private static int MAX_Y = 750;
        private static int CELL_SIZE = 25;
        private static int FONT_SIZE = 25;
        private static int COLS = 60;
        private static int ROWS = 40;
        private static string CAPTION = "Tying game";
        // private static string DATA_PATH = "Data/messages.txt";
        public static Color WHITE = new Color(255, 255, 255);
        public static Color RED = new Color(255, 0, 0);
        private static int DEFAULT_ARTIFACTS = 10;


        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();

            // create the banner
            Actor banner = new Actor();
            banner.SetText("Score: ");
            banner.SetFontSize(20);
            banner.SetColor(WHITE);
            banner.SetPosition(new Point(CELL_SIZE, 0));
            cast.AddActor("banner", banner);
            
            Actor level = new Actor();
            level.SetText("Level: ");
            level.SetFontSize(20);
            level.SetColor(WHITE);
            level.SetPosition(new Point (925, 0));
            cast.AddActor("level", level);

            Actor life = new Actor();
            life.SetText("Life: ");
            life.SetFontSize(20);
            life.SetColor(WHITE);
            life.SetPosition(new Point (525, 0));
            cast.AddActor("life", life);

            Actor bar = new Actor();
            bar.SetText("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            bar.SetFontSize(20);
            bar.SetColor(RED);
            bar.SetPosition(new Point (0, MAX_Y-20));
            cast.AddActor("bar", bar);

            // create the robot
            // Actor robot = new Actor();
            // robot.SetText("#");
            // robot.SetFontSize(FONT_SIZE);
            // robot.SetColor(WHITE);
            // robot.SetPosition(new Point(MAX_X / 2, 735));
            // cast.AddActor("robot", robot);

            // load the messages
            // List<string> messages = File.ReadAllLines(DATA_PATH).ToList<string>();
            // string[] letters = {"A", "B", "C", "D", "E"};

            // Create the Artifacts
            CreateArtift createArtift = new CreateArtift();
            createArtift.CreateDefult(cast, DEFAULT_ARTIFACTS, COLS, ROWS, CELL_SIZE, FONT_SIZE);
            // start the game
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService 
                = new VideoService(CAPTION, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);
            Director director = new Director(keyboardService, videoService, DEFAULT_ARTIFACTS);
            director.StartGame(cast, COLS, ROWS, CELL_SIZE, FONT_SIZE);

            // test comment
        }
    }
}

