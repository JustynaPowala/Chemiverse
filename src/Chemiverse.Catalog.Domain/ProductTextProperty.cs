using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Chemiverse.Catalog.Domain
{
	public class ProductTextProperty
	{
		public Guid PropertyId { get; private set; }
		public string Value { get; private set; }

		public static ProductTextProperty Create(Guid id, string value)
		{
			ProductTextProperty productTextProperty = new ProductTextProperty();
			productTextProperty.PropertyId = id;
			productTextProperty.Value = value;
			return productTextProperty;
		}

		public void ChangeValue(string newValue)
		{
			Value = newValue;
		}
	}

	
}
