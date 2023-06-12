using Chemiverse.Catalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace Chemiverse.Catalog.Tests
{
	public class Category_tests
	{
		[Fact]
		public void when_Add_category_then_new_category_created()
		{
			var id = Guid.NewGuid();
			var name = "xxxxxxxxxxxxxxxxxxxasdfweerrtt";

			var category = Category.Add(id, name);

			Assert.Equal(id, category.Id);
			Assert.Equal(name, category.Name);
		}


		[Fact]
		public void when_Rename_then_name_changed_to_new_name()
		{
			var expectedNewName = "dkfecatgjdrgrogoergoo";
			var category = Category.Add(Guid.NewGuid(), "abecadlo"); 
		
			category.Rename(expectedNewName);
			Assert.Equal(expectedNewName, category.Name);
		}

		[Fact] 
		public void when_Add_subcategory_then_subcategory_created()
		{
			var id = Guid.NewGuid();
			var name = "abcddcvcvdll";
			var category = Category.Add(Guid.NewGuid(), "abecadlo");		

			var subcategory = category.AddSubcategory(id, name);

			Assert.Equal(category.Id, subcategory.ParentId);
			Assert.Equal(id, subcategory.Id);
			Assert.Equal(name, subcategory.Name);
		}
	}
}
