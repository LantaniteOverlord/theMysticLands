using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMysticLands.Items.Weapons.Ranged
{
	public class GunForm4: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("DeathEaterSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("bad gun" + " bad" + "testing gun don't use");
		}

		public override void SetDefaults() 
		{
			item.damage = 37;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 20f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);

			recipe.AddIngredient(null, "GunForm3");
			recipe.AddIngredient(ItemID.TendonBow, 1);
			recipe.AddIngredient(ItemID.CrimsonSeeds, 10);
			recipe.AddIngredient(ItemID.CrimtaneBar, 10);
			recipe.AddIngredient(ItemID.Granite, 10);
			recipe.AddIngredient(ItemID.Marble, 10);

			recipe.AddTile(TileID.Hellforge);//crafting station

			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}