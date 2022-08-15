#region Using ...

using EgyptianRecipes.Application.Common.Models;
using System;
using System.Diagnostics;
#endregion

namespace EgyptianRecipes.Application.Models.ViewModels
{
    [DebuggerDisplay("Pagination={Pagination}, Sorting={Sorting}, Title={Title}")]
    public class BranchEditViewModel: BranchCreateViewModel
    {

        #region Properties      
        public Guid Id { get; set; }
        #endregion
    }
}
