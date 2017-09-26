using Terraria.ModLoader;

namespace AGSmod
{
	class AGSmod : Mod
	{
		public AGSmod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
