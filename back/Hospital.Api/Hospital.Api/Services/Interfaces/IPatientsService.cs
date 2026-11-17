using Hospital.Api.Models.Data;
using Hospital.Api.Models.DTOs;

namespace Hospital.Api.Services.Interfaces
{
	public interface IPatientsService
	{

		public Task<List<Patient>> AllAsync();
		public Task<Patient> GetById(int id);
		public Task<Boolean> Add(CreatePatientDTO dtopatient);
		public Task<Boolean> DeleteById(int id);
		public Task<Boolean> Update(int id, PatientDTO dtopatient);

	}
}
