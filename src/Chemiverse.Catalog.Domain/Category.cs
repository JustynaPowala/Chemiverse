using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chemiverse.Catalog.Domain
{
	public class Category
	{
		protected Category()
		{
		
		}
		public Guid Id { get; private set; }	
		public string Name { get; private set; }

		public static Category Add(Guid id, string name)
		{
			Category category = new Category();
			category.Id = id;
			category.Name = name;
			return category;
		}

		public void Rename(string newName)
		{
			Name = newName;
		}
	}
}
