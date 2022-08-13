using System;

namespace EgyptianRecipes.Application.Exceptions
{
    public class BadRequestException: ApplicationException
    {
        public BadRequestException(string message): base(message)
        {

        }
    }
}
