using ABCPharmacy.API.Domain;
using ABCPharmacy.API.Services.Interface;
using ABCPharmacy.Data.Models;
using ABCPharmacy.Data.Repositories.Interface;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABCPharmacy.API.Services
{
    public class MedicineService : IMedicineService
    {
        private IMedicineRepository _medicineRepository;
        private readonly IMapper _mapper;
        public MedicineService(IMedicineRepository medicineRepository,IMapper mapper)
        {
            this._medicineRepository = medicineRepository ?? throw new ArgumentNullException(nameof(medicineRepository)); ;
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper)); ;
        }

        public async Task<bool> AddMedicine(MedicineDomain medicine)
        {
            var med = _mapper.Map<Medicine>(medicine);
            return await _medicineRepository.AddMedicine(med);
        }

        public async Task<bool> EditMedicine(MedicineDomain medicine)
        {
            var med = _mapper.Map<Medicine>(medicine);
            return await _medicineRepository.EditMedicine(med);
            
        }

        public async Task<MedicineDomain> GetMedicineById(int medicineId)
        {
            var medicine = await _medicineRepository.GetMedicineById(medicineId);
            var medicineDomain = _mapper.Map<MedicineDomain>(medicine);
            return medicineDomain;
        }

        public async Task<IEnumerable<MedicineDomain>> GetMedicines()
        {

            var medicines = await _medicineRepository.GetMedicines();
            var medicinesDomain = _mapper.Map<List<MedicineDomain>>(medicines);
            return medicinesDomain;
        }
    }



}
