using AutoMapper;
using Core.Application.DTOs;
using Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO;
using Core.Application.DTOs.MatchDTOs;
using Core.Application.DTOs.MatchDTOs.InfoMatch;
using Core.Application.DTOs.MatchDTOs.infoMatchTimeLineDTO;
using Core.Application.DTOs.MatchDTOS;
using Mongo.Models;
using Mongo.Models.InfoMatch;
using Mongo.Models.InfoMatchTimeLine;

namespace Mongo.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Summoners mappers
            CreateMap<SummonerDTO, SummonerModel>().ReverseMap();

            // Info match time line mappers
            CreateMap<InfoMatchTimeLineDTO, InfoMatchTimeLineModel>()
                .ForMember(dest => dest.Metadata, opt => opt.MapFrom(src => src.Metadata))
                .ForMember(dest => dest.Info, opt => opt.MapFrom(src => src.Info))
                .ReverseMap();

            CreateMap<InfoTimeLineDTO, InfoTimeLineModel>().ReverseMap();

            // Match mappers
            CreateMap<MatchDTO, MatchModel>().ReverseMap();

            // Info match mappers
            CreateMap<InfoMatchDTO, InfoMatchModel>()
                .ForMember(dest => dest.Metadata, opt => opt.MapFrom(src => src.Metadata))
                .ForMember(dest => dest.Info, opt => opt.MapFrom(src => src.Info))
                .ReverseMap();

            CreateMap<MetadataDTO, MetadataModel>().ReverseMap();
            CreateMap<InfoDTO, InfoModel>().ReverseMap();
            CreateMap<BaronDTO, BaronModel>().ReverseMap();
            CreateMap<ChallengesDTO, ChallengesModel>().ReverseMap();
            CreateMap<ChampionDTO, ChampionModel>().ReverseMap();
            CreateMap<InhibitorDTO, InhibitorModel>().ReverseMap();
            CreateMap<DragonDTO, DragonModel>().ReverseMap();
            CreateMap<HordeDTO, HordeModel>().ReverseMap();
            CreateMap<ObjectivesDTO, ObjectivesModel>().ReverseMap();
            CreateMap<ParticipantDTO, ParticipantModel>().ReverseMap();
            CreateMap<PerksDTO, PerksModel>().ReverseMap();
            CreateMap<SelectionDTO, SelectionModel>().ReverseMap();
            CreateMap<StatPerksDTO, StatPerksModel>().ReverseMap();
            CreateMap<StyleDTO, StyleModel>().ReverseMap();
            CreateMap<TeamDTO, TeamModel>().ReverseMap();
            CreateMap<TowerDTO, TowerModel>().ReverseMap();
        }
    }
}
