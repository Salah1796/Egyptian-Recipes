#region Using ...
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace EgyptianRecipes.Domain.Common.Contracts
{
	public interface IEntityIdentity<TPrimeryKey>
	{
	   TPrimeryKey Id { get; set; }
	}
}
