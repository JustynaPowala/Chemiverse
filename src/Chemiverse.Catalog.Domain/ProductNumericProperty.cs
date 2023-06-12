using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Chemiverse.Catalog.Domain
{
	public class ProductNumericProperty
	{
		public Guid PropertyId { get; private set; }
		public decimal Value { get; private set; }

		public static ProductNumericProperty Create(Guid id, decimal value)
		{
			ProductNumericProperty productNumericProperty = new ProductNumericProperty();
			productNumericProperty.PropertyId = id;
			productNumericProperty.Value = value;
			return productNumericProperty;
		}

		public void ChangeValue(decimal newValue)
		{
			Value = newValue;
		}
	}

	
}
