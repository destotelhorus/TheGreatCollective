﻿using System;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Housing;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace Eco.Mods.TechTree
{
		[Serialized]
	[RequireComponent(typeof(PropertyAuthComponent), null)]
	[RequireComponent(typeof(HousingComponent), null)]
	public class PaperHeartBrokenBlackObject : WorldObject, IRepresentsItem
	{
						public override LocString DisplayName
		{
			get
			{
				return Localizer.DoStr("Paper Heart Broken Black");
			}
		}

						public override TableTextureMode TableTexture
		{
			get
			{
				return (TableTextureMode)2;
			}
		}

						public virtual Type RepresentedItemType
		{
			get
			{
				return typeof(PaperHeartBrokenBlackItem);
			}
		}

				protected override void Initialize()
		{
			base.GetComponent<HousingComponent>(null).HomeValue = PaperHeartBrokenBlackItem.HousingVal;
		}

				public override void Destroy()
		{
			base.Destroy();
		}
	}
}