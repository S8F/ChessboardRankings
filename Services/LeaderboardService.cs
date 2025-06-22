
using System.Net.Http.Json;
using ChessboardRankings.Data;

namespace ChessboardRankings.Services
{
   public class LeaderboardService
    {
        private readonly HttpClient _httpClient;

        public LeaderboardService(HttpClient httpClient )
        {
            _httpClient = httpClient;
        }

        public async Task<LeaderboardsModel?> GetLeaderboardsAsync( )
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<LeaderboardsModel>("https://api.chess.com/pub/leaderboards" );
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error fetching leaderboards: {ex.Message}");
                return null;
            }
        }
    }
}

