using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Athena.Models.Module;

namespace Athena.Models.Application
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationGameModulesListModel : Model
    {
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, GameModuleModel> Modules { get; set; } = new Dictionary<string, GameModuleModel>();
    }
}
