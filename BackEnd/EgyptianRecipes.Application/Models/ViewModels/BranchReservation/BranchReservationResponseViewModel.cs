using System;

namespace EgyptianRecipes.Application.Models.ViewModels.BranchReservation
{
    public class BranchReservationResponseViewModel
    {
        public Guid Id { get; set; }    
        public Guid BranchId { get; set; }
        public DateTime Date { get; set; }
    }
}
