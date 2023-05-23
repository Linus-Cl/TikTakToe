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

        public void FillHeatmapDefault(int size)
        {
            Heatmap = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Heatmap[i, j] = 1;
                }
            }
        }

        public bool CheckWinCondition(int x, int y)
        {
            
            return false;
        }

        public void AdjustHeatmap(int x, int y)
        {
            Heatmap[x, y]++;

            for (int i = -1; i <= 1; i++)
            {
                if (x + i >= 0 && x + i < Heatmap.Length)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (y + j >= 0 && y + j < Heatmap.Length && !(i == 0 && j == 0))
                        {
                            Heatmap[i, j]++;
                        }
                    }
                }

            }
        }

        public Player(int playerId, string playerName)
        {
            id = playerId;
            name = playerName;
        }

    }
}
