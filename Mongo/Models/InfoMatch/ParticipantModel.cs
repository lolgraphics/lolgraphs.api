using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Models.InfoMatch
{
    public class ParticipantModel
    {
        [BsonElement("allInPings")]
        public long AllInPings { get; set; }

        [BsonElement("assistMePings")]
        public long AssistMePings { get; set; }

        [BsonElement("assists")]
        public long Assists { get; set; }

        [BsonElement("baronKills")]
        public long BaronKills { get; set; }

        [BsonElement("basicPings")]
        public long BasicPings { get; set; }

        [BsonElement("bountyLevel")]
        public long BountyLevel { get; set; }

        [BsonElement("challenges")]
        public required ChallengesModel Challenges { get; set; }

        [BsonElement("champExperience")]
        public long ChampExperience { get; set; }

        [BsonElement("champLevel")]
        public long ChampLevel { get; set; }

        [BsonElement("championId")]
        public long ChampionId { get; set; }

        [BsonElement("championName")]
        public required string ChampionName { get; set; }

        [BsonElement("championTransform")]
        public long ChampionTransform { get; set; }

        [BsonElement("commandPings")]
        public long CommandPings { get; set; }

        [BsonElement("consumablesPurchased")]
        public long ConsumablesPurchased { get; set; }

        [BsonElement("damageDealtToBuildings")]
        public long DamageDealtToBuildings { get; set; }

        [BsonElement("damageDealtToObjectives")]
        public long DamageDealtToObjectives { get; set; }

        [BsonElement("damageDealtToTurrets")]
        public long DamageDealtToTurrets { get; set; }

        [BsonElement("damageSelfMitigated")]
        public long DamageSelfMitigated { get; set; }

        [BsonElement("dangerPings")]
        public long DangerPings { get; set; }

        [BsonElement("deaths")]
        public long Deaths { get; set; }

        [BsonElement("detectorWardsPlaced")]
        public long DetectorWardsPlaced { get; set; }

        [BsonElement("doubleKills")]
        public long DoubleKills { get; set; }

        [BsonElement("dragonKills")]
        public long DragonKills { get; set; }

        [BsonElement("eligibleForProgression")]
        public bool EligibleForProgression { get; set; }

        [BsonElement("enemyMissingPings")]
        public long EnemyMissingPings { get; set; }

        [BsonElement("enemyVisionPings")]
        public long EnemyVisionPings { get; set; }

        [BsonElement("firstBloodAssist")]
        public bool FirstBloodAssist { get; set; }

        [BsonElement("firstBloodKill")]
        public bool FirstBloodKill { get; set; }

        [BsonElement("firstTowerAssist")]
        public bool FirstTowerAssist { get; set; }

        [BsonElement("firstTowerKill")]
        public bool FirstTowerKill { get; set; }

        [BsonElement("gameEndedInEarlySurrender")]
        public bool GameEndedInEarlySurrender { get; set; }

        [BsonElement("gameEndedInSurrender")]
        public bool GameEndedInSurrender { get; set; }

        [BsonElement("getBackPings")]
        public long GetBackPings { get; set; }

        [BsonElement("goldEarned")]
        public long GoldEarned { get; set; }

        [BsonElement("goldSpent")]
        public long GoldSpent { get; set; }

        [BsonElement("holdPings")]
        public long HoldPings { get; set; }

        [BsonElement("individualPosition")]
        public required string IndividualPosition { get; set; }

        [BsonElement("inhibitorKills")]
        public long InhibitorKills { get; set; }

        [BsonElement("inhibitorTakedowns")]
        public long InhibitorTakedowns { get; set; }

        [BsonElement("inhibitorsLost")]
        public long InhibitorsLost { get; set; }

        [BsonElement("item0")]
        public long Item0 { get; set; }

        [BsonElement("item1")]
        public long Item1 { get; set; }

        [BsonElement("item2")]
        public long Item2 { get; set; }

        [BsonElement("item3")]
        public long Item3 { get; set; }

        [BsonElement("item4")]
        public long Item4 { get; set; }

        [BsonElement("item5")]
        public long Item5 { get; set; }

        [BsonElement("item6")]
        public long Item6 { get; set; }

        [BsonElement("itemsPurchased")]
        public long ItemsPurchased { get; set; }

        [BsonElement("killingSprees")]
        public long KillingSprees { get; set; }

        [BsonElement("kills")]
        public long Kills { get; set; }

        [BsonElement("lane")]
        public required string Lane { get; set; }

        [BsonElement("largestCriticalStrike")]
        public long LargestCriticalStrike { get; set; }

        [BsonElement("largestKillingSpree")]
        public long LargestKillingSpree { get; set; }

        [BsonElement("largestMultiKill")]
        public long LargestMultiKill { get; set; }

        [BsonElement("longestTimeSpentLiving")]
        public long LongestTimeSpentLiving { get; set; }

        [BsonElement("magicDamageDealt")]
        public long MagicDamageDealt { get; set; }

        [BsonElement("magicDamageDealtToChampions")]
        public long MagicDamageDealtToChampions { get; set; }

        [BsonElement("magicDamageTaken")]
        public long MagicDamageTaken { get; set; }

        [BsonElement("missions")]
        public required Dictionary<string, long> Missions { get; set; }

        [BsonElement("needVisionPings")]
        public long NeedVisionPings { get; set; }

        [BsonElement("neutralMinionsKilled")]
        public long NeutralMinionsKilled { get; set; }

        [BsonElement("nexusKills")]
        public long NexusKills { get; set; }

        [BsonElement("nexusLost")]
        public long NexusLost { get; set; }

        [BsonElement("nexusTakedowns")]
        public long NexusTakedowns { get; set; }

        [BsonElement("objectivesStolen")]
        public long ObjectivesStolen { get; set; }

        [BsonElement("objectivesStolenAssists")]
        public long ObjectivesStolenAssists { get; set; }

        [BsonElement("onMyWayPings")]
        public long OnMyWayPings { get; set; }

        [BsonElement("participantId")]
        public long ParticipantId { get; set; }

        [BsonElement("pentaKills")]
        public long PentaKills { get; set; }

        [BsonElement("perks")]
        public required PerksModel Perks { get; set; }

        [BsonElement("physicalDamageDealt")]
        public long PhysicalDamageDealt { get; set; }

        [BsonElement("physicalDamageDealtToChampions")]
        public long PhysicalDamageDealtToChampions { get; set; }

        [BsonElement("physicalDamageTaken")]
        public long PhysicalDamageTaken { get; set; }

        [BsonElement("placement")]
        public long Placement { get; set; }

        [BsonElement("playerAugment1")]
        public long PlayerAugment1 { get; set; }

        [BsonElement("playerAugment2")]
        public long PlayerAugment2 { get; set; }

        [BsonElement("playerAugment3")]
        public long PlayerAugment3 { get; set; }

        [BsonElement("playerAugment4")]
        public long PlayerAugment4 { get; set; }

        [BsonElement("playerAugment5")]
        public long PlayerAugment5 { get; set; }

        [BsonElement("playerAugment6")]
        public long PlayerAugment6 { get; set; }

        [BsonElement("playerSubteamId")]
        public long PlayerSubteamId { get; set; }

        [BsonElement("profileIcon")]
        public long ProfileIcon { get; set; }

        [BsonElement("pushPings")]
        public long PushPings { get; set; }

        [BsonElement("puuid")]
        public required string Puuid { get; set; }

        [BsonElement("quadraKills")]
        public long QuadraKills { get; set; }

        [BsonElement("riotIdGameName")]
        public required string RiotIdGameName { get; set; }

        [BsonElement("riotIdTagline")]
        public required string RiotIdTagline { get; set; }

        [BsonElement("role")]
        public required string Role { get; set; }

        [BsonElement("sightWardsBoughtInGame")]
        public long SightWardsBoughtInGame { get; set; }

        [BsonElement("spell1Casts")]
        public long Spell1Casts { get; set; }

        [BsonElement("spell2Casts")]
        public long Spell2Casts { get; set; }

        [BsonElement("spell3Casts")]
        public long Spell3Casts { get; set; }

        [BsonElement("spell4Casts")]
        public long Spell4Casts { get; set; }

        [BsonElement("subteamPlacement")]
        public long SubteamPlacement { get; set; }

        [BsonElement("summoner1Casts")]
        public long Summoner1Casts { get; set; }

        [BsonElement("summoner1Id")]
        public long Summoner1Id { get; set; }

        [BsonElement("summoner2Casts")]
        public long Summoner2Casts { get; set; }

        [BsonElement("summoner2Id")]
        public long Summoner2Id { get; set; }

        [BsonElement("summonerId")]
        public required string SummonerId { get; set; }

        [BsonElement("summonerLevel")]
        public long SummonerLevel { get; set; }

        [BsonElement("summonerName")]
        public required string SummonerName { get; set; }

        [BsonElement("teamEarlySurrendered")]
        public bool TeamEarlySurrendered { get; set; }

        [BsonElement("teamId")]
        public long TeamId { get; set; }

        [BsonElement("teamPosition")]
        public required string TeamPosition { get; set; }

        [BsonElement("timeCCingOthers")]
        public long TimeCCingOthers { get; set; }

        [BsonElement("timePlayed")]
        public long TimePlayed { get; set; }

        [BsonElement("totalAllyJungleMinionsKilled")]
        public long TotalAllyJungleMinionsKilled { get; set; }

        [BsonElement("totalDamageDealt")]
        public long TotalDamageDealt { get; set; }

        [BsonElement("totalDamageDealtToChampions")]
        public long TotalDamageDealtToChampions { get; set; }

        [BsonElement("totalDamageShieldedOnTeammates")]
        public long TotalDamageShieldedOnTeammates { get; set; }

        [BsonElement("totalDamageTaken")]
        public long TotalDamageTaken { get; set; }

        [BsonElement("totalEnemyJungleMinionsKilled")]
        public long TotalEnemyJungleMinionsKilled { get; set; }

        [BsonElement("totalHeal")]
        public long TotalHeal { get; set; }

        [BsonElement("totalHealsOnTeammates")]
        public long TotalHealsOnTeammates { get; set; }

        [BsonElement("totalMinionsKilled")]
        public long TotalMinionsKilled { get; set; }

        [BsonElement("totalTimeCCDealt")]
        public long TotalTimeCcDealt { get; set; }

        [BsonElement("totalTimeSpentDead")]
        public long TotalTimeSpentDead { get; set; }

        [BsonElement("totalUnitsHealed")]
        public long TotalUnitsHealed { get; set; }

        [BsonElement("tripleKills")]
        public long TripleKills { get; set; }

        [BsonElement("trueDamageDealt")]
        public long TrueDamageDealt { get; set; }

        [BsonElement("trueDamageDealtToChampions")]
        public long TrueDamageDealtToChampions { get; set; }

        [BsonElement("trueDamageTaken")]
        public long TrueDamageTaken { get; set; }

        [BsonElement("turretKills")]
        public long TurretKills { get; set; }

        [BsonElement("turretTakedowns")]
        public long TurretTakedowns { get; set; }

        [BsonElement("turretsLost")]
        public long TurretsLost { get; set; }

        [BsonElement("unrealKills")]
        public long UnrealKills { get; set; }

        [BsonElement("visionClearedPings")]
        public long VisionClearedPings { get; set; }

        [BsonElement("visionScore")]
        public long VisionScore { get; set; }

        [BsonElement("visionWardsBoughtInGame")]
        public long VisionWardsBoughtInGame { get; set; }

        [BsonElement("wardsKilled")]
        public long WardsKilled { get; set; }

        [BsonElement("wardsPlaced")]
        public long WardsPlaced { get; set; }

        [BsonElement("win")]
        public bool Win { get; set; }
    }
}
