using System;


namespace Unit05.Game.Casting
{
    /// <summary>
    /// <para>A tasty item that snakes like to eat.</para>
    /// <para>
    /// The responsibility of Food is to select a random position and points that it's worth.
    /// </para>
    /// </summary>
    public class Score : Actor
    {
        private string status = "";
        private string title = "jjjjjj";

        /// <summary>
        /// Constructs a new instance of an Food.
        /// </summary>
        public Score(string title)
        {
            this.title = title;
            UpdateStatus(this.status);
        }

        /// <summary>
        /// Adds the given points to the score.
        /// </summary>
        /// <param name="points">The points to add.</param>
        public void UpdateStatus(string status)
        {
            SetText($"{title}: {status}");
        }
    }
}