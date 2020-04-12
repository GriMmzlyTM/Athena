using Athena.Models.Config;

namespace Athena.Services.Config
{
    public interface IApplicationConfigService
    {
        ApplicationConfigModel GetConfig();
    }
}
