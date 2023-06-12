using Chemiverse.Catalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chemiverse.Catalog.Tests
{
	public class TextProperty_tests
	{
		[Fact]
		public void when_TextProperty_Define_then_TextProperty_created()
		{

			var id = Guid.NewGuid();
			var name = "axsdfeghjdjrtr";
			

			var numericProperty = TextProperty.Define(id, name);
			Assert.Equal(id, numericProperty.Id);
			Assert.Equal(name, numericProperty.Name);
		}
	}
}
