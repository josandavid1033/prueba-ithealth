using Hospital.Api.Models.Data;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Api.Models.DTOs
{
	public record PatientDTO(int Id, string Document_type, int Document_num, string Name, DateTime Birthday, string Email, string Gender, string Address, int Phone_number, int State);
	public class CreatePatientDTO
	{
		[Required] 
		public int Document_type_id { get; set; }
		[Required]
		public int Document_num { get; set; }
		[Required]
		[StringLength(100)]
		public string Name { get; set; }
		public DateTime Birthday { get; set; }
		[StringLength(30)]
		public string Email { get; set; }
		[Required]
		public int Gender_id { get; set; }
		[StringLength(40)]
		public string Address { get; set; }
		public int Phone_number { get; set; }
		public int State { get; set; }

	}
}
