using System.ComponentModel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMysticLands.Enemy
{
    public class LantaniteZombie : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("LantaniteZombie");  //name of enemy

            Main.npcFrameCount[npc.type] = 1;  //number of frames for the enemy
        }

        public override void SetDefaults()
        {
            npc.width = 18;  //widt of the hitbox for the enemy
            npc.height = 40; //height of the enemies hitbox
            npc.lifeMax = 1250; //max health
            npc.damage = 35;  // how much damage the enemy deals
            npc.defense = 5; //how much defence the enemy has
            npc.HitSound = SoundID.NPCHit1; //what sound the enemy makes when it is hit
            npc.DeathSound = SoundID.NPCDeath2;  //what sound the enemy makes when it is killed
            npc.value = 10f; //how much money it drops
            npc.knockBackResist = 0.75f;  //how much knockback is resisted
            npc.aiStyle = 3; //what ai it is
            aiType = NPCID.Zombie; //what vanilla ai it is
            animationType = NPCID.Zombie; //what animation type it is
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.025f; //where and how often it spawns
        }

        public override void NPCLoot()
        {
            Item.NewItem(npc.position, mod.ItemType("LantaniteBar"));
        }
    }
}
