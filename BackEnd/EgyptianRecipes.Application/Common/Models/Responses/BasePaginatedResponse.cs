using EgyptianRecipes.Application.Models;
using EgyptianRecipes.Application.Common.Models;
using System.Collections.Generic;

namespace EgyptianRecipes.Application.Common.Responses
{
    public class BasePaginatedResponse<T> : BaseResponse<T>    
    {
        public BasePaginatedResponse()
        {
            Success = true;
        }
        public BasePaginatedResponse(string message = null)
        {
            Success = true;
            Message = message;
        }

        public BasePaginatedResponse(string message, bool success)
        {
            Success = success;
            Message = message;
        }
        public Pagination Pagination { get; set; }
    }
}
