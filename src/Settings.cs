using System.Reflection;
using ModSettings;
using static Il2Cpp.FSMHierarchy;

namespace ChooseStartingGear
{

    class ChooseStartingGearSettings : JsonModSettings
    {
        [Section("Starting Gear Redux Options")]
        [Name("Choose starting gear")]
        [Description("GAME DEFAULT: This mod is disabled.\nDEFAULT PLUS: Add items in addition to the default starting gear.\nCUSTOM: Only receive the gear you choose.")]
        [Choice("Game Default", "Default PLUS", "Custom")]
        public ModFunction modFunction = ModFunction.Default;

        // Clothing
        [Section("Clothing")]
        [Name("Show Clothing")]
        [Description("Show/Hide menu. Any selected items WILL be added even if menu is hidden.")]
        public bool clothing = false;

        [Name("Clothing Set")]
        [Description("NO: Choose your own clothing.\nYES: You will get a random set of clothes.")]
        public bool clothingSet = false;

        [Name("Clothing Condition")]
        [Description("RANDOM: All items will have Random condition.\nCUSTOM: Set your own values.")]
        [Choice("Random", "Custom")]
        public Condition clothingCondition = Condition.Random;

        [Section("Head")]
        [Name("Outer Slot Item")]
        [Description("Choose clothing item for this slot")]
        [Choice("None", "Baseball Cap", "Cotton Scarf", "Cotton Toque", "Fleece Cowl", "Long Wool Scarf", "Rabbitskin Hat", "Wool Scarf", "Wool Toque",
                "Cougar Hide Wrap (DLC)", "Miner's Helmet (DLC)", "Wolfskin Hat (DLC)", "Wolf Scarf (MOD)", "Wolfskin Cap (MOD)")]
        public HeadOuter headOuter = HeadOuter.None;

