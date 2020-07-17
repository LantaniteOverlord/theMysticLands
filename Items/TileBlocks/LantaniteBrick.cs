using System;
using System.Reflection;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.CodeDom.Compiler;

namespace TheMysticLands.Items.TileBlocks
{
    public class LantaniteBrick : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 10;
            item.useAnimation = 10;
            item.createTile = mod.TileType("Lantanitebrick"); // what tile is placed when used
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(null, "LantaniteBar");
            recipe.AddIngredient(ItemID.StoneBlock, 1);

            recipe.AddTile(TileID.DemonAltar);//crafting station

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}