using AutoMapper;
using ProiectDAW.DTO;
using ProiectDAW.Models;

namespace ProiectDAW.Mapper
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<Portofel, PortofelDTO>();
            CreateMap<PortofelDTO, Portofel>();
        }
    }
}
