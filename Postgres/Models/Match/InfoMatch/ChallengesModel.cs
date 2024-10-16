using Postgres.Models.Match.InfoMatch;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.InfoMatch
{

    [Table("Challenges")]
    public class ChallengesModel
    {
        public long ChallengesModelId { get; set; } // Primary Key
        public long The12AssistStreakCount { get; set; }

        public long InfernalScalePickup { get; set; }

        public long SwarmDefeatAatrox { get; set; }

        public long SwarmDefeatBriar { get; set; }

        public long SwarmDefeatMiniBosses { get; set; }

        public long SwarmEvolveWeapon { get; set; }

        public long SwarmHave3Passives { get; set; }

        public long SwarmKillEnemy { get; set; }

        public long SwarmPickupGold { get; set; }

        public long SwarmReachLevel50 { get; set; }

        public long SwarmSurvive15Min { get; set; }

        public long SwarmWinWith5EvolvedWeapons { get; set; }

        public long AbilityUses { get; set; }

        public long AcesBefore15Minutes { get; set; }

        public long AlliedJungleMonsterKills { get; set; }

        public long BaronTakedowns { get; set; }

        public long BlastConeOppositeOpponentCount { get; set; }

        public long BountyGold { get; set; }

        public long BuffsStolen { get; set; }

        public long CompleteSupportQuestInTime { get; set; }

        public long ControlWardsPlaced { get; set; }

        public double DamagePerMinute { get; set; }

        public double DamageTakenOnTeamPercentage { get; set; }

        public long DancedWithRiftHerald { get; set; }

        public long DeathsByEnemyChamps { get; set; }

        public long DodgeSkillShotsSmallWindow { get; set; }

        public long DoubleAces { get; set; }

        public long DragonTakedowns { get; set; }

        public double EffectiveHealAndShielding { get; set; }

        public long ElderDragonKillsWithOpposingSoul { get; set; }

        public long ElderDragonMultikills { get; set; }

        public long EnemyChampionImmobilizations { get; set; }

        public long EnemyJungleMonsterKills { get; set; }

        public long EpicMonsterKillsNearEnemyJungler { get; set; }

        public long EpicMonsterKillsWithin30SecondsOfSpawn { get; set; }

        public long EpicMonsterSteals { get; set; }

        public long EpicMonsterStolenWithoutSmite { get; set; }

        public long FirstTurretKilled { get; set; }

        public long FistBumpParticipation { get; set; }

        public long FlawlessAces { get; set; }

        public long FullTeamTakedown { get; set; }

        public double GameLength { get; set; }

        public long GetTakedownsInAllLanesEarlyJungleAsLaner { get; set; }

        public double GoldPerMinute { get; set; }

        public long HadOpenNexus { get; set; }

        public long ImmobilizeAndKillWithAlly { get; set; }

        public long InitialBuffCount { get; set; }

        public long InitialCrabCount { get; set; }

        public long JungleCsBefore10Minutes { get; set; }

        public long JunglerTakedownsNearDamagedEpicMonster { get; set; }

        public long KTurretsDestroyedBeforePlatesFall { get; set; }

        public double Kda { get; set; }

        public long KillAfterHiddenWithAlly { get; set; }

        public double KillParticipation { get; set; }

        public long KilledChampTookFullTeamDamageSurvived { get; set; }

        public long KillingSprees { get; set; }

        public long KillsNearEnemyTurret { get; set; }

        public long KillsOnOtherLanesEarlyJungleAsLaner { get; set; }

        public long KillsOnRecentlyHealedByAramPack { get; set; }

        public long KillsUnderOwnTurret { get; set; }

        public long KillsWithHelpFromEpicMonster { get; set; }

        public long KnockEnemyIntoTeamAndKill { get; set; }

        public long LandSkillShotsEarlyGame { get; set; }

        public long LaneMinionsFirst10Minutes { get; set; }

        public long LegendaryCount { get; set; }

        public required List<LegendaryItemUsedModel> LegendaryItemUsed { get; set; }

        public long LostAnInhibitor { get; set; }

        public long MaxKillDeficit { get; set; }

        public long MejaisFullStackInTime { get; set; }

        public long MoreEnemyJungleThanOpponent { get; set; }

        public long MultiKillOneSpell { get; set; }

        public long MultiTurretRiftHeraldCount { get; set; }

        public long Multikills { get; set; }

        public long MultikillsAfterAggressiveFlash { get; set; }

        public long OuterTurretExecutesBefore10Minutes { get; set; }

        public long OutnumberedKills { get; set; }

        public long OutnumberedNexusKill { get; set; }

        public long PerfectDragonSoulsTaken { get; set; }

        public long PerfectGame { get; set; }

        public long PickKillWithAlly { get; set; }

        public long PoroExplosions { get; set; }

        public long QuickCleanse { get; set; }

        public long QuickFirstTurret { get; set; }

        public long QuickSoloKills { get; set; }

        public long RiftHeraldTakedowns { get; set; }

        public long SaveAllyFromDeath { get; set; }

        public long ScuttleCrabKills { get; set; }

        public long SkillshotsDodged { get; set; }

        public long SkillshotsHit { get; set; }

        public long SnowballsHit { get; set; }

        public long SoloBaronKills { get; set; }

        public long SoloKills { get; set; }

        public long StealthWardsPlaced { get; set; }

        public long SurvivedSingleDigitHpCount { get; set; }

        public long SurvivedThreeImmobilizesInFight { get; set; }

       
        public long TakedownOnFirstTurret { get; set; }

        public long Takedowns { get; set; }

        public long TakedownsAfterGainingLevelAdvantage { get; set; }

        public long TakedownsBeforeJungleMinionSpawn { get; set; }

        public long TakedownsFirstXMinutes { get; set; }

        public long TakedownsInAlcove { get; set; }

        public long TakedownsInEnemyFountain { get; set; }

        public long TeamBaronKills { get; set; }

        public double TeamDamagePercentage { get; set; }

        public long TeamElderDragonKills { get; set; }

        public long TeamRiftHeraldKills { get; set; }

        public long TookLargeDamageSurvived { get; set; }

        public long TurretPlatesTaken { get; set; }

        public long TurretTakedowns { get; set; }

        public long TurretsTakenWithRiftHerald { get; set; }

        public long TwentyMinionsIn3SecondsCount { get; set; }

        public long TwoWardsOneSweeperCount { get; set; }

        public long UnseenRecalls { get; set; }

        public double VisionScorePerMinute { get; set; }

        public long VoidMonsterKill { get; set; }

    
        public long WardTakedowns { get; set; }

  
        public long WardTakedownsBefore20M { get; set; }

        public long WardsGuarded { get; set; }

        public long? HighestCrowdControlScore { get; set; }

        public double? FirstTurretKilledTime { get; set; }

        public long? HighestChampionDamage { get; set; }

        public double? ShortestTimeToAceFromFirstTakedown { get; set; }

        // Foreign Key
        public long ParticipantModelId { get; set; }
        public ParticipantModel Participant { get; set; } // Relacionamento de Navegação
    }
}
