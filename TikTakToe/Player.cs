namespace TikTakToe
{
    public class Player
    {
        public int id
        { get; set; }
        public string name
        { get; set; }
        public int[,] Heatmap
        {get; set; }

        public Player(int playerId, string playerName)
        {
            id = playerId;
            name = playerName;
        }

    }
}
