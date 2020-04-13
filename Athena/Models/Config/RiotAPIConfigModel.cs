namespace Athena.Models.Config
{
    /// <summary>
    /// Riot API configuration data. 
    /// </summary>
    public class RiotAPIConfigModel : Model
    {
        public string ApiKey { get; set; }
        public int RateLimitPer10s { get; set; }
        public int RateLimitPer10m { get; set; }
    }
}
