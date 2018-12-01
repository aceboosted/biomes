using Terraria.ID;
using Terraria.ModLoader;

namespace Deicideon.Items
{
	public class cecilsblade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("cecils blade");
			Tooltip.SetDefault("no eyes, no problem");
		}
		public override void SetDefaults()
		{
			item.damage = 22;
			item.melee = false;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
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
			recipe.AddIngredient(ItemID.Lens, 3);
			recipe.AddIngredient(ItemID.LightsBane, 1);
			recipe.AddIngredient(ItemID.Ruby, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
