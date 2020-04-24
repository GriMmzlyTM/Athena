using System;
using Athena.ViewModels;

namespace Athena.Models.Module
{

    /// <summary>
    /// 
    /// </summary>
    public class GameModuleModel : Model
    {
        public string Name { get; set; }
        public Type SettingsViewModel { get; set; }
    }
}
