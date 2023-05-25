using Microsoft.AspNetCore.Identity;

namespace Emerketo_webapp.Models
{
	public class ApplicationUser : IdentityUser
	{
		public string FirstName { get; set; } = null!;
		public string LastName { get; set; } = null!;
		public int AddressId { get; set; }
		public Address Address { get; set; } = null!;
	}
}
