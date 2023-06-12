using Chemiverse.Catalog.Application;
using Chemiverse.Catalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemiverse.Catalog.Infrastructure
{
	public class NumericPropertyRepository : INumericPropertyRepository
	{
		private readonly CatalogDbContext _catalogDbContext;

		public NumericPropertyRepository(CatalogDbContext catalogDbContext)
		{
			_catalogDbContext = catalogDbContext;
		}
		public async Task<NumericProperty> GetAsync(Guid id)
		{
			return await _catalogDbContext.NumericProperties.FindAsync(id);
		}

		public async Task SaveAsync(NumericProperty property)
		{
			var existingNumericProperty = await _catalogDbContext.NumericProperties.FindAsync(property.Id);
			if(existingNumericProperty == null)
			{
				_catalogDbContext.NumericProperties.Add(property);
			}
			else
			{
				_catalogDbContext.Entry(existingNumericProperty).CurrentValues.SetValues(property);
			}
			await _catalogDbContext.SaveChangesAsync();
		}
	}
}
