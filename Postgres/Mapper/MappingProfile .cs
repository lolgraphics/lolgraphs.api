using AutoMapper;
using Core.Application.DTOs;
using Core.Application.DTOs.MatchDtos;
using Core.Application.DTOs.MatchDtos.InfoMatch;
using Core.Application.DTOs.MatchDtos.InfoMatchDto;
using Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO;
using Core.Application.DTOs.MatchDTOs;
using Core.Application.DTOs.MatchDTOs.InfoMatch;
using Core.Application.DTOs.MatchDTOs.infoMatchTimeLineDTO;
using Postgres.Models;
using Postgres.Models.InfoMatch;
using Postgres.Models.InfoMatchTimeLine;
using Postgres.Models.Match;
using Postgres.Models.Match.InfoMatch;
using Postgres.Models.Match.infoMatchTimeLine;

namespace Postgres.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Summoner mappers
            CreateMap<SummonerDto, SummonerModel>().ReverseMap();

            // Match mappers
            CreateMap<MatchDto, MatchModel>().ReverseMap();

            // Info Match Time Line mappers
            CreateMap<InfoMatchTimeLineDTO, InfoMatchTimeLineModel>()
                .ForMember(dest => dest.Metadata, opt => opt.MapFrom(src => src.Metadata))
                .ForMember(dest => dest.Info, opt => opt.MapFrom(src => src.Info))
                .ReverseMap();
            CreateMap<long, AssistingParticipantIdsModel>()
                .ForMember(dest => dest.AssistingParticipantId, opt => opt.MapFrom(src => src));
            CreateMap<InfoTimeLineDTO, InfoTimeLineModel>().ReverseMap();
            CreateMap<FrameDTO, FrameModel>().ReverseMap();
            CreateMap<EventDTO, EventModel>().ReverseMap();
            CreateMap<KeyValuePair<string, ParticipantFrameDTO>, ParticipantFrameModel>()
                .ForMember(dest => dest.ParticipantId, opt => opt.MapFrom(src => long.Parse(src.Key)))
                .ForMember(dest => dest.ChampionStats, opt => opt.MapFrom(src => src.Value.ChampionStats))
                .ForMember(dest => dest.DamageStats, opt => opt.MapFrom(src => src.Value.DamageStats))
                .ForMember(dest => dest.CurrentGold, opt => opt.MapFrom(src => src.Value.CurrentGold))
                .ForMember(dest => dest.GoldPerSecond, opt => opt.MapFrom(src => src.Value.GoldPerSecond))
                .ForMember(dest => dest.JungleMinionsKilled, opt => opt.MapFrom(src => src.Value.JungleMinionsKilled))
                .ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.Value.Level))
                .ForMember(dest => dest.MinionsKilled, opt => opt.MapFrom(src => src.Value.MinionsKilled))
                .ForMember(dest => dest.TimeEnemySpentControlled, opt => opt.MapFrom(src => src.Value.TimeEnemySpentControlled))
                .ForMember(dest => dest.TotalGold, opt => opt.MapFrom(src => src.Value.TotalGold))
                .ForMember(dest => dest.Xp, opt => opt.MapFrom(src => src.Value.Xp));
            CreateMap<ChampionStatsDto, ChampionStatsModel>().ReverseMap();
            CreateMap<DamageStatsDto, DamageStatsModel>().ReverseMap();
            CreateMap<ParticipantFrameDTO, ParticipantFrameModel>().ReverseMap();
            CreateMap<PositionDTO, PositionEventModel>().ReverseMap();
            CreateMap<VictimDamageReceivedDTO, VictimDamageReceivedModel>().ReverseMap();
            CreateMap<VictimDamageDealDTO, VictimDamageDealtModel>().ReverseMap();
            CreateMap<MetadataTimeLineDTO, MetadataTimeLineModel>().ReverseMap();

            // Info Match mappers
            CreateMap<InfoMatchDto, InfoMatchModel>()
                .ForMember(dest => dest.Metadata, opt => opt.MapFrom(src => src.Metadata))
                .ForMember(dest => dest.Info, opt => opt.MapFrom(src => src.Info))
                .ReverseMap();
            CreateMap<MetadataInfoMatchDTO, MetadataInfoMatchModel>()
                .ForMember(dest => dest.Participants, opt => opt.MapFrom(src => src.Participants.Select(p => new ParticipantsIdModel { ParticipantsPuuid = p }).ToList()))
                .ReverseMap()
                .ForMember(dest => dest.Participants, opt => opt.MapFrom(src => src.Participants.Select(p => p.ParticipantsPuuid).ToList()));
            CreateMap<ChallengesDto, ChallengesModel>()
                .ForMember(dest => dest.LegendaryItemUsed, opt => opt.MapFrom(src => src.LegendaryItemUsed.Select(item => new LegendaryItemUsedModel { LegendaryItemId = item })));
            CreateMap<long, LegendaryItemUsedModel>()
                .ForMember(dest => dest.LegendaryItemId, opt => opt.MapFrom(src => src));
            CreateMap<InfoDto, InfoModel>().ReverseMap();
            CreateMap<BaronDto, BaronModel>().ReverseMap();
            CreateMap<ChallengesDto, ChallengesModel>().ReverseMap();
            CreateMap<ChampionDto, ChampionModel>().ReverseMap();
            CreateMap<InhibitorDto, InhibitorModel>().ReverseMap();
            CreateMap<DragonDto, DragonModel>().ReverseMap();
            CreateMap<HordeDto, HordeModel>().ReverseMap();
            CreateMap<ParticipantDto, ParticipantModel>().ReverseMap();
            CreateMap<RiftHeraldDto, RiftHeraldModel>().ReverseMap();
            CreateMap<ObjectivesDto, ObjectivesModel>().ReverseMap();
            CreateMap<PerksDto, PerksModel>().ReverseMap();
            CreateMap<SelectionDto, SelectionModel>().ReverseMap();
            CreateMap<StatPerksDto, StatPerksModel>().ReverseMap();
            CreateMap<StyleDto, StyleModel>().ReverseMap();
            CreateMap<TeamDto, TeamModel>().ReverseMap();
            CreateMap<TowerDto, TowerModel>().ReverseMap();
        }
    }
}
