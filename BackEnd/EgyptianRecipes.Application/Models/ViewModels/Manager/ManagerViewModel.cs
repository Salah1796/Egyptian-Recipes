#region Using ...

using EgyptianRecipes.Application.Common.Models;
using System;
using System.Diagnostics;
#endregion

namespace MinistryOfHealthService.Core.Models.ViewModels
{
    [DebuggerDisplay("Pagination={Pagination}, Sorting={Sorting}, Name={Name}")]
    public class ManagerViewModel
    {
        #region Properties      
        public Guid Id { get; set; }
        public string Name { get; set; }
        #endregion
    }
}
