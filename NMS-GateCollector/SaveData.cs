// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using NMS_GateCollector;
//
//    var SaveData = SaveData.FromJson(jsonString);

namespace NMS_GateCollector
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class SaveData
    {
        [JsonProperty("Version")]
        public long Version { get; set; }

        [JsonProperty("Platform")]
        public string Platform { get; set; }

        [JsonProperty("PlayerStateData")]
        public PlayerStateData PlayerStateData { get; set; }

        [JsonProperty("SpawnStateData")]
        public SpawnStateData SpawnStateData { get; set; }

        [JsonProperty("GameKnowledgeData")]
        public GameKnowledgeData GameKnowledgeData { get; set; }

        [JsonProperty("DiscoveryManagerData")]
        public DiscoveryManagerData DiscoveryManagerData { get; set; }
    }

    public partial class DiscoveryManagerData
    {
        [JsonProperty("DiscoveryData-v1")]
        public DiscoveryDataV1 DiscoveryDataV1 { get; set; }
    }

    public partial class DiscoveryDataV1
    {
        [JsonProperty("ReserveStore")]
        public long ReserveStore { get; set; }

        [JsonProperty("ReserveManaged")]
        public long ReserveManaged { get; set; }

        [JsonProperty("Store")]
        public Store Store { get; set; }

        [JsonProperty("Available")]
        public Available[] Available { get; set; }

        [JsonProperty("Enqueued")]
        public object[] Enqueued { get; set; }
    }

    public partial class Available
    {
        [JsonProperty("TSrec")]
        public long TSrec { get; set; }

        [JsonProperty("DD")]
        public Dd Dd { get; set; }
    }

    public partial class Dd
    {
        [JsonProperty("UA")]
        public Ua Ua { get; set; }

        [JsonProperty("DT")]
        public string Dt { get; set; }

        [JsonProperty("VP")]
        public Ua[] Vp { get; set; }

        public GateData GateData { get { return new GateData(Ua); }}
    }

    public partial class Store
    {
        [JsonProperty("Record")]
        public Record[] Record { get; set; }
    }

    public partial class Record
    {
        [JsonProperty("DD")]
        public Dd Dd { get; set; }

        [JsonProperty("DM")]
        public Dm Dm { get; set; }

        [JsonProperty("OWS")]
        public Ows Ows { get; set; }

        [JsonProperty("RID")]
        public string Rid { get; set; }

        [JsonProperty("PTK")]
        public string Ptk { get; set; }
    }

    public partial class Dm
    {
        [JsonProperty("CN")]
        public string Cn { get; set; }
    }

    public partial class Ows
    {
        [JsonProperty("LID")]
        public string Lid { get; set; }

        [JsonProperty("UID")]
        public string Uid { get; set; }

        [JsonProperty("USN")]
        public string Usn { get; set; }

        [JsonProperty("TS")]
        public long Ts { get; set; }
    }

    public partial class GameKnowledgeData
    {
        [JsonProperty("Waypoints")]
        public Waypoint[] Waypoints { get; set; }
    }

    public partial class Waypoint
    {
        [JsonProperty("Address")]
        public Dictionary<string, long> Address { get; set; }

        [JsonProperty("Type")]
        public WaypointType Type { get; set; }

        [JsonProperty("EventId")]
        public string EventId { get; set; }
    }

    public partial class WaypointType
    {
        [JsonProperty("GalaxyWaypointType")]
        public string GalaxyWaypointType { get; set; }
    }

    public partial class PlayerStateData
    {
        [JsonProperty("UniverseAddress")]
        public AtlasStationAdressDatum UniverseAddress { get; set; }

        [JsonProperty("Inventory")]
        public Chest10Inventory Inventory { get; set; }

        [JsonProperty("Inventory_TechOnly")]
        public Chest10Inventory InventoryTechOnly { get; set; }

        [JsonProperty("Inventory_Cargo")]
        public Chest10Inventory InventoryCargo { get; set; }

        [JsonProperty("ShipInventory")]
        public Chest10Inventory ShipInventory { get; set; }

        [JsonProperty("WeaponInventory")]
        public Chest10Inventory WeaponInventory { get; set; }

        [JsonProperty("GraveInventory")]
        public Chest10Inventory GraveInventory { get; set; }

        [JsonProperty("SpawnGrave")]
        public bool SpawnGrave { get; set; }

        [JsonProperty("SpaceGrave")]
        public bool SpaceGrave { get; set; }

        [JsonProperty("GraveUniverseAddress")]
        public AtlasStationAdressDatum GraveUniverseAddress { get; set; }

        [JsonProperty("GravePosition")]
        public double[] GravePosition { get; set; }

        [JsonProperty("GraveMatrixLookAt")]
        public double[] GraveMatrixLookAt { get; set; }

        [JsonProperty("GraveMatrixUp")]
        public double[] GraveMatrixUp { get; set; }

        [JsonProperty("ShipLayout")]
        public Layout ShipLayout { get; set; }

        [JsonProperty("WeaponLayout")]
        public Layout WeaponLayout { get; set; }

        [JsonProperty("CurrentShip")]
        public CurrentFreighter CurrentShip { get; set; }

        [JsonProperty("CurrentWeapon")]
        public CurrentWeapon CurrentWeapon { get; set; }

        [JsonProperty("KnownTech")]
        public string[] KnownTech { get; set; }

        [JsonProperty("KnownProducts")]
        public string[] KnownProducts { get; set; }

        [JsonProperty("KnownWords")]
        public KnownWord[] KnownWords { get; set; }

        [JsonProperty("MissionProgress")]
        public MissionProgress[] MissionProgress { get; set; }

        [JsonProperty("PostMissionIndex")]
        public long PostMissionIndex { get; set; }

        [JsonProperty("CurrentMissionID")]
        public string CurrentMissionId { get; set; }

        [JsonProperty("CurrentMissionSeed")]
        public Seed CurrentMissionSeed { get; set; }

        [JsonProperty("PreviousMissionID")]
        public string PreviousMissionId { get; set; }

        [JsonProperty("PreviousMissionSeed")]
        public Seed PreviousMissionSeed { get; set; }

        [JsonProperty("HoloExplorerInteraction")]
        public HoloInteraction HoloExplorerInteraction { get; set; }

        [JsonProperty("HoloScepticInteraction")]
        public HoloInteraction HoloScepticInteraction { get; set; }

        [JsonProperty("HoloNooneInteraction")]
        public HoloInteraction HoloNooneInteraction { get; set; }

        [JsonProperty("Health")]
        public long Health { get; set; }

        [JsonProperty("ShipHealth")]
        public long ShipHealth { get; set; }

        [JsonProperty("Shield")]
        public long Shield { get; set; }

        [JsonProperty("ShipShield")]
        public long ShipShield { get; set; }

        [JsonProperty("Energy")]
        public long Energy { get; set; }

        [JsonProperty("Units")]
        public long Units { get; set; }

        [JsonProperty("TimeAlive")]
        public long TimeAlive { get; set; }

        [JsonProperty("TotalPlayTime")]
        public long TotalPlayTime { get; set; }

        [JsonProperty("MarkerStack")]
        public MarkerStack[] MarkerStack { get; set; }

        [JsonProperty("Stats")]
        public PlayerStateDataStat[] Stats { get; set; }

        [JsonProperty("StoredInteractions")]
        public StoredInteraction[] StoredInteractions { get; set; }

        [JsonProperty("MaintenanceInteractions")]
        public MaintenanceInteraction[] MaintenanceInteractions { get; set; }

        [JsonProperty("VisitedSystems")]
        public long[] VisitedSystems { get; set; }

        [JsonProperty("Hazard")]
        public long[] Hazard { get; set; }

        [JsonProperty("BoltAmmo")]
        public long BoltAmmo { get; set; }

        [JsonProperty("LaserAmmo")]
        public long LaserAmmo { get; set; }

        [JsonProperty("GrenadeAmmo")]
        public long GrenadeAmmo { get; set; }

        [JsonProperty("FirstSpawnPosition")]
        public double[] FirstSpawnPosition { get; set; }

        [JsonProperty("SavedInteractionIndicies")]
        public SavedInteractionIndicy[] SavedInteractionIndicies { get; set; }

        [JsonProperty("InteractionProgressTable")]
        public string[] InteractionProgressTable { get; set; }

        [JsonProperty("AtlasStationAdressData")]
        public AtlasStationAdressDatum[] AtlasStationAdressData { get; set; }

        [JsonProperty("NewAtlasStationAdressData")]
        public AtlasStationAdressDatum[] NewAtlasStationAdressData { get; set; }

        [JsonProperty("VisitedAtlasStationsData")]
        public AtlasStationAdressDatum[] VisitedAtlasStationsData { get; set; }

        [JsonProperty("FirstAtlasStationDiscovered")]
        public bool FirstAtlasStationDiscovered { get; set; }

        [JsonProperty("ProgressionLevel")]
        public long ProgressionLevel { get; set; }

        [JsonProperty("IsNew")]
        public bool IsNew { get; set; }

        [JsonProperty("UseSmallerBlackholeJumps")]
        public bool UseSmallerBlackholeJumps { get; set; }

        [JsonProperty("UsedEntitlements")]
        public UsedEntitlement[] UsedEntitlements { get; set; }

        [JsonProperty("PlanetPositions")]
        public long[][] PlanetPositions { get; set; }

        [JsonProperty("PlanetSeeds")]
        public Seed[][] PlanetSeeds { get; set; }

        [JsonProperty("PrimaryPlanet")]
        public long PrimaryPlanet { get; set; }

        [JsonProperty("TimeLastSpaceBattle")]
        public long TimeLastSpaceBattle { get; set; }

        [JsonProperty("WarpsLastSpaceBattle")]
        public long WarpsLastSpaceBattle { get; set; }

        [JsonProperty("TimeLastMiniStation")]
        public long TimeLastMiniStation { get; set; }

        [JsonProperty("WarpsLastMiniStation")]
        public long WarpsLastMiniStation { get; set; }

        [JsonProperty("MiniStationUA")]
        public string MiniStationUa { get; set; }

        [JsonProperty("AnomalyPositionOverride")]
        public long[] AnomalyPositionOverride { get; set; }

        [JsonProperty("GameStartAddress1")]
        public AtlasStationAdressDatum GameStartAddress1 { get; set; }

        [JsonProperty("GameStartAddress2")]
        public AtlasStationAdressDatum GameStartAddress2 { get; set; }

        [JsonProperty("GalacticMapRequests")]
        public bool[] GalacticMapRequests { get; set; }

        [JsonProperty("FirstShipPosition")]
        public double[] FirstShipPosition { get; set; }

        [JsonProperty("SavedSunAngle")]
        public double SavedSunAngle { get; set; }

        [JsonProperty("SavedSunAxis")]
        public double[] SavedSunAxis { get; set; }

        [JsonProperty("HazardTimeAlive")]
        public long HazardTimeAlive { get; set; }

        [JsonProperty("RevealBlackHoles")]
        public bool RevealBlackHoles { get; set; }

        [JsonProperty("CurrentFreighter")]
        public CurrentFreighter CurrentFreighter { get; set; }

        [JsonProperty("FreighterLayout")]
        public Layout FreighterLayout { get; set; }

        [JsonProperty("FreighterInventory")]
        public Chest10Inventory FreighterInventory { get; set; }

        [JsonProperty("FreighterInventory_TechOnly")]
        public Chest10Inventory FreighterInventoryTechOnly { get; set; }

        [JsonProperty("FreighterUniverseAddress")]
        public AtlasStationAdressDatum FreighterUniverseAddress { get; set; }

        [JsonProperty("BaseBuildingObjects")]
        public Object[] BaseBuildingObjects { get; set; }

        [JsonProperty("TerrainEditData")]
        public TerrainEditData TerrainEditData { get; set; }

        [JsonProperty("NPCWorkers")]
        public NpcWorker[] NpcWorkers { get; set; }

        [JsonProperty("PersistentPlayerBases")]
        public PersistentPlayerBasis[] PersistentPlayerBases { get; set; }

        [JsonProperty("TeleportEndpoints")]
        public TeleportEndpoint[] TeleportEndpoints { get; set; }

        [JsonProperty("Chest1Layout")]
        public Layout Chest1Layout { get; set; }

        [JsonProperty("Chest1Inventory")]
        public Chest10Inventory Chest1Inventory { get; set; }

        [JsonProperty("Chest2Layout")]
        public Layout Chest2Layout { get; set; }

        [JsonProperty("Chest2Inventory")]
        public Chest10Inventory Chest2Inventory { get; set; }

        [JsonProperty("Chest3Layout")]
        public Layout Chest3Layout { get; set; }

        [JsonProperty("Chest3Inventory")]
        public Chest10Inventory Chest3Inventory { get; set; }

        [JsonProperty("Chest4Layout")]
        public Layout Chest4Layout { get; set; }

        [JsonProperty("Chest4Inventory")]
        public Chest10Inventory Chest4Inventory { get; set; }

        [JsonProperty("Chest5Layout")]
        public Layout Chest5Layout { get; set; }

        [JsonProperty("Chest5Inventory")]
        public Chest10Inventory Chest5Inventory { get; set; }

        [JsonProperty("Chest6Layout")]
        public Layout Chest6Layout { get; set; }

        [JsonProperty("Chest6Inventory")]
        public Chest10Inventory Chest6Inventory { get; set; }

        [JsonProperty("Chest7Layout")]
        public Layout Chest7Layout { get; set; }

        [JsonProperty("Chest7Inventory")]
        public Chest10Inventory Chest7Inventory { get; set; }

        [JsonProperty("Chest8Layout")]
        public Layout Chest8Layout { get; set; }

        [JsonProperty("Chest8Inventory")]
        public Chest10Inventory Chest8Inventory { get; set; }

        [JsonProperty("Chest9Layout")]
        public Layout Chest9Layout { get; set; }

        [JsonProperty("Chest9Inventory")]
        public Chest10Inventory Chest9Inventory { get; set; }

        [JsonProperty("Chest10Layout")]
        public Layout Chest10Layout { get; set; }

        [JsonProperty("Chest10Inventory")]
        public Chest10Inventory Chest10Inventory { get; set; }

        [JsonProperty("ChestMagicLayout")]
        public Layout ChestMagicLayout { get; set; }

        [JsonProperty("ChestMagicInventory")]
        public Chest10Inventory ChestMagicInventory { get; set; }

        [JsonProperty("ChestMagic2Layout")]
        public Layout ChestMagic2Layout { get; set; }

        [JsonProperty("ChestMagic2Inventory")]
        public Chest10Inventory ChestMagic2Inventory { get; set; }

        [JsonProperty("CurrentFreighterNPC")]
        public CurrentFreighter CurrentFreighterNpc { get; set; }

        [JsonProperty("VehicleOwnership")]
        public VehicleOwnership[] VehicleOwnership { get; set; }

        [JsonProperty("PrimaryVehicle")]
        public long PrimaryVehicle { get; set; }

        [JsonProperty("ShipOwnership")]
        public ShipOwnership[] ShipOwnership { get; set; }

        [JsonProperty("PrimaryShip")]
        public long PrimaryShip { get; set; }

        [JsonProperty("MultiShipEnabled")]
        public bool MultiShipEnabled { get; set; }

        [JsonProperty("PlayerWeaponName")]
        public string PlayerWeaponName { get; set; }

        [JsonProperty("PlayerFreighterName")]
        public string PlayerFreighterName { get; set; }

        [JsonProperty("StartGameShipPosition")]
        public double[] StartGameShipPosition { get; set; }

        [JsonProperty("TradingSupplyDataIndex")]
        public long TradingSupplyDataIndex { get; set; }

        [JsonProperty("TradingSupplyData")]
        public TradingSupplyDatum[] TradingSupplyData { get; set; }

        [JsonProperty("LastPortal")]
        public object[] LastPortal { get; set; }

        [JsonProperty("VisitedPortal")]
        public VisitedPortal VisitedPortal { get; set; }

        [JsonProperty("KnownPortalRunes")]
        public long KnownPortalRunes { get; set; }

        [JsonProperty("OnOtherSideOfPortal")]
        public bool OnOtherSideOfPortal { get; set; }

        [JsonProperty("PortalMarkerPosition_Local")]
        public double[] PortalMarkerPositionLocal { get; set; }

        [JsonProperty("PortalMarkerPosition_Offset")]
        public long[] PortalMarkerPositionOffset { get; set; }
    }

    public partial class AtlasStationAdressDatum
    {
        [JsonProperty("RealityIndex")]
        public long RealityIndex { get; set; }

        [JsonProperty("GalacticAddress")]
        public Dictionary<string, long> GalacticAddress { get; set; }
    }

    public partial class Object
    {
        [JsonProperty("Timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("ObjectID")]
        public string ObjectId { get; set; }

        [JsonProperty("GalacticAddress")]
        public GalacticAddress GalacticAddress { get; set; }

        [JsonProperty("RegionSeed")]
        public Seed RegionSeed { get; set; }

        [JsonProperty("UserData")]
        public long UserData { get; set; }

        [JsonProperty("Position")]
        public double[] Position { get; set; }

        [JsonProperty("Up")]
        public double[] Up { get; set; }

        [JsonProperty("At")]
        public double[] At { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }
    }

    public partial class Chest10Inventory
    {
        [JsonProperty("Slots")]
        public Slot[] Slots { get; set; }

        [JsonProperty("ValidSlotIndices")]
        public Index[] ValidSlotIndices { get; set; }

        [JsonProperty("Class")]
        public Class Class { get; set; }

        [JsonProperty("SubstanceMaxStorageMultiplier")]
        public long SubstanceMaxStorageMultiplier { get; set; }

        [JsonProperty("ProductMaxStorageMultiplier")]
        public long ProductMaxStorageMultiplier { get; set; }

        [JsonProperty("BaseStatValues")]
        public BaseStatValue[] BaseStatValues { get; set; }

        [JsonProperty("SpecialSlots")]
        public object[] SpecialSlots { get; set; }

        [JsonProperty("Width")]
        public long Width { get; set; }

        [JsonProperty("Height")]
        public long Height { get; set; }

        [JsonProperty("IsCool")]
        public bool IsCool { get; set; }

        [JsonProperty("Version")]
        public long Version { get; set; }
    }

    public partial class BaseStatValue
    {
        [JsonProperty("BaseStatID")]
        public string BaseStatId { get; set; }

        [JsonProperty("Value")]
        public double Value { get; set; }
    }

    public partial class Class
    {
        [JsonProperty("InventoryClass")]
        public string InventoryClass { get; set; }
    }

    public partial class Slot
    {
        [JsonProperty("Type")]
        public SlotType Type { get; set; }

        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Amount")]
        public long Amount { get; set; }

        [JsonProperty("MaxAmount")]
        public long MaxAmount { get; set; }

        [JsonProperty("DamageFactor")]
        public long DamageFactor { get; set; }

        [JsonProperty("Index")]
        public Index Index { get; set; }
    }

    public partial class Index
    {
        [JsonProperty("X")]
        public long X { get; set; }

        [JsonProperty("Y")]
        public long Y { get; set; }
    }

    public partial class SlotType
    {
        [JsonProperty("InventoryType")]
        public string InventoryType { get; set; }
    }

    public partial class Layout
    {
        [JsonProperty("Slots")]
        public long Slots { get; set; }

        [JsonProperty("Seed")]
        public Seed[] Seed { get; set; }

        [JsonProperty("Level")]
        public long Level { get; set; }
    }

    public partial class CurrentFreighter
    {
        [JsonProperty("Filename")]
        public string Filename { get; set; }

        [JsonProperty("Seed")]
        public Seed[] Seed { get; set; }

        [JsonProperty("AltId")]
        public string AltId { get; set; }

        [JsonProperty("ProceduralTexture")]
        public ProceduralTexture ProceduralTexture { get; set; }
    }

    public partial class ProceduralTexture
    {
        [JsonProperty("Samplers")]
        public object[] Samplers { get; set; }
    }

    public partial class CurrentWeapon
    {
        [JsonProperty("Filename")]
        public string Filename { get; set; }

        [JsonProperty("GenerationSeed")]
        public Seed[] GenerationSeed { get; set; }
    }

    public partial class HoloInteraction
    {
        [JsonProperty("GalacticAddress")]
        public long GalacticAddress { get; set; }

        [JsonProperty("Value")]
        public long Value { get; set; }

        [JsonProperty("Position")]
        public long[] Position { get; set; }
    }

    public partial class KnownWord
    {
        [JsonProperty("Word")]
        public string Word { get; set; }

        [JsonProperty("Races")]
        public bool[] Races { get; set; }
    }

    public partial class MaintenanceInteraction
    {
        [JsonProperty("InventoryContainer")]
        public Chest10Inventory InventoryContainer { get; set; }

        [JsonProperty("LastUpdateTimestamp")]
        public long LastUpdateTimestamp { get; set; }

        [JsonProperty("DamageTimers")]
        public long[] DamageTimers { get; set; }

        [JsonProperty("Flags")]
        public long Flags { get; set; }
    }

    public partial class MarkerStack
    {
        [JsonProperty("Table")]
        public long Table { get; set; }

        [JsonProperty("Event")]
        public string Event { get; set; }

        [JsonProperty("GalacticAddress")]
        public Ua GalacticAddress { get; set; }

        [JsonProperty("BuildingSeed")]
        public Seed[] BuildingSeed { get; set; }

        [JsonProperty("BuildingLocation")]
        public double[] BuildingLocation { get; set; }

        [JsonProperty("BuildingClass")]
        public BuildingClass BuildingClass { get; set; }

        [JsonProperty("Time")]
        public long Time { get; set; }

        [JsonProperty("MissionID")]
        public string MissionId { get; set; }

        [JsonProperty("MissionSeed")]
        public Seed MissionSeed { get; set; }

        [JsonProperty("ParticipantType")]
        public ParticipantType ParticipantType { get; set; }
    }

    public partial class BuildingClass
    {
        [JsonProperty("BuildingClass")]
        public string BuildingClassBuildingClass { get; set; }
    }

    public partial class ParticipantType
    {
        [JsonProperty("ParticipantType")]
        public string ParticipantTypeParticipantType { get; set; }
    }

    public partial class MissionProgress
    {
        [JsonProperty("Mission")]
        public string Mission { get; set; }

        [JsonProperty("Progress")]
        public long Progress { get; set; }

        [JsonProperty("Seed")]
        public Ua Seed { get; set; }

        [JsonProperty("Data")]
        public long Data { get; set; }

        [JsonProperty("Participants")]
        public Participant[] Participants { get; set; }
    }

    public partial class Participant
    {
        [JsonProperty("UA")]
        public Ua Ua { get; set; }

        [JsonProperty("BuildingSeed")]
        public Seed[] BuildingSeed { get; set; }

        [JsonProperty("ParticipantType")]
        public ParticipantType ParticipantType { get; set; }
    }

    public partial class NpcWorker
    {
        [JsonProperty("ResourceElement")]
        public CurrentFreighter ResourceElement { get; set; }

        [JsonProperty("InteractionSeed")]
        public Seed[] InteractionSeed { get; set; }

        [JsonProperty("HasTerminal")]
        public bool HasTerminal { get; set; }

        [JsonProperty("HiredWorker")]
        public bool HiredWorker { get; set; }
    }

    public partial class PersistentPlayerBasis
    {
        [JsonProperty("BaseVersion")]
        public long BaseVersion { get; set; }

        [JsonProperty("GalacticAddress")]
        public Ua GalacticAddress { get; set; }

        [JsonProperty("Position")]
        public double[] Position { get; set; }

        [JsonProperty("Forward")]
        public double[] Forward { get; set; }

        [JsonProperty("UserData")]
        public long UserData { get; set; }

        [JsonProperty("Objects")]
        public Object[] Objects { get; set; }

        [JsonProperty("RID")]
        public string Rid { get; set; }

        [JsonProperty("Owner")]
        public Ows Owner { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }
    }

    public partial class SavedInteractionIndicy
    {
        [JsonProperty("SavedRaceIndicies")]
        public long[] SavedRaceIndicies { get; set; }
    }

    public partial class ShipOwnership
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Resource")]
        public CurrentFreighter Resource { get; set; }

        [JsonProperty("Inventory")]
        public Chest10Inventory Inventory { get; set; }

        [JsonProperty("Inventory_TechOnly")]
        public Chest10Inventory InventoryTechOnly { get; set; }

        [JsonProperty("InventoryLayout")]
        public Layout InventoryLayout { get; set; }

        [JsonProperty("Location")]
        public long Location { get; set; }

        [JsonProperty("Position")]
        public long[] Position { get; set; }

        [JsonProperty("Direction")]
        public long[] Direction { get; set; }
    }

    public partial class PlayerStateDataStat
    {
        [JsonProperty("GroupId")]
        public string GroupId { get; set; }

        [JsonProperty("Address")]
        public Ua Address { get; set; }

        [JsonProperty("Stats")]
        public StatStat[] Stats { get; set; }
    }

    public partial class StatStat
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Value")]
        public Value Value { get; set; }
    }

    public partial class Value
    {
        [JsonProperty("IntValue")]
        public long IntValue { get; set; }

        [JsonProperty("FloatValue")]
        public double FloatValue { get; set; }

        [JsonProperty("Denominator")]
        public long Denominator { get; set; }
    }

    public partial class StoredInteraction
    {
        [JsonProperty("Interactions")]
        public Interaction[] Interactions { get; set; }
    }

    public partial class Interaction
    {
        [JsonProperty("GalacticAddress")]
        public Ua GalacticAddress { get; set; }

        [JsonProperty("Value")]
        public long Value { get; set; }

        [JsonProperty("Position")]
        public double[] Position { get; set; }
    }

    public partial class TeleportEndpoint
    {
        [JsonProperty("UniverseAddress")]
        public AtlasStationAdressDatum UniverseAddress { get; set; }

        [JsonProperty("Position")]
        public double[] Position { get; set; }

        [JsonProperty("Facing")]
        public double[] Facing { get; set; }

        [JsonProperty("TeleporterType")]
        public string TeleporterType { get; set; }
    }

    public partial class TerrainEditData
    {
        [JsonProperty("GalacticAddresses")]
        public Ua[] GalacticAddresses { get; set; }

        [JsonProperty("BufferOffsets")]
        public long[] BufferOffsets { get; set; }

        [JsonProperty("BufferSizes")]
        public long[] BufferSizes { get; set; }

        [JsonProperty("BufferAges")]
        public long[] BufferAges { get; set; }

        [JsonProperty("BufferAnchors")]
        public double[][] BufferAnchors { get; set; }

        [JsonProperty("Edits")]
        public Edit[] Edits { get; set; }
    }

    public partial class Edit
    {
        [JsonProperty("Data")]
        public long Data { get; set; }

        [JsonProperty("Position")]
        public long Position { get; set; }
    }

    public partial class TradingSupplyDatum
    {
        [JsonProperty("GalacticAddress")]
        public Ua GalacticAddress { get; set; }

        [JsonProperty("Supply")]
        public double Supply { get; set; }

        [JsonProperty("Demand")]
        public long Demand { get; set; }

        [JsonProperty("Product")]
        public string Product { get; set; }

        [JsonProperty("Timestamp")]
        public long Timestamp { get; set; }
    }

    public partial class UsedEntitlement
    {
        [JsonProperty("EntitlementId")]
        public string EntitlementId { get; set; }
    }

    public partial class VehicleOwnership
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Resource")]
        public CurrentFreighter Resource { get; set; }

        [JsonProperty("Inventory")]
        public Chest10Inventory Inventory { get; set; }

        [JsonProperty("Inventory_TechOnly")]
        public Chest10Inventory InventoryTechOnly { get; set; }

        [JsonProperty("InventoryLayout")]
        public Layout InventoryLayout { get; set; }

        [JsonProperty("Location")]
        public Ua Location { get; set; }

        [JsonProperty("Position")]
        public double[] Position { get; set; }

        [JsonProperty("Direction")]
        public double[] Direction { get; set; }
    }

    public partial class VisitedPortal
    {
        [JsonProperty("PortalSeed")]
        public Seed[] PortalSeed { get; set; }

        [JsonProperty("LastPortalUA")]
        public string LastPortalUa { get; set; }
    }

    public partial class SpawnStateData
    {
        [JsonProperty("PlayerPositionInSystem")]
        public double[] PlayerPositionInSystem { get; set; }

        [JsonProperty("PlayerTransformAt")]
        public double[] PlayerTransformAt { get; set; }

        [JsonProperty("ShipPositionInSystem")]
        public double[] ShipPositionInSystem { get; set; }

        [JsonProperty("ShipTransformAt")]
        public double[] ShipTransformAt { get; set; }

        [JsonProperty("LastKnownPlayerState")]
        public string LastKnownPlayerState { get; set; }

        [JsonProperty("FreighterPositionInSystem")]
        public long[] FreighterPositionInSystem { get; set; }

        [JsonProperty("FreighterTransformAt")]
        public long[] FreighterTransformAt { get; set; }

        [JsonProperty("FreighterTransformUp")]
        public long[] FreighterTransformUp { get; set; }
    }

    public partial struct Ua
    {
        public long? Integer;
        public string String;
    }

    public partial struct GalacticAddress
    {
        public long? Integer;
        public string String;
    }

    public partial struct Seed
    {
        public bool? Bool;
        public long? Integer;
        public string String;
    }

    public partial class SaveData
    {
        public static SaveData FromJson(string json) => JsonConvert.DeserializeObject<SaveData>(json, Converter.Settings);
    }

    public partial struct Ua
    {
        public Ua(JsonReader reader, JsonSerializer serializer)
        {
            Integer = null;
            String = null;

            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    Integer = serializer.Deserialize<long>(reader);
                    String = string.Format("0x{0:X14}", Integer);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    Integer = Convert.ToInt64(String, 16);
                    return;
            }
            throw new Exception("Cannot convert Ua");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (Integer != null)
            {
                serializer.Serialize(writer, Integer);
                return;
            }
            if (String != null)
            {
                serializer.Serialize(writer, String);
                return;
            }
            throw new Exception("Union must not be null");
        }
    }

    public partial struct GalacticAddress
    {
        public GalacticAddress(JsonReader reader, JsonSerializer serializer)
        {
            Integer = null;
            String = null;

            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return;
                case JsonToken.Integer:
                    Integer = serializer.Deserialize<long>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    return;
            }
            throw new Exception("Cannot convert GalacticAddress");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (Integer != null)
            {
                serializer.Serialize(writer, Integer);
                return;
            }
            if (String != null)
            {
                serializer.Serialize(writer, String);
                return;
            }
            writer.WriteNull();
        }
    }

    public partial struct Seed
    {
        public Seed(JsonReader reader, JsonSerializer serializer)
        {
            Bool = null;
            String = null;
            Integer = null;

            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    Bool = serializer.Deserialize<bool>(reader);
                    return;
                case JsonToken.Integer:
                    Integer = serializer.Deserialize<long>(reader);
                    String = string.Format("0x{0:X14}", Integer);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    Integer = Convert.ToInt64(String, 16);
                    return;
            }
            throw new Exception("Cannot convert Seed");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (Bool != null)
            {
                serializer.Serialize(writer, Bool);
                return;
            }
            if (String != null)
            {
                serializer.Serialize(writer, String);
                return;
            }
            throw new Exception("Union must not be null");
        }
    }

    public static class Serialize
    {
        public static string ToJson(this SaveData self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal class Converter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Ua) || t == typeof(GalacticAddress) || t == typeof(Seed);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (t == typeof(Ua))
                return new Ua(reader, serializer);
            if (t == typeof(GalacticAddress))
                return new GalacticAddress(reader, serializer);
            if (t == typeof(Seed))
                return new Seed(reader, serializer);
            throw new Exception("Unknown type");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var t = value.GetType();
            if (t == typeof(Ua))
            {
                ((Ua)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(GalacticAddress))
            {
                ((GalacticAddress)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Seed))
            {
                ((Seed)value).WriteJson(writer, serializer);
                return;
            }
            throw new Exception("Unknown type");
        }

        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new Converter(),
                new IsoDateTimeConverter()
                {
                    DateTimeStyles = DateTimeStyles.AssumeUniversal,
                },
            },
        };
    }
}
