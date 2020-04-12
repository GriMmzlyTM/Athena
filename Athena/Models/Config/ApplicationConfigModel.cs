using System;

namespace Athena.Models.Config
{
    public class ApplicationConfigModel
    {
        public string Environment { get; set; }
        public Enum EnvironmentEnum => Enum.Parse<DevelopmentEnvironment>(Environment, true);
    }

    public enum DevelopmentEnvironment
    {
        Dev = 0,
        Staging = 1,
        Prod = 2,
        Test = 3,
        Invalid = 999
    }
}
