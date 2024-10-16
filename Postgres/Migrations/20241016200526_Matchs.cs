using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Postgres.Migrations
{
    /// <inheritdoc />
    public partial class Matchs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChampionStats",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AbilityHaste = table.Column<int>(type: "integer", nullable: false),
                    AbilityPower = table.Column<int>(type: "integer", nullable: false),
                    Armor = table.Column<int>(type: "integer", nullable: false),
                    ArmorPen = table.Column<int>(type: "integer", nullable: false),
                    ArmorPenPercent = table.Column<int>(type: "integer", nullable: false),
                    AttackDamage = table.Column<int>(type: "integer", nullable: false),
                    AttackSpeed = table.Column<int>(type: "integer", nullable: false),
                    BonusArmorPenPercent = table.Column<int>(type: "integer", nullable: false),
                    BonusMagicPenPercent = table.Column<int>(type: "integer", nullable: false),
                    CcReduction = table.Column<int>(type: "integer", nullable: false),
                    CooldownReduction = table.Column<int>(type: "integer", nullable: false),
                    Health = table.Column<int>(type: "integer", nullable: false),
                    HealthMax = table.Column<int>(type: "integer", nullable: false),
                    HealthRegen = table.Column<int>(type: "integer", nullable: false),
                    Lifesteal = table.Column<int>(type: "integer", nullable: false),
                    MagicPen = table.Column<int>(type: "integer", nullable: false),
                    MagicPenPercent = table.Column<int>(type: "integer", nullable: false),
                    MagicResist = table.Column<int>(type: "integer", nullable: false),
                    MovementSpeed = table.Column<int>(type: "integer", nullable: false),
                    Omnivamp = table.Column<int>(type: "integer", nullable: false),
                    PhysicalVamp = table.Column<int>(type: "integer", nullable: false),
                    Power = table.Column<int>(type: "integer", nullable: false),
                    PowerMax = table.Column<int>(type: "integer", nullable: false),
                    PowerRegen = table.Column<int>(type: "integer", nullable: false),
                    SpellVamp = table.Column<int>(type: "integer", nullable: false),
                    ParticipantId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DamageStats",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MagicDamageDone = table.Column<int>(type: "integer", nullable: false),
                    MagicDamageDoneToChampions = table.Column<int>(type: "integer", nullable: false),
                    MagicDamageTaken = table.Column<int>(type: "integer", nullable: false),
                    PhysicalDamageDone = table.Column<int>(type: "integer", nullable: false),
                    PhysicalDamageDoneToChampions = table.Column<int>(type: "integer", nullable: false),
                    PhysicalDamageTaken = table.Column<int>(type: "integer", nullable: false),
                    TotalDamageDone = table.Column<int>(type: "integer", nullable: false),
                    TotalDamageDoneToChampions = table.Column<int>(type: "integer", nullable: false),
                    TotalDamageTaken = table.Column<int>(type: "integer", nullable: false),
                    TrueDamageDone = table.Column<int>(type: "integer", nullable: false),
                    TrueDamageDoneToChampions = table.Column<int>(type: "integer", nullable: false),
                    TrueDamageTaken = table.Column<int>(type: "integer", nullable: false),
                    ParticipantId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Info",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EndOfGameResult = table.Column<string>(type: "text", nullable: true),
                    GameCreation = table.Column<long>(type: "bigint", nullable: false),
                    GameDuration = table.Column<long>(type: "bigint", nullable: false),
                    GameEndTimestamp = table.Column<long>(type: "bigint", nullable: false),
                    GameId = table.Column<long>(type: "bigint", nullable: false),
                    GameMode = table.Column<string>(type: "text", nullable: false),
                    GameName = table.Column<string>(type: "text", nullable: false),
                    GameStartTimestamp = table.Column<long>(type: "bigint", nullable: false),
                    GameType = table.Column<string>(type: "text", nullable: false),
                    GameVersion = table.Column<string>(type: "text", nullable: false),
                    MapId = table.Column<long>(type: "bigint", nullable: false),
                    PlatformId = table.Column<string>(type: "text", nullable: false),
                    QueueId = table.Column<long>(type: "bigint", nullable: false),
                    TournamentCode = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InfoTimeLine",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EndOfGameResult = table.Column<string>(type: "text", nullable: true),
                    FrameInterval = table.Column<long>(type: "bigint", nullable: false),
                    GameId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoTimeLine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Puuid = table.Column<string>(type: "text", nullable: false),
                    TimeLastMatchPlayed = table.Column<long>(type: "bigint", nullable: false),
                    FormatedDate = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => new { x.Puuid, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "MetadataInfoMatch",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataVersion = table.Column<long>(type: "bigint", nullable: false),
                    MatchId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetadataInfoMatch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetadataTimeLine",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataVersion = table.Column<long>(type: "bigint", nullable: false),
                    MatchId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetadataTimeLine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Summoners",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    AccountId = table.Column<string>(type: "text", nullable: false),
                    Puuid = table.Column<string>(type: "text", nullable: false),
                    ProfileIconId = table.Column<int>(type: "integer", nullable: false),
                    RevisionDate = table.Column<long>(type: "bigint", nullable: false),
                    SummonerLevel = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summoners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    ParticipantModelId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AllInPings = table.Column<long>(type: "bigint", nullable: false),
                    AssistMePings = table.Column<long>(type: "bigint", nullable: false),
                    Assists = table.Column<long>(type: "bigint", nullable: false),
                    BaronKills = table.Column<long>(type: "bigint", nullable: false),
                    BasicPings = table.Column<long>(type: "bigint", nullable: false),
                    BountyLevel = table.Column<long>(type: "bigint", nullable: false),
                    ChampExperience = table.Column<long>(type: "bigint", nullable: false),
                    ChampLevel = table.Column<long>(type: "bigint", nullable: false),
                    ChampionId = table.Column<long>(type: "bigint", nullable: false),
                    ChampionName = table.Column<string>(type: "text", nullable: false),
                    ChampionTransform = table.Column<long>(type: "bigint", nullable: false),
                    CommandPings = table.Column<long>(type: "bigint", nullable: false),
                    ConsumablesPurchased = table.Column<long>(type: "bigint", nullable: false),
                    DamageDealtToBuildings = table.Column<long>(type: "bigint", nullable: false),
                    DamageDealtToObjectives = table.Column<long>(type: "bigint", nullable: false),
                    DamageDealtToTurrets = table.Column<long>(type: "bigint", nullable: false),
                    DamageSelfMitigated = table.Column<long>(type: "bigint", nullable: false),
                    DangerPings = table.Column<long>(type: "bigint", nullable: false),
                    Deaths = table.Column<long>(type: "bigint", nullable: false),
                    DetectorWardsPlaced = table.Column<long>(type: "bigint", nullable: false),
                    DoubleKills = table.Column<long>(type: "bigint", nullable: false),
                    DragonKills = table.Column<long>(type: "bigint", nullable: false),
                    EligibleForProgression = table.Column<bool>(type: "boolean", nullable: false),
                    EnemyMissingPings = table.Column<long>(type: "bigint", nullable: false),
                    EnemyVisionPings = table.Column<long>(type: "bigint", nullable: false),
                    FirstBloodAssist = table.Column<bool>(type: "boolean", nullable: false),
                    FirstBloodKill = table.Column<bool>(type: "boolean", nullable: false),
                    FirstTowerAssist = table.Column<bool>(type: "boolean", nullable: false),
                    FirstTowerKill = table.Column<bool>(type: "boolean", nullable: false),
                    GameEndedInEarlySurrender = table.Column<bool>(type: "boolean", nullable: false),
                    GameEndedInSurrender = table.Column<bool>(type: "boolean", nullable: false),
                    GetBackPings = table.Column<long>(type: "bigint", nullable: false),
                    GoldEarned = table.Column<long>(type: "bigint", nullable: false),
                    GoldSpent = table.Column<long>(type: "bigint", nullable: false),
                    HoldPings = table.Column<long>(type: "bigint", nullable: false),
                    IndividualPosition = table.Column<string>(type: "text", nullable: false),
                    InhibitorKills = table.Column<long>(type: "bigint", nullable: false),
                    InhibitorTakedowns = table.Column<long>(type: "bigint", nullable: false),
                    InhibitorsLost = table.Column<long>(type: "bigint", nullable: false),
                    Item0 = table.Column<long>(type: "bigint", nullable: false),
                    Item1 = table.Column<long>(type: "bigint", nullable: false),
                    Item2 = table.Column<long>(type: "bigint", nullable: false),
                    Item3 = table.Column<long>(type: "bigint", nullable: false),
                    Item4 = table.Column<long>(type: "bigint", nullable: false),
                    Item5 = table.Column<long>(type: "bigint", nullable: false),
                    Item6 = table.Column<long>(type: "bigint", nullable: false),
                    ItemsPurchased = table.Column<long>(type: "bigint", nullable: false),
                    KillingSprees = table.Column<long>(type: "bigint", nullable: false),
                    Kills = table.Column<long>(type: "bigint", nullable: false),
                    Lane = table.Column<string>(type: "text", nullable: false),
                    LargestCriticalStrike = table.Column<long>(type: "bigint", nullable: false),
                    LargestKillingSpree = table.Column<long>(type: "bigint", nullable: false),
                    LargestMultiKill = table.Column<long>(type: "bigint", nullable: false),
                    LongestTimeSpentLiving = table.Column<long>(type: "bigint", nullable: false),
                    MagicDamageDealt = table.Column<long>(type: "bigint", nullable: false),
                    MagicDamageDealtToChampions = table.Column<long>(type: "bigint", nullable: false),
                    MagicDamageTaken = table.Column<long>(type: "bigint", nullable: false),
                    NeedVisionPings = table.Column<long>(type: "bigint", nullable: false),
                    NeutralMinionsKilled = table.Column<long>(type: "bigint", nullable: false),
                    NexusKills = table.Column<long>(type: "bigint", nullable: false),
                    NexusLost = table.Column<long>(type: "bigint", nullable: false),
                    NexusTakedowns = table.Column<long>(type: "bigint", nullable: false),
                    ObjectivesStolen = table.Column<long>(type: "bigint", nullable: false),
                    ObjectivesStolenAssists = table.Column<long>(type: "bigint", nullable: false),
                    OnMyWayPings = table.Column<long>(type: "bigint", nullable: false),
                    ParticipantId = table.Column<long>(type: "bigint", nullable: false),
                    PentaKills = table.Column<long>(type: "bigint", nullable: false),
                    PhysicalDamageDealt = table.Column<long>(type: "bigint", nullable: false),
                    PhysicalDamageDealtToChampions = table.Column<long>(type: "bigint", nullable: false),
                    PhysicalDamageTaken = table.Column<long>(type: "bigint", nullable: false),
                    Placement = table.Column<long>(type: "bigint", nullable: false),
                    PlayerAugment1 = table.Column<long>(type: "bigint", nullable: false),
                    PlayerAugment2 = table.Column<long>(type: "bigint", nullable: false),
                    PlayerAugment3 = table.Column<long>(type: "bigint", nullable: false),
                    PlayerAugment4 = table.Column<long>(type: "bigint", nullable: false),
                    PlayerAugment5 = table.Column<long>(type: "bigint", nullable: false),
                    PlayerAugment6 = table.Column<long>(type: "bigint", nullable: false),
                    PlayerSubteamId = table.Column<long>(type: "bigint", nullable: false),
                    ProfileIcon = table.Column<long>(type: "bigint", nullable: false),
                    PushPings = table.Column<long>(type: "bigint", nullable: false),
                    Puuid = table.Column<string>(type: "text", nullable: false),
                    QuadraKills = table.Column<long>(type: "bigint", nullable: false),
                    RiotIdGameName = table.Column<string>(type: "text", nullable: true),
                    RiotIdTagline = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<string>(type: "text", nullable: true),
                    SightWardsBoughtInGame = table.Column<long>(type: "bigint", nullable: false),
                    Spell1Casts = table.Column<long>(type: "bigint", nullable: false),
                    Spell2Casts = table.Column<long>(type: "bigint", nullable: false),
                    Spell3Casts = table.Column<long>(type: "bigint", nullable: false),
                    Spell4Casts = table.Column<long>(type: "bigint", nullable: false),
                    SubteamPlacement = table.Column<long>(type: "bigint", nullable: false),
                    Summoner1Casts = table.Column<long>(type: "bigint", nullable: false),
                    Summoner1Id = table.Column<long>(type: "bigint", nullable: false),
                    Summoner2Casts = table.Column<long>(type: "bigint", nullable: false),
                    Summoner2Id = table.Column<long>(type: "bigint", nullable: false),
                    SummonerId = table.Column<string>(type: "text", nullable: false),
                    SummonerLevel = table.Column<long>(type: "bigint", nullable: false),
                    SummonerName = table.Column<string>(type: "text", nullable: false),
                    TeamEarlySurrendered = table.Column<bool>(type: "boolean", nullable: false),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    TeamPosition = table.Column<string>(type: "text", nullable: false),
                    TimeCCingOthers = table.Column<long>(type: "bigint", nullable: false),
                    TimePlayed = table.Column<long>(type: "bigint", nullable: false),
                    TotalAllyJungleMinionsKilled = table.Column<long>(type: "bigint", nullable: false),
                    TotalDamageDealt = table.Column<long>(type: "bigint", nullable: false),
                    TotalDamageDealtToChampions = table.Column<long>(type: "bigint", nullable: false),
                    TotalDamageShieldedOnTeammates = table.Column<long>(type: "bigint", nullable: false),
                    TotalDamageTaken = table.Column<long>(type: "bigint", nullable: false),
                    TotalEnemyJungleMinionsKilled = table.Column<long>(type: "bigint", nullable: false),
                    TotalHeal = table.Column<long>(type: "bigint", nullable: false),
                    TotalHealsOnTeammates = table.Column<long>(type: "bigint", nullable: false),
                    TotalMinionsKilled = table.Column<long>(type: "bigint", nullable: false),
                    TotalTimeCcDealt = table.Column<long>(type: "bigint", nullable: false),
                    TotalTimeSpentDead = table.Column<long>(type: "bigint", nullable: false),
                    TotalUnitsHealed = table.Column<long>(type: "bigint", nullable: false),
                    TripleKills = table.Column<long>(type: "bigint", nullable: false),
                    TrueDamageDealt = table.Column<long>(type: "bigint", nullable: false),
                    TrueDamageDealtToChampions = table.Column<long>(type: "bigint", nullable: false),
                    TrueDamageTaken = table.Column<long>(type: "bigint", nullable: false),
                    TurretKills = table.Column<long>(type: "bigint", nullable: false),
                    TurretTakedowns = table.Column<long>(type: "bigint", nullable: false),
                    TurretsLost = table.Column<long>(type: "bigint", nullable: false),
                    UnrealKills = table.Column<long>(type: "bigint", nullable: false),
                    VisionClearedPings = table.Column<long>(type: "bigint", nullable: false),
                    VisionScore = table.Column<long>(type: "bigint", nullable: false),
                    VisionWardsBoughtInGame = table.Column<long>(type: "bigint", nullable: false),
                    WardsKilled = table.Column<long>(type: "bigint", nullable: false),
                    WardsPlaced = table.Column<long>(type: "bigint", nullable: false),
                    Win = table.Column<bool>(type: "boolean", nullable: false),
                    InfoId = table.Column<long>(type: "bigint", nullable: false),
                    InfoModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.ParticipantModelId);
                    table.ForeignKey(
                        name: "FK_Participants_Info_InfoModelId",
                        column: x => x.InfoModelId,
                        principalTable: "Info",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Win = table.Column<bool>(type: "boolean", nullable: false),
                    TeamId = table.Column<int>(type: "integer", nullable: false),
                    InfoId = table.Column<long>(type: "bigint", nullable: false),
                    InfoModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Info_InfoModelId",
                        column: x => x.InfoModelId,
                        principalTable: "Info",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Frame",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<long>(type: "bigint", nullable: false),
                    InfoTimeLineModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Frame_InfoTimeLine_InfoTimeLineModelId",
                        column: x => x.InfoTimeLineModelId,
                        principalTable: "InfoTimeLine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantTimeLine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParticipantId = table.Column<int>(type: "integer", nullable: false),
                    Puuid = table.Column<string>(type: "text", nullable: false),
                    InfoTimeLineModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantTimeLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParticipantTimeLine_InfoTimeLine_InfoTimeLineModelId",
                        column: x => x.InfoTimeLineModelId,
                        principalTable: "InfoTimeLine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InfoMatches",
                columns: table => new
                {
                    Puuid = table.Column<string>(type: "text", nullable: false),
                    MatchId = table.Column<string>(type: "text", nullable: false),
                    MetadataId = table.Column<long>(type: "bigint", nullable: false),
                    InfoId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoMatches", x => new { x.MatchId, x.Puuid });
                    table.ForeignKey(
                        name: "FK_InfoMatches_Info_InfoId",
                        column: x => x.InfoId,
                        principalTable: "Info",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InfoMatches_MetadataInfoMatch_MetadataId",
                        column: x => x.MetadataId,
                        principalTable: "MetadataInfoMatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantsId",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParticipantsPuuid = table.Column<string>(type: "text", nullable: false),
                    MetadataModelInfoMatchModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantsId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParticipantsId_MetadataInfoMatch_MetadataModelInfoMatchMode~",
                        column: x => x.MetadataModelInfoMatchModelId,
                        principalTable: "MetadataInfoMatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InfoMatchTimeLines",
                columns: table => new
                {
                    Puuid = table.Column<string>(type: "text", nullable: false),
                    MatchId = table.Column<string>(type: "text", nullable: false),
                    MetadataModelId = table.Column<long>(type: "bigint", nullable: false),
                    InfoTimeLineModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoMatchTimeLines", x => new { x.MatchId, x.Puuid });
                    table.ForeignKey(
                        name: "FK_InfoMatchTimeLines_InfoTimeLine_InfoTimeLineModelId",
                        column: x => x.InfoTimeLineModelId,
                        principalTable: "InfoTimeLine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InfoMatchTimeLines_MetadataTimeLine_MetadataModelId",
                        column: x => x.MetadataModelId,
                        principalTable: "MetadataTimeLine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Challenges",
                columns: table => new
                {
                    ChallengesModelId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    The12AssistStreakCount = table.Column<long>(type: "bigint", nullable: false),
                    InfernalScalePickup = table.Column<long>(type: "bigint", nullable: false),
                    SwarmDefeatAatrox = table.Column<long>(type: "bigint", nullable: false),
                    SwarmDefeatBriar = table.Column<long>(type: "bigint", nullable: false),
                    SwarmDefeatMiniBosses = table.Column<long>(type: "bigint", nullable: false),
                    SwarmEvolveWeapon = table.Column<long>(type: "bigint", nullable: false),
                    SwarmHave3Passives = table.Column<long>(type: "bigint", nullable: false),
                    SwarmKillEnemy = table.Column<long>(type: "bigint", nullable: false),
                    SwarmPickupGold = table.Column<long>(type: "bigint", nullable: false),
                    SwarmReachLevel50 = table.Column<long>(type: "bigint", nullable: false),
                    SwarmSurvive15Min = table.Column<long>(type: "bigint", nullable: false),
                    SwarmWinWith5EvolvedWeapons = table.Column<long>(type: "bigint", nullable: false),
                    AbilityUses = table.Column<long>(type: "bigint", nullable: false),
                    AcesBefore15Minutes = table.Column<long>(type: "bigint", nullable: false),
                    AlliedJungleMonsterKills = table.Column<long>(type: "bigint", nullable: false),
                    BaronTakedowns = table.Column<long>(type: "bigint", nullable: false),
                    BlastConeOppositeOpponentCount = table.Column<long>(type: "bigint", nullable: false),
                    BountyGold = table.Column<long>(type: "bigint", nullable: false),
                    BuffsStolen = table.Column<long>(type: "bigint", nullable: false),
                    CompleteSupportQuestInTime = table.Column<long>(type: "bigint", nullable: false),
                    ControlWardsPlaced = table.Column<long>(type: "bigint", nullable: false),
                    DamagePerMinute = table.Column<double>(type: "double precision", nullable: false),
                    DamageTakenOnTeamPercentage = table.Column<double>(type: "double precision", nullable: false),
                    DancedWithRiftHerald = table.Column<long>(type: "bigint", nullable: false),
                    DeathsByEnemyChamps = table.Column<long>(type: "bigint", nullable: false),
                    DodgeSkillShotsSmallWindow = table.Column<long>(type: "bigint", nullable: false),
                    DoubleAces = table.Column<long>(type: "bigint", nullable: false),
                    DragonTakedowns = table.Column<long>(type: "bigint", nullable: false),
                    EffectiveHealAndShielding = table.Column<double>(type: "double precision", nullable: false),
                    ElderDragonKillsWithOpposingSoul = table.Column<long>(type: "bigint", nullable: false),
                    ElderDragonMultikills = table.Column<long>(type: "bigint", nullable: false),
                    EnemyChampionImmobilizations = table.Column<long>(type: "bigint", nullable: false),
                    EnemyJungleMonsterKills = table.Column<long>(type: "bigint", nullable: false),
                    EpicMonsterKillsNearEnemyJungler = table.Column<long>(type: "bigint", nullable: false),
                    EpicMonsterKillsWithin30SecondsOfSpawn = table.Column<long>(type: "bigint", nullable: false),
                    EpicMonsterSteals = table.Column<long>(type: "bigint", nullable: false),
                    EpicMonsterStolenWithoutSmite = table.Column<long>(type: "bigint", nullable: false),
                    FirstTurretKilled = table.Column<long>(type: "bigint", nullable: false),
                    FistBumpParticipation = table.Column<long>(type: "bigint", nullable: false),
                    FlawlessAces = table.Column<long>(type: "bigint", nullable: false),
                    FullTeamTakedown = table.Column<long>(type: "bigint", nullable: false),
                    GameLength = table.Column<double>(type: "double precision", nullable: false),
                    GetTakedownsInAllLanesEarlyJungleAsLaner = table.Column<long>(type: "bigint", nullable: false),
                    GoldPerMinute = table.Column<double>(type: "double precision", nullable: false),
                    HadOpenNexus = table.Column<long>(type: "bigint", nullable: false),
                    ImmobilizeAndKillWithAlly = table.Column<long>(type: "bigint", nullable: false),
                    InitialBuffCount = table.Column<long>(type: "bigint", nullable: false),
                    InitialCrabCount = table.Column<long>(type: "bigint", nullable: false),
                    JungleCsBefore10Minutes = table.Column<long>(type: "bigint", nullable: false),
                    JunglerTakedownsNearDamagedEpicMonster = table.Column<long>(type: "bigint", nullable: false),
                    KTurretsDestroyedBeforePlatesFall = table.Column<long>(type: "bigint", nullable: false),
                    Kda = table.Column<double>(type: "double precision", nullable: false),
                    KillAfterHiddenWithAlly = table.Column<long>(type: "bigint", nullable: false),
                    KillParticipation = table.Column<double>(type: "double precision", nullable: false),
                    KilledChampTookFullTeamDamageSurvived = table.Column<long>(type: "bigint", nullable: false),
                    KillingSprees = table.Column<long>(type: "bigint", nullable: false),
                    KillsNearEnemyTurret = table.Column<long>(type: "bigint", nullable: false),
                    KillsOnOtherLanesEarlyJungleAsLaner = table.Column<long>(type: "bigint", nullable: false),
                    KillsOnRecentlyHealedByAramPack = table.Column<long>(type: "bigint", nullable: false),
                    KillsUnderOwnTurret = table.Column<long>(type: "bigint", nullable: false),
                    KillsWithHelpFromEpicMonster = table.Column<long>(type: "bigint", nullable: false),
                    KnockEnemyIntoTeamAndKill = table.Column<long>(type: "bigint", nullable: false),
                    LandSkillShotsEarlyGame = table.Column<long>(type: "bigint", nullable: false),
                    LaneMinionsFirst10Minutes = table.Column<long>(type: "bigint", nullable: false),
                    LegendaryCount = table.Column<long>(type: "bigint", nullable: false),
                    LostAnInhibitor = table.Column<long>(type: "bigint", nullable: false),
                    MaxKillDeficit = table.Column<long>(type: "bigint", nullable: false),
                    MejaisFullStackInTime = table.Column<long>(type: "bigint", nullable: false),
                    MoreEnemyJungleThanOpponent = table.Column<long>(type: "bigint", nullable: false),
                    MultiKillOneSpell = table.Column<long>(type: "bigint", nullable: false),
                    MultiTurretRiftHeraldCount = table.Column<long>(type: "bigint", nullable: false),
                    Multikills = table.Column<long>(type: "bigint", nullable: false),
                    MultikillsAfterAggressiveFlash = table.Column<long>(type: "bigint", nullable: false),
                    OuterTurretExecutesBefore10Minutes = table.Column<long>(type: "bigint", nullable: false),
                    OutnumberedKills = table.Column<long>(type: "bigint", nullable: false),
                    OutnumberedNexusKill = table.Column<long>(type: "bigint", nullable: false),
                    PerfectDragonSoulsTaken = table.Column<long>(type: "bigint", nullable: false),
                    PerfectGame = table.Column<long>(type: "bigint", nullable: false),
                    PickKillWithAlly = table.Column<long>(type: "bigint", nullable: false),
                    PoroExplosions = table.Column<long>(type: "bigint", nullable: false),
                    QuickCleanse = table.Column<long>(type: "bigint", nullable: false),
                    QuickFirstTurret = table.Column<long>(type: "bigint", nullable: false),
                    QuickSoloKills = table.Column<long>(type: "bigint", nullable: false),
                    RiftHeraldTakedowns = table.Column<long>(type: "bigint", nullable: false),
                    SaveAllyFromDeath = table.Column<long>(type: "bigint", nullable: false),
                    ScuttleCrabKills = table.Column<long>(type: "bigint", nullable: false),
                    SkillshotsDodged = table.Column<long>(type: "bigint", nullable: false),
                    SkillshotsHit = table.Column<long>(type: "bigint", nullable: false),
                    SnowballsHit = table.Column<long>(type: "bigint", nullable: false),
                    SoloBaronKills = table.Column<long>(type: "bigint", nullable: false),
                    SoloKills = table.Column<long>(type: "bigint", nullable: false),
                    StealthWardsPlaced = table.Column<long>(type: "bigint", nullable: false),
                    SurvivedSingleDigitHpCount = table.Column<long>(type: "bigint", nullable: false),
                    SurvivedThreeImmobilizesInFight = table.Column<long>(type: "bigint", nullable: false),
                    TakedownOnFirstTurret = table.Column<long>(type: "bigint", nullable: false),
                    Takedowns = table.Column<long>(type: "bigint", nullable: false),
                    TakedownsAfterGainingLevelAdvantage = table.Column<long>(type: "bigint", nullable: false),
                    TakedownsBeforeJungleMinionSpawn = table.Column<long>(type: "bigint", nullable: false),
                    TakedownsFirstXMinutes = table.Column<long>(type: "bigint", nullable: false),
                    TakedownsInAlcove = table.Column<long>(type: "bigint", nullable: false),
                    TakedownsInEnemyFountain = table.Column<long>(type: "bigint", nullable: false),
                    TeamBaronKills = table.Column<long>(type: "bigint", nullable: false),
                    TeamDamagePercentage = table.Column<double>(type: "double precision", nullable: false),
                    TeamElderDragonKills = table.Column<long>(type: "bigint", nullable: false),
                    TeamRiftHeraldKills = table.Column<long>(type: "bigint", nullable: false),
                    TookLargeDamageSurvived = table.Column<long>(type: "bigint", nullable: false),
                    TurretPlatesTaken = table.Column<long>(type: "bigint", nullable: false),
                    TurretTakedowns = table.Column<long>(type: "bigint", nullable: false),
                    TurretsTakenWithRiftHerald = table.Column<long>(type: "bigint", nullable: false),
                    TwentyMinionsIn3SecondsCount = table.Column<long>(type: "bigint", nullable: false),
                    TwoWardsOneSweeperCount = table.Column<long>(type: "bigint", nullable: false),
                    UnseenRecalls = table.Column<long>(type: "bigint", nullable: false),
                    VisionScorePerMinute = table.Column<double>(type: "double precision", nullable: false),
                    VoidMonsterKill = table.Column<long>(type: "bigint", nullable: false),
                    WardTakedowns = table.Column<long>(type: "bigint", nullable: false),
                    WardTakedownsBefore20M = table.Column<long>(type: "bigint", nullable: false),
                    WardsGuarded = table.Column<long>(type: "bigint", nullable: false),
                    HighestCrowdControlScore = table.Column<long>(type: "bigint", nullable: true),
                    FirstTurretKilledTime = table.Column<double>(type: "double precision", nullable: true),
                    HighestChampionDamage = table.Column<long>(type: "bigint", nullable: true),
                    ShortestTimeToAceFromFirstTakedown = table.Column<double>(type: "double precision", nullable: true),
                    ParticipantModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.ChallengesModelId);
                    table.ForeignKey(
                        name: "FK_Challenges_Participants_ParticipantModelId",
                        column: x => x.ParticipantModelId,
                        principalTable: "Participants",
                        principalColumn: "ParticipantModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Perks",
                columns: table => new
                {
                    PerksModelId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParticipantModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perks", x => x.PerksModelId);
                    table.ForeignKey(
                        name: "FK_Perks_Participants_ParticipantModelId",
                        column: x => x.ParticipantModelId,
                        principalTable: "Participants",
                        principalColumn: "ParticipantModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChampionBaned",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ChampionId = table.Column<long>(type: "bigint", nullable: false),
                    PickTurn = table.Column<long>(type: "bigint", nullable: false),
                    TeamId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionBaned", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChampionBaned_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Objectives",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TeamId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objectives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Objectives_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RealTimestamp = table.Column<long>(type: "bigint", nullable: true),
                    Timestamp = table.Column<long>(type: "bigint", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true),
                    LevelUpType = table.Column<string>(type: "text", nullable: true),
                    ParticipantId = table.Column<long>(type: "bigint", nullable: true),
                    SkillSlot = table.Column<long>(type: "bigint", nullable: true),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    CreatorId = table.Column<long>(type: "bigint", nullable: true),
                    WardType = table.Column<string>(type: "text", nullable: true),
                    Bounty = table.Column<long>(type: "bigint", nullable: true),
                    KillStreakLength = table.Column<long>(type: "bigint", nullable: true),
                    KillerId = table.Column<long>(type: "bigint", nullable: true),
                    ShutdownBounty = table.Column<long>(type: "bigint", nullable: true),
                    VictimId = table.Column<long>(type: "bigint", nullable: true),
                    KillType = table.Column<string>(type: "text", nullable: true),
                    MultiKillLength = table.Column<long>(type: "bigint", nullable: true),
                    Level = table.Column<long>(type: "bigint", nullable: true),
                    LaneType = table.Column<string>(type: "text", nullable: true),
                    TeamId = table.Column<long>(type: "bigint", nullable: true),
                    KillerTeamId = table.Column<long>(type: "bigint", nullable: true),
                    MonsterType = table.Column<string>(type: "text", nullable: true),
                    AfterId = table.Column<long>(type: "bigint", nullable: true),
                    BeforeId = table.Column<long>(type: "bigint", nullable: true),
                    GoldGain = table.Column<long>(type: "bigint", nullable: true),
                    BuildingType = table.Column<string>(type: "text", nullable: true),
                    TowerType = table.Column<string>(type: "text", nullable: true),
                    MonsterSubType = table.Column<string>(type: "text", nullable: true),
                    ActualStartTime = table.Column<long>(type: "bigint", nullable: true),
                    GameId = table.Column<long>(type: "bigint", nullable: true),
                    WinningTeam = table.Column<long>(type: "bigint", nullable: true),
                    FrameModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Event_Frame_FrameModelId",
                        column: x => x.FrameModelId,
                        principalTable: "Frame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantFrame",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdParticipantFrame = table.Column<long>(type: "bigint", nullable: false),
                    CurrentGold = table.Column<long>(type: "bigint", nullable: false),
                    GoldPerSecond = table.Column<long>(type: "bigint", nullable: false),
                    JungleMinionsKilled = table.Column<long>(type: "bigint", nullable: false),
                    Level = table.Column<long>(type: "bigint", nullable: false),
                    MinionsKilled = table.Column<long>(type: "bigint", nullable: false),
                    ParticipantId = table.Column<long>(type: "bigint", nullable: false),
                    DamageStatsId = table.Column<long>(type: "bigint", nullable: false),
                    ChampionStatsId = table.Column<long>(type: "bigint", nullable: false),
                    PositionParticipantModelId = table.Column<long>(type: "bigint", nullable: false),
                    TimeEnemySpentControlled = table.Column<long>(type: "bigint", nullable: false),
                    TotalGold = table.Column<long>(type: "bigint", nullable: false),
                    Xp = table.Column<long>(type: "bigint", nullable: false),
                    FrameModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantFrame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParticipantFrame_ChampionStats_ChampionStatsId",
                        column: x => x.ChampionStatsId,
                        principalTable: "ChampionStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParticipantFrame_DamageStats_DamageStatsId",
                        column: x => x.DamageStatsId,
                        principalTable: "DamageStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParticipantFrame_Frame_FrameModelId",
                        column: x => x.FrameModelId,
                        principalTable: "Frame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LegendaryItemUsed",
                columns: table => new
                {
                    LegendaryItemUsedModelId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LegendaryItemId = table.Column<long>(type: "bigint", nullable: false),
                    ChallengesModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegendaryItemUsed", x => x.LegendaryItemUsedModelId);
                    table.ForeignKey(
                        name: "FK_LegendaryItemUsed_Challenges_ChallengesModelId",
                        column: x => x.ChallengesModelId,
                        principalTable: "Challenges",
                        principalColumn: "ChallengesModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatPerks",
                columns: table => new
                {
                    StatPerksModelId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Defense = table.Column<long>(type: "bigint", nullable: false),
                    Flex = table.Column<long>(type: "bigint", nullable: false),
                    Offense = table.Column<long>(type: "bigint", nullable: false),
                    PerksModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatPerks", x => x.StatPerksModelId);
                    table.ForeignKey(
                        name: "FK_StatPerks_Perks_PerksModelId",
                        column: x => x.PerksModelId,
                        principalTable: "Perks",
                        principalColumn: "PerksModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Style",
                columns: table => new
                {
                    StyleModelId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    StyleStyle = table.Column<long>(type: "bigint", nullable: false),
                    PerksModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Style", x => x.StyleModelId);
                    table.ForeignKey(
                        name: "FK_Style_Perks_PerksModelId",
                        column: x => x.PerksModelId,
                        principalTable: "Perks",
                        principalColumn: "PerksModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Baron",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    First = table.Column<bool>(type: "boolean", nullable: false),
                    Kills = table.Column<long>(type: "bigint", nullable: false),
                    ObjectivesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baron", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baron_Objectives_ObjectivesId",
                        column: x => x.ObjectivesId,
                        principalTable: "Objectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Champion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    First = table.Column<bool>(type: "boolean", nullable: false),
                    Kills = table.Column<long>(type: "bigint", nullable: false),
                    ObjectivesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Champion_Objectives_ObjectivesId",
                        column: x => x.ObjectivesId,
                        principalTable: "Objectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dragon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    First = table.Column<bool>(type: "boolean", nullable: false),
                    Kills = table.Column<long>(type: "bigint", nullable: false),
                    ObjectivesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dragon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dragon_Objectives_ObjectivesId",
                        column: x => x.ObjectivesId,
                        principalTable: "Objectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Horde",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    First = table.Column<bool>(type: "boolean", nullable: false),
                    Kills = table.Column<long>(type: "bigint", nullable: false),
                    ObjectivesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horde", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Horde_Objectives_ObjectivesId",
                        column: x => x.ObjectivesId,
                        principalTable: "Objectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inhibitor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    First = table.Column<bool>(type: "boolean", nullable: false),
                    Kills = table.Column<long>(type: "bigint", nullable: false),
                    ObjectivesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inhibitor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inhibitor_Objectives_ObjectivesId",
                        column: x => x.ObjectivesId,
                        principalTable: "Objectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RiftHerald",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    First = table.Column<bool>(type: "boolean", nullable: false),
                    Kills = table.Column<long>(type: "bigint", nullable: false),
                    ObjectivesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiftHerald", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiftHerald_Objectives_ObjectivesId",
                        column: x => x.ObjectivesId,
                        principalTable: "Objectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tower",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    First = table.Column<bool>(type: "boolean", nullable: false),
                    Kills = table.Column<long>(type: "bigint", nullable: false),
                    ObjectivesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tower", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tower_Objectives_ObjectivesId",
                        column: x => x.ObjectivesId,
                        principalTable: "Objectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssistingParticipantIds",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AssistingParticipantId = table.Column<long>(type: "bigint", nullable: false),
                    EventModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssistingParticipantIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssistingParticipantIds_Event_EventModelId",
                        column: x => x.EventModelId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PositionEvent",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    X = table.Column<long>(type: "bigint", nullable: false),
                    Y = table.Column<long>(type: "bigint", nullable: false),
                    EventModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PositionEvent_Event_EventModelId",
                        column: x => x.EventModelId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VictimDamageDealt",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Basic = table.Column<bool>(type: "boolean", nullable: false),
                    MagicDamage = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ParticipantId = table.Column<long>(type: "bigint", nullable: false),
                    PhysicalDamage = table.Column<long>(type: "bigint", nullable: false),
                    SpellName = table.Column<string>(type: "text", nullable: false),
                    SpellSlot = table.Column<long>(type: "bigint", nullable: false),
                    TrueDamage = table.Column<long>(type: "bigint", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    EventModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VictimDamageDealt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VictimDamageDealt_Event_EventModelId",
                        column: x => x.EventModelId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VictimDamageReceived",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Basic = table.Column<bool>(type: "boolean", nullable: false),
                    MagicDamage = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ParticipantId = table.Column<long>(type: "bigint", nullable: false),
                    PhysicalDamage = table.Column<long>(type: "bigint", nullable: false),
                    SpellName = table.Column<string>(type: "text", nullable: false),
                    SpellSlot = table.Column<long>(type: "bigint", nullable: false),
                    TrueDamage = table.Column<long>(type: "bigint", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    EventModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VictimDamageReceived", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VictimDamageReceived_Event_EventModelId",
                        column: x => x.EventModelId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PositionParticipant",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    X = table.Column<long>(type: "bigint", nullable: false),
                    Y = table.Column<long>(type: "bigint", nullable: false),
                    ParticipantFrameModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionParticipant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PositionParticipant_ParticipantFrame_ParticipantFrameModelId",
                        column: x => x.ParticipantFrameModelId,
                        principalTable: "ParticipantFrame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Selection",
                columns: table => new
                {
                    SelectionModelId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Perk = table.Column<long>(type: "bigint", nullable: false),
                    Var1 = table.Column<long>(type: "bigint", nullable: false),
                    Var2 = table.Column<long>(type: "bigint", nullable: false),
                    Var3 = table.Column<long>(type: "bigint", nullable: false),
                    StyleModelId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Selection", x => x.SelectionModelId);
                    table.ForeignKey(
                        name: "FK_Selection_Style_StyleModelId",
                        column: x => x.StyleModelId,
                        principalTable: "Style",
                        principalColumn: "StyleModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssistingParticipantIds_EventModelId",
                table: "AssistingParticipantIds",
                column: "EventModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Baron_ObjectivesId",
                table: "Baron",
                column: "ObjectivesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_ParticipantModelId",
                table: "Challenges",
                column: "ParticipantModelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Champion_ObjectivesId",
                table: "Champion",
                column: "ObjectivesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChampionBaned_TeamId",
                table: "ChampionBaned",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Dragon_ObjectivesId",
                table: "Dragon",
                column: "ObjectivesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Event_FrameModelId",
                table: "Event",
                column: "FrameModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Frame_InfoTimeLineModelId",
                table: "Frame",
                column: "InfoTimeLineModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Horde_ObjectivesId",
                table: "Horde",
                column: "ObjectivesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InfoMatches_InfoId",
                table: "InfoMatches",
                column: "InfoId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoMatches_MetadataId",
                table: "InfoMatches",
                column: "MetadataId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoMatchTimeLines_InfoTimeLineModelId",
                table: "InfoMatchTimeLines",
                column: "InfoTimeLineModelId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoMatchTimeLines_MetadataModelId",
                table: "InfoMatchTimeLines",
                column: "MetadataModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Inhibitor_ObjectivesId",
                table: "Inhibitor",
                column: "ObjectivesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LegendaryItemUsed_ChallengesModelId",
                table: "LegendaryItemUsed",
                column: "ChallengesModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_TeamId",
                table: "Objectives",
                column: "TeamId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantFrame_ChampionStatsId",
                table: "ParticipantFrame",
                column: "ChampionStatsId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantFrame_DamageStatsId",
                table: "ParticipantFrame",
                column: "DamageStatsId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantFrame_FrameModelId",
                table: "ParticipantFrame",
                column: "FrameModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_InfoModelId",
                table: "Participants",
                column: "InfoModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantsId_MetadataModelInfoMatchModelId",
                table: "ParticipantsId",
                column: "MetadataModelInfoMatchModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantTimeLine_InfoTimeLineModelId",
                table: "ParticipantTimeLine",
                column: "InfoTimeLineModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Perks_ParticipantModelId",
                table: "Perks",
                column: "ParticipantModelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PositionEvent_EventModelId",
                table: "PositionEvent",
                column: "EventModelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PositionParticipant_ParticipantFrameModelId",
                table: "PositionParticipant",
                column: "ParticipantFrameModelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RiftHerald_ObjectivesId",
                table: "RiftHerald",
                column: "ObjectivesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Selection_StyleModelId",
                table: "Selection",
                column: "StyleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_StatPerks_PerksModelId",
                table: "StatPerks",
                column: "PerksModelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Style_PerksModelId",
                table: "Style",
                column: "PerksModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_InfoModelId",
                table: "Teams",
                column: "InfoModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Tower_ObjectivesId",
                table: "Tower",
                column: "ObjectivesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VictimDamageDealt_EventModelId",
                table: "VictimDamageDealt",
                column: "EventModelId");

            migrationBuilder.CreateIndex(
                name: "IX_VictimDamageReceived_EventModelId",
                table: "VictimDamageReceived",
                column: "EventModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssistingParticipantIds");

            migrationBuilder.DropTable(
                name: "Baron");

            migrationBuilder.DropTable(
                name: "Champion");

            migrationBuilder.DropTable(
                name: "ChampionBaned");

            migrationBuilder.DropTable(
                name: "Dragon");

            migrationBuilder.DropTable(
                name: "Horde");

            migrationBuilder.DropTable(
                name: "InfoMatches");

            migrationBuilder.DropTable(
                name: "InfoMatchTimeLines");

            migrationBuilder.DropTable(
                name: "Inhibitor");

            migrationBuilder.DropTable(
                name: "LegendaryItemUsed");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "ParticipantsId");

            migrationBuilder.DropTable(
                name: "ParticipantTimeLine");

            migrationBuilder.DropTable(
                name: "PositionEvent");

            migrationBuilder.DropTable(
                name: "PositionParticipant");

            migrationBuilder.DropTable(
                name: "RiftHerald");

            migrationBuilder.DropTable(
                name: "Selection");

            migrationBuilder.DropTable(
                name: "StatPerks");

            migrationBuilder.DropTable(
                name: "Summoners");

            migrationBuilder.DropTable(
                name: "Tower");

            migrationBuilder.DropTable(
                name: "VictimDamageDealt");

            migrationBuilder.DropTable(
                name: "VictimDamageReceived");

            migrationBuilder.DropTable(
                name: "MetadataTimeLine");

            migrationBuilder.DropTable(
                name: "Challenges");

            migrationBuilder.DropTable(
                name: "MetadataInfoMatch");

            migrationBuilder.DropTable(
                name: "ParticipantFrame");

            migrationBuilder.DropTable(
                name: "Style");

            migrationBuilder.DropTable(
                name: "Objectives");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "ChampionStats");

            migrationBuilder.DropTable(
                name: "DamageStats");

            migrationBuilder.DropTable(
                name: "Perks");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Frame");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "InfoTimeLine");

            migrationBuilder.DropTable(
                name: "Info");
        }
    }
}
