namespace ChessboardRankings.Data
{
    public class Leaderboards
    {
        public List<Player> daily { get; set; }
        public List<Player> daily960 { get; set; }
        public List<Player> rapid { get; set; }
        public List<Player> blitz { get; set; }
        public List<Player> bullet { get; set; }
        public List<Player> correspondence { get; set; }
        public List<Player> tactics { get; set; }
        public List<Player> rush { get; set; }
        public List<Player> battle { get; set; }
    }

    public class Player
    {
        public int player_id { get; set; }
        public string @id { get; set; }
        public string url { get; set; }
        public string username { get; set; }
        public int score { get; set; }
        public int rank { get; set; }
        public string country { get; set; }
        public string title { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string avatar { get; set; }
        public Trend trend_score { get; set; }
        public Trend trend_rank { get; set; }
        public string flair_code { get; set; }
        public int win_count { get; set; }
        public int loss_count { get; set; }
        public int draw_count { get; set; }
    }

    public class Trend
    {
        public int direction { get; set; }
        public int delta { get; set; }
    }
}