        [Name("    Item Condition")]
        [Description("Default is 100%")]
        [Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
        public float headOuterCondition = 1f;

        [Name("Inner Slot Item")]
        [Description("Choose clothing item for this slot")]
        [Choice("None", "Balaclava", "Baseball Cap", "Cotton Scarf", "Cotton Toque", "Fleece Cowl", "Long Wool Scarf", "Wool Scarf", "Wool Toque",
                "Miner's Helmet (DLC)", "Technical Balaclava (DLC)")]
        public HeadInner headInner = HeadInner.None;

        [Name("    Item Condition")]
        [Description("Default is 100%")]
        [Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
        public float headInnerCondition = 1f;

        [Section("Torso (Outer)")]
        [Name("Outer Slot Item")]
        [Description("Choose clothing item for this slot")]
        [Choice("None", "Bearskin Coat", "Down Vest", "Expedition Parka", "Light Shell", "Mackinaw Jacket", "Mariner's Pea Coat", "Military Coat", "Moose-Hide Cloak",
                "Old Fashioned Parka", "Simple Parka", "Ski Jacket", "Sport Vest", "Urban Parka", "Windbreaker", "Wolfskin Coat", "Deerskin Coat",
                "Miner's Jacket (DLC)", "Tactical Jacket (DLC)")]
        public TorsoOuter torsoOuterOuter = TorsoOuter.None;

        [Name("    Item Condition")]
        [Description("Default is 100%")]
        [Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
        public float torsoOuterOuterCondition = 1f;

        [Name("Inner Slot Item")]
        [Description("Choose clothing item for this slot")]
        [Choice("None", "Bearskin Coat", "Down Vest", "Expedition Parka", "Light Shell", "Mackinaw Jacket", "Mariner's Pea Coat", "Military Coat", "Moose-Hide Cloak",
                "Old Fashioned Parka", "Simple Parka", "Ski Jacket", "Sport Vest", "Urban Parka", "Windbreaker", "Wolfskin Coat", "Deerskin Coat",
                "Miner's Jacket (DLC)", "Tactical Jacket (DLC)")]
        public TorsoOuter torsoOuterInner = TorsoOuter.None;

        [Name("    Item Condition")]
        [Description("Default is 100%")]
        [Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
        public float torsoOuterInnerCondition = 1f;

        [Section("Torso (Inner)")]

        [Name("Outer Slot Item")]
        [Description("Choose clothing item for this slot")]
        [Choice("None", "Cowichan Sweater", "Dress Shirt", "Fisherman's Sweater", "Hoodie", "Plaid Shirt", "Sweatshirt", "Thick Wool Sweater",
                "Thin Wool Sweater", "T-Shirt", "Wool Shirt",
                "Snappy T-Shirt (DLC)", "GBI T-Shirt (DLC)", "CM T-Shirt (DLC)", "Festive Sweater (DLC)", "Hockey Jersey A (DLC)")]
        public TorsoInner torsoInnerOuter = TorsoInner.None;

        [Name("    Item Condition")]
        [Description("Default is 100%")]
        [Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
        public float torsoInnerOuterCondition = 1f;

        [Name("Inner Slot Item")]
        [Description("Choose clothing item for this slot")]
        [Choice("None", "Cowichan Sweater", "Dress Shirt", "Fisherman's Sweater", "Hoodie", "Plaid Shirt", "Sweatshirt", "Thick Wool Sweater",
                "Thin Wool Sweater", "T-Shirt", "Wool Shirt",
                "Snappy T-Shirt (DLC)", "GBI T-Shirt (DLC)", "CM T-Shirt (DLC)", "Festive Sweater (DLC)", "Hockey Jersey A (DLC)")]
        public TorsoInner torsoInnerInner = TorsoInner.None;

        [Name("    Item Condition")]
        [Description("Default is 100%")]
        [Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
        public float torsoInnerInnerCondition = 1f;

        [Section("Hands")]
        [Name("Hands Slot Item")]
        [Description("Choose clothing item for this slot")]
        [Choice("None", "Driving Gloves", "Fleece Mittens", "Gauntlets", "Rabbitskin Mitts", "Ski Gloves", "Wool Mittens", "Work Gloves",
                "Brown Wool Mittens (DLC)", "Blue Wool Mittens (DLC)", "Burgundy Wool Mittens (DLC)", "Tactical Gloves (DLC)", "Deerskin Gloves (MOD)")]
        public Hands hands = Hands.None;

        [Name("    Item Condition")]
        [Description("Default is 100%")]
        [Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
        public float handsCondition = 1f;

        [Section("Accessories")]
        [Name("Outer Slot Item")]
        [Description("Choose clothing item for this slot")]
        [Choice("None", "Crampons", "Moose-Hide Satchel", "Wool Ear Wrap", "Improvised Crampons", "Security Chief's Rifle Holster (DLC)", "Foreman's Toolbelt (DLC)", "Improvised Down Insulation (DLC)")]
        public AccessoriesOuter accessoriesOuter = AccessoriesOuter.None;

        [Name("    Item Condition")]
        [Description("Default is 100%")]
        [Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
        public float accessoriesOuterCondition = 1f;

        [Name("Inner Slot Item")]
        [Description("Choose clothing item for this slot")]
        [Choice("None", "Moose-Hide Satchel", "Wool Ear Wrap", "Security Chief's Rifle Holster (DLC)", "Foreman's Toolbelt (DLC)", "Improvised Down Insulation (DLC)")]
        public AccessoriesInner accessoriesInner = AccessoriesInner.None;

        [Name("    Item Condition")]
        [Description("Default is 100%")]
        [Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
        public float accessoriesInnerCondition = 1f;

        [Section("Legs (Outer)")]
        [Name("Outer Slot Item")]
        [Description("Choose clothing item for this slot")]
        [Choice("None", "Cargo Pants", "Combat Pants", "Deerskin Pants", "Jeans", "Snow Pants", "Work Pants",
                "Miner's Pants (DLC)", "Wolfskin Pants (DLC)")]
        public LegsOuter legsOuterOuter = LegsOuter.None;

        [Name("    Item Condition")]
        [Description("Default is 100%")]
        [Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
        public float legsOuterOuterCondition = 1f;

        [Name("Inner Slot Item")]
        [Description("Choose clothing item for this slot")]
        [Choice("None", "Cargo Pants", "Combat Pants", "Deerskin Pants", "Jeans", "Snow Pants", "Work Pants",
                "Miner's Pants (DLC)", "Wolfskin Pants (DLC)")]
        public LegsOuter legsOuterInner = LegsOuter.None;

        [Name("    Item Condition")]
        [Description("Default is 100%")]
        [Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
        public float legsOuterInnerCondition = 1f;

        [Section("Legs (Inner)")]

        [Name("Outer Slot Item")]
        [Description("Choose clothing item for this slot")]
        [Choice("None", "Thermal Underwear", "Wool Longjohns", "Bearskin Leggings (MOD)")]
        public LegsInner legsInnerOuter = LegsInner.None;

        [Name("    Item Condition")]
        [Description("Default is 100%")]
        [Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
        public float legsInnerOuterCondition = 1f;

        [Name("Inner Slot Item")]
        [Description("Choose clothing item for this slot")]
        [Choice("None", "Thermal Underwear", "Wool Longjohns", "Bearskin Leggings (MOD)")]
        public LegsInner legsInnerInner = LegsInner.None;

        [Name("    Item Condition")]
        [Description("Default is 100%")]
        [Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
        public float legsInnerInnerCondition = 1f;

        [Section("Feet (Inner)")]
        [Name("Outer Slot Item")]
        [Description("Choose clothing item for this slot")]
        [Choice("None", "Climbing Socks", "Sports Socks", "Wool Socks",
                "Plaid Wool Socks (DLC)", "Moose Wool Socks (DLC)", "Dots Wool Socks (DLC)")]
        public FeetInner feetInnerOuter = FeetInner.None;

        [Name("    Item Condition")]
        [Description("Default is 100%")]
        [Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
        public float feetInnerOuterCondition = 1f;

        [Name("Inner Slot Item")]
        [Description("Choose clothing item for this slot")]
        [Choice("None", "Climbing Socks", "Sports Socks", "Wool Socks",
                "Plaid Wool Socks (DLC)", "Moose Wool Socks (DLC)", "Dots Wool Socks (DLC)")]
        public FeetInner feetInnerInner = FeetInner.None;

        [Name("    Item Condition")]
        [Description("Default is 100%")]
        [Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
        public float feetInnerInnerCondition = 1f;

        [Section("Feet (Outer)")]
        [Name("Shoe Slot Item")]
        [Description("Choose clothing item for this slot")]
        [Choice("None", "Combat Boots", "Deerskin Boots", "Insulated Boots", "Leather Shoes", "Mountaineering Boots", "Mukluks", "Running Shoes", "Ski Boots", "Trail Boots", "Work Boots",
                "Miner's Boots (DLC)", "Wolfskin Boots (MOD)")]
        public FeetOuter feetOuter = FeetOuter.None;

        [Name("    Item Condition")]
        [Description("Default is 100%")]
        [Slider(0f, 1f, 101, NumberFormat = "{0:P0}")]
        public float feetOuterCondition = 1f;

        // Fire Starting
        [Section("Fire Starting")]
        [Name("Show Fire Starting")]
        [Description("Show/Hide menu. Any selected items WILL be added even if menu is hidden.")]
        public bool fireStarting = false;

        [Name("Fire Starter")]
        [Choice("None", "Cardboard Matches", "Firestriker", "Magnifying Lens", "Wooden Matches")]
        public FireStarter firestarter = FireStarter.None;

        [Name("    Match Quantity")]
        [Description("Quantity")]
        [Slider(1, 25)]
        public int matchQty = 1;

        [Name("Tinder")]
        [Choice("None", "Birch Bark", "Cat Tail Head", "Newspaper", "Tinder Plug")]
        public Tinder tinderType = Tinder.None;

        [Name("    Tinder Quantity")]
        [Slider(1, 5)]
        public int tinderQty = 1;

        [Name("Fuel")]
        [Choice("None", "Cedar Log", "Fir Log", "Fire Log", "Reclaimed Wood", "Stick")]
        public Fuel fuelType = Fuel.None;

        [Name("    Fuel Quantity")]
        [Slider(1, 5)]
        public int fuelQty = 1;

        [Name("Accelerant")]
        [Choice("None", "Accelerant", "Lamp Fuel")]
        public Accelerant accelerant = Accelerant.None;

        // First Aid
        [Section("First Aid")]
        [Name("Show First Aid")]
        [Description("Show/Hide menu. Any selected items WILL be added even if menu is hidden.")]
        public bool firstAid = false;

        [Name("Antibiotics")]
        [Description("Quantity")]
        [Slider(0, 24)]
        public int antibiotics = 0;

        [Name("Antiseptic")]
        [Description("Quantity")]
        [Slider(0, 5)]
        public int antiseptic = 0;

        [Name("Bandages")]
        [Description("Quantity")]
        [Slider(0, 5)]
        public int bandages = 0;

        [Name("Emergency Stim")]
        [Description("Quantity")]
        [Slider(0, 5)]
        public int emergencyStim = 0;

        [Name("Old Man's Beard Dressing")]
        [Description("Quantity")]
        [Slider(0, 5)]
        public int oldMansBeardDressing = 0;

        [Name("Painkillers")]
        [Description("Quantity")]
        [Slider(0, 24)]
        public int painkillers = 0;

        [Name("Prepared Birch Bark")]
        [Description("Quantity")]
        [Slider(0, 5)]
        public int preparedBirchBark = 0;

        [Name("Prepared Reshi Mushrooms")]
        [Description("Quantity")]
        [Slider(0, 5)]
        public int preparedReshiMushrooms = 0;

        [Name("Prepared Rose Hips")]
        [Description("Quantity")]
        [Slider(0, 5)]
        public int preparedRoseHips = 0;

        [Name("Water Purification Tablets")]
        [Description("Quantity")]
        [Slider(0, 24)]
        public int waterPurificationTablets = 0;

        [Name("Caffeine Pills (DLC)")]
        [Description("Quantity")]
        [Slider(0, 5)]
        public int caffeinePills = 0;

        [Name("Vitamin-C Pills (DLC)")]
        [Description("Quantity")]
        [Slider(0, 5)]
        public int vitaminCPills = 0;

        [Name("Heat Pack (DLC)")]
        [Description("Quantity")]
        [Slider(0, 5)]
        public int heatPad = 0;

        // Food and Drink
        [Section("Food and Drink")]
        [Name("Show Food and Drink")]
        [Description("Show/Hide menu. Any selected items WILL be added even if menu is hidden.")]
        public bool foodDrink = false;

        [Name("Food Item 1")]
        [Choice("None", "Airline Food - Chicken", "Airline Food - Vegetarian", "Beef Jerky", "Candy Bar", "Condensed Milk", "Dog Food", "Energy Bar", "Granola Bar", "Ketchup Chips", "Maple Syrup", "Military-Grade MRE",
                "Peanut Butter", "Pinnacle Peaches", "Pork and Beans", "Salty Crackers", "Tin of Sardines", "Tomato Soup", "Cooked Bear Meat", "Cooked Moose Meat", "Cooked Rabbit Meat", "Cooked Wolf Meat", "Cooked Venison",
                "Cooked Coho Salmon", "Cooked Lake Whitefish", "Cooked Rainbow Trout", "Cooked Smallmouth Bass", "Raw Bear Meat", "Raw Moose Meat", "Raw Rabbit Meat", "Raw Wolf Meat", "Raw Venison",
                "Raw Coho Salmon", "Raw Lake Whitefish", "Raw Rainbow Trout", "Raw Smallmouth Bass",
                "Canned Pineapple (DLC)", "Dried Apples (DLC)", "Pickles (DLC)", "Cereal (DLC)", "Canned Corn (DLC)", "Canned Ham (DLC)", "Carrot (DLC)", "Potato (DLC)", "Cooking Oil (DLC)", "Salt (DLC)", "Salt Bag (DLC)", "Oats Tin (DLC)", "Flour (DLC)",
                "Cooked Meat Cougar (DLC)", "Raw Meat Cougar (DLC)",
                "Raw Burbot (DLC)", "Raw Goldeye (DLC)", "Raw Red Irish Lord (DLC)", "Raw Rockfish (DLC)", "Raw Smallmouth Bass (DLC)", "Cooked Burbot (DLC)", "Cooked Goldeye (DLC)", "Cooked Red Irish Lord (DLC)", "Cooked Rockfish (DLC)", "Cooked Smallmouth Bass (DLC)")]
        public Food food1 = Food.None;

        [Name("Food Item 2")]
        [Choice("None", "Airline Food - Chicken", "Airline Food - Vegetarian", "Beef Jerky", "Candy Bar", "Condensed Milk", "Dog Food", "Energy Bar", "Granola Bar", "Ketchup Chips", "Maple Syrup", "Military-Grade MRE",
                "Peanut Butter", "Pinnacle Peaches", "Pork and Beans", "Salty Crackers", "Tin of Sardines", "Tomato Soup", "Cooked Bear Meat", "Cooked Moose Meat", "Cooked Rabbit Meat", "Cooked Wolf Meat", "Cooked Venison",
                "Cooked Coho Salmon", "Cooked Lake Whitefish", "Cooked Rainbow Trout", "Cooked Smallmouth Bass", "Raw Bear Meat", "Raw Moose Meat", "Raw Rabbit Meat", "Raw Wolf Meat", "Raw Venison",
                "Raw Coho Salmon", "Raw Lake Whitefish", "Raw Rainbow Trout", "Raw Smallmouth Bass",
                "Canned Pineapple (DLC)", "Dried Apples (DLC)", "Pickles (DLC)", "Cereal (DLC)", "Canned Corn (DLC)", "Canned Ham (DLC)", "Carrot (DLC)", "Potato (DLC)", "Cooking Oil (DLC)", "Salt (DLC)", "Salt Bag (DLC)", "Oats Tin (DLC)", "Flour (DLC)",
                "Cooked Meat Cougar (DLC)", "Raw Meat Cougar (DLC)",
                "Raw Burbot (DLC)", "Raw Goldeye (DLC)", "Raw Red Irish Lord (DLC)", "Raw Rockfish (DLC)", "Raw Smallmouth Bass (DLC)", "Cooked Burbot (DLC)", "Cooked Goldeye (DLC)", "Cooked Red Irish Lord (DLC)", "Cooked Rockfish (DLC)", "Cooked Smallmouth Bass (DLC)")]
        public Food food2 = Food.None;

        [Name("Food Item 3")]
        [Choice("None", "Airline Food - Chicken", "Airline Food - Vegetarian", "Beef Jerky", "Candy Bar", "Condensed Milk", "Dog Food", "Energy Bar", "Granola Bar", "Ketchup Chips", "Maple Syrup", "Military-Grade MRE",
                "Peanut Butter", "Pinnacle Peaches", "Pork and Beans", "Salty Crackers", "Tin of Sardines", "Tomato Soup", "Cooked Bear Meat", "Cooked Moose Meat", "Cooked Rabbit Meat", "Cooked Wolf Meat", "Cooked Venison",
                "Cooked Coho Salmon", "Cooked Lake Whitefish", "Cooked Rainbow Trout", "Cooked Smallmouth Bass", "Raw Bear Meat", "Raw Moose Meat", "Raw Rabbit Meat", "Raw Wolf Meat", "Raw Venison",
                "Raw Coho Salmon", "Raw Lake Whitefish", "Raw Rainbow Trout", "Raw Smallmouth Bass",
                "Canned Pineapple (DLC)", "Dried Apples (DLC)", "Pickles (DLC)", "Cereal (DLC)", "Canned Corn (DLC)", "Canned Ham (DLC)", "Carrot (DLC)", "Potato (DLC)", "Cooking Oil (DLC)", "Salt (DLC)", "Salt Bag (DLC)", "Oats Tin (DLC)", "Flour (DLC)",
                "Cooked Meat Cougar (DLC)", "Raw Meat Cougar (DLC)",
                "Raw Burbot (DLC)", "Raw Goldeye (DLC)", "Raw Red Irish Lord (DLC)", "Raw Rockfish (DLC)", "Raw Smallmouth Bass (DLC)", "Cooked Burbot (DLC)", "Cooked Goldeye (DLC)", "Cooked Red Irish Lord (DLC)", "Cooked Rockfish (DLC)", "Cooked Smallmouth Bass (DLC)")]
        public Food food3 = Food.None;

        [Name("Food Item 4")]
        [Choice("None", "Airline Food - Chicken", "Airline Food - Vegetarian", "Beef Jerky", "Candy Bar", "Condensed Milk", "Dog Food", "Energy Bar", "Granola Bar", "Ketchup Chips", "Maple Syrup", "Military-Grade MRE",
                "Peanut Butter", "Pinnacle Peaches", "Pork and Beans", "Salty Crackers", "Tin of Sardines", "Tomato Soup", "Cooked Bear Meat", "Cooked Moose Meat", "Cooked Rabbit Meat", "Cooked Wolf Meat", "Cooked Venison",
                "Cooked Coho Salmon", "Cooked Lake Whitefish", "Cooked Rainbow Trout", "Cooked Smallmouth Bass", "Raw Bear Meat", "Raw Moose Meat", "Raw Rabbit Meat", "Raw Wolf Meat", "Raw Venison",
                "Raw Coho Salmon", "Raw Lake Whitefish", "Raw Rainbow Trout", "Raw Smallmouth Bass",
                "Canned Pineapple (DLC)", "Dried Apples (DLC)", "Pickles (DLC)", "Cereal (DLC)", "Canned Corn (DLC)", "Canned Ham (DLC)", "Carrot (DLC)", "Potato (DLC)", "Cooking Oil (DLC)", "Salt (DLC)", "Salt Bag (DLC)", "Oats Tin (DLC)", "Flour (DLC)",
                "Cooked Meat Cougar (DLC)", "Raw Meat Cougar (DLC)",
                "Raw Burbot (DLC)", "Raw Goldeye (DLC)", "Raw Red Irish Lord (DLC)", "Raw Rockfish (DLC)", "Raw Smallmouth Bass (DLC)", "Cooked Burbot (DLC)", "Cooked Goldeye (DLC)", "Cooked Red Irish Lord (DLC)", "Cooked Rockfish (DLC)", "Cooked Smallmouth Bass (DLC)")]
        public Food food4 = Food.None;

        [Name("Food Item 5")]
        [Choice("None", "Airline Food - Chicken", "Airline Food - Vegetarian", "Beef Jerky", "Candy Bar", "Condensed Milk", "Dog Food", "Energy Bar", "Granola Bar", "Ketchup Chips", "Maple Syrup", "Military-Grade MRE",
                "Peanut Butter", "Pinnacle Peaches", "Pork and Beans", "Salty Crackers", "Tin of Sardines", "Tomato Soup", "Cooked Bear Meat", "Cooked Moose Meat", "Cooked Rabbit Meat", "Cooked Wolf Meat", "Cooked Venison",
                "Cooked Coho Salmon", "Cooked Lake Whitefish", "Cooked Rainbow Trout", "Cooked Smallmouth Bass", "Raw Bear Meat", "Raw Moose Meat", "Raw Rabbit Meat", "Raw Wolf Meat", "Raw Venison",
                "Raw Coho Salmon", "Raw Lake Whitefish", "Raw Rainbow Trout", "Raw Smallmouth Bass",
                "Canned Pineapple (DLC)", "Dried Apples (DLC)", "Pickles (DLC)", "Cereal (DLC)", "Canned Corn (DLC)", "Canned Ham (DLC)", "Carrot (DLC)", "Potato (DLC)", "Cooking Oil (DLC)", "Salt (DLC)", "Salt Bag (DLC)", "Oats Tin (DLC)", "Flour (DLC)",
                "Cooked Meat Cougar (DLC)", "Raw Meat Cougar (DLC)",
                "Raw Burbot (DLC)", "Raw Goldeye (DLC)", "Raw Red Irish Lord (DLC)", "Raw Rockfish (DLC)", "Raw Smallmouth Bass (DLC)", "Cooked Burbot (DLC)", "Cooked Goldeye (DLC)", "Cooked Red Irish Lord (DLC)", "Cooked Rockfish (DLC)", "Cooked Smallmouth Bass (DLC)")]
        public Food food5 = Food.None;

        [Name("Drink Item 1")]
        [Description("If using Better Water Management, add any water using that mod's settings")]
        [Choice("None", "GO! Energy Drink", "Grape Soda", "Orange Soda", "Summit Soda", "Water 0.5L", "Water 1L")]
        public Drink drink1 = Drink.None;

        [Name("Drink Item 2")]
        [Description("If using Better Water Management, add any water using that mod's settings")]
        [Choice("None", "GO! Energy Drink", "Grape Soda", "Orange Soda", "Summit Soda", "Water 0.5L", "Water 1L")]
        public Drink drink2 = Drink.None;

        [Name("Drink Item 3")]
        [Description("If using Better Water Management, add any water using that mod's settings")]
        [Choice("None", "GO! Energy Drink", "Grape Soda", "Orange Soda", "Summit Soda", "Water 0.5L", "Water 1L")]
        public Drink drink3 = Drink.None;

        [Name("Drink Item 4")]
        [Description("If using Better Water Management, add any water using that mod's settings")]
        [Choice("None", "GO! Energy Drink", "Grape Soda", "Orange Soda", "Summit Soda", "Water 0.5L", "Water 1L")]
        public Drink drink4 = Drink.None;

        [Name("Drink Item 5")]
        [Description("If using Better Water Management, add any water using that mod's settings")]
        [Choice("None", "GO! Energy Drink", "Grape Soda", "Orange Soda", "Summit Soda", "Water 0.5L", "Water 1L")]
        public Drink drink5 = Drink.None;

        // Tools
        [Section("Tools")]
        [Name("Show Tools")]
        [Description("Show/Hide menu. Any selected items WILL be added even if menu is hidden.")]
        public bool tools = false;

        [Name("Bedroll")]
        [Choice("None", "Bedroll", "Bearskin Bedroll", "Bedroll Down")]
        public Bedroll bedroll = Bedroll.None;

        [Name("Can Opener")]
        public bool canOpener = false;

        [Name("Cooking Item 1")]
        [Choice("None", "Cooking Pot", "Recycled Can", "Skillet (DLC)")]
        public Cooking cooking1 = Cooking.None;

        [Name("Cooking Item 2")]
        [Choice("None", "Cooking Pot", "Recycled Can", "Skillet (DLC)")]
        public Cooking cooking2 = Cooking.None;

        [Name("Fishing Tackle")]
        [Slider(0, 5)]
        public int fishingTackle = 0;

        [Name("Hacksaw")]
        public bool hacksaw = false;

        [Name("Hatchet")]
        [Choice("None", "Hatchet", "Improvised Hatchet")]
        public Hatchet hatchet = Hatchet.None;

        [Name("Heavy Hammer")]
        public bool heavyHammer = false;

        [Name("Hook")]
        [Slider(0, 5)]
        public int hook = 0;

        [Name("Knife")]
        [Choice("None", "Hunting Knife", "Improvised Knife", "Jeremiah's Knife", "Survival Knife (DLC)", "Cougar Claw Knife (DLC)")]
        public Knife knife = Knife.None;

        [Name("Light Source")]
        [Choice("None", "Flare", "Flashlight", "Marine Flare", "Storm Lantern", "Torch", "Spelunker's Lantern (DLC)", "Miner's Flashlight (DLC)")]
        public LightSources lightSource = LightSources.None;

        [Name("Line")]
        [Slider(0, 5)]
        public int line = 0;

        [Name("Mountaineering Rope")]
        public bool mountaineeringRope = false;

        [Name("Prybar")]
        public bool prybar = false;

        [Name("Rifle Cleaning Kit")]
        public bool rifleCleaningKit = false;

        [Name("Sewing Kit")]
        public bool sewingKit = false;

        [Name("Snare")]
        public bool snare = false;

        [Name("Spray Paint")]
        public bool sprayPaint = false;

        [Name("Tool Box")]
        [Choice("None", "Quality Tools", "Simple Tools")]
        public ToolBox toolBox = ToolBox.None;

        [Name("Weapon")]
        [Choice("None", "Distress Pistol", "Hunting Rifle", "Revolver", "Survival Bow (DLC)", "Bunker Rifle (DLC)", "Warden's Revolver (DLC)", "Forester's Revolver (DLC)", "Hunter's Revolver (DLC)",
                "Barb's Rifle (DLC)", "Curator's Rifle (DLC)", "Vaughn's Rifle (DLC)", "Woodwrioght's Bow (DLC)", "Sport Bow (DLC)", "Bushcraft Bow (DLC)")]
        public Weapons weapon = Weapons.None;

        [Name("Arrow Type")]
        [Choice("None", "Simple Arrow", "Manufactured Arrow (DLC)")]
        public ArrowType arrowType = ArrowType.None;

        [Name("    Ammunition")]
        [Description("Quantity of Ammunition for chosen Weapon")]
        [Slider(0, 25)]
        public int ammunitionQty = 0;

        [Name("Whetstone")]
        public bool whetstone = false;

        // DLC Tools
        [Name("Sticker Flask (DLC)")]
        public bool stickFlask = false;

        [Name("Camera (DLC)")]
        public bool camera = false;

        [Name("FastFilm-500 (DLC)")]
        [Description("Quantity")]
        [Slider(0, 30)]
        public int filmBoxColour = 0;

        [Name("FastFilm-500BW (DLC)")]
        [Description("Quantity")]
        [Slider(0, 30)]
        public int filmBoxBW = 0;

        [Name("FastFilm-500SPA (DLC)")]
        [Description("Quantity")]
        [Slider(0, 30)]
        public int filmBoxSepia = 0;

        [Name("Wires (DLC)")]
        [Description("Quantity")]
        [Slider(0, 10)]
        public int wireBundle = 0;

        [Name("Fuses (DLC)")]
        [Description("Quantity")]
        [Slider(0, 10)]
        public int fuse = 0;

        [Name("Travois (DLC)")]
        public bool travois = false;

        [Name("Handheld Shortwave (DLC)")]
        public bool handheldShortwave = false;

        [Name("Respirator (DLC)")]
        public bool respirator = false;

        [Name("Canister (DLC)")]
        [Description("Quantity")]
        [Slider(0, 5)]
        public int canister = 0;

        // Materials
        [Section("Materials")]
        [Name("Show Materials")]
        [Description("Show/Hide menu. Any selected items WILL be added even if menu is hidden.")]
        public bool materials = false;

        [Section("        Ammunition")]
        [Name("Show Ammunition")]
        [Description("Show/Hide menu. Any selected items WILL be added even if menu is hidden.")]
        public bool ammunition = false;

        [Name("Arrowhead")]
        [Slider(0, 5)]
        public int arrowhead = 0;

        [Name("Arrow Shaft")]
        [Slider(0, 5)]
        public int arrowShaft = 0;

        [Name("Bullet")]
        [Slider(0, 25)]
        public int bullet = 0;

        [Name("Can of Gunpowder")]
        [Slider(0, 5)]
        public int gunpowder = 0;

        [Name("Charcoal")]
        [Slider(0, 5)]
        public int charcoal = 0;

        [Name("Crow Feather")]
        [Slider(0, 15)]
        public int crowFeather = 0;

        [Name("Dusting Sulfur")]
        [Slider(0, 5)]
        public int dustingSulfur = 0;

        [Name("Revolver Shell Casing")]
        [Slider(0, 25)]
        public int revolverShell = 0;

        [Name("Rifle Shell Casing")]
        [Slider(0, 25)]
        public int rifleShell = 0;

        [Name("Scrap Lead")]
        [Slider(0, 5)]
        public int scrapLead = 0;

        [Name("Stump Remover")]
        [Slider(0, 5)]
        public int stumpRemover = 0;

        [Section("        Hides and Gut")]
        [Name("Show Hides and Gut")]
        [Description("Show/Hide menu. Any selected items WILL be added even if menu is hidden.")]
        public bool hides = false;

        [Name("Bear Hide (Cured)")]
        [Slider(0, 5)]
        public int bearHideCured = 0;

        [Name("Bear Hide (Fresh)")]
        [Slider(0, 5)]
        public int bearHideFresh = 0;

        [Name("Deer Hide (Cured)")]
        [Slider(0, 5)]
        public int deerHideCured = 0;

        [Name("Deer Hide (Fresh)")]
        [Slider(0, 5)]
        public int deerHideFresh = 0;

        [Name("Gut (Cured)")]
        [Slider(0, 5)]
        public int gutCured = 0;

        [Name("Gut (Fresh)")]
        [Slider(0, 5)]
        public int gutFresh = 0;

        [Name("Moose Hide (Cured)")]
        [Slider(0, 5)]
        public int mooseHideCured = 0;

        [Name("Moose Hide (Fresh)")]
        [Slider(0, 5)]
        public int mooseHideFresh = 0;

        [Name("Rabbit Pelt (Cured)")]
        [Slider(0, 5)]
        public int rabbitPeltCured = 0;

        [Name("Rabbit Pelt (Fresh)")]
        [Slider(0, 5)]
        public int rabbitPeltFresh = 0;

        [Name("Wolf Pelt (Cured)")]
        [Slider(0, 5)]
        public int wolfPeltCured = 0;

        [Name("Wolf Pelt (Fresh)")]
        [Slider(0, 5)]
        public int wolfPeltFresh = 0;

        [Name("Cougar Pelt (Cured) (DLC)")]
        [Slider(0, 5)]
        public int cougarPeltCured = 0;

        [Name("Cougar Pelt (Fresh) (DLC)")]
        [Slider(0, 5)]
        public int cougarPeltFresh = 0;

        [Name("Cougar Claw (DLC)")]
        [Slider(0, 5)]
        public int cougarClaw = 0;

        [Section("        Saplings")]
        [Name("Show Saplings")]
        [Description("Show/Hide menu. Any selected items WILL be added even if menu is hidden.")]
        public bool saplings = false;

        [Name("Birch Sapling (Cured)")]
        [Slider(0, 5)]
        public int birchSaplingCured = 0;

        [Name("Birch Sapling (Fresh)")]
        [Slider(0, 5)]
        public int birchSaplingFresh = 0;

        [Name("Maple Sapling (Cured)")]
        [Slider(0, 5)]
        public int mapleSaplingCured = 0;

        [Name("Maple Sapling (Fresh)")]
        [Slider(0, 5)]
        public int mapleSaplingFresh = 0;

        [Section("        Other Materials")]
        [Name("Show Other Materials")]
        [Description("Show/Hide menu. Any selected items WILL be added even if menu is hidden.")]
        public bool other = false;

        [Name("Cloth")]
        [Slider(0, 5)]
        public int cloth = 0;

        [Name("Cured Leather")]
        [Slider(0, 5)]
        public int curedLeather = 0;

        [Name("Scrap Metal")]
        [Slider(0, 5)]
        public int scrapMetal = 0;

        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            if (field.Name == nameof(modFunction) ||
                field.Name == nameof(clothing) ||
                field.Name == nameof(clothingSet) ||
                field.Name == nameof(clothingCondition) ||
                field.Name == nameof(headOuter) || field.Name == nameof(headInner) ||
                field.Name == nameof(torsoOuterOuter) || field.Name == nameof(torsoOuterInner) ||
                field.Name == nameof(torsoInnerOuter) || field.Name == nameof(torsoInnerInner) ||
                field.Name == nameof(hands) ||
                field.Name == nameof(accessoriesOuter) || field.Name == nameof(accessoriesInner) ||
                field.Name == nameof(legsOuterOuter) || field.Name == nameof(legsOuterInner) ||
                field.Name == nameof(legsInnerOuter) || field.Name == nameof(legsInnerInner) ||
                field.Name == nameof(feetInnerOuter) || field.Name == nameof(feetInnerInner) ||
                field.Name == nameof(feetOuter) ||
                field.Name == nameof(fireStarting) ||
                field.Name == nameof(firestarter) || field.Name == nameof(tinderType) || field.Name == nameof(fuelType) ||
                field.Name == nameof(firstAid) ||
                field.Name == nameof(foodDrink) ||
                field.Name == nameof(food1) || field.Name == nameof(food2) || field.Name == nameof(food3) || field.Name == nameof(food4) ||
                field.Name == nameof(drink1) || field.Name == nameof(drink2) || field.Name == nameof(drink3) || field.Name == nameof(drink4) ||
                field.Name == nameof(tools) ||
                field.Name == nameof(cooking1) ||
                field.Name == nameof(weapon) ||
                field.Name == nameof(materials) ||
                field.Name == nameof(ammunition) || field.Name == nameof(hides) || field.Name == nameof(saplings) || field.Name == nameof(other))
            {
                RefreshFields();
            }
        }

        internal void RefreshFields()
        {
            // Sections
            SetFieldVisible(nameof(clothing), Settings.settings.modFunction != ModFunction.Default);
            SetFieldVisible(nameof(fireStarting), Settings.settings.modFunction != ModFunction.Default);
            SetFieldVisible(nameof(firstAid), Settings.settings.modFunction != ModFunction.Default);
            SetFieldVisible(nameof(foodDrink), Settings.settings.modFunction != ModFunction.Default);
            SetFieldVisible(nameof(tools), Settings.settings.modFunction != ModFunction.Default);
            SetFieldVisible(nameof(materials), Settings.settings.modFunction != ModFunction.Default);

            // Clothing
            SetFieldVisible(nameof(clothingSet), Settings.settings.modFunction == ModFunction.Custom && clothing);
            SetFieldVisible(nameof(clothingCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(headOuter), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(headOuterCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingCondition == Condition.Custom && headOuter != HeadOuter.None && clothingSet == false);
            SetFieldVisible(nameof(headInner), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(headInnerCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingCondition == Condition.Custom && headInner != HeadInner.None && clothingSet == false);

            SetFieldVisible(nameof(torsoOuterOuter), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(torsoOuterOuterCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingCondition == Condition.Custom && torsoOuterOuter != TorsoOuter.None && clothingSet == false);
            SetFieldVisible(nameof(torsoOuterInner), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(torsoOuterInnerCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingCondition == Condition.Custom && torsoOuterInner != TorsoOuter.None && clothingSet == false);

            SetFieldVisible(nameof(torsoInnerOuter), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(torsoInnerOuterCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingCondition == Condition.Custom && torsoInnerOuter != TorsoInner.None && clothingSet == false);
            SetFieldVisible(nameof(torsoInnerInner), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(torsoInnerInnerCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingCondition == Condition.Custom && torsoInnerInner != TorsoInner.None && clothingSet == false);

            SetFieldVisible(nameof(hands), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(handsCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingCondition == Condition.Custom && hands != Hands.None && clothingSet == false);

            SetFieldVisible(nameof(accessoriesOuter), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(accessoriesOuterCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingCondition == Condition.Custom && accessoriesOuter != AccessoriesOuter.None && clothingSet == false);
            SetFieldVisible(nameof(accessoriesInner), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(accessoriesInnerCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingCondition == Condition.Custom && accessoriesInner != AccessoriesInner.None && clothingSet == false);

            SetFieldVisible(nameof(legsOuterOuter), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(legsOuterOuterCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingCondition == Condition.Custom && legsOuterOuter != LegsOuter.None && clothingSet == false);
            SetFieldVisible(nameof(legsOuterInner), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(legsOuterInnerCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingCondition == Condition.Custom && legsOuterInner != LegsOuter.None && clothingSet == false);

            SetFieldVisible(nameof(legsInnerOuter), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(legsInnerOuterCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingCondition == Condition.Custom && legsInnerOuter != LegsInner.None && clothingSet == false);
            SetFieldVisible(nameof(legsInnerInner), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(legsInnerInnerCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingCondition == Condition.Custom && legsInnerInner != LegsInner.None && clothingSet == false);

            SetFieldVisible(nameof(feetInnerInner), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(feetInnerInnerCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingCondition == Condition.Custom && feetInnerInner != FeetInner.None && clothingSet == false);
            SetFieldVisible(nameof(feetInnerOuter), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(feetInnerOuterCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingCondition == Condition.Custom && feetInnerOuter != FeetInner.None && clothingSet == false);

            SetFieldVisible(nameof(feetOuter), Settings.settings.modFunction != ModFunction.Default && clothing && clothingSet == false);
            SetFieldVisible(nameof(feetOuterCondition), Settings.settings.modFunction != ModFunction.Default && clothing && clothingCondition == Condition.Custom && feetOuter != FeetOuter.None && clothingSet == false);

            // Fire Starting
            SetFieldVisible(nameof(firestarter), Settings.settings.modFunction != ModFunction.Default && fireStarting);
            SetFieldVisible(nameof(matchQty), Settings.settings.modFunction != ModFunction.Default && fireStarting && (firestarter == FireStarter.GEAR_PackMatches || firestarter == FireStarter.GEAR_WoodMatches));
            SetFieldVisible(nameof(tinderType), Settings.settings.modFunction != ModFunction.Default && fireStarting);
            SetFieldVisible(nameof(tinderQty), Settings.settings.modFunction != ModFunction.Default && fireStarting && tinderType != Tinder.None);
            SetFieldVisible(nameof(fuelType), Settings.settings.modFunction != ModFunction.Default && fireStarting);
            SetFieldVisible(nameof(fuelQty), Settings.settings.modFunction != ModFunction.Default && fireStarting && fuelType != Fuel.None);
            SetFieldVisible(nameof(accelerant), Settings.settings.modFunction != ModFunction.Default && fireStarting);

            // First Aid
            SetFieldVisible(nameof(antibiotics), Settings.settings.modFunction != ModFunction.Default && firstAid);
            SetFieldVisible(nameof(antiseptic), Settings.settings.modFunction != ModFunction.Default && firstAid);
            SetFieldVisible(nameof(bandages), Settings.settings.modFunction != ModFunction.Default && firstAid);
            SetFieldVisible(nameof(emergencyStim), Settings.settings.modFunction != ModFunction.Default && firstAid);
            SetFieldVisible(nameof(oldMansBeardDressing), Settings.settings.modFunction != ModFunction.Default && firstAid);
            SetFieldVisible(nameof(painkillers), Settings.settings.modFunction != ModFunction.Default && firstAid);
            SetFieldVisible(nameof(preparedBirchBark), Settings.settings.modFunction != ModFunction.Default && firstAid);
            SetFieldVisible(nameof(preparedReshiMushrooms), Settings.settings.modFunction != ModFunction.Default && firstAid);
            SetFieldVisible(nameof(preparedRoseHips), Settings.settings.modFunction != ModFunction.Default && firstAid);
            SetFieldVisible(nameof(waterPurificationTablets), Settings.settings.modFunction != ModFunction.Default && firstAid);
            SetFieldVisible(nameof(caffeinePills), Settings.settings.modFunction != ModFunction.Default && firstAid);
            SetFieldVisible(nameof(vitaminCPills), Settings.settings.modFunction != ModFunction.Default && firstAid);
            SetFieldVisible(nameof(heatPad), Settings.settings.modFunction != ModFunction.Default && firstAid);

            // Food & Drink
            SetFieldVisible(nameof(food1), Settings.settings.modFunction != ModFunction.Default && foodDrink);
            SetFieldVisible(nameof(food2), Settings.settings.modFunction != ModFunction.Default && foodDrink && food1 != Food.None);
            SetFieldVisible(nameof(food3), Settings.settings.modFunction != ModFunction.Default && foodDrink && food1 != Food.None && food2 != Food.None);
            SetFieldVisible(nameof(food4), Settings.settings.modFunction != ModFunction.Default && foodDrink && food1 != Food.None && food2 != Food.None && food3 != Food.None);
            SetFieldVisible(nameof(food5), Settings.settings.modFunction != ModFunction.Default && foodDrink && food1 != Food.None && food2 != Food.None && food3 != Food.None && food4 != Food.None);
            SetFieldVisible(nameof(drink1), Settings.settings.modFunction != ModFunction.Default && foodDrink);
            SetFieldVisible(nameof(drink2), Settings.settings.modFunction != ModFunction.Default && foodDrink && drink1 != Drink.None);
            SetFieldVisible(nameof(drink3), Settings.settings.modFunction != ModFunction.Default && foodDrink && drink1 != Drink.None && drink2 != Drink.None);
            SetFieldVisible(nameof(drink4), Settings.settings.modFunction != ModFunction.Default && foodDrink && drink1 != Drink.None && drink2 != Drink.None && drink3 != Drink.None);
            SetFieldVisible(nameof(drink5), Settings.settings.modFunction != ModFunction.Default && foodDrink && drink1 != Drink.None && drink2 != Drink.None && drink3 != Drink.None && drink4 != Drink.None);

            // Tools
            SetFieldVisible(nameof(bedroll), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(cooking1), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(cooking2), Settings.settings.modFunction != ModFunction.Default && tools && cooking1 != Cooking.None);
            SetFieldVisible(nameof(lightSource), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(weapon), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(ammunitionQty), Settings.settings.modFunction != ModFunction.Default && tools && weapon != Weapons.None);
            SetFieldVisible(nameof(canOpener), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(fishingTackle), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(hacksaw), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(hatchet), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(heavyHammer), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(hook), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(knife), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(line), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(mountaineeringRope), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(prybar), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(rifleCleaningKit), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(sewingKit), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(snare), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(sprayPaint), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(toolBox), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(whetstone), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(arrowType), Settings.settings.modFunction != ModFunction.Default && tools);

            // DLC Tools
            SetFieldVisible(nameof(stickFlask), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(camera), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(filmBoxColour), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(filmBoxBW), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(filmBoxSepia), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(wireBundle), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(fuse), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(travois), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(handheldShortwave), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(respirator), Settings.settings.modFunction != ModFunction.Default && tools);
            SetFieldVisible(nameof(canister), Settings.settings.modFunction != ModFunction.Default && tools);

            // Materials
            SetFieldVisible(nameof(ammunition), Settings.settings.modFunction != ModFunction.Default && materials);
            SetFieldVisible(nameof(hides), Settings.settings.modFunction != ModFunction.Default && materials);
            SetFieldVisible(nameof(saplings), Settings.settings.modFunction != ModFunction.Default && materials);
            SetFieldVisible(nameof(other), Settings.settings.modFunction != ModFunction.Default && materials);

            SetFieldVisible(nameof(arrowhead), Settings.settings.modFunction != ModFunction.Default && materials && ammunition);
            SetFieldVisible(nameof(arrowShaft), Settings.settings.modFunction != ModFunction.Default && materials && ammunition);
            SetFieldVisible(nameof(bullet), Settings.settings.modFunction != ModFunction.Default && materials && ammunition);
            SetFieldVisible(nameof(gunpowder), Settings.settings.modFunction != ModFunction.Default && materials && ammunition);
            SetFieldVisible(nameof(charcoal), Settings.settings.modFunction != ModFunction.Default && materials && ammunition);
            SetFieldVisible(nameof(crowFeather), Settings.settings.modFunction != ModFunction.Default && materials && ammunition);
            SetFieldVisible(nameof(dustingSulfur), Settings.settings.modFunction != ModFunction.Default && materials && ammunition);
            SetFieldVisible(nameof(revolverShell), Settings.settings.modFunction != ModFunction.Default && materials && ammunition);
            SetFieldVisible(nameof(rifleShell), Settings.settings.modFunction != ModFunction.Default && materials && ammunition);
            SetFieldVisible(nameof(scrapLead), Settings.settings.modFunction != ModFunction.Default && materials && ammunition);
            SetFieldVisible(nameof(stumpRemover), Settings.settings.modFunction != ModFunction.Default && materials && ammunition);

            SetFieldVisible(nameof(bearHideCured), Settings.settings.modFunction != ModFunction.Default && materials && hides);
            SetFieldVisible(nameof(bearHideFresh), Settings.settings.modFunction != ModFunction.Default && materials && hides);
            SetFieldVisible(nameof(deerHideCured), Settings.settings.modFunction != ModFunction.Default && materials && hides);
            SetFieldVisible(nameof(deerHideFresh), Settings.settings.modFunction != ModFunction.Default && materials && hides);
            SetFieldVisible(nameof(gutCured), Settings.settings.modFunction != ModFunction.Default && materials && hides);
            SetFieldVisible(nameof(gutFresh), Settings.settings.modFunction != ModFunction.Default && materials && hides);
            SetFieldVisible(nameof(mooseHideCured), Settings.settings.modFunction != ModFunction.Default && materials && hides);
            SetFieldVisible(nameof(mooseHideFresh), Settings.settings.modFunction != ModFunction.Default && materials && hides);
            SetFieldVisible(nameof(rabbitPeltCured), Settings.settings.modFunction != ModFunction.Default && materials && hides);
            SetFieldVisible(nameof(rabbitPeltFresh), Settings.settings.modFunction != ModFunction.Default && materials && hides);
            SetFieldVisible(nameof(wolfPeltCured), Settings.settings.modFunction != ModFunction.Default && materials && hides);
            SetFieldVisible(nameof(wolfPeltFresh), Settings.settings.modFunction != ModFunction.Default && materials && hides);
            SetFieldVisible(nameof(cougarPeltCured), Settings.settings.modFunction != ModFunction.Default && materials && hides);
            SetFieldVisible(nameof(cougarPeltFresh), Settings.settings.modFunction != ModFunction.Default && materials && hides);
            SetFieldVisible(nameof(cougarClaw), Settings.settings.modFunction != ModFunction.Default && materials && hides);

            SetFieldVisible(nameof(birchSaplingCured), Settings.settings.modFunction != ModFunction.Default && materials && saplings);
            SetFieldVisible(nameof(birchSaplingFresh), Settings.settings.modFunction != ModFunction.Default && materials && saplings);
            SetFieldVisible(nameof(mapleSaplingCured), Settings.settings.modFunction != ModFunction.Default && materials && saplings);
            SetFieldVisible(nameof(mapleSaplingFresh), Settings.settings.modFunction != ModFunction.Default && materials && saplings);

            SetFieldVisible(nameof(cloth), Settings.settings.modFunction != ModFunction.Default && materials && other);
            SetFieldVisible(nameof(curedLeather), Settings.settings.modFunction != ModFunction.Default && materials && other);
            SetFieldVisible(nameof(scrapMetal), Settings.settings.modFunction != ModFunction.Default && materials && other);
        }
    }
    
    internal static class Settings
    {
        public static ChooseStartingGearSettings settings;
        public static void OnLoad()
        {
            settings = new ChooseStartingGearSettings();
            settings.AddToModSettings("Choose Starting Gear Redux");
            settings.RefreshFields();
        }
    }
}