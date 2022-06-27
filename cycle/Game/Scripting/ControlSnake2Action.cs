using Unit05.Game.Casting;
using Unit05.Game.Services;
using System.Collections.Generic;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An input action that controls the snake.</para>
    /// <para>
    /// The responsibility of ControlActorsAction is to get the direction and move the snake's head.
    /// </para>
    /// </summary>
    public class ControlSnake2Action : Action
    {
        private KeyboardService keyboardService;
        private Point direction = new Point(Constants.CELL_SIZE, 0);

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public ControlSnake2Action(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            Snake2 snake2 = (Snake2)cast.GetFirstActor("snake2");
            Actor segments = snake2.GetHead();
            Color color = segments.GetColor();
            // left
            if (keyboardService.IsKeyDown("j"))
            {
                direction = new Point(-Constants.CELL_SIZE, 0);
                
                if (color != Constants.WHITE)
                {
                    snake2.GrowTail(1);
                }
            }

            // right
            if (keyboardService.IsKeyDown("l"))
            {
                direction = new Point(Constants.CELL_SIZE, 0);
                
                if (color != Constants.WHITE)
                {
                    snake2.GrowTail(1);
                }
            }

            // up
            if (keyboardService.IsKeyDown("i"))
            {
                direction = new Point(0, -Constants.CELL_SIZE);
                
                if (color != Constants.WHITE)
                {
                    snake2.GrowTail(1);
                }
            }

            // down
            if (keyboardService.IsKeyDown("k"))
            {
                direction = new Point(0, Constants.CELL_SIZE);
                
                if (color != Constants.WHITE)
                {
                    snake2.GrowTail(1);
                }
            }

            
            snake2.TurnHead(direction);

        }
    }
}