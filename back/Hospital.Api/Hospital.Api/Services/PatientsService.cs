using Hospital.Api.Models.Data;
using Hospital.Api.Models.DTOs;
using Hospital.Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Api.Services
{
	public class PatientsService(AppDbContext context) : IPatientsService
	{
		
		public Task<bool> Add(CreatePatientDTO dtopatient)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Patient>> AllAsync()
		{
			List<Patient> Patients = await context.Patients.AsNoTracking().Select(s => new PatientDTO { Id = s.Id, Name = s.Name, Document_type = s.Document_type.Document_type })
		}

		public Task<bool> DeleteById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Patient> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> Update(int id, PatientDTO dtopatient)
		{
			throw new NotImplementedException();
		}
	}
}
