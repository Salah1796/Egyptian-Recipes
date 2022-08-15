#region Using ...
using System;
using System.Diagnostics;
#endregion

namespace EgyptianRecipes.Application.Models.ViewModels
{
    [DebuggerDisplay("Id ={Id} , Title={Title}")]
    public class BranchLightViewModel
    {
        #region Constructors
        public BranchLightViewModel()
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
