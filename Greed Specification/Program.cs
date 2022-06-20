﻿using System;
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
        private static int FRAME_RATE = 30;
        private static int MAX_X = 1050;
        private static int MAX_Y = 750;
        private static int CELL_SIZE = 15;
        private static int FONT_SIZE = 15;
        private static int COLS = 60;
        private static int ROWS = 40;
        private static string CAPTION = "Greed Specification";
        private static string DATA_PATH = "Data/messages.txt";
        private static Color WHITE = new Color(255, 255, 255);
        private static int DEFAULT_ARTIFACTS = 100;


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

            // create the robot
            Actor robot = new Actor();
            robot.SetText("#");
            robot.SetFontSize(FONT_SIZE);
            robot.SetColor(WHITE);
            robot.SetPosition(new Point(MAX_X / 2, 735));
            cast.AddActor("robot", robot);

            // load the messages
            List<string> messages = File.ReadAllLines(DATA_PATH).ToList<string>();
            string[] rAg = {"@", "*"};

            // Create the Artifacts
            CreateArtift createArtift = new CreateArtift();
            createArtift.CreateDefult(cast, DEFAULT_ARTIFACTS, COLS, ROWS, CELL_SIZE, FONT_SIZE);
            // start the game
            KeyboardService keyboardService = new KeyboardService(CELL_SIZE);
            VideoService videoService 
                = new VideoService(CAPTION, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);
            Director director = new Director(keyboardService, videoService, DEFAULT_ARTIFACTS);
            director.StartGame(cast, COLS, ROWS, CELL_SIZE, FONT_SIZE);

            // test comment
        }
    }
}
