using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemiverse.Catalog.Domain
{
	public class NumericProperty
	{
		public Guid Id { get; private set; }
		public string Name { get; private set; }
		public string Unit { get; private set; }

		public static NumericProperty Define(Guid id, string name, string unit)
		{
			var numericProperty = new NumericProperty();
			numericProperty.Id = id;
			numericProperty.Name = name;
			numericProperty.Unit = unit;
			return numericProperty;
		}
	}
}
