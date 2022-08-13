using System;

namespace EgyptianRecipes.Application.Models.ViewModels.BranchReservation
{
    public class BranchReservationCreateViewModel
    {
        public Guid BranchId { get; set; }
        public DateTime Date { get; set; }
    }
}
