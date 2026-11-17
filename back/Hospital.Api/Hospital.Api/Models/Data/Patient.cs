using System.Reflection.Metadata;

namespace Hospital.Api.Models.Data
{
	public class Patient
	{
		public int Id { get; set; }
		public Document_type Document_type { get; set; } //Esto podríaser un enum
		public int Document_num {  get; set; }
		public string Name { get; set; }
		public DateTime Birthday { get; set; }
		public string Email { get; set; }
		public Gender Gender { get; set; } //También podría ser un enum
		public string Address { get; set; }
		public int Phone_number { get; set; }
		public int State { get; set; }

	}
}
