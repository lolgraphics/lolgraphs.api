using Postgres.Models.InfoMatch;

namespace Postgres.Models.Match.InfoMatch
{
    public class ParticipantModel
    {

        public long ParticipantModelId { get; set; } // Primary Key

        public long AllInPings { get; set; }

        public long AssistMePings { get; set; }

        public long Assists { get; set; }

        public long BaronKills { get; set; }

        public long BasicPings { get; set; }

        public long BountyLevel { get; set; }

        public long ChampExperience { get; set; }

        public long ChampLevel { get; set; }

        public long ChampionId { get; set; }

        public required string ChampionName { get; set; }

        public long ChampionTransform { get; set; }

        public long CommandPings { get; set; }

        public long ConsumablesPurchased { get; set; }

        public long DamageDealtToBuildings { get; set; }

        public long DamageDealtToObjectives { get; set; }

        public long DamageDealtToTurrets { get; set; }

        public long DamageSelfMitigated { get; set; }

        public long DangerPings { get; set; }

        public long Deaths { get; set; }

        public long DetectorWardsPlaced { get; set; }

        public long DoubleKills { get; set; }

        public long DragonKills { get; set; }

        public bool EligibleForProgression { get; set; }

        public long EnemyMissingPings { get; set; }

        public long EnemyVisionPings { get; set; }

        public bool FirstBloodAssist { get; set; }

        public bool FirstBloodKill { get; set; }

        public bool FirstTowerAssist { get; set; }

        public bool FirstTowerKill { get; set; }

        public bool GameEndedInEarlySurrender { get; set; }

        public bool GameEndedInSurrender { get; set; }

        public long GetBackPings { get; set; }

        public long GoldEarned { get; set; }

        public long GoldSpent { get; set; }

        public long HoldPings { get; set; }

        public required string IndividualPosition { get; set; }

        public long InhibitorKills { get; set; }

        public long InhibitorTakedowns { get; set; }

        public long InhibitorsLost { get; set; }

        public long Item0 { get; set; }

        public long Item1 { get; set; }

        public long Item2 { get; set; }

        public long Item3 { get; set; }

        public long Item4 { get; set; }

        public long Item5 { get; set; }

        public long Item6 { get; set; }

        public long ItemsPurchased { get; set; }

        public long KillingSprees { get; set; }

        public long Kills { get; set; }

        public required string Lane { get; set; }

        public long LargestCriticalStrike { get; set; }

        public long LargestKillingSpree { get; set; }

        public long LargestMultiKill { get; set; }

        public long LongestTimeSpentLiving { get; set; }

        public long MagicDamageDealt { get; set; }

        public long MagicDamageDealtToChampions { get; set; }

        public long MagicDamageTaken { get; set; }

        public long NeedVisionPings { get; set; }

        public long NeutralMinionsKilled { get; set; }

        public long NexusKills { get; set; }

        public long NexusLost { get; set; }

        public long NexusTakedowns { get; set; }

        public long ObjectivesStolen { get; set; }

        public long ObjectivesStolenAssists { get; set; }

        public long OnMyWayPings { get; set; }

        public long ParticipantId { get; set; }

        public long PentaKills { get; set; }

        public long PhysicalDamageDealt { get; set; }

        public long PhysicalDamageDealtToChampions { get; set; }

        public long PhysicalDamageTaken { get; set; }

        public long Placement { get; set; }

        public long PlayerAugment1 { get; set; }

        public long PlayerAugment2 { get; set; }

        public long PlayerAugment3 { get; set; }

        public long PlayerAugment4 { get; set; }

        public long PlayerAugment5 { get; set; }

        public long PlayerAugment6 { get; set; }

        public long PlayerSubteamId { get; set; }

        public long ProfileIcon { get; set; }

        public long PushPings { get; set; }

        public required string Puuid { get; set; }

        public long QuadraKills { get; set; }

        public string? RiotIdGameName { get; set; }

        public string? RiotIdTagline { get; set; }

        public string? Role { get; set; }

        public long SightWardsBoughtInGame { get; set; }

        public long Spell1Casts { get; set; }

        public long Spell2Casts { get; set; }

        public long Spell3Casts { get; set; }

        public long Spell4Casts { get; set; }

        public long SubteamPlacement { get; set; }

        public long Summoner1Casts { get; set; }

        public long Summoner1Id { get; set; }

        public long Summoner2Casts { get; set; }

        public long Summoner2Id { get; set; }

        public required string SummonerId { get; set; }

        public long SummonerLevel { get; set; }

        public required string SummonerName { get; set; }

        public bool TeamEarlySurrendered { get; set; }

        public long TeamId { get; set; }

        public required string TeamPosition { get; set; }

        public long TimeCCingOthers { get; set; }

        public long TimePlayed { get; set; }

        public long TotalAllyJungleMinionsKilled { get; set; }

        public long TotalDamageDealt { get; set; }

        public long TotalDamageDealtToChampions { get; set; }

        public long TotalDamageShieldedOnTeammates { get; set; }

        public long TotalDamageTaken { get; set; }

        public long TotalEnemyJungleMinionsKilled { get; set; }

        public long TotalHeal { get; set; }

        public long TotalHealsOnTeammates { get; set; }

        public long TotalMinionsKilled { get; set; }

        public long TotalTimeCcDealt { get; set; }

        public long TotalTimeSpentDead { get; set; }

        public long TotalUnitsHealed { get; set; }

        public long TripleKills { get; set; }

        public long TrueDamageDealt { get; set; }

        public long TrueDamageDealtToChampions { get; set; }

        public long TrueDamageTaken { get; set; }

        public long TurretKills { get; set; }

        public long TurretTakedowns { get; set; }

        public long TurretsLost { get; set; }

        public long UnrealKills { get; set; }

        public long VisionClearedPings { get; set; }

        public long VisionScore { get; set; }

        public long VisionWardsBoughtInGame { get; set; }

        public long WardsKilled { get; set; }

        public long WardsPlaced { get; set; }

        public bool Win { get; set; }

        // Foreign Key relationships
        public long InfoId { get; set; } // Foreign Key to InfoModel
        public InfoModel InfoModel { get; set; } // Relacionamento de Navegação

        // Relationships to Challenges and Perks
        public ChallengesModel Challenges { get; set; } // Corrigido para ser um único objeto

        public PerksModel Perks { get; set; }
    }
}
