using AutoMapper;
using Core.Application.DTOs;
using Core.Application.DTOs.MatchDtos;
using Core.Application.DTOs.MatchDtos.InfoMatch;
using Mongo.Models;
using Mongo.Models.InfoMatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SummonerDto, SummonerModel>().ReverseMap();
            CreateMap<MatchDto, MatchModel>().ReverseMap();

            CreateMap<InfoMatchDto, InfoMatchModel>()
           .ForMember(dest => dest.Metadata, opt => opt.MapFrom(src => src.Metadata))
           .ForMember(dest => dest.Info, opt => opt.MapFrom(src => src.Info))
           .ReverseMap();

            // Nested types mapping
            CreateMap<MetadataDto, MetadataModel>().ReverseMap();
            CreateMap<InfoDto, InfoModel>().ReverseMap();
            CreateMap<BaronDto, BaronModel>().ReverseMap();
            CreateMap<ChallengesDto, ChallengesModel>().ReverseMap();
            CreateMap<ChampionDto, ChampionModel>().ReverseMap();
            CreateMap<InhibitorDto, InhibitorModel>().ReverseMap();
            CreateMap<DragonDto, DragonModel>().ReverseMap();
            CreateMap<HordeDto, HordeModel>().ReverseMap();
            CreateMap<ObjectivesDto, ObjectivesModel>().ReverseMap();
            CreateMap<ParticipantDto, ParticipantModel>().ReverseMap();
            CreateMap<PerksDto, PerksModel>().ReverseMap();
            CreateMap<SelectionDto, SelectionModel>().ReverseMap();
            CreateMap<StatPerksDto, StatPerksModel>().ReverseMap();
            CreateMap<StyleDto, StyleModel>().ReverseMap();
            CreateMap<TeamDto, TeamModel>().ReverseMap();
            CreateMap<TowerDto, TowerModel>().ReverseMap();
        }
    }
}
