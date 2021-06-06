using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModSettings;

namespace ContainerTweaks
{
    class ContainerTweaksSettings : JsonModSettings
    {
        [Name("Backpack")]
        [Description("Default is 15 kg")]
        [Slider(0f, 30f, 31, NumberFormat = "{0:0.##} kg")]
        public float backpackCapacity = 15;

        [Name("Briefcase")]
        [Description("Default is 10 kg")]
        [Slider(0f, 30f, 31, NumberFormat = "{0:0.##} kg")]
        public float briefcaseCapacity = 10;

        [Name("Cabinet (Small)")]
        [Description("Default is 20 kg")]
        [Slider(0f, 50f, 51, NumberFormat = "{0:0.##} kg")]
        public float cabinetSmlCapacity = 20;

        [Name("Cabinet (Large)")]
        [Description("Default is 40 kg")]
        [Slider(0f, 200f, 201, NumberFormat = "{0:0.##} kg")]
        public float cabinetLgeCapacity = 40;

        [Name("Cargo Container")]
        [Description("Default is 30 kg")]
        [Slider(0f, 250f, 251, NumberFormat = "{0:0.##} kg")]
        public float cargoContainerCapacity = 30;

        [Name("Cash Register")]
        [Description("Default is 5 kg")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##} kg")]
        public float cashRegisterCapacity = 5;

        [Name("Coal Bin")]
        [Description("Default is 60 kg")]
        [Slider(0f, 250f, 251, NumberFormat = "{0:0.##} kg")]
        public float coalBinCapacity = 60;

        [Name("Cooler")]
        [Description("Default is 20 kg")]
        [Slider(0f, 150f, 151, NumberFormat = "{0:0.##} kg")]
        public float coolerCapacity = 20;

        [Name("Cupboard")]
        [Description("Default is 15 kg")]
        [Slider(0f, 50f, 51, NumberFormat = "{0:0.##} kg")]
        public float cupboardCapacity = 15;

        [Name("Dresser Drawer")]
        [Description("Default is 5 kg")]
        [Slider(0f, 50f, 51, NumberFormat = "{0:0.##} kg")]
        public float dresserDrawerCapacity = 5;

        [Name("Dryer")]
        [Description("Default is 30 kg")]
        [Slider(0f, 500f, 501, NumberFormat = "{0:0.##} kg")]
        public float dryerCapacity = 30;

        [Name("File Cabinet")]
        [Description("Default is 10 kg")]
        [Slider(0f, 50f, 51, NumberFormat = "{0:0.##} kg")]
        public float fileCabinetCapacity = 10;

        [Name("First Aid Kit")]
        [Description("Default is 5 kg")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##} kg")]
        public float firstAidCapacity = 5;

        [Name("Firewood Bin")]
        [Description("Default is 30 kg")]
        [Slider(0f, 500f, 501, NumberFormat = "{0:0.##} kg")]
        public float firewoodBinCapacity = 30;

        [Name("Fishing Hut Drawer")]
        [Description("Default is 10 kg")]
        [Slider(0f, 50f, 51, NumberFormat = "{0:0.##} kg")]
        public float fishingHutDrawerCapacity = 10;

        [Name("Freezer")]
        [Description("Default is 20 kg")]
        [Slider(0f, 100f, 101, NumberFormat = "{0:0.##} kg")]
        public float freezerCapacity = 20;

        [Name("Fridge")]
        [Description("Default is 40 kg")]
        [Slider(0f, 200f, 201, NumberFormat = "{0:0.##} kg")]
        public float fridgeCapacity = 40;

        [Name("Glove Box")]
        [Description("Default is 5 kg")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##} kg")]
        public float gloveBoxCapacity = 5;

        [Name("Hatch")]
        [Description("Default is 40 kg")]
        [Slider(0f, 250f, 251, NumberFormat = "{0:0.##} kg")]
        public float hatchCapacity = 40;

        [Name("Hidden Cache")]
        [Description("Default is 15 kg")]
        [Slider(0f, 50f, 51, NumberFormat = "{0:0.##} kg")]
        public float hiddenCacheCapacity = 15;

        [Name("Kitchen Cabinet")]
        [Description("Default is 15 kg")]
        [Slider(0f, 50f, 51, NumberFormat = "{0:0.##} kg")]
        public float kitchenCabinetCapacity = 15;

        [Name("Lock Box")]
        [Description("Default is 10 kg")]
        [Slider(0f, 50f, 51, NumberFormat = "{0:0.##} kg")]
        public float lockBoxCapacity = 10;

        [Name("Locker")]
        [Description("Default is 30 kg")]
        [Slider(0f, 100f, 101, NumberFormat = "{0:0.##} kg")]
        public float lockerCapacity = 30;

        [Name("Medicine Shelf")]
        [Description("Default is 5 kg")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##} kg")]
        public float medicineShelfCapacity = 5;

        [Name("Metal Desk Drawer (Small)")]
        [Description("Default is 5 kg")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##} kg")]
        public float deskDrawerSmlCapacity = 5;

        [Name("Metal Desk Drawer (Large)")]
        [Description("Default is 10 kg")]
        [Slider(0f, 50f, 51, NumberFormat = "{0:0.##} kg")]
        public float deskDrawerLgeCapacity = 10;

        [Name("Metal Container")]
        [Description("Default is 15 kg")]
        [Slider(0f, 50f, 51, NumberFormat = "{0:0.##} kg")]
        public float metalContainerCapacity = 15;

        [Name("Oven")]
        [Description("Default is 40 kg")]
        [Slider(0f, 100f, 101, NumberFormat = "{0:0.##} kg")]
        public float ovenCapacity = 40;

        [Name("Plastic Container")]
        [Description("Default is 15 kg")]
        [Slider(0f, 30f, 31, NumberFormat = "{0:0.##} kg")]
        public float plasticContainerCapacity = 15;

        [Name("Rock Cache")]
        [Description("Default is 30 kg")]
        [Slider(0f, 100f, 101, NumberFormat = "{0:0.##} kg")]
        public float rockCacheCapacity = 30;

        [Name("Safe")]
        [Description("Default is 10 kg")]
        [Slider(0f, 50f, 51, NumberFormat = "{0:0.##} kg")]
        public float safeCapacity = 10;

        [Name("Safety Deposit Box")]
        [Description("Default is 5 kg")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##} kg")]
        public float safetyDepositBoxCapacity = 5;

        [Name("Side Table Drawer")]
        [Description("Default is 5 kg")]
        [Slider(0f, 50f, 51, NumberFormat = "{0:0.##} kg")]
        public float endTableDrawerCapacity = 5;

        [Name("Supply Bin")]
        [Description("Default is 30 kg")]
        [Slider(0f, 250f, 251, NumberFormat = "{0:0.##} kg")]
        public float supplyBinCapacity = 30;

        [Name("Suitcase")]
        [Description("Default is 20 kg")]
        [Slider(0f, 50f, 51, NumberFormat = "{0:0.##} kg")]
        public float suitcaseCapacity = 20;

        [Name("Tool Cabinet Drawer (Small)")]
        [Description("Default is 5 kg")]
        [Slider(0f, 50f, 51, NumberFormat = "{0:0.##} kg")]
        public float toolCabinetDrawerSmlCapacity = 5;

        [Name("Tool Cabinet Drawer (Large)")]
        [Description("Default is 10 kg")]
        [Slider(0f, 50f, 51, NumberFormat = "{0:0.##} kg")]
        public float toolCabinetDrawerLgeCapacity = 10;

        [Name("Trash Can")]
        [Description("Default is 15 kg")]
        [Slider(0f, 500f, 501, NumberFormat = "{0:0.##} kg")]
        public float trashCanCapacity = 15;

        [Name("Trunk")]
        [Description("Default is 40 kg")]
        [Slider(0f, 500f, 501, NumberFormat = "{0:0.##} kg")]
        public float trunkCapacity = 40;

        [Name("Washer")]
        [Description("Default is 30 kg")]
        [Slider(0f, 500f, 501, NumberFormat = "{0:0.##} kg")]
        public float washerCapacity = 30;

        [Name("Wood Desk Drawer")]
        [Description("Default is 5 kg")]
        [Slider(0f, 50f, 51, NumberFormat = "{0:0.##} kg")]
        public float woodDeskDrawerCapacity = 5;

        [Name("Workbench Drawer")]
        [Description("Default is 5 kg")]
        [Slider(0f, 25f, 26, NumberFormat = "{0:0.##} kg")]
        public float workbenchDrawerCapacity = 5;
    }

    internal static class Settings
    {
        public static ContainerTweaksSettings settings;

        public static void OnLoad()
        {
            settings = new ContainerTweaksSettings();
            settings.AddToModSettings("Container Tweaks");
        }
    }
}
