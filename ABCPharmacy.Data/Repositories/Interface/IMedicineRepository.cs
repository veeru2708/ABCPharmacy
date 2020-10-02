using ABCPharmacy.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ABCPharmacy.Data.Repositories.Interface
{
    public interface IMedicineRepository
    {
        Task<bool> AddMedicine(Medicine medicine);

        Task<bool> EditMedicine(Medicine medicine);

        Task<IEnumerable<Medicine>> GetMedicines();

        Task<Medicine> GetMedicineById(int MedicineId);

    }
}
