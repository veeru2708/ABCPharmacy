using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABCPharmacy.API.Domain;
using ABCPharmacy.API.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ABCPharmacy.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        
        private readonly ILogger<MedicineController> _logger;
        private readonly IMedicineService _medicineService;

        public MedicineController(ILogger<MedicineController> logger, IMedicineService medicineService)
        {
            _logger = logger;
            _medicineService = medicineService;
        }

        [HttpGet]
        public async Task<IEnumerable<MedicineDomain>> Get()
        {
            return await _medicineService.GetMedicines();
        }

        [HttpGet("id")]
        public async Task<MedicineDomain> GetById(int id)
        {
            return await _medicineService.GetMedicineById(id);
        }

        [HttpPut]
        public async Task<IActionResult> Update(MedicineDomain medicine)
        {
            var result =  await _medicineService.EditMedicine(medicine);
            if (result)
                return Ok();
            else
                return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Add(MedicineDomain medicine)
        {
            var result = await _medicineService.AddMedicine(medicine);
            if (result)
                return Ok();
            else
                return BadRequest();

        }
    }
}
