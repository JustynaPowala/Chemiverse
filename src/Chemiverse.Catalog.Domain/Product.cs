namespace Chemiverse.Catalog.Domain
{
	public class Product
	{
		public Guid Id { get; private set; }
		public string Name { get; private set; }
		public string Description { get; private set; }
		
		
		public void Describe(string description)
		{
			Description = description;
		}

	}
}