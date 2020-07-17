using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMysticLands.Items.Weapons.Melee
{
	public class BrokenSoulEater : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("DeathEaterSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("kinda like necromancy... I think? " + "the origonal sword used to bring back the anchient one " + "testing sword don't use");
		}

		public override void SetDefaults() 
		{
			item.damage = 3000;
			item.melee = true;
			item.width = 40;
			item.height = 10;
			item.useTime = 2;
			item.useAnimation = 5;
			item.shoot = ProjectileID.VampireKnife;
			item.shootSpeed = 5;
			item.useStyle = 6;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}