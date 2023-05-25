namespace Emerketo_webapp.Models
{
	public class Address
	{
		public int Id { get; set; }
		public string StreetAddress { get; set; } = null!;
		public string PostalCode { get; set; } = null!;
		public string City { get; set; } = null!;
	}
}
