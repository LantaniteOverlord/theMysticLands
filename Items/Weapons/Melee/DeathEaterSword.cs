using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMysticLands.Items.Weapons.Melee
{
	public class DeathEaterSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("DeathEaterSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("kinda like necromancy... I think? " + "testing sword don't use");
		}

		public override void SetDefaults() 
		{
			item.damage = 70;
			item.melee = true;
			item.width = 40;
			item.height = 10;
			item.useTime = 7;
			item.useAnimation = 15;
			item.shoot = ProjectileID.VampireKnife;
			item.shootSpeed = 30;
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
			recipe.AddIngredient(null, "BloodMoonsEdge");
			recipe.AddIngredient(ItemID.PearlwoodSword, 1);
			recipe.AddIngredient(ItemID.SoulDrain, 1); //life drain
			//dont forget to add biome souls
			recipe.AddTile(TileID.DemonAltar);      //crafting station
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}