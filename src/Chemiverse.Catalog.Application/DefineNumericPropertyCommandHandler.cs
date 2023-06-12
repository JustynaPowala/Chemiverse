using Chemiverse.Catalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemiverse.Catalog.Application
{
	public class DefineNumericPropertyCommandHandler
	{
		private readonly INumericPropertyRepository _numericPropertyRepository;

		public DefineNumericPropertyCommandHandler(INumericPropertyRepository numericPropertyRepository)
		{
			_numericPropertyRepository = numericPropertyRepository;
		}
		public async Task HandleAsync(DefineNumericPropertyCommand command)
		{
			var property = NumericProperty.Define(command.Id, command.Name, command.Unit);
			await _numericPropertyRepository.SaveAsync(property);
		}
	}
}
