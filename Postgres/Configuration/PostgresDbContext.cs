using Microsoft.EntityFrameworkCore;
using Postgres.Models;
using Postgres.Models.InfoMatch;
using Postgres.Models.InfoMatchTimeLine;
using Postgres.Models.Match;
using Postgres.Models.Match.InfoMatch;
using Postgres.Models.Match.infoMatchTimeLine;

namespace Postgres.Configuration
{
    public class PostgresDbContext : DbContext
    {
        public PostgresDbContext(DbContextOptions<PostgresDbContext> options)
            : base(options)
        {
        }

        public DbSet<SummonerModel> Summoners { get; set; }
        public DbSet<MatchModel> Matches { get; set; }
        public DbSet<InfoMatchModel> InfoMatches { get; set; }
        public DbSet<InfoMatchTimeLineModel> InfoMatchTimeLines { get; set; }
        public DbSet<TeamModel> Teams { get; set; }
        public DbSet<ObjectivesModel> Objectives { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Summoners and Matches
            modelBuilder.Entity<SummonerModel>().ToTable("Summoners");
            modelBuilder.Entity<MatchModel>().ToTable("Matches")
                .HasKey(c => new { c.Puuid, c.Id });

            #region InfoMatch Relationships

            // InfoMatch and related models
            modelBuilder.Entity<InfoMatchModel>().ToTable("InfoMatches")
                .HasKey(i => new { i.MatchId, i.Puuid });

            modelBuilder.Entity<InfoMatchTimeLineModel>().ToTable("InfoMatchTimeLines");

            // Participants
            modelBuilder.Entity<ParticipantModel>().ToTable("Participants")
                .HasOne(p => p.Challenges)
                .WithOne(c => c.Participant)
                .HasForeignKey<ChallengesModel>(c => c.ParticipantModelId);

            modelBuilder.Entity<ParticipantModel>()
                .HasOne(p => p.Perks)
                .WithOne(p => p.Participant)
                .HasForeignKey<PerksModel>(p => p.ParticipantModelId);

            // Perks and related models
            modelBuilder.Entity<PerksModel>()
                .HasOne(p => p.StatPerks)
                .WithOne(sp => sp.Perks)
                .HasForeignKey<StatPerksModel>(sp => sp.PerksModelId);

            modelBuilder.Entity<PerksModel>()
                .HasMany(p => p.Styles)
                .WithOne(s => s.Perks)
                .HasForeignKey(s => s.PerksModelId);

            modelBuilder.Entity<StyleModel>()
                .HasMany(s => s.Selections)
                .WithOne(sel => sel.Style)
                .HasForeignKey(sel => sel.StyleModelId);

            // Challenges and LegendaryItemUsed
            modelBuilder.Entity<ChallengesModel>()
                .HasMany(c => c.LegendaryItemUsed)
                .WithOne(l => l.Challenges)
                .HasForeignKey(l => l.ChallengesModelId);

            // Teams and Objectives
            modelBuilder.Entity<TeamModel>().ToTable("Teams")
                .HasOne(t => t.Objectives)
                .WithOne(o => o.Team)
                .HasForeignKey<ObjectivesModel>(o => o.TeamId);

            // MetadataInfoMatch and ParticipantsId
            modelBuilder.Entity<MetadataInfoMatchModel>()
                .HasMany(m => m.Participants)
                .WithOne(p => p.MetadataInfoMatch)
                .HasForeignKey(p => p.MetadataModelInfoMatchModelId);

            // Team and ChampionBanned
            modelBuilder.Entity<TeamModel>()
                .HasMany(t => t.Bans)
                .WithOne(b => b.Team)
                .HasForeignKey(b => b.TeamId);

            #endregion

            #region Objectives Relationships

            // Objectives and related entities
            modelBuilder.Entity<ObjectivesModel>()
                .HasOne(o => o.Baron)
                .WithOne(b => b.Objectives)
                .HasForeignKey<BaronModel>(b => b.ObjectivesId);

            modelBuilder.Entity<ObjectivesModel>()
                .HasOne(o => o.Champion)
                .WithOne(c => c.Objectives)
                .HasForeignKey<ChampionModel>(c => c.ObjectivesId);

            modelBuilder.Entity<ObjectivesModel>()
                .HasOne(o => o.Dragon)
                .WithOne(d => d.Objectives)
                .HasForeignKey<DragonModel>(d => d.ObjectivesId);

            modelBuilder.Entity<ObjectivesModel>()
                .HasOne(o => o.Horde)
                .WithOne(h => h.Objectives)
                .HasForeignKey<HordeModel>(h => h.ObjectivesId);

            modelBuilder.Entity<ObjectivesModel>()
                .HasOne(o => o.Inhibitor)
                .WithOne(i => i.Objectives)
                .HasForeignKey<InhibitorModel>(i => i.ObjectivesId);

            modelBuilder.Entity<ObjectivesModel>()
                .HasOne(o => o.RiftHerald)
                .WithOne(r => r.Objectives)
                .HasForeignKey<RiftHeraldModel>(r => r.ObjectivesId);

            modelBuilder.Entity<ObjectivesModel>()
                .HasOne(o => o.Tower)
                .WithOne(t => t.Objectives)
                .HasForeignKey<TowerModel>(t => t.ObjectivesId);

            #endregion

            #region InfoMatchTimeLine Relationships

            // InfoMatchTimeLineModel and related models
            modelBuilder.Entity<InfoMatchTimeLineModel>()
                .HasKey(i => new { i.MatchId, i.Puuid });

            modelBuilder.Entity<InfoMatchTimeLineModel>()
                .HasOne(i => i.Metadata)
                .WithMany(m => m.InfoMatchTimeLines)
                .HasForeignKey(i => i.MetadataModelId);

            modelBuilder.Entity<InfoMatchTimeLineModel>()
                .HasOne(i => i.Info)
                .WithMany(t => t.InfoMatchTimeLines)
                .HasForeignKey(i => i.InfoTimeLineModelId);

            // InfoTimeLineModel relationships
            modelBuilder.Entity<InfoTimeLineModel>()
                .HasMany(i => i.Frames)
                .WithOne(f => f.InfoTimeLine)
                .HasForeignKey(f => f.InfoTimeLineModelId);

            modelBuilder.Entity<FrameModel>()
                .HasMany(f => f.Events)
                .WithOne(e => e.Frame)
                .HasForeignKey(e => e.FrameModelId);

            modelBuilder.Entity<FrameModel>()
                .HasMany(f => f.ParticipantFrames)
                .WithOne(p => p.Frame)
                .HasForeignKey(p => p.FrameModelId);

            modelBuilder.Entity<EventModel>()
                .HasMany(e => e.AssistingParticipantIds)
                .WithOne(a => a.Event)
                .HasForeignKey(a => a.EventModelId);

            modelBuilder.Entity<EventModel>()
                .HasMany(e => e.VictimDamageDealt)
                .WithOne(v => v.Event)
                .HasForeignKey(v => v.EventModelId);

            modelBuilder.Entity<EventModel>()
                .HasMany(e => e.VictimDamageReceived)
                .WithOne(v => v.Event)
                .HasForeignKey(v => v.EventModelId);

            // Position relationships
            modelBuilder.Entity<EventModel>()
                .HasOne(e => e.Position)
                .WithOne(p => p.Event)
                .HasForeignKey<PositionEventModel>(p => p.EventModelId);

            modelBuilder.Entity<ParticipantFrameModel>()
                .HasOne(p => p.Position)
                .WithOne(p => p.ParticipantFrame)
                .HasForeignKey<PositionParticipantModel>(p => p.ParticipantFrameModelId);

            // ParticipantFrame relationships
            modelBuilder.Entity<ParticipantFrameModel>()
                .HasOne(p => p.DamageStats)
                .WithMany(d => d.ParticipantFrames)
                .HasForeignKey(p => p.DamageStatsId);

            modelBuilder.Entity<ParticipantFrameModel>()
                .HasOne(p => p.ChampionStats)
                .WithMany(c => c.ParticipantFrames)
                .HasForeignKey(p => p.ChampionStatsId);

            // ParticipantTimeLine relationships
            modelBuilder.Entity<ParticipantTimeLineModel>()
                .HasOne(p => p.InfoTimeLine)
                .WithMany(i => i.ParticipantsTimeLine)
                .HasForeignKey(p => p.InfoTimeLineModelId);

            #endregion
        }
    }
}
