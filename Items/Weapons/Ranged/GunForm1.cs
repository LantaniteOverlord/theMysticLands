using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMysticLands.Items.Weapons.Ranged
{
	public class GunForm1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("DeathEaterSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("bad gun" + " bad" + "testing gun don't use");
		}

		public override void SetDefaults() 
		{
			item.damage = 7;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);

			recipe.AddIngredient(ItemID.Acorn, 5);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.IronBar, 10);
			//dont forget to add biome souls

			recipe.AddTile(TileID.WorkBenches);//crafting station

			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}