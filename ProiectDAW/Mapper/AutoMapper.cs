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
            CreateMap<Portofel, PortofelUpdateDTO>();
            CreateMap<PortofelUpdateDTO, Portofel>();
            CreateMap<Atractie, AtractieDTO>();
            CreateMap<AtractieDTO, Atractie>();
            CreateMap<Atractie, AtractieUpdateDTO>();
            CreateMap<AtractieUpdateDTO, Atractie>();
            CreateMap<Bilet, BiletDTO>();
            CreateMap<BiletDTO, Bilet>();
            CreateMap<Bilet, BiletUpdateDTO>();
            CreateMap<BiletUpdateDTO, Bilet>();
            CreateMap<Cazare, CazareDTO>();
            CreateMap<CazareDTO, Cazare>();
            CreateMap<Cazare, CazareUpdateDTO>();
            CreateMap<CazareUpdateDTO, Cazare>();
            CreateMap<Facilitate, FacilitateDTO>();
            CreateMap<FacilitateDTO, Facilitate>();
            CreateMap<Facilitate, FacilitateUpdateDTO>();
            CreateMap<FacilitateUpdateDTO, Facilitate>();
            CreateMap<Fotografie, FotografieDTO>();
            CreateMap<FotografieDTO, Fotografie>();
            CreateMap<Fotografie, FotografieUpdateDTO>();
            CreateMap<FotografieUpdateDTO, Fotografie>();
            CreateMap<Pachet, PachetDTO>();
            CreateMap<PachetDTO, Pachet>();
            CreateMap<Pachet, PachetUpdateDTO>();
            CreateMap<PachetUpdateDTO, Pachet>();
            CreateMap<Rezervare, RezervareDTO>();
            CreateMap<RezervareDTO, Rezervare>();
            CreateMap<Rezervare, RezervareUpdateDTO>();
            CreateMap<RezervareUpdateDTO, Rezervare>();
            CreateMap<RezervareCazare, RezervareCazareDTO>();
            CreateMap<RezervareCazareDTO, RezervareCazare>();
            CreateMap<RezervareCazare, RezervareCazareUpdateDTO>();
            CreateMap<RezervareCazareUpdateDTO, RezervareCazare>();
            CreateMap<Vacanta, VacantaDTO>();
            CreateMap<VacantaDTO, Vacanta>();
            CreateMap<Vacanta, VacantaUpdateDTO>();
            CreateMap<VacantaUpdateDTO, Vacanta>();
        }
    }
}
