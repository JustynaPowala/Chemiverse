using Chemiverse.Catalog.Domain;
using Xunit;

namespace Chemiverse.Catalog.Tests
{
	public class Product_test
	{
		[Theory]
		[InlineData("NaOH")]
		[InlineData("NaOHaha")]
		public void when_describe_then_description_set(string expectedDescription)
		{
			var product = new Product();

			product.Describe(expectedDescription);

			Assert.Equal(expectedDescription, product.Description);
		}

	}
}