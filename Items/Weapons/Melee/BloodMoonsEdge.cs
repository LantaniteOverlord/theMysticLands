using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMysticLands.Items.Weapons.Melee
{
	public class BloodMoonsEdge : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("DeathEaterSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("although the projectile only appears like halfway across the screen it still counts as a projectile before it appears(you can see the particle effects) " + "testing sword don't use");
		}

		public override void SetDefaults() 
		{
			item.damage = 35;
			item.melee = true;
			item.width = 40;
			item.height = 10;
			item.useTime = 10;
			item.useAnimation = 10;
			item.shoot = ModContent.ProjectileType<Projectiles.CrimsonBlade>();
			item.shootSpeed = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);

			recipe.AddIngredient(ItemID.BloodButcherer, 1);
			recipe.AddIngredient(ItemID.Muramasa, 1);
			recipe.AddIngredient(ItemID.BladeofGrass, 1);
			recipe.AddIngredient(ItemID.FieryGreatsword, 1);
			recipe.AddIngredient(ItemID.CrimstoneBlock, 250);

			recipe.AddTile(TileID.DemonAltar);//crafting station

			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}