using EmployeeApp.Core.Interface.Common;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApp.Core.Entities.Common
{
	public class BaseEntity : IDelete
	{
		[Key]
		public int Id { get; set; }
		public bool IsDeleted { get; set; }
	}
}