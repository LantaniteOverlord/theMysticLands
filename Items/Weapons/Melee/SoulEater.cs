using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMysticLands.Items.Weapons.Melee
{
	public class SoulEater : ModItem
	{

		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("DeathEaterSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("kinda like necromancy... I think? " + "the origonal sword used to bring back the anchient one " + "testing sword don't use");
		}

		public override void SetDefaults() 
		{
			item.damage = 999999;
			item.melee = true;
			item.width = 40;
			item.height = 10;
			item.useTime = 2;
			item.useAnimation = 5;
			item.shoot = ModContent.ProjectileType<Projectiles.BloodSword>();
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

			recipe.AddIngredient(null, "DeathEaterSword");
			recipe.AddIngredient(ItemID.VampireKnives, 1);
			recipe.AddIngredient(ItemID.InfluxWaver, 1);
			recipe.AddIngredient(ItemID.TerraBlade, 1);
			recipe.AddIngredient(ItemID.StarWrath, 1);
			recipe.AddTile(TileID.DemonAltar);//crafting station

			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}