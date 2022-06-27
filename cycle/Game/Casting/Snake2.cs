using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit05.Game.Casting
{
    public class Snake2:Snake
    {
        public Snake2():base()
        {
            
        }

        public override void GrowTail(int numberOfSegments)
        {
            List<Actor> segments = GetSegments();
            for (int i = 0; i < numberOfSegments; i++)
            {
                Actor tail = segments.Last<Actor>();
                Point velocity = tail.GetVelocity();
                Point offset = velocity.Reverse();
                Point position = tail.GetPosition().Add(offset);

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText("#");
                segment.SetColor(Constants.GREEN);
                AddToSegments(segment);
            }
        }
        public override void PrepareBody()
        {
            int x = Constants.MAX_X - Constants.MAX_X/ 4;
            int y = Constants.MAX_Y - Constants.MAX_Y/ 4;

            for (int i = 0; i < Constants.SNAKE_LENGTH; i++)
            {
                Point position = new Point(x - i * Constants.CELL_SIZE, y);
                Point velocity = new Point(1 * Constants.CELL_SIZE, 0);
                string text = i == 0 ? "@" : "#";
                Color color = i == 0 ? Constants.GREEN : Constants.GREEN;

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText(text);
                segment.SetColor(color);
                AddToSegments(segment);
            }
        }
    }
}