namespace TikTakToe
{
    public class Player
    {
        public string Name
        { get; set; }
        public int[,] Heatmap
        {get; set; }

        public Player(string playerName)
        {
            Name = playerName;
        }

    }
}
