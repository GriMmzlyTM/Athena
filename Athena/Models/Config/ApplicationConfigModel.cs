using System;

namespace Athena.Models.Config
{
    /// <summary>
    /// Application configuration data parsed from yaml
    /// </summary>
    public class ApplicationConfigModel : Model
    {
        public string Environment { get; set; }
        public DevelopmentEnvironment EnvironmentEnum { get; set; }

        public RiotAPIConfigModel RiotApiConfig { get; set; }

    }

    public enum DevelopmentEnvironment
    {
        Dev = 0,
        Staging = 1,
        Prod = 2,
        Test = 3,
    }
}
