#region Using ...

using EgyptianRecipes.Application.Common.Models;
using System;
using System.Diagnostics;
#endregion

namespace MinistryOfHealthService.Core.Models.ViewModels
{
    [DebuggerDisplay("Pagination={Pagination}, Sorting={Sorting}, Name={Name}")]
    public class ManagerCreateViewModel 
    {
        #region Properties      
        public string Name { get; set; }
        #endregion
    }
}
