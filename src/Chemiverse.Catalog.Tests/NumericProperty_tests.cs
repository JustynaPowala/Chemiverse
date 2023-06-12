using Chemiverse.Catalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chemiverse.Catalog.Tests
{
	public class NumericProperty_tests
	{

		[Fact]
		public void when_NumericProperty_Define_then_NumericProperty_created()
		{

			var id = Guid.NewGuid();
			var name = "axsdfeghjdjrtr";
			var unit = "orpeorpeorperpoe";

			var numericProperty = NumericProperty.Define(id, name, unit);

			Assert.Equal(id, numericProperty.Id);
			Assert.Equal(name, numericProperty.Name);
			Assert.Equal(unit, numericProperty.Unit);
		}
	}
}
