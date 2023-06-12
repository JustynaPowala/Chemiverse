namespace Chemiverse.Catalog.Domain
{
	public class Product
	{
		private List<ProductNumericProperty> _numericProperties = new List<ProductNumericProperty>();
		private List<ProductTextProperty> _textProperties = new List<ProductTextProperty>();
		protected Product()
		{

		}
		public Guid Id { get; private set; }
		public string Name { get; private set; }
		public string Description { get; private set; }	
		public Guid CategoryId { get; private set;}
		public IReadOnlyList<ProductNumericProperty> NumericProperties => _numericProperties;
		public IReadOnlyList<ProductTextProperty> TextProperties => _textProperties;
		

		public static Product Introduce(Guid id, string name)
		{
			var product = new Product();
			product.Id = id;
			product.Name = name;
			return product;
		}
		public void Describe(string description)
		{
			Description = description;
		}
		public void Rename(string newName)
		{
			Name = newName;
		}

		public void MoveToCategory(Guid categoryId)
		{
			CategoryId = categoryId;
		}

		public void AssignProperty(NumericProperty property, decimal value) 
		{
			var productNumericProperty = _numericProperties.FirstOrDefault(p => p.PropertyId == property.Id);
			if(productNumericProperty == null) 
			{
				productNumericProperty = ProductNumericProperty.Create(property.Id, value);
					_numericProperties.Add(productNumericProperty);
			}
			else
			{
				productNumericProperty.ChangeValue(value);
			}		
		}

		public void AssignProperty(TextProperty property, string value)
		{
			var productTextProperty = _textProperties.FirstOrDefault(p=>p.PropertyId == property.Id);
			if(productTextProperty == null)
			{
				productTextProperty = ProductTextProperty.Create(property.Id, value);
				_textProperties.Add(productTextProperty);
			}
			else
			{
				productTextProperty.ChangeValue(value);
			}
		}
	}
}

