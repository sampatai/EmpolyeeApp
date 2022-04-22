using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Core.Interface
{
	public interface ITrackable
	{
		DateTime CreatedOn { get; set; }
		DateTime UpdatedOn { get; set; }
	}
}
