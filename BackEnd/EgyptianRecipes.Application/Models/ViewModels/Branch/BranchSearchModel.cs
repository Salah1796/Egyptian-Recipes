#region Using ...

using EgyptianRecipes.Application.Common.Models;
using System;
using System.Diagnostics;
#endregion

namespace MinistryOfHealthService.Core.Models.ViewModels
{
    [DebuggerDisplay("Pagination={Pagination}, Sorting={Sorting}, Title={Title}")]
    public class BranchSearchModel : BaseFilter
    {
        #region Constructors
        public BranchSearchModel()
        {
        }
        #endregion

        #region Properties
        public string Title { get; set; }
        public DateTime? FromOpeningHour { get; set; }
        public DateTime? ToOpeningHour { get; set; }
        public DateTime? FromClosingHour { get; set; }
        public DateTime? ToClosingHour { get; set; }
        public string ManagerName { get; set; }
        #endregion
    }
}
