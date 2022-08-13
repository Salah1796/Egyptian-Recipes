#region Using ...
using System;
using System.Diagnostics;
#endregion

namespace MinistryOfHealthService.Core.Models.ViewModels
{
    [DebuggerDisplay("Id={Id} , Name={Name}")]
    public class ManagerLookupViewModel
    {
        #region Constructors
        public ManagerLookupViewModel()
        {
        }
        #endregion

        #region Properties      
        public Guid Id { get; set; }
        public string Name { get; set; }
        #endregion
    }
}
