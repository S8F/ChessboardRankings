namespace ChessboardRankings.Data
{
    public class LeaderboardsModel
    {
        public List<Player> daily { get; set; }
        public List<Player> rapid { get; set; }
        public List<Player> blitz { get; set; }
        public List<Player> bullet { get; set; }
        public List<Player> correspondence { get; set; }
        public List<Player> tactics { get; set; }
    }

    public class Player
    {
        public string username { get; set; }
        public int score { get; set; }
        public int rank { get; set; }
        public string title { get; set; }
        public string name { get; set; }
        public string avatar { get; set; }
        public int win_count { get; set; }
        public int loss_count { get; set; }
        public int draw_count { get; set; }
    }
}

