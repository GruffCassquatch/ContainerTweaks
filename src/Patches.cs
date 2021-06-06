using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmony;
using UnityEngine;

namespace ContainerTweaks
{
    class Patches
    {
        [HarmonyPatch(typeof(Container), "Awake")]
        internal class Container_Awake
        {
            private static void Postfix(Container __instance)
            {
                if (__instance.m_DisplayName == "Backpack") __instance.m_CapacityKG = Settings.settings.backpackCapacity;
                else if (__instance.m_DisplayName == "Briefcase") __instance.m_CapacityKG = Settings.settings.briefcaseCapacity;

                else if (__instance.m_DisplayName == "Cabinet")
                {
                    if (__instance.name == "CONTAINER_SmallCabinetA" || __instance.name == "OBJ_SmallCabinetDoorLeft") __instance.m_CapacityKG = Settings.settings.cabinetSmlCapacity;

                    if (__instance.name == "OBJ_KitchenCabinetDoorA" || __instance.name == "OBJ_KitchenCabinetDoorB" || __instance.name == "OBJ_KitchenCabinetDoorC" || __instance.name == "OBJ_KitchenCabinetDoorD")
                        __instance.m_CapacityKG = Settings.settings.kitchenCabinetCapacity;
                }
                else if (__instance.m_DisplayName == "Cabinet Door") __instance.m_CapacityKG = Settings.settings.cabinetLgeCapacity;
                else if (__instance.m_DisplayName == "Cargo Container") __instance.m_CapacityKG = Settings.settings.cargoContainerCapacity;
                else if (__instance.m_DisplayName == "Coal Bin") __instance.m_CapacityKG = Settings.settings.coalBinCapacity;
                else if (__instance.m_DisplayName == "Cooler") __instance.m_CapacityKG = Settings.settings.coolerCapacity;
                else if (__instance.m_DisplayName == "Cupboard") __instance.m_CapacityKG = Settings.settings.cupboardCapacity;

                else if (__instance.m_DisplayName == "Drawer")
                {
                    if (__instance.name == "OBJ_MetalDeskDrawer1" || __instance.name == "OBJ_MetalDeskDrawer4")  __instance.m_CapacityKG = Settings.settings.deskDrawerLgeCapacity;
                    else if (__instance.name == "OBJ_MetalDeskDrawer2" || __instance.name == "OBJ_MetalDeskDrawer3") __instance.m_CapacityKG = Settings.settings.deskDrawerSmlCapacity;
                    else if (__instance.name == "OBJ_FishingCabinDresserDrawerA" || __instance.name == "OBJ_FishingCabinDresserDrawerB") __instance.m_CapacityKG = Settings.settings.fishingHutDrawerCapacity;
                    else if (__instance.name == "OBJ_WorkBenchDrawer") __instance.m_CapacityKG = Settings.settings.workbenchDrawerCapacity;
                    else if (__instance.name == "OBJ_EndTableDrawer") __instance.m_CapacityKG = Settings.settings.endTableDrawerCapacity;
                    else if (__instance.name == "OBJ_DresserDrawerA" || __instance.name == "OBJ_DresserDrawerB" || __instance.name == "OBJ_DresserDrawerC" || __instance.name == "OBJ_DresserDrawerD" || __instance.name == "OBJ_DresserDrawerE" || __instance.name == "OBJ_DresserDrawerF" || __instance.name == "OBJ_DresserTallDrawerA" || __instance.name == "OBJ_DresserTallDrawerB" || __instance.name == "OBJ_DresserTallDrawerC" || __instance.name == "OBJ_DresserTallDrawerD"  || __instance.name == "OBJ_DresserTallDrawerE") 
                        __instance.m_CapacityKG = Settings.settings.dresserDrawerCapacity;
                    else if (__instance.name == "OBJ_ToolCabinetDrawerA" || __instance.name == "OBJ_ToolCabinetDrawerB" || __instance.name == "OBJ_ToolCabinetDrawerC" || __instance.name == "OBJ_ToolCabinetDrawerD" || __instance.name == "OBJ_ToolCabinetDrawerE")
                        __instance.m_CapacityKG = Settings.settings.toolCabinetDrawerSmlCapacity;
                    else if (__instance.name == "OBJ_ToolCabinetDrawerE") __instance.m_CapacityKG = Settings.settings.toolCabinetDrawerLgeCapacity;
                    else if (__instance.name == "OBJ_TrailerInteriorDeskDrawerLg_Prefab") __instance.m_CapacityKG = Settings.settings.woodDeskDrawerCapacity;
                }
                else if (__instance.m_DisplayName == "Dryer") __instance.m_CapacityKG = Settings.settings.dryerCapacity;
                else if (__instance.m_DisplayName == "File Cabinet") __instance.m_CapacityKG = Settings.settings.fileCabinetCapacity;
                else if (__instance.m_DisplayName == "Firewood Bin") __instance.m_CapacityKG = Settings.settings.firewoodBinCapacity;
                else if (__instance.m_DisplayName == "First Aid Kit") __instance.m_CapacityKG = Settings.settings.firstAidCapacity;
                else if (__instance.m_DisplayName == "Freezer") __instance.m_CapacityKG = Settings.settings.freezerCapacity;
                else if (__instance.m_DisplayName == "Fridge") __instance.m_CapacityKG = Settings.settings.fridgeCapacity;
                else if (__instance.m_DisplayName == "Glove Box") __instance.m_CapacityKG = Settings.settings.gloveBoxCapacity;
                else if (__instance.m_DisplayName == "Hatch") __instance.m_CapacityKG = Settings.settings.hatchCapacity;
                else if (__instance.m_DisplayName == "Hidden Cache") __instance.m_CapacityKG = Settings.settings.hiddenCacheCapacity;
                else if (__instance.m_DisplayName == "Lock Box") __instance.m_CapacityKG = Settings.settings.lockBoxCapacity;
                else if (__instance.m_DisplayName == "Locker") __instance.m_CapacityKG = Settings.settings.lockerCapacity;
                else if (__instance.m_DisplayName == "Medicine Shelf") __instance.m_CapacityKG = Settings.settings.medicineShelfCapacity;
                else if (__instance.m_DisplayName == "Metal Container") __instance.m_CapacityKG = Settings.settings.metalContainerCapacity;
                else if (__instance.m_DisplayName == "Oven") __instance.m_CapacityKG = Settings.settings.ovenCapacity;
                else if (__instance.m_DisplayName == "Plastic Container") __instance.m_CapacityKG = Settings.settings.plasticContainerCapacity;
                else if (__instance.m_DisplayName == "Register") __instance.m_CapacityKG = Settings.settings.cashRegisterCapacity;
                else if (__instance.m_DisplayName == "Rock Cache") __instance.m_CapacityKG = Settings.settings.rockCacheCapacity;
                else if (__instance.m_DisplayName == "Safe") __instance.m_CapacityKG = Settings.settings.safeCapacity;
                else if (__instance.m_DisplayName == "Safety Deposit Box") __instance.m_CapacityKG = Settings.settings.safetyDepositBoxCapacity;
                else if (__instance.m_DisplayName == "Suitcase") __instance.m_CapacityKG = Settings.settings.suitcaseCapacity;
                else if (__instance.m_DisplayName == "Supply Bin") __instance.m_CapacityKG = Settings.settings.supplyBinCapacity;
                else if (__instance.m_DisplayName == "Trash Can") __instance.m_CapacityKG = Settings.settings.trashCanCapacity;
                else if (__instance.m_DisplayName == "Trunk") __instance.m_CapacityKG = Settings.settings.trunkCapacity;
                else if (__instance.m_DisplayName == "Washer") __instance.m_CapacityKG = Settings.settings.washerCapacity;
                
                //else __instance.m_CapacityKG = __instance.m_CapacityKG* 2;
            }
        }
    }
}
