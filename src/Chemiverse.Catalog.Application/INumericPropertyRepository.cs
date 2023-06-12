using Chemiverse.Catalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemiverse.Catalog.Application
{
	public interface INumericPropertyRepository
	{
		Task<NumericProperty> GetAsync(Guid id);
		Task SaveAsync(NumericProperty property);
	}
}
