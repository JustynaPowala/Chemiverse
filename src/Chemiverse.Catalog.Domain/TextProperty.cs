using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemiverse.Catalog.Domain
{
	public class TextProperty
	{
		public Guid Id { get; private set; }
		public string Name { get; private set; }

		public static TextProperty Define(Guid id, string name)
		{
			var textProperty = new TextProperty();
			textProperty.Id = id;
			textProperty.Name = name;
			return textProperty;
		}
	}
}
