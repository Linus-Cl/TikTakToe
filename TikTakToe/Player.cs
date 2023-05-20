namespace TikTakToe
{
    public class Player
    {
        public int id
        { get; set; }
        public string name
        { get; set; }

        public Player(int playerId, string playerName)
        {
            id = playerId;
            name = playerName;
        }
        //public string getName() { return name; }
        //public int getId() { return id; }
    }
}
