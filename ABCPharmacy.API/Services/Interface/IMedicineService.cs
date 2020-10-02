using ABCPharmacy.API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABCPharmacy.API.Services.Interface
{
    public interface IMedicineService
    {
        Task<bool> AddMedicine(MedicineDomain medicine);

        Task<bool> EditMedicine(MedicineDomain medicine);

        Task<IEnumerable<MedicineDomain>> GetMedicines();

        Task<MedicineDomain> GetMedicineById(int Medicine);


    }
}
