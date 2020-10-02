using ABCPharmacy.Data.Models;
using ABCPharmacy.Data.Repositories.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPharmacy.Data.Repositories
{
    public class MedicineRepository : IMedicineRepository
    {
        private ApplicationDbContext _dbContext;
        private readonly ILogger<MedicineRepository> _logger;
        public MedicineRepository(ApplicationDbContext dbContext, ILogger<MedicineRepository>  logger)
        {
            this._dbContext = dbContext;
            this._logger = logger;
            var medicine1 = new Medicine()
            {
                Id = 1,
                Name = "Crocin",
                Brand = "USV",
                Expiry = Convert.ToDateTime("11/11/2022"),
                Notes = "Headache,Fever",
                Price = 10,
                Quantity = 15
            };
            var medicine2 = new Medicine()
            {
                Id = 2,
                Name = "Combiflam",
                Brand = "USV",
                Expiry = Convert.ToDateTime("11/11/2022"),
                Notes = "Headache,Fever",
                Price = 12,
                Quantity = 15
            };
            var medicine3 = new Medicine()
            {
                Id = 3,
                Name = "Asprin",
                Brand = "USV",
                Expiry = Convert.ToDateTime("11/11/2022"),
                Notes = "Headache,Fever",
                Price = 22,
                Quantity = 15
            };
            var medicine4 = new Medicine()
            {
                Id = 4,
                Name = "Amlong",
                Brand = "USV",
                Expiry = Convert.ToDateTime("11/11/2022"),
                Notes = "Blood Pressure",
                Price = 312,
                Quantity = 15
            };
            AddMedicine(medicine1);
            AddMedicine(medicine2);
            AddMedicine(medicine3);
            AddMedicine(medicine4);
        }
        public async Task<bool> AddMedicine(Medicine medicine)
        {
            try
            {
                _dbContext.Medicines.Add(medicine);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error adding the medicine: {ex.Message}");
                throw;
            }

            return true;
        }

        public async Task<bool> EditMedicine(Medicine medicine)
        {
            try
            {
                var med = _dbContext.Medicines.FirstOrDefault(med => med.Id == medicine.Id);
                med.Name = medicine.Name;
                med.Notes = medicine.Notes;
                med.Quantity = medicine.Quantity;
                med.Expiry = medicine.Expiry;
                _dbContext.Medicines.Update(med);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error updating the medicine: {ex.Message}");
                throw;
            }

            return true;
        }

        public async Task<Medicine> GetMedicineById(int medicineId)
        {
            var medicine = _dbContext.Medicines.FirstOrDefault(x => x.Id == medicineId);
            return medicine;
        }

        public async Task<IEnumerable<Medicine>> GetMedicines()
        {
            var medicines = _dbContext.Medicines.Select(x=>x);
            return medicines;
        }
    }
}
