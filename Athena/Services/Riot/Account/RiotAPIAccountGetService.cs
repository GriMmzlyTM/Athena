using Athena.Models.Account;
using Athena.Models.Payloads;
using Athena.Models.Payloads.Riot.Account;
using RiotSharp.Endpoints.SummonerEndpoint;
using System;

namespace Athena.Services.Riot.Account
{
    public class RiotAPIAccountGetService : IRiotAPIAccountGetService
    {

        private readonly RiotAPIService _riotApiService;
        private readonly RiotAccountModel _riotAccountModel;

        public RiotAPIAccountGetService (
            RiotAPIService riotApiService,
            RiotAccountModel riotAccountModel
            )
        {
            _riotApiService = riotApiService;
            _riotAccountModel = riotAccountModel;
        }

        public void Execute()
        {
            throw new InvalidOperationException("AccountGetPayload must be specified.");
        }

        public void Execute<TServicePayload>(TServicePayload payload) where TServicePayload : class, IServicePayload
        {
            if(!(payload is RiotAPIAccountPayload)) 
                throw new InvalidOperationException($"Incorrect payload provided - Expected {typeof(RiotAPIAccountPayload)} | Got {typeof(TServicePayload)}");

            var accountGetPayload = payload as RiotAPIAccountPayload;

            var api = _riotApiService.GetApi();
            
            var newAccount = new RiotAccountModel();
            try
            {
                var summoner = api.Summoner.GetSummonerByNameAsync(
                    region: accountGetPayload.AccountRegion,
                    summonerName: accountGetPayload.AccountName).Result;

                newAccount.Summoner = summoner;
            }
            catch (Exception)
            {
                newAccount = new RiotAccountModel
                {
                    Summoner = new Summoner
                    {
                        Name = "INVALID SUMMONER"
                    }
                };
            }
            finally
            {
                // Update singleton account model
                _riotAccountModel.Update(newAccount);
            }
        }
    }
}
