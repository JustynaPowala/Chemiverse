using Chemiverse.Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemiverse.Catalog.Infrastructure
{
	public class CatalogDbContext : DbContext
	{
		public CatalogDbContext()
			: base()
		{
			
		}

		public DbSet<NumericProperty> NumericProperties { get; set; }
	}
}
