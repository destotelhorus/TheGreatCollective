// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Modules;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Systems.Tooltip;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Items;
    using Eco.Gameplay.Housing.PropertyValues;

    /// 1
    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    public partial class dWireFenceObject : WorldObject, IRepresentsItem
    {
        public override LocString DisplayName => Localizer.DoStr("Wire Fence");
        public override InteractResult OnActInteract(InteractionContext context) => InteractResult.NoOp;
        public virtual Type RepresentedItemType => typeof(dWireFenceItem);

        protected override void Initialize() { }

        public override void Destroy()
        {
            base.Destroy();
        }
    }

    [Serialized]
    [LocDisplayName("Wire Fence")]
    public partial class dWireFenceItem : WorldObjectItem<dWireFenceObject>
    {
        public override LocString DisplayDescription => Localizer.DoStr("Keeps critters out. *Disclaimer: Does not impede animals.");

        static dWireFenceItem() { }
    }

    /// 2
    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    public partial class dWireFenceBeginsObject : WorldObject, IRepresentsItem
    {
        public override LocString DisplayName => Localizer.DoStr("Reinforced Wire Fence");
        public override InteractResult OnActInteract(InteractionContext context) => InteractResult.NoOp;

        public virtual Type RepresentedItemType => typeof(dWireFenceBeginsItem);

        protected override void Initialize(){}

        public override void Destroy()
        {
            base.Destroy();
        }
    }

    [Serialized]
    [LocDisplayName("Reinforced Wire Fence")]
    public partial class dWireFenceBeginsItem : WorldObjectItem<dWireFenceBeginsObject>
    {
        public override LocString DisplayDescription => Localizer.DoStr("A reinforced section of fence perfect for near gates.");

        static dWireFenceBeginsItem() { }
    }
    
    // 3
    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    public partial class dWireFenceBrokenObject : WorldObject, IRepresentsItem
    {
        public override LocString DisplayName => Localizer.DoStr("Broken Wire Fence");
        public override InteractResult OnActInteract(InteractionContext context) => InteractResult.NoOp;
        public virtual Type RepresentedItemType => typeof(dWireFenceBrokenItem);

        protected override void Initialize() { }

        public override void Destroy()
        {
            base.Destroy();
        }
    }

    [Serialized]
    [LocDisplayName("Broken Wire Fence")]
    public partial class dWireFenceBrokenItem : WorldObjectItem<dWireFenceBrokenObject>
    {
        public override LocString DisplayDescription => Localizer.DoStr("No refunds.");

        static dWireFenceBrokenItem() { }
    }

    // 4
    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    public partial class dWireFenceCornerObject : WorldObject, IRepresentsItem
    {
        public override LocString DisplayName => Localizer.DoStr("Corner Wire Fence");
        public override InteractResult OnActInteract(InteractionContext context) => InteractResult.NoOp;
        public virtual Type RepresentedItemType => typeof(dWireFenceCornerItem);

        protected override void Initialize() { }

        public override void Destroy()
        {
            base.Destroy();
        }
    }

    [Serialized]
    [LocDisplayName("Corner Wire Fence")]
    public partial class dWireFenceCornerItem : WorldObjectItem<dWireFenceCornerObject>
    {
        public override LocString DisplayDescription => Localizer.DoStr("Perfect for rectangles..");

        static dWireFenceCornerItem() { }
    }

    // 5
    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    public partial class dWireFenceDiagonalObject : WorldObject, IRepresentsItem
    {
        public override LocString DisplayName => Localizer.DoStr("Diagonal Wire Fence");
        public override InteractResult OnActInteract(InteractionContext context) => InteractResult.NoOp;
        public virtual Type RepresentedItemType => typeof(dWireFenceDiagonalItem);

        protected override void Initialize() { }

        public override void Destroy()
        {
            base.Destroy();
        }
    }

    [Serialized]
    [LocDisplayName("Diagonal Wire Fence")]
    public partial class dWireFenceDiagonalItem : WorldObjectItem<dWireFenceDiagonalObject>
    {
        public override LocString DisplayDescription => Localizer.DoStr("A diagonal fence, string it along those country roads with impunity.");

        static dWireFenceDiagonalItem() { }
    }

    // 6
    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    public partial class dWireFenceDownObject : WorldObject, IRepresentsItem
    {
        public override LocString DisplayName => Localizer.DoStr("Downward Wire Fence");
        public override InteractResult OnActInteract(InteractionContext context) => InteractResult.NoOp;
        public virtual Type RepresentedItemType => typeof(dWireFenceDownItem);

        protected override void Initialize() { }

        public override void Destroy()
        {
            base.Destroy();
        }
    }

    [Serialized]
    [LocDisplayName("Downward Wire Fence")]
    public partial class dWireFenceDownItem : WorldObjectItem<dWireFenceDownObject>
    {
        public override LocString DisplayDescription => Localizer.DoStr("It go down.");

        static dWireFenceDownItem() { }
    }

    // 7
    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    public partial class dWireFenceGateObject : WorldObject, IRepresentsItem
    {
        public override LocString DisplayName => Localizer.DoStr("Wire Fence Gate");
        public override InteractResult OnActInteract(InteractionContext context) => InteractResult.NoOp;
        public virtual Type RepresentedItemType => typeof(dWireFenceGateItem);

        protected override void Initialize() { }

        public override void Destroy()
        {
            base.Destroy();
        }
    }

    [Serialized]
    [LocDisplayName("Wire Fence Gate")]
    public partial class dWireFenceGateItem : WorldObjectItem<dWireFenceGateObject>
    {
        public override LocString DisplayDescription => Localizer.DoStr("A gate. It seems you've lost the keys.");

        static dWireFenceGateItem() { }
    }

    // 8
    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    public partial class dWireFenceGateBentObject : WorldObject, IRepresentsItem
    {
        public override LocString DisplayName => Localizer.DoStr("Bent Wire Fence Gate");
        public override InteractResult OnActInteract(InteractionContext context) => InteractResult.NoOp;
        public virtual Type RepresentedItemType => typeof(dWireFenceGateBentItem);

        protected override void Initialize() { }

        public override void Destroy()
        {
            base.Destroy();
        }
    }

    [Serialized]
    [LocDisplayName("Bent Wire Fence Gate")]
    public partial class dWireFenceGateBentItem : WorldObjectItem<dWireFenceGateBentObject>
    {
        public override LocString DisplayDescription => Localizer.DoStr("It's jammed shut.");

        static dWireFenceGateBentItem() { }
    }

    // 9
    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    public partial class dWireFenceUpObject : WorldObject, IRepresentsItem
    {
        public override LocString DisplayName => Localizer.DoStr("Upward Wire Fence");
        public override InteractResult OnActInteract(InteractionContext context) => InteractResult.NoOp;
        public virtual Type RepresentedItemType => typeof(dWireFenceUpItem);

        protected override void Initialize() { }

        public override void Destroy()
        {
            base.Destroy();
        }
    }

    [Serialized]
    [LocDisplayName("Upward Wire Fence")]
    public partial class dWireFenceUpItem : WorldObjectItem<dWireFenceUpObject>
    {
        public override LocString DisplayDescription => Localizer.DoStr("It don't go down.");

        static dWireFenceUpItem() { }
    }

    // 10 workbench and recipes
    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(MinimapComponent))]
    [RequireComponent(typeof(LinkComponent))]
    [RequireComponent(typeof(CraftingComponent))]
    [RequireComponent(typeof(SolidGroundComponent))]
    [RequireComponent(typeof(PluginModulesComponent))]
    [RequireComponent(typeof(RoomRequirementsComponent))]
    public partial class dSawhorseWorkbenchObject : WorldObject, IRepresentsItem
    {
        public override LocString DisplayName => Localizer.DoStr("Fence Workbench");
        public override TableTextureMode TableTexture => TableTextureMode.Wood;
        public virtual Type RepresentedItemType => typeof(dSawhorseWorkbenchItem);

        protected override void Initialize()
        {
            this.GetComponent<MinimapComponent>().Initialize(Localizer.DoStr("Crafting"));
        }

        public override void Destroy()
        {
            base.Destroy();
        }
    }

    [Serialized]
    [LocDisplayName("Fence Workbench")]
    [Ecopedia("Work Stations", "Craft Tables", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [AllowPluginModules(Tags = new[] { "BasicUpgrade", }, ItemTypes = new[] { typeof(CarpentryBasicUpgradeItem),
typeof(LoggingBasicUpgradeItem),
typeof(BasicEngineeringUpgradeItem), })]
    public partial class dSawhorseWorkbenchItem : WorldObjectItem<dSawhorseWorkbenchObject>, IPersistentData
    {
        public override LocString DisplayDescription => Localizer.DoStr("A table for fences of all kind.");

        static dSawhorseWorkbenchItem() { }

        [TooltipChildren] public HomeFurnishingValue HousingTooltip => HousingVal; 
        [TooltipChildren]
        public static HomeFurnishingValue HousingVal => new()
        {
            Category = HomeFurnishingValue.RoomCategory.Industrial,
            TypeForRoomLimit = Localizer.DoStr(""),
        };

        [Serialized, TooltipChildren] public object PersistentData { get; set; }
    }

    // recipes
    public partial class dSawhorseWorkbenchRecipe : RecipeFamily
    {
        public dSawhorseWorkbenchRecipe()
        {
            var product = new Recipe(
                "SawhorseWorkbench",
                Localizer.DoStr("Fence Workbench"),
                new IngredientElement[]
                {
               new IngredientElement("Wood", 20),
                },
               new CraftingElement<dSawhorseWorkbenchItem>()
            );
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(100);
            this.CraftMinutes = CreateCraftTimeValue(1);
            this.Initialize(Localizer.DoStr("Fence Workbench"), typeof(dSawhorseWorkbenchRecipe));
            CraftingComponent.AddRecipe(typeof(WorkbenchObject), this);
        }
    }

    public partial class dWireFenceRecipe : RecipeFamily
    {
        public dWireFenceRecipe()
        {
            var product = new Recipe(
                "WireFence",
                Localizer.DoStr("Wire Fence"),
                new IngredientElement[]
                {
               new IngredientElement("Wood", 4),
                },
               new CraftingElement<dWireFenceItem>()
            );
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(75);
            this.CraftMinutes = CreateCraftTimeValue(.3f);
            this.Initialize(Localizer.DoStr("Wire Fence"), typeof(dWireFenceRecipe));
            CraftingComponent.AddRecipe(typeof(dSawhorseWorkbenchObject), this);
        }
    }
    
    public partial class dWireFenceBeginsRecipe : RecipeFamily
    {
        public dWireFenceBeginsRecipe()
        {
            var product = new Recipe(
                "ReinforcedWireFence",
                Localizer.DoStr("Reinforced Wire Fence"),
                new IngredientElement[]
                {
               new IngredientElement("Wood", 8),
                },
               new CraftingElement<dWireFenceBeginsItem>()
            );
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(100);
            this.CraftMinutes = CreateCraftTimeValue(.5f);
            this.Initialize(Localizer.DoStr("Reinforced Wire Fence"), typeof(dWireFenceBeginsRecipe));
            CraftingComponent.AddRecipe(typeof(dSawhorseWorkbenchObject), this);
        }
    }

    public partial class dWireFenceBrokenRecipe : RecipeFamily
    {
        public dWireFenceBrokenRecipe()
        {
            var product = new Recipe(
                "BrokenWireFence",
                Localizer.DoStr("Broken Wire Fence"),
                new IngredientElement[]
                {
               new IngredientElement("Wood", 4),
                },
               new CraftingElement<dWireFenceBrokenItem>()
            );
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(75);
            this.CraftMinutes = CreateCraftTimeValue(.3f);
            this.Initialize(Localizer.DoStr("Broken Wire Fence"), typeof(dWireFenceBrokenRecipe));
            CraftingComponent.AddRecipe(typeof(dSawhorseWorkbenchObject), this);
        }
    }

    public partial class dWireFenceCornerRecipe : RecipeFamily
    {
        public dWireFenceCornerRecipe()
        {
            var product = new Recipe(
                "WireFenceCorner",
                Localizer.DoStr("Wire Fence Corner"),
                new IngredientElement[]
                {
               new IngredientElement("Wood", 4),
                },
               new CraftingElement<dWireFenceCornerItem>()
            );
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(75);
            this.CraftMinutes = CreateCraftTimeValue(.5f);
            this.Initialize(Localizer.DoStr("Wire Fence Corner"), typeof(dWireFenceCornerRecipe));
            CraftingComponent.AddRecipe(typeof(dSawhorseWorkbenchObject), this);
        }
    }

    public partial class dWireFenceDiagonalRecipe : RecipeFamily
    {
        public dWireFenceDiagonalRecipe()
        {
            var product = new Recipe(
                "DiagonalWireFence",
                Localizer.DoStr("Diagonal Wire Fence"),
                new IngredientElement[]
                {
               new IngredientElement("Wood", 4),
                },
               new CraftingElement<dWireFenceDiagonalItem>()
            );
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(75);
            this.CraftMinutes = CreateCraftTimeValue(.3f);
            this.Initialize(Localizer.DoStr("Diagonal Wire Fence"), typeof(dWireFenceDiagonalRecipe));
            CraftingComponent.AddRecipe(typeof(dSawhorseWorkbenchObject), this);
        }
    }

    public partial class dWireFenceDownRecipe : RecipeFamily
    {
        public dWireFenceDownRecipe()
        {
            var product = new Recipe(
                "DownWireFence",
                Localizer.DoStr("Downward Wire Fence"),
                new IngredientElement[]
                {
               new IngredientElement("Wood", 4),
                },
               new CraftingElement<dWireFenceDownItem>()
            );
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(75);
            this.CraftMinutes = CreateCraftTimeValue(.3f);
            this.Initialize(Localizer.DoStr("Downward Wire Fence"), typeof(dWireFenceDownRecipe));
            CraftingComponent.AddRecipe(typeof(dSawhorseWorkbenchObject), this);
        }
    }

    public partial class dWireFenceGateRecipe : RecipeFamily
    {
        public dWireFenceGateRecipe()
        {
            var product = new Recipe(
                "WireGate",
                Localizer.DoStr("Wire Fence Gate"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(IronBarItem), 4),
                },
               new CraftingElement<dWireFenceGateItem>()
            );
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(75);
            this.CraftMinutes = CreateCraftTimeValue(.3f);
            this.Initialize(Localizer.DoStr("Wire Fence Gate"), typeof(dWireFenceGateRecipe));
            CraftingComponent.AddRecipe(typeof(dSawhorseWorkbenchObject), this);
        }
    }

    public partial class dWireFenceGateBentRecipe : RecipeFamily
    {
        public dWireFenceGateBentRecipe()
        {
            var product = new Recipe(
                "BentGate",
                Localizer.DoStr("Bent Wire Fence Gate"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(IronBarItem), 4),
                },
               new CraftingElement<dWireFenceGateBentItem>()
            );
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(75);
            this.CraftMinutes = CreateCraftTimeValue(.5f);
            this.Initialize(Localizer.DoStr("Bent Wire Fence Gate"), typeof(dWireFenceGateBentRecipe));
            CraftingComponent.AddRecipe(typeof(dSawhorseWorkbenchObject), this);
        }
    }

    public partial class dWireFenceUpRecipe : RecipeFamily
    {
        public dWireFenceUpRecipe()
        {
            var product = new Recipe(
                "UpWireFence",
                Localizer.DoStr("Upward Wire Fence"),
                new IngredientElement[]
                {
               new IngredientElement("Wood", 4),
                },
               new CraftingElement<dWireFenceUpItem>()
            );
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(75);
            this.CraftMinutes = CreateCraftTimeValue(.5f);
            this.Initialize(Localizer.DoStr("Upward Wire Fence"), typeof(dWireFenceUpRecipe));
            CraftingComponent.AddRecipe(typeof(dSawhorseWorkbenchObject), this);
        }
    }
}
