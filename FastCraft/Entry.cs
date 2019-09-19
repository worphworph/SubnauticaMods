namespace FastCraft
{
    using SMLHelper.V2.Handlers;
    
    public class QPatch
    {
        public static void Patch()
        // RefillOxygenTank / MidGameBatteries - mod compatibility
        {
            if (TechTypeHandler.TryGetModdedTechType("TankRefill", out TechType customTankTechType1))
            {
                 CraftDataHandler.SetCraftingTime(customTankTechType1, 0.01f);
            }
            if (TechTypeHandler.TryGetModdedTechType("DoubleTankRefill", out TechType customTankTechType2))
            {
                CraftDataHandler.SetCraftingTime(customTankTechType2, 0.01f);
            }
            if (TechTypeHandler.TryGetModdedTechType("HighCapacityTankRefill", out TechType customTankTechType3))
            {
                CraftDataHandler.SetCraftingTime(customTankTechType3, 0.01f);
            }
            if (TechTypeHandler.TryGetModdedTechType("PlasteelTankRefill", out TechType customTankTechType4))
            {
                CraftDataHandler.SetCraftingTime(customTankTechType4, 0.01f);
            }
            if (TechTypeHandler.TryGetModdedTechType("DeepBattery", out TechType customTankTechType5))
            {
                CraftDataHandler.SetCraftingTime(customTankTechType5, 0.01f);
            }
            if (TechTypeHandler.TryGetModdedTechType("DeepPowerCell", out TechType customTankTechType6))
            {
                CraftDataHandler.SetCraftingTime(customTankTechType6, 0.01f);
            }
            
                                    
            //Game resources
            CraftDataHandler.SetCraftingTime(TechType.Titanium, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.TitaniumIngot, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.FiberMesh, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Silicone, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Glass, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Bleach, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Lubricant, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.EnameledGlass, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.PlasteelIngot, 0.01f);
            //Advanced materials
            CraftDataHandler.SetCraftingTime(TechType.HydrochloricAcid, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Benzene, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.AramidFibers, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Aerogel, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Polyaniline, 0.01f);
            //Electronics
            CraftDataHandler.SetCraftingTime(TechType.CopperWire, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Battery, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.PowerCell, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.ComputerChip, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.WiringKit, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.AdvancedWiringKit, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.ReactorRod, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.PrecursorIonBattery, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.PrecursorIonPowerCell, 0.01f);
            //Sustenance
            CraftDataHandler.SetCraftingTime(TechType.FilteredWater, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.DisinfectedWater, 0.01f);
            //Cooked Food
            CraftDataHandler.SetCraftingTime(TechType.CookedHoleFish, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CookedPeeper, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CookedBladderfish, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CookedGarryFish, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CookedHoverfish, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CookedReginald, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CookedSpadefish, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CookedBoomerang, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CookedLavaBoomerang, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CookedEyeye, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CookedLavaEyeye, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CookedOculus, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CookedHoopfish, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CookedSpinefish, 0.01f);
            //Cured Food
            CraftDataHandler.SetCraftingTime(TechType.CuredHoleFish, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CuredPeeper, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CuredBladderfish, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CuredGarryFish, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CuredHoverfish, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CuredReginald, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CuredSpadefish, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CuredBoomerang, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CuredLavaBoomerang, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CuredEyeye, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CuredLavaEyeye, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CuredOculus, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CuredHoopfish, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CuredSpinefish, 0.01f);
            //Equipment
            CraftDataHandler.SetCraftingTime(TechType.Tank, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.DoubleTank, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Fins, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.RadiationSuit, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.RadiationGloves, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.RadiationHelmet, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.ReinforcedDiveSuit, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.ReinforcedGloves, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Stillsuit, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.FirstAidKit, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.FireExtinguisher, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Rebreather, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Compass, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Pipe, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.PrecursorKey_Orange, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.PrecursorKey_Purple, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.PrecursorKey_Blue, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.PipeSurfaceFloater, 0.01f);
            //Tools
            CraftDataHandler.SetCraftingTime(TechType.Scanner, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Welder, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Flashlight, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Knife, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.DiveReel, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.AirBladder, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Flare, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Builder, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.LaserCutter, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.StasisRifle, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.PropulsionCannon, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.LEDLight, 0.01f);
            //Deployables
            CraftDataHandler.SetCraftingTime(TechType.Seaglide, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Constructor, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Beacon, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.SmallStorage, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.Gravsphere, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CyclopsDecoy, 0.01f);
            //Modification Station
            CraftDataHandler.SetCraftingTime(TechType.HeatBlade, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.PlasteelTank, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.HighCapacityTank, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.UltraGlideFins, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.SwimChargeFins, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.RepulsionCannon, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CyclopsHullModule2, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CyclopsHullModule3, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.ExoHullModule2, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.VehicleHullModule2, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.VehicleHullModule3, 0.01f);
            //Vehicle Upgrade Console
            CraftDataHandler.SetCraftingTime(TechType.VehicleArmorPlating, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.VehiclePowerUpgradeModule, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.VehicleStorageModule, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.VehicleHullModule1, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.SeamothSolarCharge, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.SeamothElectricalDefense, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.SeamothTorpedoModule, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.SeamothSonarModule, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.ExoHullModule1, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.ExosuitThermalReactorModule, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.ExosuitJetUpgradeModule, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.ExosuitPropulsionArmModule, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.ExosuitGrapplingArmModule, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.ExosuitDrillArmModule, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.ExosuitTorpedoArmModule, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.WhirlpoolTorpedo, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.GasTorpedo, 0.01f);
            //Cyclops Upgrade Fabricator
            CraftDataHandler.SetCraftingTime(TechType.CyclopsHullModule1, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.PowerUpgradeModule, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CyclopsThermalReactorModule, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CyclopsSonarModule, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CyclopsFireSuppressionModule, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CyclopsSeamothRepairModule, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CyclopsDecoyModule, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.CyclopsShieldModule, 0.01f);
            //Scanner Room
            CraftDataHandler.SetCraftingTime(TechType.MapRoomHUDChip, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.MapRoomCamera, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.MapRoomUpgradeScanRange, 0.01f);
            CraftDataHandler.SetCraftingTime(TechType.MapRoomUpgradeScanSpeed, 0.01f);
            
        }
    }
}