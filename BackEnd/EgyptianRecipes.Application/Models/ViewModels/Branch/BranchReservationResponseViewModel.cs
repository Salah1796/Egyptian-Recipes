using System;

namespace EgyptianRecipes.Application.Models.ViewModels.Branch
{
    public class BranchReservationResponseViewModel
    {
        public Guid Id { get; set; }    
        public string BranchName { get; set; }
        public DateTime Date { get; set; }
    }
}
