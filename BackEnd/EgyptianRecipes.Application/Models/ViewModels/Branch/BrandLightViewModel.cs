#region Using ...
using System;
using System.Diagnostics;
#endregion

namespace MinistryOfHealthService.Core.Models.ViewModels
{
    [DebuggerDisplay("Pagination={Pagination}, Sorting={Sorting}, Title={Title}")]
    public class BrandLightViewModel
    {
        #region Constructors
        public BrandLightViewModel()
        {
        }
        #endregion

        #region Properties      
        public Guid Id { get; set; }

        public string Title { get; set; }
        public DateTime OpeningHour { get; set; }
        public DateTime ClosingHour { get; set; }
        public string ManagerName { get; set; }
        #endregion
    }
}
