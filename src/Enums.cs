namespace ChooseStartingGear
{
    // ========================================
    // MOD CONFIGURATION
    // ========================================

    public enum ModFunction
    {
        Default, DefaultPlus, Custom
    }

    public enum Condition
    {
        Random, Custom
    }

    // ========================================
    // CLOTHING ENUMS
    // ========================================

    // Random Clothing (used for randomized gear selection - no "None" option)
    public enum RandomHeadOuter
    {
        GEAR_BaseballCap, GEAR_CottonScarf, GEAR_BasicWoolHat, GEAR_WoolWrapCap, GEAR_WoolWrap, GEAR_RabbitskinHat, GEAR_BasicWoolScarf, GEAR_Toque,
        GEAR_CougarWrap, GEAR_MinersHelmet, GEAR_WolfSkinHat, GEAR_wolfscarf, GEAR_WolfskinCap_MOD
    }

    public enum RandomHeadInner
    {
        GEAR_Balaclava, GEAR_BaseballCap, GEAR_CottonScarf, GEAR_BasicWoolHat, GEAR_WoolWrapCap, GEAR_WoolWrap, GEAR_BasicWoolScarf, GEAR_Toque,
        GEAR_MinersHelmet, GEAR_HatGatorBalaclavaA
    }

    public enum RandomTorsoOuter
    {
        GEAR_BearSkinCoat, GEAR_DownVest, GEAR_PremiumWinterCoat, GEAR_SkiJacket, GEAR_MackinawJacket, GEAR_QualityWinterCoat, GEAR_MilitaryParka, GEAR_MooseHideCloak,
        GEAR_HeavyParka, GEAR_LightParka, GEAR_DownSkiJacket, GEAR_InsulatedVest, GEAR_DownParka, GEAR_BasicWinterCoat, GEAR_WolfSkinCape, GEAR_DeerskinCoat,
        GEAR_MinersJacket, GEAR_TacticalJacket
    }

    public enum RandomTorsoInner
    {
        GEAR_CowichanSweater, GEAR_CottonShirt, GEAR_FishermanSweater, GEAR_CottonHoodie, GEAR_PlaidShirt, GEAR_FleeceSweater, GEAR_HeavyWoolSweater, GEAR_WoolSweater, GEAR_TeeShirt, GEAR_WoolShirt,
        GEAR_TShirtSnappy, GEAR_TShirtGBI, GEAR_TShirtCM, GEAR_SweaterChristmasA, GEAR_JerseyHockeyA
    }

    public enum RandomHands
    {
        GEAR_BasicGloves, GEAR_FleeceMittens, GEAR_Gauntlets, GEAR_RabbitSkinMittens, GEAR_SkiGloves, GEAR_Mittens, GEAR_WorkGloves,
        GEAR_MittenBrownStripe, GEAR_MittenBlueStripe, GEAR_MittenBurgundyPattern, GEAR_TacticalGloves, GEAR_DeerskinGloves_MOD
    }

    public enum RandomAccessoriesInner
    {
        GEAR_MooseHideBag, GEAR_EarMuffs, GEAR_RifleScabbardA, GEAR_Toolbelt, GEAR_ImprovisedDownInsulation
    }

    public enum RandomLegsOuter
    {
        GEAR_CargoPants, GEAR_CombatPants, GEAR_DeerSkinPants, GEAR_Jeans, GEAR_InsulatedPants, GEAR_WorkPants, GEAR_MinersPants, GEAR_WolfSkinPant
    }

    public enum RandomLegsInner
    {
        GEAR_LongUnderwear, GEAR_LongUnderwearWool, GEAR_BearskinLeggings_MOD
    }

    public enum RandomFeetInner
    {
        GEAR_ClimbingSocks, GEAR_CottonSocks, GEAR_WoolSocks, GEAR_SockPlaid, GEAR_SockMoose, GEAR_SockDots
    }

    public enum RandomFeetOuter
    {
        GEAR_CombatBoots, GEAR_DeerSkinBoots, GEAR_InsulatedBoots, GEAR_LeatherShoes, GEAR_GreyMotherBoots, GEAR_MuklukBoots, GEAR_BasicShoes, GEAR_SkiBoots, GEAR_BasicBoots, GEAR_WorkBoots, GEAR_MinersBoots, GEAR_WolfskinBoots_MOD
    }

    // Custom Clothing (used for specific gear selection - includes "None" option)
    public enum HeadOuter
    {
        None, GEAR_BaseballCap, GEAR_CottonScarf, GEAR_BasicWoolHat, GEAR_WoolWrapCap, GEAR_WoolWrap, GEAR_RabbitskinHat, GEAR_BasicWoolScarf, GEAR_Toque,
        GEAR_CougarWrap, GEAR_MinersHelmet, GEAR_WolfSkinHat, GEAR_wolfscarf, GEAR_WolfskinCap_MOD
    }

    public enum HeadInner
    {
        None, GEAR_Balaclava, GEAR_BaseballCap, GEAR_CottonScarf, GEAR_BasicWoolHat, GEAR_WoolWrapCap, GEAR_WoolWrap, GEAR_BasicWoolScarf, GEAR_Toque,
        GEAR_MinersHelmet, GEAR_HatGatorBalaclavaA
    }

    public enum TorsoOuter
    {
        None, GEAR_BearSkinCoat, GEAR_DownVest, GEAR_PremiumWinterCoat, GEAR_SkiJacket, GEAR_MackinawJacket, GEAR_QualityWinterCoat, GEAR_MilitaryParka, GEAR_MooseHideCloak,
        GEAR_HeavyParka, GEAR_LightParka, GEAR_DownSkiJacket, GEAR_InsulatedVest, GEAR_DownParka, GEAR_BasicWinterCoat, GEAR_WolfSkinCape, GEAR_DeerskinCoat,
        GEAR_MinersJacket, GEAR_TacticalJacket    }

    public enum TorsoInner
    {
        None, GEAR_CowichanSweater, GEAR_CottonShirt, GEAR_FishermanSweater, GEAR_CottonHoodie, GEAR_PlaidShirt, GEAR_FleeceSweater,
        GEAR_HeavyWoolSweater, GEAR_WoolSweater, GEAR_TeeShirt, GEAR_WoolShirt,
        GEAR_TShirtSnappy, GEAR_TShirtGBI, GEAR_TShirtCM, GEAR_SweaterChristmasA, GEAR_JerseyHockeyA
    }

    public enum Hands
    {
        None, GEAR_BasicGloves, GEAR_FleeceMittens, GEAR_Gauntlets, GEAR_RabbitSkinMittens, GEAR_SkiGloves, GEAR_Mittens, GEAR_WorkGloves,
        GEAR_MittenBrownStripe, GEAR_MittenBlueStripe, GEAR_MittenBurgundyPattern, GEAR_TacticalGloves, GEAR_DeerskinGloves_MOD
    }

    public enum AccessoriesInner
    {
        None, GEAR_MooseHideBag, GEAR_EarMuffs, GEAR_RifleScabbardA, GEAR_Toolbelt, GEAR_ImprovisedDownInsulation
    }

    public enum AccessoriesOuter
    {
        None, GEAR_Crampons, GEAR_MooseHideBag, GEAR_EarMuffs, GEAR_ImprovisedCrampons, GEAR_RifleScabbardA, GEAR_Toolbelt, GEAR_ImprovisedDownInsulation
    }

    public enum LegsOuter
    {
        None, GEAR_CargoPants, GEAR_CombatPants, GEAR_DeerSkinPants, GEAR_Jeans, GEAR_InsulatedPants, GEAR_WorkPants,
        GEAR_MinersPants, GEAR_WolfSkinPant
    }

    public enum LegsInner
    {
        None, GEAR_LongUnderwear, GEAR_LongUnderwearWool, GEAR_BearskinLeggings_MOD
    }

    public enum FeetInner
    {
        None, GEAR_ClimbingSocks, GEAR_CottonSocks, GEAR_WoolSocks,
        GEAR_SockPlaid, GEAR_SockMoose, GEAR_SockDots
    }

    public enum FeetOuter
    {
        None, GEAR_CombatBoots, GEAR_DeerSkinBoots, GEAR_InsulatedBoots, GEAR_LeatherShoes, GEAR_GreyMotherBoots, GEAR_MuklukBoots, GEAR_BasicShoes, GEAR_SkiBoots,
        GEAR_BasicBoots, GEAR_WorkBoots, GEAR_MinersBoots, GEAR_WolfskinBoots_MOD
    }

    // ========================================
    // FIRE STARTING ENUMS
    // ========================================

    public enum FireStarter
    {
        None, GEAR_PackMatches, GEAR_Firestriker, GEAR_MagnifyingLens, GEAR_WoodMatches
    }

    public enum Tinder
    {
        None, GEAR_BarkTinder, GEAR_CattailTinder, GEAR_Newsprint, GEAR_Tinder
    }

    public enum Fuel
    {
        None, GEAR_Softwood, GEAR_Hardwood, GEAR_Firelog, GEAR_ReclaimedWoodB, GEAR_Stick
    }

    public enum Accelerant
    {
        None, GEAR_Accelerant, GEAR_LampFuel
    }

    // ========================================
    // FOOD AND DRINK ENUMS
    // ========================================

    public enum Food
    {
        None, GEAR_AirlineFoodChick, GEAR_AirlineFoodVeg, GEAR_BeefJerky, GEAR_CandyBar, GEAR_CondensedMilk, GEAR_DogFood, GEAR_EnergyBar, GEAR_GranolaBar, GEAR_KetchupChips, GEAR_MapleSyrup, GEAR_MRE,
        GEAR_PeanutButter, GEAR_PinnacleCanPeaches, GEAR_CannedBeans, GEAR_Crackers, GEAR_CannedSardines, Gear_TomatoSoupCan, GEAR_CookedMeatBear, GEAR_CookedMeatMoose, GEAR_CookedMeatRabbit,
        GEAR_CookedMeatWolf, GEAR_CookedMeatDeer, GEAR_CookedCohoSalmon, Gear_CookedLakeWhitefish, Gear_CookedRainbowTrout, Gear_CookedSmallmouthBass, GEAR_RawMeatBear, GEAR_RawMeatMoose, GEAR_RawMeatRabbit,
        GEAR_RawMeatWolf, GEAR_RawMeatDeer, GEAR_RawCohoSalmon, Gear_RawLakeWhitefish, Gear_RawRainbowTrout, Gear_RawSmallmouthBass,
        GEAR_CannedPineapple, GEAR_DriedApples, GEAR_Pickles, GEAR_Cereal_A, GEAR_CannedCorn, GEAR_CannedHam, GEAR_Carrot, GEAR_Potato, GEAR_CookingOil, GEAR_Salt, GEAR_SaltBag, GEAR_OatsTin, GEAR_Flour,
        GEAR_CookedMeatCougar, GEAR_RawMeatCougar,
        GEAR_RawBurbot, GEAR_RawGoldeye, GEAR_RawRedIrishLord, GEAR_RawRockfish, GEAR_RawSmallMouthBass, GEAR_CookedBurbot, GEAR_CookedGoldeye, GEAR_CookedRedIrishLord, GEAR_CookedRockfish, GEAR_CookedSmallMouthBass
    }

    public enum Drink
    {
        None, GEAR_SodaEnergy, GEAR_SodaGrape, GEAR_SodaOrange, GEAR_Soda, GEAR_Water500ml, GEAR_Water1000ml
    }

    // ========================================
    // TOOLS ENUMS
    // ========================================

    public enum Bedroll
    {
        None, GEAR_BedRoll, GEAR_BearSkinBedRoll, GEAR_BedRoll_Down
    }

    public enum Cooking
    {
        None, GEAR_CookingPot, GEAR_RecycledCan, GEAR_Skillet
    }

    public enum LightSources
    {
        None, GEAR_FlareA, GEAR_Flashlight, GEAR_BlueFlare, GEAR_KeroseneLampB, GEAR_Torch,
        GEAR_KeroseneLamp_Spelunkers, GEAR_Flashlight_LongLasting
    }

    public enum Weapons
    {
        None, GEAR_FlareGun, GEAR_Rifle, GEAR_Revolver, GEAR_Bow,
        GEAR_Rifle_Trader, GEAR_RevolverStubNosed, GEAR_RevolverFancy, GEAR_RevolverGreen, GEAR_Rifle_Barbs, GEAR_Rifle_Curators, GEAR_Rifle_Vaughns,
        GEAR_Bow_Woodwrights, GEAR_Bow_Manufactured, GEAR_Bow_Bushcraft
    }

    public enum ArrowType
    {
        None, GEAR_Arrow, GEAR_ArrowManufactured
    }

    public enum Hatchet
    {
        None, GEAR_Hatchet, GEAR_HatchetImprovised
    }

    public enum Knife
    {
        None, GEAR_Knife, GEAR_KnifeImprovised, GEAR_JeremiahKnife, GEAR_SurvivalKnife, GEAR_CougarClawKnife
    }

    public enum ToolBox
    {
        None, GEAR_HighQualityTools, GEAR_SimpleTools
    }
}
