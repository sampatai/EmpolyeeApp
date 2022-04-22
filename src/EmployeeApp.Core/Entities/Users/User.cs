using EmployeeApp.Core.Entities.Common;
using EmployeeApp.Core.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeApp.Core.Entities.Users
{
    public class User : BaseEntity, ITrackable
	{
		[MaxLength(250)]
		public string UserName { get; set; }
		[MaxLength(250)]
		public string FirstName { get; set; }
		[MaxLength(250)]
		public string LastName { get; set; }
		[MaxLength(250)]
		public string Email { get; set; }
		[MaxLength(20)]
		public string Mobile { get; set; }
		public int UserAccountStatus { get; set; }
	
		public int? BingoUserRoleId { get; set; }
	
		public DateTime? RegisteredOn { get; set; }

        public DateTime CreatedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdatedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
