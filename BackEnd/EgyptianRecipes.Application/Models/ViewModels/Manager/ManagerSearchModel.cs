#region Using ...

using EgyptianRecipes.Application.Common.Models;
using System;
using System.Diagnostics;
#endregion

namespace EgyptianRecipes.Application.Models.ViewModels
{
    [DebuggerDisplay("Pagination={Pagination}, Sorting={Sorting}, Name={Name}")]
    public class ManagerSearchModel
    {
        #region Constructors
        public ManagerSearchModel()
        {
        }
        #endregion

        #region Properties
        public string Name { get; set; }
        
        #endregion
    }
}
