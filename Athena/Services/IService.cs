using Athena.Models.Payloads;

namespace Athena.Services
{
    public interface IService
    {
        void Execute();
        void Execute<TServicePayload>(TServicePayload payload) where TServicePayload : class, IServicePayload;
    }
}
