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
			var product = Product.Introduce(Guid.NewGuid(), "greghjykjtr");

			product.Describe(expectedDescription);

			Assert.Equal(expectedDescription, product.Description);
		}

		[Fact]
		public void when_product_Introduce_then_product_created()
		{
			var id = Guid.NewGuid();
			var name = "cvdfhjrykrthtr";

			var product = Product.Introduce(id, name);

			Assert.Equal(id, product.Id);
			Assert.Equal(name, product.Name);
		}

		[Fact]
		public void when_Rename_then_name_changed_to_new_name()
		{
			var expectedNewName = "dkfecatgjdrgrogoergoo";
			var product = Product.Introduce(Guid.NewGuid(), "abecadlo");

			product.Rename(expectedNewName);
			Assert.Equal(expectedNewName, product.Name);
		}

		[Fact]
		public void when_MoveToCategory_then_category_assinged()
		{
			var product = Product.Introduce(Guid.NewGuid(), "abecadlo");
			var categoryId = Guid.NewGuid();
			product.MoveToCategory(categoryId);
			Assert.Equal(categoryId, product.CategoryId);
		}


		[Fact]
		public void when_numeric_property_assign_then_value_added_to_numeric_properties()
		{
			//given
			var product = Product.Introduce(Guid.NewGuid(), "abecadlo");
			var numericProperty = NumericProperty.Define(Guid.NewGuid(), "fffffffffffffffff", "ggggggggggggg");
			//when
			product.AssignProperty(numericProperty, 23);
			//then
			Assert.Contains(product.NumericProperties, p => p.Value == 23 && p.PropertyId == numericProperty.Id);		
		}

		[Fact]
		public void given_product_with_numeric_property_when_the_same_property_assigned_with_different_value_then_value_of_that_property_changed()
		{
			//given
			var product = Product.Introduce(Guid.NewGuid(), "abecadlo");
			var numericProperty = NumericProperty.Define(Guid.NewGuid(), "fffffffffffffffff", "ggggggggggggg");
			product.AssignProperty(numericProperty, 23);

			//when
			product.AssignProperty(numericProperty, 24);

			//then
			Assert.Contains(product.NumericProperties, p => p.Value == 24 && p.PropertyId == numericProperty.Id);
			Assert.DoesNotContain(product.NumericProperties, p => p.Value == 23 && p.PropertyId == numericProperty.Id);
		}

		[Fact]
		public void given_product_with_text_property_when_the_same_property_assigned_with_different_value_then_value_of_that_property_changed()
		{
			//given
			var product = Product.Introduce(Guid.NewGuid(), "abecadlo");
			var textProperty = TextProperty.Define(Guid.NewGuid(), "fffffffffffffffff");
			product.AssignProperty(textProperty, "23");

			//when
			product.AssignProperty(textProperty, "24");

			//then
			Assert.Contains(product.TextProperties, p => p.Value == "24" && p.PropertyId == textProperty.Id);
			Assert.DoesNotContain(product.TextProperties, p => p.Value == "23" && p.PropertyId == textProperty.Id);
		}
	}
}