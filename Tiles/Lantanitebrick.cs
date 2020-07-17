using System;
using System.Reflection;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System.ComponentModel;

namespace TheMysticLands.Tiles
{
    public class Lantanitebrick : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;  //this makes the tile a solid block
           // Main.tileLighted[Type] = true;  //this makes the tile emit light

           // drop = Mod.ItemType("LantaniteBrick"); // what it drops when broken

            ModTranslation name = CreateMapEntryName();  // map stuff startt
            name.SetDefault("Lantanite brick");  // what the name of the tile is
            AddMapEntry(new Color(150, 120, 143), name); //what color it is on the map and what name it shows

            minPick = 70;  //pick strength needed
        }

       // public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) // might define light
       // {
        //    r = 0.5f;
        //    g = 0.75f;
        //    b = 1f;   //how much red green and blue light it gives off
       // }
    }
}