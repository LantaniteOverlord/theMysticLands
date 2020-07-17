using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMysticLands.Items.Weapons.Ranged
{
	public class CatGun: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("DeathEaterSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("what?");
		}

		public override void SetDefaults()
		{
			item.damage = 555;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 1;
			item.useAnimation = 1;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<Projectiles.CatGunProj>();
			item.shootSpeed = 20f;
		}

		public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);

			recipe.AddIngredient(ItemID.ClockworkAssaultRifle, 1);
			recipe.AddIngredient(ItemID.Gatligator, 1);
			recipe.AddIngredient(ItemID.Uzi, 1);
			recipe.AddIngredient(ItemID.Megashark, 1);
			recipe.AddIngredient(ItemID.ChainGun, 1);
			recipe.AddIngredient(ItemID.Xenopopper, 1);
			recipe.AddIngredient(ItemID.VortexBeater, 1);
			recipe.AddIngredient(ItemID.SDMG, 1);
			recipe.AddIngredient(ItemID.Meowmere, 1);

			recipe.AddTile(TileID.Hellforge);//crafting station

			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}