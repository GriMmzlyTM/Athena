using Athena.Models.Payloads;

namespace Athena.Services
{
    public interface IService<in TServicePayload> where TServicePayload: IServicePayload
    {
        void Execute(TServicePayload payload);
    }

    public interface IService
    {
        void Execute();
    }
}
