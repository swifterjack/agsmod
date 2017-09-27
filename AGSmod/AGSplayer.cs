using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AGSmod
{
    public class AGSplayer : ModPlayer
    {
			public bool fodlepet = false;
		public override void ResetEffects()
		{
			fodlepet = false;
		}
    }
}