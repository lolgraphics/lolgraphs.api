using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDTOs.InfoMatch
{
    public class ChallengesDTO
    {
        [JsonProperty("12AssistStreakCount")]
        public long The12AssistStreakCount { get; set; }

        [JsonProperty("InfernalScalePickup")]
        public long InfernalScalePickup { get; set; }

        [JsonProperty("SWARM_DefeatAatrox")]
        public long SwarmDefeatAatrox { get; set; }

        [JsonProperty("SWARM_DefeatBriar")]
        public long SwarmDefeatBriar { get; set; }

        [JsonProperty("SWARM_DefeatMiniBosses")]
        public long SwarmDefeatMiniBosses { get; set; }

        [JsonProperty("SWARM_EvolveWeapon")]
        public long SwarmEvolveWeapon { get; set; }

        [JsonProperty("SWARM_Have3Passives")]
        public long SwarmHave3Passives { get; set; }

        [JsonProperty("SWARM_KillEnemy")]
        public long SwarmKillEnemy { get; set; }

        [JsonProperty("SWARM_PickupGold")]
        public long SwarmPickupGold { get; set; }

        [JsonProperty("SWARM_ReachLevel50")]
        public long SwarmReachLevel50 { get; set; }

        [JsonProperty("SWARM_Survive15Min")]
        public long SwarmSurvive15Min { get; set; }

        [JsonProperty("SWARM_WinWith5EvolvedWeapons")]
        public long SwarmWinWith5EvolvedWeapons { get; set; }

        [JsonProperty("abilityUses")]
        public long AbilityUses { get; set; }

        [JsonProperty("acesBefore15Minutes")]
        public long AcesBefore15Minutes { get; set; }

        [JsonProperty("alliedJungleMonsterKills")]
        public long AlliedJungleMonsterKills { get; set; }

        [JsonProperty("baronTakedowns")]
        public long BaronTakedowns { get; set; }

        [JsonProperty("blastConeOppositeOpponentCount")]
        public long BlastConeOppositeOpponentCount { get; set; }

        [JsonProperty("bountyGold")]
        public long BountyGold { get; set; }

        [JsonProperty("buffsStolen")]
        public long BuffsStolen { get; set; }

        [JsonProperty("completeSupportQuestInTime")]
        public long CompleteSupportQuestInTime { get; set; }

        [JsonProperty("controlWardsPlaced")]
        public long ControlWardsPlaced { get; set; }

        [JsonProperty("damagePerMinute")]
        public double DamagePerMinute { get; set; }

        [JsonProperty("damageTakenOnTeamPercentage")]
        public double DamageTakenOnTeamPercentage { get; set; }

        [JsonProperty("dancedWithRiftHerald")]
        public long DancedWithRiftHerald { get; set; }

        [JsonProperty("deathsByEnemyChamps")]
        public long DeathsByEnemyChamps { get; set; }

        [JsonProperty("dodgeSkillShotsSmallWindow")]
        public long DodgeSkillShotsSmallWindow { get; set; }

        [JsonProperty("doubleAces")]
        public long DoubleAces { get; set; }

        [JsonProperty("dragonTakedowns")]
        public long DragonTakedowns { get; set; }

        [JsonProperty("effectiveHealAndShielding")]
        public double EffectiveHealAndShielding { get; set; }

        [JsonProperty("elderDragonKillsWithOpposingSoul")]
        public long ElderDragonKillsWithOpposingSoul { get; set; }

        [JsonProperty("elderDragonMultikills")]
        public long ElderDragonMultikills { get; set; }

        [JsonProperty("enemyChampionImmobilizations")]
        public long EnemyChampionImmobilizations { get; set; }

        [JsonProperty("enemyJungleMonsterKills")]
        public long EnemyJungleMonsterKills { get; set; }

        [JsonProperty("epicMonsterKillsNearEnemyJungler")]
        public long EpicMonsterKillsNearEnemyJungler { get; set; }

        [JsonProperty("epicMonsterKillsWithin30SecondsOfSpawn")]
        public long EpicMonsterKillsWithin30SecondsOfSpawn { get; set; }

        [JsonProperty("epicMonsterSteals")]
        public long EpicMonsterSteals { get; set; }

        [JsonProperty("epicMonsterStolenWithoutSmite")]
        public long EpicMonsterStolenWithoutSmite { get; set; }

        [JsonProperty("firstTurretKilled")]
        public long FirstTurretKilled { get; set; }

        [JsonProperty("fistBumpParticipation")]
        public long FistBumpParticipation { get; set; }

        [JsonProperty("flawlessAces")]
        public long FlawlessAces { get; set; }

        [JsonProperty("fullTeamTakedown")]
        public long FullTeamTakedown { get; set; }

        [JsonProperty("gameLength")]
        public double GameLength { get; set; }

        [JsonProperty("getTakedownsInAllLanesEarlyJungleAsLaner")]
        public long GetTakedownsInAllLanesEarlyJungleAsLaner { get; set; }

        [JsonProperty("goldPerMinute")]
        public double GoldPerMinute { get; set; }

        [JsonProperty("hadOpenNexus")]
        public long HadOpenNexus { get; set; }

        [JsonProperty("immobilizeAndKillWithAlly")]
        public long ImmobilizeAndKillWithAlly { get; set; }

        [JsonProperty("initialBuffCount")]
        public long InitialBuffCount { get; set; }

        [JsonProperty("initialCrabCount")]
        public long InitialCrabCount { get; set; }

        [JsonProperty("jungleCsBefore10Minutes")]
        public long JungleCsBefore10Minutes { get; set; }

        [JsonProperty("junglerTakedownsNearDamagedEpicMonster")]
        public long JunglerTakedownsNearDamagedEpicMonster { get; set; }

        [JsonProperty("kTurretsDestroyedBeforePlatesFall")]
        public long KTurretsDestroyedBeforePlatesFall { get; set; }

        [JsonProperty("kda")]
        public double Kda { get; set; }

        [JsonProperty("killAfterHiddenWithAlly")]
        public long KillAfterHiddenWithAlly { get; set; }

        [JsonProperty("killParticipation")]
        public double KillParticipation { get; set; }

        [JsonProperty("killedChampTookFullTeamDamageSurvived")]
        public long KilledChampTookFullTeamDamageSurvived { get; set; }

        [JsonProperty("killingSprees")]
        public long KillingSprees { get; set; }

        [JsonProperty("killsNearEnemyTurret")]
        public long KillsNearEnemyTurret { get; set; }

        [JsonProperty("killsOnOtherLanesEarlyJungleAsLaner")]
        public long KillsOnOtherLanesEarlyJungleAsLaner { get; set; }

        [JsonProperty("killsOnRecentlyHealedByAramPack")]
        public long KillsOnRecentlyHealedByAramPack { get; set; }

        [JsonProperty("killsUnderOwnTurret")]
        public long KillsUnderOwnTurret { get; set; }

        [JsonProperty("killsWithHelpFromEpicMonster")]
        public long KillsWithHelpFromEpicMonster { get; set; }

        [JsonProperty("knockEnemyIntoTeamAndKill")]
        public long KnockEnemyIntoTeamAndKill { get; set; }

        [JsonProperty("landSkillShotsEarlyGame")]
        public long LandSkillShotsEarlyGame { get; set; }

        [JsonProperty("laneMinionsFirst10Minutes")]
        public long LaneMinionsFirst10Minutes { get; set; }

        [JsonProperty("legendaryCount")]
        public long LegendaryCount { get; set; }

        [JsonProperty("legendaryItemUsed")]
        public required List<long> LegendaryItemUsed { get; set; }

        [JsonProperty("lostAnInhibitor")]
        public long LostAnInhibitor { get; set; }

        [JsonProperty("maxKillDeficit")]
        public long MaxKillDeficit { get; set; }

        [JsonProperty("mejaisFullStackInTime")]
        public long MejaisFullStackInTime { get; set; }

        [JsonProperty("moreEnemyJungleThanOpponent")]
        public long MoreEnemyJungleThanOpponent { get; set; }

        [JsonProperty("multiKillOneSpell")]
        public long MultiKillOneSpell { get; set; }

        [JsonProperty("multiTurretRiftHeraldCount")]
        public long MultiTurretRiftHeraldCount { get; set; }

        [JsonProperty("multikills")]
        public long Multikills { get; set; }

        [JsonProperty("multikillsAfterAggressiveFlash")]
        public long MultikillsAfterAggressiveFlash { get; set; }

        [JsonProperty("outerTurretExecutesBefore10Minutes")]
        public long OuterTurretExecutesBefore10Minutes { get; set; }

        [JsonProperty("outnumberedKills")]
        public long OutnumberedKills { get; set; }

        [JsonProperty("outnumberedNexusKill")]
        public long OutnumberedNexusKill { get; set; }

        [JsonProperty("perfectDragonSoulsTaken")]
        public long PerfectDragonSoulsTaken { get; set; }

        [JsonProperty("perfectGame")]
        public long PerfectGame { get; set; }

        [JsonProperty("pickKillWithAlly")]
        public long PickKillWithAlly { get; set; }

        [JsonProperty("poroExplosions")]
        public long PoroExplosions { get; set; }

        [JsonProperty("quickCleanse")]
        public long QuickCleanse { get; set; }

        [JsonProperty("quickFirstTurret")]
        public long QuickFirstTurret { get; set; }

        [JsonProperty("quickSoloKills")]
        public long QuickSoloKills { get; set; }

        [JsonProperty("riftHeraldTakedowns")]
        public long RiftHeraldTakedowns { get; set; }

        [JsonProperty("saveAllyFromDeath")]
        public long SaveAllyFromDeath { get; set; }

        [JsonProperty("scuttleCrabKills")]
        public long ScuttleCrabKills { get; set; }

        [JsonProperty("skillshotsDodged")]
        public long SkillshotsDodged { get; set; }

        [JsonProperty("skillshotsHit")]
        public long SkillshotsHit { get; set; }

        [JsonProperty("snowballsHit")]
        public long SnowballsHit { get; set; }

        [JsonProperty("soloBaronKills")]
        public long SoloBaronKills { get; set; }

        [JsonProperty("soloKills")]
        public long SoloKills { get; set; }

        [JsonProperty("stealthWardsPlaced")]
        public long StealthWardsPlaced { get; set; }

        [JsonProperty("survivedSingleDigitHpCount")]
        public long SurvivedSingleDigitHpCount { get; set; }

        [JsonProperty("survivedThreeImmobilizesInFight")]
        public long SurvivedThreeImmobilizesInFight { get; set; }

        [JsonProperty("takedownOnFirstTurret")]
        public long TakedownOnFirstTurret { get; set; }

        [JsonProperty("takedowns")]
        public long Takedowns { get; set; }

        [JsonProperty("takedownsAfterGainingLevelAdvantage")]
        public long TakedownsAfterGainingLevelAdvantage { get; set; }

        [JsonProperty("takedownsBeforeJungleMinionSpawn")]
        public long TakedownsBeforeJungleMinionSpawn { get; set; }

        [JsonProperty("takedownsFirstXMinutes")]
        public long TakedownsFirstXMinutes { get; set; }

        [JsonProperty("takedownsInAlcove")]
        public long TakedownsInAlcove { get; set; }

        [JsonProperty("takedownsInEnemyFountain")]
        public long TakedownsInEnemyFountain { get; set; }

        [JsonProperty("teamBaronKills")]
        public long TeamBaronKills { get; set; }

        [JsonProperty("teamDamagePercentage")]
        public double TeamDamagePercentage { get; set; }

        [JsonProperty("teamElderDragonKills")]
        public long TeamElderDragonKills { get; set; }

        [JsonProperty("teamRiftHeraldKills")]
        public long TeamRiftHeraldKills { get; set; }

        [JsonProperty("tookLargeDamageSurvived")]
        public long TookLargeDamageSurvived { get; set; }

        [JsonProperty("turretPlatesTaken")]
        public long TurretPlatesTaken { get; set; }

        [JsonProperty("turretTakedowns")]
        public long TurretTakedowns { get; set; }

        [JsonProperty("turretsTakenWithRiftHerald")]
        public long TurretsTakenWithRiftHerald { get; set; }

        [JsonProperty("twentyMinionsIn3SecondsCount")]
        public long TwentyMinionsIn3SecondsCount { get; set; }

        [JsonProperty("twoWardsOneSweeperCount")]
        public long TwoWardsOneSweeperCount { get; set; }

        [JsonProperty("unseenRecalls")]
        public long UnseenRecalls { get; set; }

        [JsonProperty("visionScorePerMinute")]
        public double VisionScorePerMinute { get; set; }

        [JsonProperty("voidMonsterKill")]
        public long VoidMonsterKill { get; set; }

        [JsonProperty("wardTakedowns")]
        public long WardTakedowns { get; set; }

        [JsonProperty("wardTakedownsBefore20M")]
        public long WardTakedownsBefore20M { get; set; }

        [JsonProperty("wardsGuarded")]
        public long WardsGuarded { get; set; }

        [JsonProperty("highestCrowdControlScore", NullValueHandling = NullValueHandling.Ignore)]
        public long? HighestCrowdControlScore { get; set; }

        [JsonProperty("firstTurretKilledTime", NullValueHandling = NullValueHandling.Ignore)]
        public double? FirstTurretKilledTime { get; set; }

        [JsonProperty("highestChampionDamage", NullValueHandling = NullValueHandling.Ignore)]
        public long? HighestChampionDamage { get; set; }

        [JsonProperty("shortestTimeToAceFromFirstTakedown", NullValueHandling = NullValueHandling.Ignore)]
        public double? ShortestTimeToAceFromFirstTakedown { get; set; }
    }
}
