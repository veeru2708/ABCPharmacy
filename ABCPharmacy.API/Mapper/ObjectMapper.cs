using ABCPharmacy.API.Domain;
using ABCPharmacy.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABCPharmacy.API.Mapper
{
    public class ObjectMapper : Profile
    {
        public ObjectMapper()
        {
            CreateMap<MedicineDomain, Medicine>();
            CreateMap<Medicine, MedicineDomain>();
        }
       

    }
}
