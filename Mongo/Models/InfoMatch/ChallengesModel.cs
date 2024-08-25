using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Models.InfoMatch
{
    public class ChallengesModel
    {
        [BsonElement("12AssistStreakCount")]
        public long The12AssistStreakCount { get; set; }

        [BsonElement("InfernalScalePickup")]
        public long InfernalScalePickup { get; set; }

        [BsonElement("SWARM_DefeatAatrox")]
        public long SwarmDefeatAatrox { get; set; }

        [BsonElement("SWARM_DefeatBriar")]
        public long SwarmDefeatBriar { get; set; }

        [BsonElement("SWARM_DefeatMiniBosses")]
        public long SwarmDefeatMiniBosses { get; set; }

        [BsonElement("SWARM_EvolveWeapon")]
        public long SwarmEvolveWeapon { get; set; }

        [BsonElement("SWARM_Have3Passives")]
        public long SwarmHave3Passives { get; set; }

        [BsonElement("SWARM_KillEnemy")]
        public long SwarmKillEnemy { get; set; }

        [BsonElement("SWARM_PickupGold")]
        public long SwarmPickupGold { get; set; }

        [BsonElement("SWARM_ReachLevel50")]
        public long SwarmReachLevel50 { get; set; }

        [BsonElement("SWARM_Survive15Min")]
        public long SwarmSurvive15Min { get; set; }

        [BsonElement("SWARM_WinWith5EvolvedWeapons")]
        public long SwarmWinWith5EvolvedWeapons { get; set; }

        [BsonElement("abilityUses")]
        public long AbilityUses { get; set; }

        [BsonElement("acesBefore15Minutes")]
        public long AcesBefore15Minutes { get; set; }

        [BsonElement("alliedJungleMonsterKills")]
        public long AlliedJungleMonsterKills { get; set; }

        [BsonElement("baronTakedowns")]
        public long BaronTakedowns { get; set; }

        [BsonElement("blastConeOppositeOpponentCount")]
        public long BlastConeOppositeOpponentCount { get; set; }

        [BsonElement("bountyGold")]
        public long BountyGold { get; set; }

        [BsonElement("buffsStolen")]
        public long BuffsStolen { get; set; }

        [BsonElement("completeSupportQuestInTime")]
        public long CompleteSupportQuestInTime { get; set; }

        [BsonElement("controlWardsPlaced")]
        public long ControlWardsPlaced { get; set; }

        [BsonElement("damagePerMinute")]
        public double DamagePerMinute { get; set; }

        [BsonElement("damageTakenOnTeamPercentage")]
        public double DamageTakenOnTeamPercentage { get; set; }

        [BsonElement("dancedWithRiftHerald")]
        public long DancedWithRiftHerald { get; set; }

        [BsonElement("deathsByEnemyChamps")]
        public long DeathsByEnemyChamps { get; set; }

        [BsonElement("dodgeSkillShotsSmallWindow")]
        public long DodgeSkillShotsSmallWindow { get; set; }

        [BsonElement("doubleAces")]
        public long DoubleAces { get; set; }

        [BsonElement("dragonTakedowns")]
        public long DragonTakedowns { get; set; }

        [BsonElement("effectiveHealAndShielding")]
        public double EffectiveHealAndShielding { get; set; }

        [BsonElement("elderDragonKillsWithOpposingSoul")]
        public long ElderDragonKillsWithOpposingSoul { get; set; }

        [BsonElement("elderDragonMultikills")]
        public long ElderDragonMultikills { get; set; }

        [BsonElement("enemyChampionImmobilizations")]
        public long EnemyChampionImmobilizations { get; set; }

        [BsonElement("enemyJungleMonsterKills")]
        public long EnemyJungleMonsterKills { get; set; }

        [BsonElement("epicMonsterKillsNearEnemyJungler")]
        public long EpicMonsterKillsNearEnemyJungler { get; set; }

        [BsonElement("epicMonsterKillsWithin30SecondsOfSpawn")]
        public long EpicMonsterKillsWithin30SecondsOfSpawn { get; set; }

        [BsonElement("epicMonsterSteals")]
        public long EpicMonsterSteals { get; set; }

        [BsonElement("epicMonsterStolenWithoutSmite")]
        public long EpicMonsterStolenWithoutSmite { get; set; }

        [BsonElement("firstTurretKilled")]
        public long FirstTurretKilled { get; set; }

        [BsonElement("fistBumpParticipation")]
        public long FistBumpParticipation { get; set; }

        [BsonElement("flawlessAces")]
        public long FlawlessAces { get; set; }

        [BsonElement("fullTeamTakedown")]
        public long FullTeamTakedown { get; set; }

        [BsonElement("gameLength")]
        public double GameLength { get; set; }

        [BsonElement("getTakedownsInAllLanesEarlyJungleAsLaner")]
        public long GetTakedownsInAllLanesEarlyJungleAsLaner { get; set; }

        [BsonElement("goldPerMinute")]
        public double GoldPerMinute { get; set; }

        [BsonElement("hadOpenNexus")]
        public long HadOpenNexus { get; set; }

        [BsonElement("immobilizeAndKillWithAlly")]
        public long ImmobilizeAndKillWithAlly { get; set; }

        [BsonElement("initialBuffCount")]
        public long InitialBuffCount { get; set; }

        [BsonElement("initialCrabCount")]
        public long InitialCrabCount { get; set; }

        [BsonElement("jungleCsBefore10Minutes")]
        public long JungleCsBefore10Minutes { get; set; }

        [BsonElement("junglerTakedownsNearDamagedEpicMonster")]
        public long JunglerTakedownsNearDamagedEpicMonster { get; set; }

        [BsonElement("kTurretsDestroyedBeforePlatesFall")]
        public long KTurretsDestroyedBeforePlatesFall { get; set; }

        [BsonElement("kda")]
        public double Kda { get; set; }

        [BsonElement("killAfterHiddenWithAlly")]
        public long KillAfterHiddenWithAlly { get; set; }

        [BsonElement("killParticipation")]
        public double KillParticipation { get; set; }

        [BsonElement("killedChampTookFullTeamDamageSurvived")]
        public long KilledChampTookFullTeamDamageSurvived { get; set; }

        [BsonElement("killingSprees")]
        public long KillingSprees { get; set; }

        [BsonElement("killsNearEnemyTurret")]
        public long KillsNearEnemyTurret { get; set; }

        [BsonElement("killsOnOtherLanesEarlyJungleAsLaner")]
        public long KillsOnOtherLanesEarlyJungleAsLaner { get; set; }

        [BsonElement("killsOnRecentlyHealedByAramPack")]
        public long KillsOnRecentlyHealedByAramPack { get; set; }

        [BsonElement("killsUnderOwnTurret")]
        public long KillsUnderOwnTurret { get; set; }

        [BsonElement("killsWithHelpFromEpicMonster")]
        public long KillsWithHelpFromEpicMonster { get; set; }

        [BsonElement("knockEnemyIntoTeamAndKill")]
        public long KnockEnemyIntoTeamAndKill { get; set; }

        [BsonElement("landSkillShotsEarlyGame")]
        public long LandSkillShotsEarlyGame { get; set; }

        [BsonElement("laneMinionsFirst10Minutes")]
        public long LaneMinionsFirst10Minutes { get; set; }

        [BsonElement("legendaryCount")]
        public long LegendaryCount { get; set; }

        [BsonElement("legendaryItemUsed")]
        public required List<long> LegendaryItemUsed { get; set; }

        [BsonElement("lostAnInhibitor")]
        public long LostAnInhibitor { get; set; }

        [BsonElement("maxKillDeficit")]
        public long MaxKillDeficit { get; set; }

        [BsonElement("mejaisFullStackInTime")]
        public long MejaisFullStackInTime { get; set; }

        [BsonElement("moreEnemyJungleThanOpponent")]
        public long MoreEnemyJungleThanOpponent { get; set; }

        [BsonElement("multiKillOneSpell")]
        public long MultiKillOneSpell { get; set; }

        [BsonElement("multiTurretRiftHeraldCount")]
        public long MultiTurretRiftHeraldCount { get; set; }

        [BsonElement("multikills")]
        public long Multikills { get; set; }

        [BsonElement("multikillsAfterAggressiveFlash")]
        public long MultikillsAfterAggressiveFlash { get; set; }

        [BsonElement("outerTurretExecutesBefore10Minutes")]
        public long OuterTurretExecutesBefore10Minutes { get; set; }

        [BsonElement("outnumberedKills")]
        public long OutnumberedKills { get; set; }

        [BsonElement("outnumberedNexusKill")]
        public long OutnumberedNexusKill { get; set; }

        [BsonElement("perfectDragonSoulsTaken")]
        public long PerfectDragonSoulsTaken { get; set; }

        [BsonElement("perfectGame")]
        public long PerfectGame { get; set; }

        [BsonElement("pickKillWithAlly")]
        public long PickKillWithAlly { get; set; }

        [BsonElement("poroExplosions")]
        public long PoroExplosions { get; set; }

        [BsonElement("quickCleanse")]
        public long QuickCleanse { get; set; }

        [BsonElement("quickFirstTurret")]
        public long QuickFirstTurret { get; set; }

        [BsonElement("quickSoloKills")]
        public long QuickSoloKills { get; set; }

        [BsonElement("riftHeraldTakedowns")]
        public long RiftHeraldTakedowns { get; set; }

        [BsonElement("saveAllyFromDeath")]
        public long SaveAllyFromDeath { get; set; }

        [BsonElement("scuttleCrabKills")]
        public long ScuttleCrabKills { get; set; }

        [BsonElement("skillshotsDodged")]
        public long SkillshotsDodged { get; set; }

        [BsonElement("skillshotsHit")]
        public long SkillshotsHit { get; set; }

        [BsonElement("snowballsHit")]
        public long SnowballsHit { get; set; }

        [BsonElement("soloBaronKills")]
        public long SoloBaronKills { get; set; }

        [BsonElement("soloKills")]
        public long SoloKills { get; set; }

        [BsonElement("stealthWardsPlaced")]
        public long StealthWardsPlaced { get; set; }

        [BsonElement("survivedSingleDigitHpCount")]
        public long SurvivedSingleDigitHpCount { get; set; }

        [BsonElement("survivedThreeImmobilizesInFight")]
        public long SurvivedThreeImmobilizesInFight { get; set; }

        [BsonElement("takedownOnFirstTurret")]
        public long TakedownOnFirstTurret { get; set; }

        [BsonElement("takedowns")]
        public long Takedowns { get; set; }

        [BsonElement("takedownsAfterGainingLevelAdvantage")]
        public long TakedownsAfterGainingLevelAdvantage { get; set; }

        [BsonElement("takedownsBeforeJungleMinionSpawn")]
        public long TakedownsBeforeJungleMinionSpawn { get; set; }

        [BsonElement("takedownsFirstXMinutes")]
        public long TakedownsFirstXMinutes { get; set; }

        [BsonElement("takedownsInAlcove")]
        public long TakedownsInAlcove { get; set; }

        [BsonElement("takedownsInEnemyFountain")]
        public long TakedownsInEnemyFountain { get; set; }

        [BsonElement("teamBaronKills")]
        public long TeamBaronKills { get; set; }

        [BsonElement("teamDamagePercentage")]
        public double TeamDamagePercentage { get; set; }

        [BsonElement("teamElderDragonKills")]
        public long TeamElderDragonKills { get; set; }

        [BsonElement("teamRiftHeraldKills")]
        public long TeamRiftHeraldKills { get; set; }

        [BsonElement("tookLargeDamageSurvived")]
        public long TookLargeDamageSurvived { get; set; }

        [BsonElement("turretPlatesTaken")]
        public long TurretPlatesTaken { get; set; }

        [BsonElement("turretTakedowns")]
        public long TurretTakedowns { get; set; }

        [BsonElement("turretsTakenWithRiftHerald")]
        public long TurretsTakenWithRiftHerald { get; set; }

        [BsonElement("twentyMinionsIn3SecondsCount")]
        public long TwentyMinionsIn3SecondsCount { get; set; }

        [BsonElement("twoWardsOneSweeperCount")]
        public long TwoWardsOneSweeperCount { get; set; }

        [BsonElement("unseenRecalls")]
        public long UnseenRecalls { get; set; }

        [BsonElement("visionScorePerMinute")]
        public double VisionScorePerMinute { get; set; }

        [BsonElement("voidMonsterKill")]
        public long VoidMonsterKill { get; set; }

        [BsonElement("wardTakedowns")]
        public long WardTakedowns { get; set; }

        [BsonElement("wardTakedownsBefore20M")]
        public long WardTakedownsBefore20M { get; set; }

        [BsonElement("wardsGuarded")]
        public long WardsGuarded { get; set; }

        [BsonElement("highestCrowdControlScore")]
        public long? HighestCrowdControlScore { get; set; }

        [BsonElement("firstTurretKilledTime")]
        public double? FirstTurretKilledTime { get; set; }

        [BsonElement("highestChampionDamage")]
        public long? HighestChampionDamage { get; set; }

        [BsonElement("shortestTimeToAceFromFirstTakedown")]
        public double? ShortestTimeToAceFromFirstTakedown { get; set; }
    }
}
