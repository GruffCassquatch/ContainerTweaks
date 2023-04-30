using HarmonyLib;
using Il2Cpp;

namespace ContainerTweaks
{
    class Patches
    {
        [HarmonyPatch(typeof(Container), "Awake")]
        internal class Container_Awake
        {
            private static void Postfix(Container __instance)
            {
                // Glove Box 1
                if (__instance.name.Contains("CarSedanGloveBox_Prefab")) __instance.m_CapacityKG = Settings.settings.gloveBoxCapacity;

                // Trunk (Car)
                else if (__instance.name.Contains("CarSedanTrunkDoor_Prefab")) __instance.m_CapacityKG = Settings.settings.carTrunkCapacity;

                // Glove Box 2
                else if (__instance.name.Contains("CarTruckGloveBox_Prefab")) __instance.m_CapacityKG = Settings.settings.gloveBoxCapacity;

                // Backpack
                if (__instance.name.Contains("CONTAINER_BackPack")) __instance.m_CapacityKG = Settings.settings.backpackCapacity;

                // Large Cabinet 1
                else if (__instance.name.Contains("CONTAINER_BathroomCabinet")) __instance.m_CapacityKG = Settings.settings.cabinetLgeCapacity;

                // Briefcase
                else if (__instance.name.Contains("CONTAINER_Briefcase")) __instance.m_CapacityKG = Settings.settings.briefcaseCapacity;

                // Hidden Cache
                else if (__instance.name.Contains("CONTAINER_CacheStoreCommon")) __instance.m_CapacityKG = Settings.settings.hiddenCacheCapacity;

                // Plastic Container 1
                else if (__instance.name.Contains("CONTAINER_CacheStoreRare")) __instance.m_CapacityKG = Settings.settings.plasticContainerCapacity;

                // Coal Bin
                else if (__instance.name.Contains("CONTAINER_CoalBin")) __instance.m_CapacityKG = Settings.settings.coalBinCapacity;

                // Cooler
                else if (__instance.name.Contains("CONTAINER_Cooler")) __instance.m_CapacityKG = Settings.settings.coolerCapacity;

                // Dryer
                else if (__instance.name.Contains("CONTAINER_Dryer")) __instance.m_CapacityKG = Settings.settings.dryerCapacity;

                // Firewood Bin
                else if (__instance.name.Contains("CONTAINER_FirewoodBin")) __instance.m_CapacityKG = Settings.settings.firewoodBinCapacity;

                // First Aid Kit
                else if (__instance.name.Contains("CONTAINER_FirstAidKit")) __instance.m_CapacityKG = Settings.settings.firstAidCapacity;

                // Gun Locker
                else if (__instance.name.Contains("CONTAINER_StorageGunLocker")) __instance.m_CapacityKG = Settings.settings.gunLockerCapacity;

                // Supply Bin
                else if (__instance.name.Contains("CONTAINER_ForestryCrate")) __instance.m_CapacityKG = Settings.settings.supplyBinCapacity;

                // Large Cabinet
                else if ( __instance.name.Contains("CONTAINER_LargeCabinet")) __instance.m_CapacityKG = Settings.settings.cabinetLgeCapacity;

                // Trunk (Box) 1
                else if (__instance.name.Contains("CONTAINER_LilysChest")) __instance.m_CapacityKG = Settings.settings.trunkCapacity;

                // Lock Box
                else if (__instance.name.Contains("CONTAINER_LockBoxB")) __instance.m_CapacityKG = Settings.settings.lockBoxCapacity;

                // Locker 1
                else if (__instance.name.Contains("CONTAINER_LockerA")) __instance.m_CapacityKG = Settings.settings.lockerCapacity;

                //Medicine Shelf
                else if (__instance.name.Contains("CONTAINER_MedicineShelf")) __instance.m_CapacityKG = Settings.settings.medicineShelfCapacity;

                // Metal Box
                else if (__instance.name.Contains("CONTAINER_MetalBox")) __instance.m_CapacityKG = Settings.settings.metalContainerCapacity;

                // Locker 2
                else if (__instance.name.Contains("CONTAINER_MetalLocker")) __instance.m_CapacityKG = Settings.settings.lockerCapacity;

                //Plastic Container
                else if (__instance.name.Contains("CONTAINER_PlasticBox")) __instance.m_CapacityKG = Settings.settings.plasticContainerCapacity;

                // Safe
                else if (__instance.name.Contains("CONTAINER_Safe")) __instance.m_CapacityKG = Settings.settings.safeCapacity;

                // Small Cabinet 1
                else if (__instance.name.Contains("CONTAINER_SmallCabinet")) __instance.m_CapacityKG = Settings.settings.cabinetSmlCapacity;

                // Trunk (Box)
                else if (__instance.name.Contains("CONTAINER_SteamerTrunk")) __instance.m_CapacityKG = Settings.settings.trunkCapacity;

                // Hatch
                else if (__instance.name.Contains("CONTAINER_StoneCabinATrapDoor")) __instance.m_CapacityKG = Settings.settings.hatchCapacity;

                // Trash Can
                else if (__instance.name.Contains("CONTAINER_TrashCanister")) __instance.m_CapacityKG = Settings.settings.trashCanCapacity;

                // Washer
                else if (__instance.name.Contains("CONTAINER_Washer")) __instance.m_CapacityKG = Settings.settings.washerCapacity;

                // Rock Cache
                else if (__instance.name.Contains("GEAR_RockCache_Prefab")) __instance.m_CapacityKG = Settings.settings.rockCacheCapacity;

                // Cargo Container
                else if (__instance.name.Contains("OBJ_CargoCrateBottomDoor")) __instance.m_CapacityKG = Settings.settings.cargoContainerCapacity;
                else if (__instance.name.Contains("OBJ_CargoCrateTopDoor")) __instance.m_CapacityKG = Settings.settings.cargoContainerCapacity;

                // Cash Register
                else if (__instance.name.Contains("OBJ_CashRegisterDrawer")) __instance.m_CapacityKG = Settings.settings.cashRegisterCapacity;

                // Dresser Drawer
                else if (__instance.name.Contains("OBJ_DresserDrawer")) __instance.m_CapacityKG = Settings.settings.dresserDrawerCapacity;
                else if (__instance.name.Contains("OBJ_DresserTallDrawer")) __instance.m_CapacityKG = Settings.settings.dresserDrawerCapacity;

                // Side Table Drawer
                else if (__instance.name.Contains("OBJ_EndTableDrawer")) __instance.m_CapacityKG = Settings.settings.endTableDrawerCapacity;

                // Cupboard
                else if (__instance.name.Contains("OBJ_CupboardDoor")) __instance.m_CapacityKG = Settings.settings.cupboardCapacity;

                // Fishing Hut Cupboard
                else if (__instance.name.Contains("OBJ_FishingCabinCupboardDoor")) __instance.m_CapacityKG = Settings.settings.cupboardCapacity;

                // Fishing Hut Drawers
                else if (__instance.name.Contains("OBJ_FishingCabinDresserDrawer")) __instance.m_CapacityKG = Settings.settings.fishingHutDrawerCapacity;

                // Fridge
                else if (__instance.name.Contains("OBJ_FridgeBottomDoor")) __instance.m_CapacityKG = Settings.settings.fridgeCapacity;

                // Freezer
                else if (__instance.name.Contains("OBJ_FridgeTopDoor")) __instance.m_CapacityKG = Settings.settings.freezerCapacity;

                // Infirmary Drawers
                else if (__instance.name.Contains("OBJ_InfirmaryDrawer")) __instance.m_CapacityKG = Settings.settings.infirmaryDrawerCapacity;

                // Oven
                else if (__instance.name.Contains("OBJ_GasOvenDoor")) __instance.m_CapacityKG = Settings.settings.ovenCapacity;

                // Kitchen Cabinet
                else if (__instance.name.Contains("OBJ_KitchenCabinetDoor")) __instance.m_CapacityKG = Settings.settings.kitchenCabinetCapacity;

                // Kitchen Drawer
                else if (__instance.name.Contains("OBJ_KitchenDrawer")) __instance.m_CapacityKG = Settings.settings.kitchenDrawerCapacity;

                // Metal Desk Drawer Large
                else if (__instance.name.Contains("OBJ_MetalDeskDrawer1"))  __instance.m_CapacityKG = Settings.settings.deskDrawerLgeCapacity;
                else if (__instance.name.Contains("OBJ_MetalDeskDrawer4")) __instance.m_CapacityKG = Settings.settings.deskDrawerLgeCapacity;

                // Metal Desk Drawer Small
                else if (__instance.name.Contains("OBJ_MetalDeskDrawer2")) __instance.m_CapacityKG = Settings.settings.deskDrawerSmlCapacity;
                else if (__instance.name.Contains("OBJ_MetalDeskDrawer3")) __instance.m_CapacityKG = Settings.settings.deskDrawerSmlCapacity;

                // File Cabinet
                else if (__instance.name.Contains("OBJ_MetalFileCabinetDrawer")) __instance.m_CapacityKG = Settings.settings.fileCabinetCapacity;

                // Workbench Drawer
                else if (__instance.name.Contains("OBJ_WorkBenchDrawer")) __instance.m_CapacityKG = Settings.settings.workbenchDrawerCapacity;
                
                // Locker 3
                else if (__instance.name.Contains("OBJ_MetalLockerDoor")) __instance.m_CapacityKG = Settings.settings.lockerCapacity;
                
                // Small Cabinet 2
                else if (__instance.name.Contains("OBJ_SmallCabinetDoor")) __instance.m_CapacityKG = Settings.settings.cabinetSmlCapacity;

                // Suitcase
                else if (__instance.name.Contains("OBJ_Suitcase")) __instance.m_CapacityKG = Settings.settings.suitcaseCapacity;

                // Tool Cabinet Drawers
                else if (__instance.name.Contains("OBJ_ToolCabinetDrawer"))
                {
                    if (__instance.name.Contains("OBJ_ToolCabinetDrawerE")) __instance.m_CapacityKG = Settings.settings.toolCabinetDrawerLgeCapacity;
                    else __instance.m_CapacityKG = Settings.settings.toolCabinetDrawerSmlCapacity;
                }

                // Warden Desk
                else if (__instance.name.Contains("OBJ_WardenDesk")) __instance.m_CapacityKG = Settings.settings.wardenDeskDrawerCapacity;

                // Wood Desk Drawer
                else if (__instance.name.Contains("OBJ_TrailerInteriorDeskDrawerLg_Prefab")) __instance.m_CapacityKG = Settings.settings.woodDeskDrawerCapacity;

                // Safety Deposit Box
                else if (__instance.name.Contains("STR_BankAVaultDepositBox")) __instance.m_CapacityKG = Settings.settings.safetyDepositBoxCapacity;
            }
        }
    }
}
