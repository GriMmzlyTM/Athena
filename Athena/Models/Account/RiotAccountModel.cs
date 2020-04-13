using RiotSharp.Endpoints.SummonerEndpoint;

namespace Athena.Models.Account
{
    /// <summary>
    /// Account data for Riot games
    /// </summary>
    public class RiotAccountModel : Model
    {
        public Summoner Summoner { get; set; }

    }
}
