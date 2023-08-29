
using AutoMapper;
using Core.Entities;
using API.Dtos;

public class MappingProfiles : Profile
{   

        public MappingProfiles(){

            CreateMap<Cliente,ClienteDto>().ReverseMap();
        }

}