using RiotSharp.Misc;

namespace Athena.Models.Payloads.Riot.Account
{
    // Payload used to execute riot API account services
    public class RiotAPIAccountPayload : IServicePayload
    {
        public string AccountName { get; set; }
        public Region AccountRegion { get; set; }
    }
}
