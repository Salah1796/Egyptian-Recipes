#region Using ...
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
#endregion


namespace EgyptianRecipes.Application.Contracts.Persistence
{
	public interface IUnitOfWorkAsync
	{
		#region Methods
		Task<int> CommitAsync();
		#endregion
	}
}
