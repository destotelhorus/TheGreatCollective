// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
     using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Economy;
    using Eco.Gameplay.Housing;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Modules;
    using Eco.Gameplay.Minimap;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Gameplay.Pipes.LiquidComponents;
    using Eco.Gameplay.Pipes.Gases;
    using Eco.Gameplay.Systems.Tooltip;
    using Eco.Shared;
    using Eco.Shared.Math;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Shared.Items;
    using Eco.Gameplay.Pipes;
    using Eco.World.Blocks;
    using Eco.Gameplay.Housing.PropertyValues;
    using static Eco.Gameplay.Housing.PropertyValues.HomeFurnishingValue;

    [Serialized]
    [RequireComponent(typeof(AirPollutionComponent))]
    [RequireComponent(typeof(OnOffComponent))]
    [RequireComponent(typeof(ChimneyComponent))]
    [RequireComponent(typeof(LiquidProducerComponent))]
    [RequireComponent(typeof(AttachmentComponent))]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(MinimapComponent))]
    [RequireComponent(typeof(LinkComponent))]
    [RequireComponent(typeof(CraftingComponent))]
    [RequireComponent(typeof(PowerGridComponent))]
    [RequireComponent(typeof(PowerConsumptionComponent))]
    [RequireComponent(typeof(HousingComponent))]
    [RequireComponent(typeof(SolidGroundComponent))]
    [RequireComponent(typeof(LiquidConverterComponent))]
    [RequireComponent(typeof(PluginModulesComponent))]
    public partial class NyElectricBlastFurnaceObject :
        WorldObject,
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Electric Blast Furnace"); } }

        public override TableTextureMode TableTexture => TableTextureMode.Metal;

        public virtual Type RepresentedItemType { get { return typeof(NyElectricBlastFurnaceItem); } }


        protected override void Initialize()
        {

            this.GetComponent<MinimapComponent>().Initialize(Localizer.DoStr("Crafting"));
            this.GetComponent<PowerGridComponent>().Initialize(10, new ElectricPower());
            this.GetComponent<PowerConsumptionComponent>().Initialize(3000f);
            this.GetComponent<HousingComponent>().HomeValue = NyElectricBlastFurnaceItem.HousingVal;

            this.GetComponent<LiquidProducerComponent>().Setup(typeof(SmogItem), 1, this.NamedOccupancyOffset("ChimneyOut"));
            this.GetComponent<AirPollutionComponent>().Initialize(this.GetComponent<LiquidProducerComponent>());
            this.GetComponent<LiquidConverterComponent>().Setup(typeof(WaterItem), typeof(SewageItem), this.NamedOccupancyOffset("WaterInputPort"), this.NamedOccupancyOffset("SewageOutputPort"), 0.3f, 0.9f);
        }

        public override void Destroy()
        {
            base.Destroy();
        }

        static NyElectricBlastFurnaceObject()
        {
            WorldObject.AddOccupancy<NyElectricBlastFurnaceObject>(new List<BlockOccupancy>() { new BlockOccupancy(new Vector3i(1, 4, 1), typeof(PipeSlotBlock), new Quaternion(-0.7071071f, 2.634177E-07f, 2.634179E-07f, 0.7071065f), "ChimneyOut"), new BlockOccupancy(new Vector3i(2, 0, 2), typeof(PipeSlotBlock), new Quaternion(0f, 0f, 0f, 1f), "WaterInputPort"), new BlockOccupancy(new Vector3i(0, 0, 0), typeof(PipeSlotBlock), new Quaternion(0f, -0.7071068f, 0f, 0.7071068f), "SewageOutputPort"), new BlockOccupancy(new Vector3i(0, 0, 1)), new BlockOccupancy(new Vector3i(0, 0, 2)), new BlockOccupancy(new Vector3i(0, 1, 0)), new BlockOccupancy(new Vector3i(0, 1, 1)), new BlockOccupancy(new Vector3i(0, 1, 2)), new BlockOccupancy(new Vector3i(0, 2, 0)), new BlockOccupancy(new Vector3i(0, 2, 1)), new BlockOccupancy(new Vector3i(0, 2, 2)), new BlockOccupancy(new Vector3i(0, 3, 0)), new BlockOccupancy(new Vector3i(0, 3, 1)), new BlockOccupancy(new Vector3i(0, 3, 2)), new BlockOccupancy(new Vector3i(0, 4, 0)), new BlockOccupancy(new Vector3i(0, 4, 1)), new BlockOccupancy(new Vector3i(0, 4, 2)), new BlockOccupancy(new Vector3i(1, 0, 0)), new BlockOccupancy(new Vector3i(1, 0, 1)), new BlockOccupancy(new Vector3i(1, 0, 2)), new BlockOccupancy(new Vector3i(1, 1, 0)), new BlockOccupancy(new Vector3i(1, 1, 1)), new BlockOccupancy(new Vector3i(1, 1, 2)), new BlockOccupancy(new Vector3i(1, 2, 0)), new BlockOccupancy(new Vector3i(1, 2, 1)), new BlockOccupancy(new Vector3i(1, 2, 2)), new BlockOccupancy(new Vector3i(1, 3, 0)), new BlockOccupancy(new Vector3i(1, 3, 1)), new BlockOccupancy(new Vector3i(1, 3, 2)), new BlockOccupancy(new Vector3i(1, 4, 0)), new BlockOccupancy(new Vector3i(1, 4, 2)), new BlockOccupancy(new Vector3i(2, 0, 0)), new BlockOccupancy(new Vector3i(2, 0, 1)), new BlockOccupancy(new Vector3i(2, 1, 0)), new BlockOccupancy(new Vector3i(2, 1, 1)), new BlockOccupancy(new Vector3i(2, 1, 2)), new BlockOccupancy(new Vector3i(2, 2, 0)), new BlockOccupancy(new Vector3i(2, 2, 1)), new BlockOccupancy(new Vector3i(2, 2, 2)), new BlockOccupancy(new Vector3i(2, 3, 0)), new BlockOccupancy(new Vector3i(2, 3, 1)), new BlockOccupancy(new Vector3i(2, 3, 2)), new BlockOccupancy(new Vector3i(2, 4, 0)), new BlockOccupancy(new Vector3i(2, 4, 1)), new BlockOccupancy(new Vector3i(2, 4, 2)), });


        }
    }


    [Serialized]
    [LocDisplayName("Electric Blast Furnace")]
    [Ecopedia("Work Stations", "Craft Tables", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [LiquidProducer(typeof(SmogItem), 1)]
    [AllowPluginModules(Tags = new[] { "AdvancedUpgrade", }, ItemTypes = new[] { typeof(AdvancedSmeltingUpgradeItem),
typeof(SmeltingUpgradeItem), })]
    public partial class NyElectricBlastFurnaceItem :
        WorldObjectItem<NyElectricBlastFurnaceObject>
        , IPersistentData
    {
        public override LocString DisplayDescription => Localizer.DoStr("A superior replacement for the blast furnace that use electric power.");

        static NyElectricBlastFurnaceItem()
        {

        }

        [TooltipChildren] public HomeFurnishingValue HousingTooltip => HousingVal;
        [TooltipChildren]
        public static HomeFurnishingValue HousingVal => new(){ Category = RoomCategory.Industrial, TypeForRoomLimit = Localizer.DoStr("") };

        [Tooltip(7)] private LocString PowerConsumptionTooltip => Localizer.Do($"Consumes: {Text.Info(100)}w of {new ElectricPower().Name} power");

        [Serialized, TooltipChildren] public object PersistentData { get; set; }
    }

    [RequiresSkill(typeof(IndustrySkill), 1)]
    public class NyElectricBlastFurnaceRecipe :
        RecipeFamily
    {
        public NyElectricBlastFurnaceRecipe()
        {
            var product = new Recipe(
                "Electric Blast Furnace",
                Localizer.DoStr("Electric Blast Furnace"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(BasicCircuitItem), 24, typeof(IndustrySkill)),
               new IngredientElement(typeof(ReinforcedConcreteItem), 16, typeof(IndustrySkill)),
               new IngredientElement(typeof(SteelPlateItem), 24, typeof(IndustrySkill)),
               new IngredientElement(typeof(SteelPipeItem), 16, typeof(IndustrySkill)),
               new IngredientElement(typeof(WindTurbineItem), 3, typeof(IndustrySkill)),
                },
                new CraftingElement<NyElectricBlastFurnaceItem>()
            );
            this.Recipes = new List<Recipe> { product };
            this.ExperienceOnCraft = 20;
            this.LaborInCalories = CreateLaborInCaloriesValue(1000, typeof(IndustrySkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(NyElectricBlastFurnaceRecipe), 25, typeof(IndustrySkill));
            this.Initialize(Localizer.DoStr("Electric Blast Furnace"), typeof(NyElectricBlastFurnaceRecipe));
            CraftingComponent.AddRecipe(typeof(AssemblyLineObject), this);
        }
    }

    [RequiresSkill(typeof(AdvancedSmeltingSkill), 1)]
    public partial class AdvancedSteelPipeRecipe :
        RecipeFamily
    {
        public AdvancedSteelPipeRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "SteelPipe",
                    Localizer.DoStr("Steel Pipe"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(SteelBarItem), 2, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<SteelPipeItem>(),
                    }
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(AdvancedSmeltingSkill));
            this.ExperienceOnCraft = 0.5f;
            this.CraftMinutes = CreateCraftTimeValue(typeof(SteelPipeRecipe), 1.5f, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));
            this.Initialize(Localizer.DoStr("Steel Pipe"), typeof(SteelPipeRecipe));

            CraftingComponent.AddRecipe(typeof(NyElectricBlastFurnaceObject), this);
        }
    }

    [RequiresSkill(typeof(SmeltingSkill), 1)]      
    public partial class AdvancedCopperBarRecipe :
        RecipeFamily
    {
        public AdvancedCopperBarRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "CopperBar",
                    Localizer.DoStr("Copper Bar"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(CopperConcentrateItem), 1, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<CopperBarItem>(2),                          
                   new CraftingElement<SlagItem>(typeof(SmeltingSkill), 1), 
 
                    }
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(SmeltingSkill)); 
            this.ExperienceOnCraft = 2;  
            this.CraftMinutes = CreateCraftTimeValue(typeof(CopperBarRecipe), 0.3f, typeof(SmeltingSkill), typeof(SmeltingFocusedSpeedTalent), typeof(SmeltingParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Copper Bar"), typeof(CopperBarRecipe));

            CraftingComponent.AddRecipe(typeof(NyElectricBlastFurnaceObject), this);
        }
	}
	
	
	[RequiresSkill(typeof(SmeltingSkill), 1)]      
    public partial class AdvancedIronBarRecipe :
        RecipeFamily
    {
        public AdvancedIronBarRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "IronBar",
                    Localizer.DoStr("Iron Bar"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(IronConcentrateItem), 1, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<IronBarItem>(2),                          
                   new CraftingElement<SlagItem>(typeof(SmeltingSkill), 1), 
 
                    }
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(SmeltingSkill)); 
            this.ExperienceOnCraft = 2;  
            this.CraftMinutes = CreateCraftTimeValue(typeof(IronBarRecipe), 0.3f, typeof(SmeltingSkill), typeof(SmeltingFocusedSpeedTalent), typeof(SmeltingParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Iron Bar"), typeof(IronBarRecipe));

            CraftingComponent.AddRecipe(typeof(NyElectricBlastFurnaceObject), this);
        }
	}
	
	[RequiresSkill(typeof(SmeltingSkill), 1)]      
    public partial class AdvancedGoldBarRecipe :
        RecipeFamily
    {
        public AdvancedGoldBarRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "GoldBar",
                    Localizer.DoStr("Gold Bar"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(GoldConcentrateItem), 1, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<GoldBarItem>(2),                          
                   new CraftingElement<SlagItem>(typeof(SmeltingSkill), 1), 
 
                    }
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(SmeltingSkill)); 
            this.ExperienceOnCraft = 2;  
            this.CraftMinutes = CreateCraftTimeValue(typeof(GoldBarRecipe), 0.3f, typeof(SmeltingSkill), typeof(SmeltingFocusedSpeedTalent), typeof(SmeltingParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Gold Bar"), typeof(GoldBarRecipe));

            CraftingComponent.AddRecipe(typeof(NyElectricBlastFurnaceObject), this);
        }
	}
	
	[RequiresSkill(typeof(AdvancedSmeltingSkill), 7)]      
    public partial class AdvancedAdvancedSmeltingUpgradeRecipe :
        RecipeFamily
    {
        public AdvancedAdvancedSmeltingUpgradeRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "AdvancedSmeltingUpgrade",
                    Localizer.DoStr("Advanced Smelting Advanced Upgrade"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(AdvancedUpgradeLvl4Item), 1, true),  
                    },
                    new CraftingElement[]
                    {
                        new CraftingElement<AdvancedSmeltingUpgradeItem>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 4;  

            this.LaborInCalories = CreateLaborInCaloriesValue(10000, typeof(AdvancedSmeltingSkill)); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(AdvancedSmeltingUpgradeRecipe), 15, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Advanced Smelting Advanced Upgrade"), typeof(AdvancedSmeltingUpgradeRecipe));

            CraftingComponent.AddRecipe(typeof(NyElectricBlastFurnaceObject), this);
        }
    }
	
	[RequiresSkill(typeof(AdvancedSmeltingSkill), 2)]      
    public partial class AdvancedModernUpgradeLvl1Recipe :
        RecipeFamily
    {
        public AdvancedModernUpgradeLvl1Recipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "ModernUpgradeLvl1",
                    Localizer.DoStr("Modern Upgrade 1"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(SteelBarItem), 6, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)), 
               new IngredientElement(typeof(RivetItem), 20, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),   
                    },
                    new CraftingElement[]
                    {
                        new CraftingElement<ModernUpgradeLvl1Item>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 4;  

            this.LaborInCalories = CreateLaborInCaloriesValue(200, typeof(AdvancedSmeltingSkill)); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(ModernUpgradeLvl1Recipe), 2, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Modern Upgrade 1"), typeof(ModernUpgradeLvl1Recipe));

            CraftingComponent.AddRecipe(typeof(NyElectricBlastFurnaceObject), this);
        }
    }
	
	[RequiresSkill(typeof(AdvancedSmeltingSkill), 1)]      
    public partial class AdvancedQuicklimeRecipe :
        RecipeFamily
    {
        public AdvancedQuicklimeRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "Quicklime",
                    Localizer.DoStr("Quicklime"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(CrushedLimestoneItem), 1, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<QuicklimeItem>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 1;  

            this.LaborInCalories = CreateLaborInCaloriesValue(80, typeof(AdvancedSmeltingSkill)); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(QuicklimeRecipe), 0.2f, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Quicklime"), typeof(QuicklimeRecipe));

            CraftingComponent.AddRecipe(typeof(NyElectricBlastFurnaceObject), this);
        }
	}
	
	[RequiresSkill(typeof(AdvancedSmeltingSkill), 1)]      
    public partial class AdvancedRebarRecipe :
        RecipeFamily
    {
        public AdvancedRebarRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "Rebar",
                    Localizer.DoStr("Rebar"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(SteelBarItem), 2, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<RebarItem>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 2;  

            this.LaborInCalories = CreateLaborInCaloriesValue(80, typeof(AdvancedSmeltingSkill)); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(RebarRecipe), 0.2f, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Rebar"), typeof(RebarRecipe));

            CraftingComponent.AddRecipe(typeof(NyElectricBlastFurnaceObject), this);
        }
	}
	
	[RequiresSkill(typeof(AdvancedSmeltingSkill), 1)]      
    public partial class AdvancedRivetRecipe :
        RecipeFamily
    {
        public AdvancedRivetRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "Rivet",
                    Localizer.DoStr("Rivet"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(SteelBarItem), 1, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<RivetItem>(3),  
                    }
                )
            };


            this.ExperienceOnCraft = 1;  

            this.LaborInCalories = CreateLaborInCaloriesValue(140, typeof(AdvancedSmeltingSkill)); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(RivetRecipe), 0.8f, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Rivet"), typeof(RivetRecipe));

            CraftingComponent.AddRecipe(typeof(NyElectricBlastFurnaceObject), this);
        }
	}
	
	[RequiresSkill(typeof(AdvancedSmeltingSkill), 1)]      
    public partial class AdvancedSteelBarRecipe :
        RecipeFamily
    {
        public AdvancedSteelBarRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "SteelBar",
                    Localizer.DoStr("Steel Bar"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(IronBarItem), 2, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),    
                    new IngredientElement("Coal", 2, true),   
                    new IngredientElement(typeof(QuicklimeItem), 1, true),  
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<SteelBarItem>(),  
                   new CraftingElement<SlagItem>(typeof(AdvancedSmeltingSkill), 2), 
 
                    }
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(AdvancedSmeltingSkill)); 
            this.ExperienceOnCraft = 2;  
            this.CraftMinutes = CreateCraftTimeValue(typeof(SteelBarRecipe), 1.5f, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Steel Bar"), typeof(SteelBarRecipe));

            CraftingComponent.AddRecipe(typeof(NyElectricBlastFurnaceObject), this);
        }
	}
}