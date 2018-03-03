// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using NMS_GateCollector;
//
//    var welcome = Welcome.FromJson(jsonString);

namespace NMS_GateCollector
{
    using System;
    using System.Collections.Generic;
    using System.Net;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Welcome
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
        public Dt Dt { get; set; }

        [JsonProperty("VP")]
        public Ua[] Vp { get; set; }
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
        public Ptk? Ptk { get; set; }
    }

    public partial class Dm
    {
        [JsonProperty("CN")]
        public string Cn { get; set; }
    }

    public partial class Ows
    {
        [JsonProperty("LID")]
        public Lid Lid { get; set; }

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
        public long CurrentMissionSeed { get; set; }

        [JsonProperty("PreviousMissionID")]
        public string PreviousMissionId { get; set; }

        [JsonProperty("PreviousMissionSeed")]
        public long PreviousMissionSeed { get; set; }

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
        public CurrentFreighterSeed[][] PlanetSeeds { get; set; }

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
        public string RegionSeed { get; set; }

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
        public InventoryClass InventoryClass { get; set; }
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
        public InventoryType InventoryType { get; set; }
    }

    public partial class Layout
    {
        [JsonProperty("Slots")]
        public long Slots { get; set; }

        [JsonProperty("Seed")]
        public Chest10LayoutSeedUnion[] Seed { get; set; }

        [JsonProperty("Level")]
        public long Level { get; set; }
    }

    public partial class CurrentFreighter
    {
        [JsonProperty("Filename")]
        public string Filename { get; set; }

        [JsonProperty("Seed")]
        public CurrentFreighterSeed[] Seed { get; set; }

        [JsonProperty("AltId")]
        public AltId AltId { get; set; }

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
        public CurrentFreighterSeed[] GenerationSeed { get; set; }
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
        public CurrentFreighterSeed[] BuildingSeed { get; set; }

        [JsonProperty("BuildingLocation")]
        public double[] BuildingLocation { get; set; }

        [JsonProperty("BuildingClass")]
        public BuildingClass BuildingClass { get; set; }

        [JsonProperty("Time")]
        public long Time { get; set; }

        [JsonProperty("MissionID")]
        public MissionId MissionId { get; set; }

        [JsonProperty("MissionSeed")]
        public long MissionSeed { get; set; }

        [JsonProperty("ParticipantType")]
        public MarkerStackParticipantType ParticipantType { get; set; }
    }

    public partial class BuildingClass
    {
        [JsonProperty("BuildingClass")]
        public string BuildingClassBuildingClass { get; set; }
    }

    public partial class MarkerStackParticipantType
    {
        [JsonProperty("ParticipantType")]
        public ParticipantTypeParticipantType ParticipantType { get; set; }
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
        public CurrentFreighterSeed[] BuildingSeed { get; set; }

        [JsonProperty("ParticipantType")]
        public MarkerStackParticipantType ParticipantType { get; set; }
    }

    public partial class NpcWorker
    {
        [JsonProperty("ResourceElement")]
        public CurrentFreighter ResourceElement { get; set; }

        [JsonProperty("InteractionSeed")]
        public CurrentFreighterSeed[] InteractionSeed { get; set; }

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
        public GroupId GroupId { get; set; }

        [JsonProperty("Address")]
        public Ua Address { get; set; }

        [JsonProperty("Stats")]
        public StatStat[] Stats { get; set; }
    }

    public partial class StatStat
    {
        [JsonProperty("Id")]
        public Id Id { get; set; }

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
        public TeleporterType TeleporterType { get; set; }
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
        public CurrentFreighterSeed[] PortalSeed { get; set; }

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

    public enum Dt { Animal, Flora, Interactable, Mineral, Planet, Sector, SolarSystem };

    public enum Lid { Empty, The76561197993130605 };

    public enum Ptk { St };

    public enum InventoryClass { A, B, C, S };

    public enum InventoryType { Product, Substance, Technology };

    public enum SeedEnum { The0X1 };

    public enum AltId { Empty };

    public enum MissionId { Empty, OverseerLoop };

    public enum ParticipantTypeParticipantType { MissionGiver, None, Primary, Secondary1, Secondary2, Secondary3, Secondary4, Secondary5, Secondary6, Secondary7, Secondary8, Secondary9 };

    public enum GroupId { GlobalStats, PlanetStats };

    public enum Id { AliensMet, AllCreatures, ArtifactHints, AtlasPath, AtlasStory, BlackholeWarps, CreaturesKill, Deaths, DepotsBroken, DiscAllCreatu, DiscCreatures, DiscFlora, DiscMinerals, DiscPlanets, DiscWaypoints, DistFly, DistSwam, DistWalked, DistWarp, DronesKilled, EarlyWarps, EdoneMissions, EgdoneMissions, EguildStand, EnemiesKilled, EseenSystems, EwordsLearnt, ExpStanding, FpodsBroken, GlobalMission, ItemsTeleprt, LongestLife, LongestLifeEx, Money, PhotoModeUsed, PiratesKilled, PlantsPlanted, PoliceKilled, PredsKilled, QuadsKilled, RareScanned, ResExtracted, SalvageLooted, SentinelKills, ShipsBought, SpaceBattles, StationVisited, TdoneMissions, TechBought, TgdoneMissions, TguildStand, Time, TimesInSpace, TraStanding, TseenSystems, Tutorial, TwordsLearnt, VisitExtBase, WalkersKilled, WarStanding, WdoneMissions, WgdoneMissions, WguildStand, WordsLearnt, WseenSystems, WwordsLearnt };

    public enum TeleporterType { Base, Spacestation };

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

    public partial struct Chest10LayoutSeedUnion
    {
        public bool? Bool;
        public SeedEnum? Enum;
    }

    public partial struct CurrentFreighterSeed
    {
        public bool? Bool;
        public string String;
    }

    public partial class Welcome
    {
        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, NMS_GateCollector.Converter.Settings);
    }

    static class DtExtensions
    {
        public static Dt? ValueForString(string str)
        {
            switch (str)
            {
                case "Animal": return Dt.Animal;
                case "Flora": return Dt.Flora;
                case "Interactable": return Dt.Interactable;
                case "Mineral": return Dt.Mineral;
                case "Planet": return Dt.Planet;
                case "Sector": return Dt.Sector;
                case "SolarSystem": return Dt.SolarSystem;
                default: return null;
            }
        }

        public static Dt ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Dt value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Dt.Animal: serializer.Serialize(writer, "Animal"); break;
                case Dt.Flora: serializer.Serialize(writer, "Flora"); break;
                case Dt.Interactable: serializer.Serialize(writer, "Interactable"); break;
                case Dt.Mineral: serializer.Serialize(writer, "Mineral"); break;
                case Dt.Planet: serializer.Serialize(writer, "Planet"); break;
                case Dt.Sector: serializer.Serialize(writer, "Sector"); break;
                case Dt.SolarSystem: serializer.Serialize(writer, "SolarSystem"); break;
            }
        }
    }

    static class LidExtensions
    {
        public static Lid? ValueForString(string str)
        {
            switch (str)
            {
                case "": return Lid.Empty;
                case "76561197993130605": return Lid.The76561197993130605;
                default: return null;
            }
        }

        public static Lid ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Lid value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Lid.Empty: serializer.Serialize(writer, ""); break;
                case Lid.The76561197993130605: serializer.Serialize(writer, "76561197993130605"); break;
            }
        }
    }

    static class PtkExtensions
    {
        public static Ptk? ValueForString(string str)
        {
            switch (str)
            {
                case "ST": return Ptk.St;
                default: return null;
            }
        }

        public static Ptk ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Ptk value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Ptk.St: serializer.Serialize(writer, "ST"); break;
            }
        }
    }

    static class InventoryClassExtensions
    {
        public static InventoryClass? ValueForString(string str)
        {
            switch (str)
            {
                case "A": return InventoryClass.A;
                case "B": return InventoryClass.B;
                case "C": return InventoryClass.C;
                case "S": return InventoryClass.S;
                default: return null;
            }
        }

        public static InventoryClass ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this InventoryClass value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case InventoryClass.A: serializer.Serialize(writer, "A"); break;
                case InventoryClass.B: serializer.Serialize(writer, "B"); break;
                case InventoryClass.C: serializer.Serialize(writer, "C"); break;
                case InventoryClass.S: serializer.Serialize(writer, "S"); break;
            }
        }
    }

    static class InventoryTypeExtensions
    {
        public static InventoryType? ValueForString(string str)
        {
            switch (str)
            {
                case "Product": return InventoryType.Product;
                case "Substance": return InventoryType.Substance;
                case "Technology": return InventoryType.Technology;
                default: return null;
            }
        }

        public static InventoryType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this InventoryType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case InventoryType.Product: serializer.Serialize(writer, "Product"); break;
                case InventoryType.Substance: serializer.Serialize(writer, "Substance"); break;
                case InventoryType.Technology: serializer.Serialize(writer, "Technology"); break;
            }
        }
    }

    static class SeedEnumExtensions
    {
        public static SeedEnum? ValueForString(string str)
        {
            switch (str)
            {
                case "0x1": return SeedEnum.The0X1;
                default: return null;
            }
        }

        public static SeedEnum ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this SeedEnum value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case SeedEnum.The0X1: serializer.Serialize(writer, "0x1"); break;
            }
        }
    }

    static class AltIdExtensions
    {
        public static AltId? ValueForString(string str)
        {
            switch (str)
            {
                case "": return AltId.Empty;
                default: return null;
            }
        }

        public static AltId ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this AltId value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case AltId.Empty: serializer.Serialize(writer, ""); break;
            }
        }
    }

    static class MissionIdExtensions
    {
        public static MissionId? ValueForString(string str)
        {
            switch (str)
            {
                case "^": return MissionId.Empty;
                case "^OVERSEER_LOOP": return MissionId.OverseerLoop;
                default: return null;
            }
        }

        public static MissionId ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this MissionId value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case MissionId.Empty: serializer.Serialize(writer, "^"); break;
                case MissionId.OverseerLoop: serializer.Serialize(writer, "^OVERSEER_LOOP"); break;
            }
        }
    }

    static class ParticipantTypeParticipantTypeExtensions
    {
        public static ParticipantTypeParticipantType? ValueForString(string str)
        {
            switch (str)
            {
                case "MissionGiver": return ParticipantTypeParticipantType.MissionGiver;
                case "None": return ParticipantTypeParticipantType.None;
                case "Primary": return ParticipantTypeParticipantType.Primary;
                case "Secondary1": return ParticipantTypeParticipantType.Secondary1;
                case "Secondary2": return ParticipantTypeParticipantType.Secondary2;
                case "Secondary3": return ParticipantTypeParticipantType.Secondary3;
                case "Secondary4": return ParticipantTypeParticipantType.Secondary4;
                case "Secondary5": return ParticipantTypeParticipantType.Secondary5;
                case "Secondary6": return ParticipantTypeParticipantType.Secondary6;
                case "Secondary7": return ParticipantTypeParticipantType.Secondary7;
                case "Secondary8": return ParticipantTypeParticipantType.Secondary8;
                case "Secondary9": return ParticipantTypeParticipantType.Secondary9;
                default: return null;
            }
        }

        public static ParticipantTypeParticipantType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this ParticipantTypeParticipantType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case ParticipantTypeParticipantType.MissionGiver: serializer.Serialize(writer, "MissionGiver"); break;
                case ParticipantTypeParticipantType.None: serializer.Serialize(writer, "None"); break;
                case ParticipantTypeParticipantType.Primary: serializer.Serialize(writer, "Primary"); break;
                case ParticipantTypeParticipantType.Secondary1: serializer.Serialize(writer, "Secondary1"); break;
                case ParticipantTypeParticipantType.Secondary2: serializer.Serialize(writer, "Secondary2"); break;
                case ParticipantTypeParticipantType.Secondary3: serializer.Serialize(writer, "Secondary3"); break;
                case ParticipantTypeParticipantType.Secondary4: serializer.Serialize(writer, "Secondary4"); break;
                case ParticipantTypeParticipantType.Secondary5: serializer.Serialize(writer, "Secondary5"); break;
                case ParticipantTypeParticipantType.Secondary6: serializer.Serialize(writer, "Secondary6"); break;
                case ParticipantTypeParticipantType.Secondary7: serializer.Serialize(writer, "Secondary7"); break;
                case ParticipantTypeParticipantType.Secondary8: serializer.Serialize(writer, "Secondary8"); break;
                case ParticipantTypeParticipantType.Secondary9: serializer.Serialize(writer, "Secondary9"); break;
            }
        }
    }

    static class GroupIdExtensions
    {
        public static GroupId? ValueForString(string str)
        {
            switch (str)
            {
                case "^GLOBAL_STATS": return GroupId.GlobalStats;
                case "^PLANET_STATS": return GroupId.PlanetStats;
                default: return null;
            }
        }

        public static GroupId ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this GroupId value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case GroupId.GlobalStats: serializer.Serialize(writer, "^GLOBAL_STATS"); break;
                case GroupId.PlanetStats: serializer.Serialize(writer, "^PLANET_STATS"); break;
            }
        }
    }

    static class IdExtensions
    {
        public static Id? ValueForString(string str)
        {
            switch (str)
            {
                case "^ALIENS_MET": return Id.AliensMet;
                case "^ALL_CREATURES": return Id.AllCreatures;
                case "^ARTIFACT_HINTS": return Id.ArtifactHints;
                case "^ATLAS_PATH": return Id.AtlasPath;
                case "^ATLAS_STORY": return Id.AtlasStory;
                case "^BLACKHOLE_WARPS": return Id.BlackholeWarps;
                case "^CREATURES_KILL": return Id.CreaturesKill;
                case "^DEATHS": return Id.Deaths;
                case "^DEPOTS_BROKEN": return Id.DepotsBroken;
                case "^DISC_ALL_CREATU": return Id.DiscAllCreatu;
                case "^DISC_CREATURES": return Id.DiscCreatures;
                case "^DISC_FLORA": return Id.DiscFlora;
                case "^DISC_MINERALS": return Id.DiscMinerals;
                case "^DISC_PLANETS": return Id.DiscPlanets;
                case "^DISC_WAYPOINTS": return Id.DiscWaypoints;
                case "^DIST_FLY": return Id.DistFly;
                case "^DIST_SWAM": return Id.DistSwam;
                case "^DIST_WALKED": return Id.DistWalked;
                case "^DIST_WARP": return Id.DistWarp;
                case "^DRONES_KILLED": return Id.DronesKilled;
                case "^EARLY_WARPS": return Id.EarlyWarps;
                case "^EDONE_MISSIONS": return Id.EdoneMissions;
                case "^EGDONE_MISSIONS": return Id.EgdoneMissions;
                case "^EGUILD_STAND": return Id.EguildStand;
                case "^ENEMIES_KILLED": return Id.EnemiesKilled;
                case "^ESEEN_SYSTEMS": return Id.EseenSystems;
                case "^EWORDS_LEARNT": return Id.EwordsLearnt;
                case "^EXP_STANDING": return Id.ExpStanding;
                case "^FPODS_BROKEN": return Id.FpodsBroken;
                case "^GLOBAL_MISSION": return Id.GlobalMission;
                case "^ITEMS_TELEPRT": return Id.ItemsTeleprt;
                case "^LONGEST_LIFE": return Id.LongestLife;
                case "^LONGEST_LIFE_EX": return Id.LongestLifeEx;
                case "^MONEY": return Id.Money;
                case "^PHOTO_MODE_USED": return Id.PhotoModeUsed;
                case "^PIRATES_KILLED": return Id.PiratesKilled;
                case "^PLANTS_PLANTED": return Id.PlantsPlanted;
                case "^POLICE_KILLED": return Id.PoliceKilled;
                case "^PREDS_KILLED": return Id.PredsKilled;
                case "^QUADS_KILLED": return Id.QuadsKilled;
                case "^RARE_SCANNED": return Id.RareScanned;
                case "^RES_EXTRACTED": return Id.ResExtracted;
                case "^SALVAGE_LOOTED": return Id.SalvageLooted;
                case "^SENTINEL_KILLS": return Id.SentinelKills;
                case "^SHIPS_BOUGHT": return Id.ShipsBought;
                case "^SPACE_BATTLES": return Id.SpaceBattles;
                case "^STATION_VISITED": return Id.StationVisited;
                case "^TDONE_MISSIONS": return Id.TdoneMissions;
                case "^TECH_BOUGHT": return Id.TechBought;
                case "^TGDONE_MISSIONS": return Id.TgdoneMissions;
                case "^TGUILD_STAND": return Id.TguildStand;
                case "^TIME": return Id.Time;
                case "^TIMES_IN_SPACE": return Id.TimesInSpace;
                case "^TRA_STANDING": return Id.TraStanding;
                case "^TSEEN_SYSTEMS": return Id.TseenSystems;
                case "^TUTORIAL": return Id.Tutorial;
                case "^TWORDS_LEARNT": return Id.TwordsLearnt;
                case "^VISIT_EXT_BASE": return Id.VisitExtBase;
                case "^WALKERS_KILLED": return Id.WalkersKilled;
                case "^WAR_STANDING": return Id.WarStanding;
                case "^WDONE_MISSIONS": return Id.WdoneMissions;
                case "^WGDONE_MISSIONS": return Id.WgdoneMissions;
                case "^WGUILD_STAND": return Id.WguildStand;
                case "^WORDS_LEARNT": return Id.WordsLearnt;
                case "^WSEEN_SYSTEMS": return Id.WseenSystems;
                case "^WWORDS_LEARNT": return Id.WwordsLearnt;
                default: return null;
            }
        }

        public static Id ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Id value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Id.AliensMet: serializer.Serialize(writer, "^ALIENS_MET"); break;
                case Id.AllCreatures: serializer.Serialize(writer, "^ALL_CREATURES"); break;
                case Id.ArtifactHints: serializer.Serialize(writer, "^ARTIFACT_HINTS"); break;
                case Id.AtlasPath: serializer.Serialize(writer, "^ATLAS_PATH"); break;
                case Id.AtlasStory: serializer.Serialize(writer, "^ATLAS_STORY"); break;
                case Id.BlackholeWarps: serializer.Serialize(writer, "^BLACKHOLE_WARPS"); break;
                case Id.CreaturesKill: serializer.Serialize(writer, "^CREATURES_KILL"); break;
                case Id.Deaths: serializer.Serialize(writer, "^DEATHS"); break;
                case Id.DepotsBroken: serializer.Serialize(writer, "^DEPOTS_BROKEN"); break;
                case Id.DiscAllCreatu: serializer.Serialize(writer, "^DISC_ALL_CREATU"); break;
                case Id.DiscCreatures: serializer.Serialize(writer, "^DISC_CREATURES"); break;
                case Id.DiscFlora: serializer.Serialize(writer, "^DISC_FLORA"); break;
                case Id.DiscMinerals: serializer.Serialize(writer, "^DISC_MINERALS"); break;
                case Id.DiscPlanets: serializer.Serialize(writer, "^DISC_PLANETS"); break;
                case Id.DiscWaypoints: serializer.Serialize(writer, "^DISC_WAYPOINTS"); break;
                case Id.DistFly: serializer.Serialize(writer, "^DIST_FLY"); break;
                case Id.DistSwam: serializer.Serialize(writer, "^DIST_SWAM"); break;
                case Id.DistWalked: serializer.Serialize(writer, "^DIST_WALKED"); break;
                case Id.DistWarp: serializer.Serialize(writer, "^DIST_WARP"); break;
                case Id.DronesKilled: serializer.Serialize(writer, "^DRONES_KILLED"); break;
                case Id.EarlyWarps: serializer.Serialize(writer, "^EARLY_WARPS"); break;
                case Id.EdoneMissions: serializer.Serialize(writer, "^EDONE_MISSIONS"); break;
                case Id.EgdoneMissions: serializer.Serialize(writer, "^EGDONE_MISSIONS"); break;
                case Id.EguildStand: serializer.Serialize(writer, "^EGUILD_STAND"); break;
                case Id.EnemiesKilled: serializer.Serialize(writer, "^ENEMIES_KILLED"); break;
                case Id.EseenSystems: serializer.Serialize(writer, "^ESEEN_SYSTEMS"); break;
                case Id.EwordsLearnt: serializer.Serialize(writer, "^EWORDS_LEARNT"); break;
                case Id.ExpStanding: serializer.Serialize(writer, "^EXP_STANDING"); break;
                case Id.FpodsBroken: serializer.Serialize(writer, "^FPODS_BROKEN"); break;
                case Id.GlobalMission: serializer.Serialize(writer, "^GLOBAL_MISSION"); break;
                case Id.ItemsTeleprt: serializer.Serialize(writer, "^ITEMS_TELEPRT"); break;
                case Id.LongestLife: serializer.Serialize(writer, "^LONGEST_LIFE"); break;
                case Id.LongestLifeEx: serializer.Serialize(writer, "^LONGEST_LIFE_EX"); break;
                case Id.Money: serializer.Serialize(writer, "^MONEY"); break;
                case Id.PhotoModeUsed: serializer.Serialize(writer, "^PHOTO_MODE_USED"); break;
                case Id.PiratesKilled: serializer.Serialize(writer, "^PIRATES_KILLED"); break;
                case Id.PlantsPlanted: serializer.Serialize(writer, "^PLANTS_PLANTED"); break;
                case Id.PoliceKilled: serializer.Serialize(writer, "^POLICE_KILLED"); break;
                case Id.PredsKilled: serializer.Serialize(writer, "^PREDS_KILLED"); break;
                case Id.QuadsKilled: serializer.Serialize(writer, "^QUADS_KILLED"); break;
                case Id.RareScanned: serializer.Serialize(writer, "^RARE_SCANNED"); break;
                case Id.ResExtracted: serializer.Serialize(writer, "^RES_EXTRACTED"); break;
                case Id.SalvageLooted: serializer.Serialize(writer, "^SALVAGE_LOOTED"); break;
                case Id.SentinelKills: serializer.Serialize(writer, "^SENTINEL_KILLS"); break;
                case Id.ShipsBought: serializer.Serialize(writer, "^SHIPS_BOUGHT"); break;
                case Id.SpaceBattles: serializer.Serialize(writer, "^SPACE_BATTLES"); break;
                case Id.StationVisited: serializer.Serialize(writer, "^STATION_VISITED"); break;
                case Id.TdoneMissions: serializer.Serialize(writer, "^TDONE_MISSIONS"); break;
                case Id.TechBought: serializer.Serialize(writer, "^TECH_BOUGHT"); break;
                case Id.TgdoneMissions: serializer.Serialize(writer, "^TGDONE_MISSIONS"); break;
                case Id.TguildStand: serializer.Serialize(writer, "^TGUILD_STAND"); break;
                case Id.Time: serializer.Serialize(writer, "^TIME"); break;
                case Id.TimesInSpace: serializer.Serialize(writer, "^TIMES_IN_SPACE"); break;
                case Id.TraStanding: serializer.Serialize(writer, "^TRA_STANDING"); break;
                case Id.TseenSystems: serializer.Serialize(writer, "^TSEEN_SYSTEMS"); break;
                case Id.Tutorial: serializer.Serialize(writer, "^TUTORIAL"); break;
                case Id.TwordsLearnt: serializer.Serialize(writer, "^TWORDS_LEARNT"); break;
                case Id.VisitExtBase: serializer.Serialize(writer, "^VISIT_EXT_BASE"); break;
                case Id.WalkersKilled: serializer.Serialize(writer, "^WALKERS_KILLED"); break;
                case Id.WarStanding: serializer.Serialize(writer, "^WAR_STANDING"); break;
                case Id.WdoneMissions: serializer.Serialize(writer, "^WDONE_MISSIONS"); break;
                case Id.WgdoneMissions: serializer.Serialize(writer, "^WGDONE_MISSIONS"); break;
                case Id.WguildStand: serializer.Serialize(writer, "^WGUILD_STAND"); break;
                case Id.WordsLearnt: serializer.Serialize(writer, "^WORDS_LEARNT"); break;
                case Id.WseenSystems: serializer.Serialize(writer, "^WSEEN_SYSTEMS"); break;
                case Id.WwordsLearnt: serializer.Serialize(writer, "^WWORDS_LEARNT"); break;
            }
        }
    }

    static class TeleporterTypeExtensions
    {
        public static TeleporterType? ValueForString(string str)
        {
            switch (str)
            {
                case "Base": return TeleporterType.Base;
                case "Spacestation": return TeleporterType.Spacestation;
                default: return null;
            }
        }

        public static TeleporterType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this TeleporterType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case TeleporterType.Base: serializer.Serialize(writer, "Base"); break;
                case TeleporterType.Spacestation: serializer.Serialize(writer, "Spacestation"); break;
            }
        }
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
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
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

    public partial struct Chest10LayoutSeedUnion
    {
        public Chest10LayoutSeedUnion(JsonReader reader, JsonSerializer serializer)
        {
            Bool = null;
            Enum = null;

            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    Bool = serializer.Deserialize<bool>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    Enum = serializer.Deserialize<SeedEnum>(reader);
                    return;
            }
            throw new Exception("Cannot convert Chest10LayoutSeedUnion");
        }

        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (Bool != null)
            {
                serializer.Serialize(writer, Bool);
                return;
            }
            if (Enum != null)
            {
                serializer.Serialize(writer, Enum);
                return;
            }
            throw new Exception("Union must not be null");
        }
    }

    public partial struct CurrentFreighterSeed
    {
        public CurrentFreighterSeed(JsonReader reader, JsonSerializer serializer)
        {
            Bool = null;
            String = null;

            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    Bool = serializer.Deserialize<bool>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    return;
            }
            throw new Exception("Cannot convert CurrentFreighterSeed");
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
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, NMS_GateCollector.Converter.Settings);
    }

    internal class Converter: JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Dt) || t == typeof(Lid) || t == typeof(Ptk) || t == typeof(InventoryClass) || t == typeof(InventoryType) || t == typeof(SeedEnum) || t == typeof(AltId) || t == typeof(MissionId) || t == typeof(ParticipantTypeParticipantType) || t == typeof(GroupId) || t == typeof(Id) || t == typeof(TeleporterType) || t == typeof(Ua) || t == typeof(GalacticAddress) || t == typeof(Chest10LayoutSeedUnion) || t == typeof(CurrentFreighterSeed) || t == typeof(Dt?) || t == typeof(Lid?) || t == typeof(Ptk?) || t == typeof(InventoryClass?) || t == typeof(InventoryType?) || t == typeof(SeedEnum?) || t == typeof(AltId?) || t == typeof(MissionId?) || t == typeof(ParticipantTypeParticipantType?) || t == typeof(GroupId?) || t == typeof(Id?) || t == typeof(TeleporterType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (t == typeof(Dt))
                return DtExtensions.ReadJson(reader, serializer);
            if (t == typeof(Lid))
                return LidExtensions.ReadJson(reader, serializer);
            if (t == typeof(Ptk))
                return PtkExtensions.ReadJson(reader, serializer);
            if (t == typeof(InventoryClass))
                return InventoryClassExtensions.ReadJson(reader, serializer);
            if (t == typeof(InventoryType))
                return InventoryTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(SeedEnum))
                return SeedEnumExtensions.ReadJson(reader, serializer);
            if (t == typeof(AltId))
                return AltIdExtensions.ReadJson(reader, serializer);
            if (t == typeof(MissionId))
                return MissionIdExtensions.ReadJson(reader, serializer);
            if (t == typeof(ParticipantTypeParticipantType))
                return ParticipantTypeParticipantTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(GroupId))
                return GroupIdExtensions.ReadJson(reader, serializer);
            if (t == typeof(Id))
                return IdExtensions.ReadJson(reader, serializer);
            if (t == typeof(TeleporterType))
                return TeleporterTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(Dt?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return DtExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Lid?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return LidExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Ptk?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return PtkExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(InventoryClass?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return InventoryClassExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(InventoryType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return InventoryTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(SeedEnum?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return SeedEnumExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(AltId?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return AltIdExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(MissionId?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return MissionIdExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(ParticipantTypeParticipantType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ParticipantTypeParticipantTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(GroupId?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return GroupIdExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Id?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return IdExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(TeleporterType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return TeleporterTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Ua))
                return new Ua(reader, serializer);
            if (t == typeof(GalacticAddress))
                return new GalacticAddress(reader, serializer);
            if (t == typeof(Chest10LayoutSeedUnion))
                return new Chest10LayoutSeedUnion(reader, serializer);
            if (t == typeof(CurrentFreighterSeed))
                return new CurrentFreighterSeed(reader, serializer);
            throw new Exception("Unknown type");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var t = value.GetType();
            if (t == typeof(Dt))
            {
                ((Dt)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Lid))
            {
                ((Lid)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Ptk))
            {
                ((Ptk)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(InventoryClass))
            {
                ((InventoryClass)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(InventoryType))
            {
                ((InventoryType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(SeedEnum))
            {
                ((SeedEnum)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(AltId))
            {
                ((AltId)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(MissionId))
            {
                ((MissionId)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(ParticipantTypeParticipantType))
            {
                ((ParticipantTypeParticipantType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(GroupId))
            {
                ((GroupId)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Id))
            {
                ((Id)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(TeleporterType))
            {
                ((TeleporterType)value).WriteJson(writer, serializer);
                return;
            }
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
            if (t == typeof(Chest10LayoutSeedUnion))
            {
                ((Chest10LayoutSeedUnion)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(CurrentFreighterSeed))
            {
                ((CurrentFreighterSeed)value).WriteJson(writer, serializer);
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
