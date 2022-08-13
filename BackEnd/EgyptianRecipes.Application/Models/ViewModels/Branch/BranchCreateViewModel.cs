#region Using ...

using EgyptianRecipes.Application.Common.Models;
using System;
using System.Diagnostics;
#endregion

namespace MinistryOfHealthService.Core.Models.ViewModels
{
    [DebuggerDisplay("Pagination={Pagination}, Sorting={Sorting}, Title={Title}")]
    public class BranchCreateViewModel 
    {

        #region Properties      
        public string Title { get; set; }
        public DateTime OpeningHour { get; set; }
        public DateTime ClosingHour { get; set; }
        public string ManagerName { get; set; }
        #endregion
    }
}
