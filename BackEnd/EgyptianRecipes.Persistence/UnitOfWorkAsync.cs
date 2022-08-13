#region Using ...
using EgyptianRecipes.Application.Contracts.Persistence;
using System;
using System.Threading.Tasks;
#endregion

namespace EgyptianRecipes.Persistence
{
	/// <summary>
	/// 
	/// </summary>
	public class UnitOfWorkAsync : IUnitOfWorkAsync
	{
		#region Data Members
		private EgyptianRecipesDbContext _context;
		#endregion

		#region Constructors
		public UnitOfWorkAsync(EgyptianRecipesDbContext context)
		{
			this._context = context;
		}
		#endregion

		#region IUnitOfWork	
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public async Task<int> CommitAsync()
		{
			var result = await this._context.SaveChangesAsync();
			return result;
		}

        #endregion
    }
}
