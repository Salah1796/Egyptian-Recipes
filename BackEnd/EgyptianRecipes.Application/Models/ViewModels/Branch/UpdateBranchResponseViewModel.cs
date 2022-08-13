using System;

namespace EgyptianRecipes.Application.Models.ViewModels.Branch
{
    public class UpdateBranchResponseViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime OpeningHour { get; set; }
        public DateTime ClosingHour { get; set; }
        public string ManagerName { get; set; }
    }
}
