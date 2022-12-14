#region Using ...

using EgyptianRecipes.Application.Common.Models;
using System;
using System.Diagnostics;
#endregion

namespace EgyptianRecipes.Application.Models.ViewModels
{
    [DebuggerDisplay("Pagination={Pagination}, Sorting={Sorting}, Title={Title}")]
    public class BranchViewModel
    {
        #region Properties      
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime OpeningHour { get; set; }
        public DateTime ClosingHour { get; set; }
        public string ManagerName { get; set; }
        #endregion
    }
}
