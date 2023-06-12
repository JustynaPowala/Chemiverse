using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemiverse.Catalog.Application
{
	public record DefineNumericPropertyCommand(Guid Id, string Name, string Unit);  //jak klasa z properties i konstruktorem przypisującym te property
}
