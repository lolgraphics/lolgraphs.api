using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.MatchDtos.InfoMatch
{
    public class ParticipantDto
    {
        [JsonProperty("allInPings")]
        public long AllInPings { get; set; }

        [JsonProperty("assistMePings")]
        public long AssistMePings { get; set; }

        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("baronKills")]
        public long BaronKills { get; set; }

        [JsonProperty("basicPings")]
        public long BasicPings { get; set; }

        [JsonProperty("bountyLevel")]
        public long BountyLevel { get; set; }

        [JsonProperty("challenges")]
        public required ChallengesDto Challenges { get; set; }

        [JsonProperty("champExperience")]
        public long ChampExperience { get; set; }

        [JsonProperty("champLevel")]
        public long ChampLevel { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("championName")]
        public required string ChampionName { get; set; }

        [JsonProperty("championTransform")]
        public long ChampionTransform { get; set; }

        [JsonProperty("commandPings")]
        public long CommandPings { get; set; }

        [JsonProperty("consumablesPurchased")]
        public long ConsumablesPurchased { get; set; }

        [JsonProperty("damageDealtToBuildings")]
        public long DamageDealtToBuildings { get; set; }

        [JsonProperty("damageDealtToObjectives")]
        public long DamageDealtToObjectives { get; set; }

        [JsonProperty("damageDealtToTurrets")]
        public long DamageDealtToTurrets { get; set; }

        [JsonProperty("damageSelfMitigated")]
        public long DamageSelfMitigated { get; set; }

        [JsonProperty("dangerPings")]
        public long DangerPings { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("detectorWardsPlaced")]
        public long DetectorWardsPlaced { get; set; }

        [JsonProperty("doubleKills")]
        public long DoubleKills { get; set; }

        [JsonProperty("dragonKills")]
        public long DragonKills { get; set; }

        [JsonProperty("eligibleForProgression")]
        public bool EligibleForProgression { get; set; }

        [JsonProperty("enemyMissingPings")]
        public long EnemyMissingPings { get; set; }

        [JsonProperty("enemyVisionPings")]
        public long EnemyVisionPings { get; set; }

        [JsonProperty("firstBloodAssist")]
        public bool FirstBloodAssist { get; set; }

        [JsonProperty("firstBloodKill")]
        public bool FirstBloodKill { get; set; }

        [JsonProperty("firstTowerAssist")]
        public bool FirstTowerAssist { get; set; }

        [JsonProperty("firstTowerKill")]
        public bool FirstTowerKill { get; set; }

        [JsonProperty("gameEndedInEarlySurrender")]
        public bool GameEndedInEarlySurrender { get; set; }

        [JsonProperty("gameEndedInSurrender")]
        public bool GameEndedInSurrender { get; set; }

        [JsonProperty("getBackPings")]
        public long GetBackPings { get; set; }

        [JsonProperty("goldEarned")]
        public long GoldEarned { get; set; }

        [JsonProperty("goldSpent")]
        public long GoldSpent { get; set; }

        [JsonProperty("holdPings")]
        public long HoldPings { get; set; }

        [JsonProperty("individualPosition")]
        public required string IndividualPosition { get; set; }

        [JsonProperty("inhibitorKills")]
        public long InhibitorKills { get; set; }

        [JsonProperty("inhibitorTakedowns")]
        public long InhibitorTakedowns { get; set; }

        [JsonProperty("inhibitorsLost")]
        public long InhibitorsLost { get; set; }

        [JsonProperty("item0")]
        public long Item0 { get; set; }

        [JsonProperty("item1")]
        public long Item1 { get; set; }

        [JsonProperty("item2")]
        public long Item2 { get; set; }

        [JsonProperty("item3")]
        public long Item3 { get; set; }

        [JsonProperty("item4")]
        public long Item4 { get; set; }

        [JsonProperty("item5")]
        public long Item5 { get; set; }

        [JsonProperty("item6")]
        public long Item6 { get; set; }

        [JsonProperty("itemsPurchased")]
        public long ItemsPurchased { get; set; }

        [JsonProperty("killingSprees")]
        public long KillingSprees { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("lane")]
        public required string Lane { get; set; }

        [JsonProperty("largestCriticalStrike")]
        public long LargestCriticalStrike { get; set; }

        [JsonProperty("largestKillingSpree")]
        public long LargestKillingSpree { get; set; }

        [JsonProperty("largestMultiKill")]
        public long LargestMultiKill { get; set; }

        [JsonProperty("longestTimeSpentLiving")]
        public long LongestTimeSpentLiving { get; set; }

        [JsonProperty("magicDamageDealt")]
        public long MagicDamageDealt { get; set; }

        [JsonProperty("magicDamageDealtToChampions")]
        public long MagicDamageDealtToChampions { get; set; }

        [JsonProperty("magicDamageTaken")]
        public long MagicDamageTaken { get; set; }

        [JsonProperty("missions")]
        public required Dictionary<string, long> Missions { get; set; }

        [JsonProperty("needVisionPings")]
        public long NeedVisionPings { get; set; }

        [JsonProperty("neutralMinionsKilled")]
        public long NeutralMinionsKilled { get; set; }

        [JsonProperty("nexusKills")]
        public long NexusKills { get; set; }

        [JsonProperty("nexusLost")]
        public long NexusLost { get; set; }

        [JsonProperty("nexusTakedowns")]
        public long NexusTakedowns { get; set; }

        [JsonProperty("objectivesStolen")]
        public long ObjectivesStolen { get; set; }

        [JsonProperty("objectivesStolenAssists")]
        public long ObjectivesStolenAssists { get; set; }

        [JsonProperty("onMyWayPings")]
        public long OnMyWayPings { get; set; }

        [JsonProperty("participantId")]
        public long ParticipantId { get; set; }

        [JsonProperty("pentaKills")]
        public long PentaKills { get; set; }

        [JsonProperty("perks")]
        public required PerksDto Perks { get; set; }

        [JsonProperty("physicalDamageDealt")]
        public long PhysicalDamageDealt { get; set; }

        [JsonProperty("physicalDamageDealtToChampions")]
        public long PhysicalDamageDealtToChampions { get; set; }

        [JsonProperty("physicalDamageTaken")]
        public long PhysicalDamageTaken { get; set; }

        [JsonProperty("placement")]
        public long Placement { get; set; }

        [JsonProperty("playerAugment1")]
        public long PlayerAugment1 { get; set; }

        [JsonProperty("playerAugment2")]
        public long PlayerAugment2 { get; set; }

        [JsonProperty("playerAugment3")]
        public long PlayerAugment3 { get; set; }

        [JsonProperty("playerAugment4")]
        public long PlayerAugment4 { get; set; }

        [JsonProperty("playerAugment5")]
        public long PlayerAugment5 { get; set; }

        [JsonProperty("playerAugment6")]
        public long PlayerAugment6 { get; set; }

        [JsonProperty("playerSubteamId")]
        public long PlayerSubteamId { get; set; }

        [JsonProperty("profileIcon")]
        public long ProfileIcon { get; set; }

        [JsonProperty("pushPings")]
        public long PushPings { get; set; }

        [JsonProperty("puuid")]
        public required string Puuid { get; set; }

        [JsonProperty("quadraKills")]
        public long QuadraKills { get; set; }

        [JsonProperty("riotIdGameName")]
        public required string RiotIdGameName { get; set; }

        [JsonProperty("riotIdTagline")]
        public required string RiotIdTagline { get; set; }

        [JsonProperty("role")]
        public required string Role { get; set; }

        [JsonProperty("sightWardsBoughtInGame")]
        public long SightWardsBoughtInGame { get; set; }

        [JsonProperty("spell1Casts")]
        public long Spell1Casts { get; set; }

        [JsonProperty("spell2Casts")]
        public long Spell2Casts { get; set; }

        [JsonProperty("spell3Casts")]
        public long Spell3Casts { get; set; }

        [JsonProperty("spell4Casts")]
        public long Spell4Casts { get; set; }

        [JsonProperty("subteamPlacement")]
        public long SubteamPlacement { get; set; }

        [JsonProperty("summoner1Casts")]
        public long Summoner1Casts { get; set; }

        [JsonProperty("summoner1Id")]
        public long Summoner1Id { get; set; }

        [JsonProperty("summoner2Casts")]
        public long Summoner2Casts { get; set; }

        [JsonProperty("summoner2Id")]
        public long Summoner2Id { get; set; }

        [JsonProperty("summonerId")]
        public required string SummonerId { get; set; }

        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }

        [JsonProperty("summonerName")]
        public required string SummonerName { get; set; }

        [JsonProperty("teamEarlySurrendered")]
        public bool TeamEarlySurrendered { get; set; }

        [JsonProperty("teamId")]
        public long TeamId { get; set; }

        [JsonProperty("teamPosition")]
        public required string TeamPosition { get; set; }

        [JsonProperty("timeCCingOthers")]
        public long TimeCCingOthers { get; set; }

        [JsonProperty("timePlayed")]
        public long TimePlayed { get; set; }

        [JsonProperty("totalAllyJungleMinionsKilled")]
        public long TotalAllyJungleMinionsKilled { get; set; }

        [JsonProperty("totalDamageDealt")]
        public long TotalDamageDealt { get; set; }

        [JsonProperty("totalDamageDealtToChampions")]
        public long TotalDamageDealtToChampions { get; set; }

        [JsonProperty("totalDamageShieldedOnTeammates")]
        public long TotalDamageShieldedOnTeammates { get; set; }

        [JsonProperty("totalDamageTaken")]
        public long TotalDamageTaken { get; set; }

        [JsonProperty("totalEnemyJungleMinionsKilled")]
        public long TotalEnemyJungleMinionsKilled { get; set; }

        [JsonProperty("totalHeal")]
        public long TotalHeal { get; set; }

        [JsonProperty("totalHealsOnTeammates")]
        public long TotalHealsOnTeammates { get; set; }

        [JsonProperty("totalMinionsKilled")]
        public long TotalMinionsKilled { get; set; }

        [JsonProperty("totalTimeCCDealt")]
        public long TotalTimeCcDealt { get; set; }

        [JsonProperty("totalTimeSpentDead")]
        public long TotalTimeSpentDead { get; set; }

        [JsonProperty("totalUnitsHealed")]
        public long TotalUnitsHealed { get; set; }

        [JsonProperty("tripleKills")]
        public long TripleKills { get; set; }

        [JsonProperty("trueDamageDealt")]
        public long TrueDamageDealt { get; set; }

        [JsonProperty("trueDamageDealtToChampions")]
        public long TrueDamageDealtToChampions { get; set; }

        [JsonProperty("trueDamageTaken")]
        public long TrueDamageTaken { get; set; }

        [JsonProperty("turretKills")]
        public long TurretKills { get; set; }

        [JsonProperty("turretTakedowns")]
        public long TurretTakedowns { get; set; }

        [JsonProperty("turretsLost")]
        public long TurretsLost { get; set; }

        [JsonProperty("unrealKills")]
        public long UnrealKills { get; set; }

        [JsonProperty("visionClearedPings")]
        public long VisionClearedPings { get; set; }

        [JsonProperty("visionScore")]
        public long VisionScore { get; set; }

        [JsonProperty("visionWardsBoughtInGame")]
        public long VisionWardsBoughtInGame { get; set; }

        [JsonProperty("wardsKilled")]
        public long WardsKilled { get; set; }

        [JsonProperty("wardsPlaced")]
        public long WardsPlaced { get; set; }

        [JsonProperty("win")]
        public bool Win { get; set; }
    }
}
