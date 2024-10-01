using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Globalization;

namespace Core.Application.Enum
{
    public enum BuildingType { InhibitorBuilding, TowerBuilding };

    public enum KillType { KillAce, KillFirstBlood, KillMulti };

    public enum LaneType { BotLane, MidLane, TopLane };

    public enum LevelUpType { Normal };

    public enum MonsterType { BaronNashor, Dragon, Horde };

    public enum EventType { BuildingKill, ChampionKill, ChampionSpecialKill, EliteMonsterKill, GameEnd, ItemDestroyed, ItemPurchased, ItemSold, ItemUndo, LevelUp, ObjectiveBountyFinish, ObjectiveBountyPrestart, PauseEnd, SkillLevelUp, TurretPlateDestroyed, WardKill, WardPlaced };

    public enum Name { Anivia, Blitzcrank, Briar, Caitlyn, Darius, JarvanIv, Jax, Kayle, MonkeyKing, SruChaosMinionMelee, SruChaosMinionRanged, SruOrderMinionMelee, SruOrderMinionRanged, SruOrderMinionSiege, SruRazorbeak, SruRazorbeakMini, Turret, TwistedFate };

    public enum VictimDamageDealtType { Minion, Monster, Other, Tower };

    public enum WardType { YellowTrinket };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                BuildingTypeConverter.Singleton,
                KillTypeConverter.Singleton,
                LaneTypeConverter.Singleton,
                LevelUpTypeConverter.Singleton,
                MonsterTypeConverter.Singleton,
                EventTypeConverter.Singleton,
                NameConverter.Singleton,
                VictimDamageDealtTypeConverter.Singleton,
                WardTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class BuildingTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BuildingType) || t == typeof(BuildingType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "INHIBITOR_BUILDING":
                    return BuildingType.InhibitorBuilding;
                case "TOWER_BUILDING":
                    return BuildingType.TowerBuilding;
            }
            throw new Exception("Cannot unmarshal type BuildingType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BuildingType)untypedValue;
            switch (value)
            {
                case BuildingType.InhibitorBuilding:
                    serializer.Serialize(writer, "INHIBITOR_BUILDING");
                    return;
                case BuildingType.TowerBuilding:
                    serializer.Serialize(writer, "TOWER_BUILDING");
                    return;
            }
            throw new Exception("Cannot marshal type BuildingType");
        }

        public static readonly BuildingTypeConverter Singleton = new BuildingTypeConverter();
    }

    internal class KillTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(KillType) || t == typeof(KillType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "KILL_ACE":
                    return KillType.KillAce;
                case "KILL_FIRST_BLOOD":
                    return KillType.KillFirstBlood;
                case "KILL_MULTI":
                    return KillType.KillMulti;
            }
            throw new Exception("Cannot unmarshal type KillType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (KillType)untypedValue;
            switch (value)
            {
                case KillType.KillAce:
                    serializer.Serialize(writer, "KILL_ACE");
                    return;
                case KillType.KillFirstBlood:
                    serializer.Serialize(writer, "KILL_FIRST_BLOOD");
                    return;
                case KillType.KillMulti:
                    serializer.Serialize(writer, "KILL_MULTI");
                    return;
            }
            throw new Exception("Cannot marshal type KillType");
        }

        public static readonly KillTypeConverter Singleton = new KillTypeConverter();
    }

    internal class LaneTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LaneType) || t == typeof(LaneType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "BOT_LANE":
                    return LaneType.BotLane;
                case "MID_LANE":
                    return LaneType.MidLane;
                case "TOP_LANE":
                    return LaneType.TopLane;
            }
            throw new Exception("Cannot unmarshal type LaneType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LaneType)untypedValue;
            switch (value)
            {
                case LaneType.BotLane:
                    serializer.Serialize(writer, "BOT_LANE");
                    return;
                case LaneType.MidLane:
                    serializer.Serialize(writer, "MID_LANE");
                    return;
                case LaneType.TopLane:
                    serializer.Serialize(writer, "TOP_LANE");
                    return;
            }
            throw new Exception("Cannot marshal type LaneType");
        }

        public static readonly LaneTypeConverter Singleton = new LaneTypeConverter();
    }

    internal class LevelUpTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LevelUpType) || t == typeof(LevelUpType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "NORMAL")
            {
                return LevelUpType.Normal;
            }
            throw new Exception("Cannot unmarshal type LevelUpType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LevelUpType)untypedValue;
            if (value == LevelUpType.Normal)
            {
                serializer.Serialize(writer, "NORMAL");
                return;
            }
            throw new Exception("Cannot marshal type LevelUpType");
        }

        public static readonly LevelUpTypeConverter Singleton = new LevelUpTypeConverter();
    }

    internal class MonsterTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MonsterType) || t == typeof(MonsterType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "BARON_NASHOR":
                    return MonsterType.BaronNashor;
                case "DRAGON":
                    return MonsterType.Dragon;
                case "HORDE":
                    return MonsterType.Horde;
            }
            throw new Exception("Cannot unmarshal type MonsterType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MonsterType)untypedValue;
            switch (value)
            {
                case MonsterType.BaronNashor:
                    serializer.Serialize(writer, "BARON_NASHOR");
                    return;
                case MonsterType.Dragon:
                    serializer.Serialize(writer, "DRAGON");
                    return;
                case MonsterType.Horde:
                    serializer.Serialize(writer, "HORDE");
                    return;
            }
            throw new Exception("Cannot marshal type MonsterType");
        }

        public static readonly MonsterTypeConverter Singleton = new MonsterTypeConverter();
    }

    internal class EventTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EventType) || t == typeof(EventType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "BUILDING_KILL":
                    return EventType.BuildingKill;
                case "CHAMPION_KILL":
                    return EventType.ChampionKill;
                case "CHAMPION_SPECIAL_KILL":
                    return EventType.ChampionSpecialKill;
                case "ELITE_MONSTER_KILL":
                    return EventType.EliteMonsterKill;
                case "GAME_END":
                    return EventType.GameEnd;
                case "ITEM_DESTROYED":
                    return EventType.ItemDestroyed;
                case "ITEM_PURCHASED":
                    return EventType.ItemPurchased;
                case "ITEM_SOLD":
                    return EventType.ItemSold;
                case "ITEM_UNDO":
                    return EventType.ItemUndo;
                case "LEVEL_UP":
                    return EventType.LevelUp;
                case "OBJECTIVE_BOUNTY_FINISH":
                    return EventType.ObjectiveBountyFinish;
                case "OBJECTIVE_BOUNTY_PRESTART":
                    return EventType.ObjectiveBountyPrestart;
                case "PAUSE_END":
                    return EventType.PauseEnd;
                case "SKILL_LEVEL_UP":
                    return EventType.SkillLevelUp;
                case "TURRET_PLATE_DESTROYED":
                    return EventType.TurretPlateDestroyed;
                case "WARD_KILL":
                    return EventType.WardKill;
                case "WARD_PLACED":
                    return EventType.WardPlaced;
            }
            throw new Exception("Cannot unmarshal type EventType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EventType)untypedValue;
            switch (value)
            {
                case EventType.BuildingKill:
                    serializer.Serialize(writer, "BUILDING_KILL");
                    return;
                case EventType.ChampionKill:
                    serializer.Serialize(writer, "CHAMPION_KILL");
                    return;
                case EventType.ChampionSpecialKill:
                    serializer.Serialize(writer, "CHAMPION_SPECIAL_KILL");
                    return;
                case EventType.EliteMonsterKill:
                    serializer.Serialize(writer, "ELITE_MONSTER_KILL");
                    return;
                case EventType.GameEnd:
                    serializer.Serialize(writer, "GAME_END");
                    return;
                case EventType.ItemDestroyed:
                    serializer.Serialize(writer, "ITEM_DESTROYED");
                    return;
                case EventType.ItemPurchased:
                    serializer.Serialize(writer, "ITEM_PURCHASED");
                    return;
                case EventType.ItemSold:
                    serializer.Serialize(writer, "ITEM_SOLD");
                    return;
                case EventType.ItemUndo:
                    serializer.Serialize(writer, "ITEM_UNDO");
                    return;
                case EventType.LevelUp:
                    serializer.Serialize(writer, "LEVEL_UP");
                    return;
                case EventType.ObjectiveBountyFinish:
                    serializer.Serialize(writer, "OBJECTIVE_BOUNTY_FINISH");
                    return;
                case EventType.ObjectiveBountyPrestart:
                    serializer.Serialize(writer, "OBJECTIVE_BOUNTY_PRESTART");
                    return;
                case EventType.PauseEnd:
                    serializer.Serialize(writer, "PAUSE_END");
                    return;
                case EventType.SkillLevelUp:
                    serializer.Serialize(writer, "SKILL_LEVEL_UP");
                    return;
                case EventType.TurretPlateDestroyed:
                    serializer.Serialize(writer, "TURRET_PLATE_DESTROYED");
                    return;
                case EventType.WardKill:
                    serializer.Serialize(writer, "WARD_KILL");
                    return;
                case EventType.WardPlaced:
                    serializer.Serialize(writer, "WARD_PLACED");
                    return;
            }
            throw new Exception("Cannot marshal type EventType");
        }

        public static readonly EventTypeConverter Singleton = new EventTypeConverter();
    }

    internal class NameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Name) || t == typeof(Name?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Anivia":
                    return Name.Anivia;
                case "Blitzcrank":
                    return Name.Blitzcrank;
                case "Briar":
                    return Name.Briar;
                case "Caitlyn":
                    return Name.Caitlyn;
                case "Darius":
                    return Name.Darius;
                case "JarvanIV":
                    return Name.JarvanIv;
                case "Jax":
                    return Name.Jax;
                case "Kayle":
                    return Name.Kayle;
                case "MonkeyKing":
                    return Name.MonkeyKing;
                case "SRU_ChaosMinionMelee":
                    return Name.SruChaosMinionMelee;
                case "SRU_ChaosMinionRanged":
                    return Name.SruChaosMinionRanged;
                case "SRU_OrderMinionMelee":
                    return Name.SruOrderMinionMelee;
                case "SRU_OrderMinionRanged":
                    return Name.SruOrderMinionRanged;
                case "SRU_OrderMinionSiege":
                    return Name.SruOrderMinionSiege;
                case "SRU_Razorbeak":
                    return Name.SruRazorbeak;
                case "SRU_RazorbeakMini":
                    return Name.SruRazorbeakMini;
                case "Turret":
                    return Name.Turret;
                case "TwistedFate":
                    return Name.TwistedFate;
            }
            throw new Exception("Cannot unmarshal type Name");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Name)untypedValue;
            switch (value)
            {
                case Name.Anivia:
                    serializer.Serialize(writer, "Anivia");
                    return;
                case Name.Blitzcrank:
                    serializer.Serialize(writer, "Blitzcrank");
                    return;
                case Name.Briar:
                    serializer.Serialize(writer, "Briar");
                    return;
                case Name.Caitlyn:
                    serializer.Serialize(writer, "Caitlyn");
                    return;
                case Name.Darius:
                    serializer.Serialize(writer, "Darius");
                    return;
                case Name.JarvanIv:
                    serializer.Serialize(writer, "JarvanIV");
                    return;
                case Name.Jax:
                    serializer.Serialize(writer, "Jax");
                    return;
                case Name.Kayle:
                    serializer.Serialize(writer, "Kayle");
                    return;
                case Name.MonkeyKing:
                    serializer.Serialize(writer, "MonkeyKing");
                    return;
                case Name.SruChaosMinionMelee:
                    serializer.Serialize(writer, "SRU_ChaosMinionMelee");
                    return;
                case Name.SruChaosMinionRanged:
                    serializer.Serialize(writer, "SRU_ChaosMinionRanged");
                    return;
                case Name.SruOrderMinionMelee:
                    serializer.Serialize(writer, "SRU_OrderMinionMelee");
                    return;
                case Name.SruOrderMinionRanged:
                    serializer.Serialize(writer, "SRU_OrderMinionRanged");
                    return;
                case Name.SruOrderMinionSiege:
                    serializer.Serialize(writer, "SRU_OrderMinionSiege");
                    return;
                case Name.SruRazorbeak:
                    serializer.Serialize(writer, "SRU_Razorbeak");
                    return;
                case Name.SruRazorbeakMini:
                    serializer.Serialize(writer, "SRU_RazorbeakMini");
                    return;
                case Name.Turret:
                    serializer.Serialize(writer, "Turret");
                    return;
                case Name.TwistedFate:
                    serializer.Serialize(writer, "TwistedFate");
                    return;
            }
            throw new Exception("Cannot marshal type Name");
        }

        public static readonly NameConverter Singleton = new NameConverter();
    }

    internal class VictimDamageDealtTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VictimDamageDealtType) || t == typeof(VictimDamageDealtType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "MINION":
                    return VictimDamageDealtType.Minion;
                case "MONSTER":
                    return VictimDamageDealtType.Monster;
                case "OTHER":
                    return VictimDamageDealtType.Other;
                case "TOWER":
                    return VictimDamageDealtType.Tower;
            }
            throw new Exception("Cannot unmarshal type VictimDamageDealtType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VictimDamageDealtType)untypedValue;
            switch (value)
            {
                case VictimDamageDealtType.Minion:
                    serializer.Serialize(writer, "MINION");
                    return;
                case VictimDamageDealtType.Monster:
                    serializer.Serialize(writer, "MONSTER");
                    return;
                case VictimDamageDealtType.Other:
                    serializer.Serialize(writer, "OTHER");
                    return;
                case VictimDamageDealtType.Tower:
                    serializer.Serialize(writer, "TOWER");
                    return;
            }
            throw new Exception("Cannot marshal type VictimDamageDealtType");
        }

        public static readonly VictimDamageDealtTypeConverter Singleton = new VictimDamageDealtTypeConverter();
    }

    internal class WardTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(WardType) || t == typeof(WardType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "YELLOW_TRINKET")
            {
                return WardType.YellowTrinket;
            }
            throw new Exception("Cannot unmarshal type WardType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (WardType)untypedValue;
            if (value == WardType.YellowTrinket)
            {
                serializer.Serialize(writer, "YELLOW_TRINKET");
                return;
            }
            throw new Exception("Cannot marshal type WardType");
        }

        public static readonly WardTypeConverter Singleton = new WardTypeConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
