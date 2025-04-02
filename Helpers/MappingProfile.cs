using AutoMapper;
using CelestialObject.DTOs;
using CelestialObject.Models;
using CelestialObject.Requests;

namespace CelestialObject.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddObjects, CelestialObjects>();
            CreateMap<CelestialObjects, MainInfoDTO>();
            CreateMap<CelestialObjects, SpecificInfoDTO>();
            CreateMap<CelestialObjects, ScienceInfoDTO>();
            CreateMap<CelestialObjects, LocationDTO>();
        } 
    }
}
