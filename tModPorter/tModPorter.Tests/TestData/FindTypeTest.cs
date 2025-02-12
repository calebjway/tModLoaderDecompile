using Terraria.ModLoader;

public abstract class FindTypeTest : Mod
{
	void ViaMemberAccess(Mod mod) {
		int a = mod.BuffType("BuffClass");
		int b = mod.DustType("DustClass");
		int c = mod.ItemType("ItemClass");
		int d = mod.MountType("MountClass");
		int e = mod.NPCType("NPCClass");
		int f = mod.PrefixType("PrefixClass");
		int g = mod.ProjectileType("ProjectileClass");
		int h = mod.TileEntityType("TileEntityClass");
		int i = mod.TileType("TileClass");
		int j = mod.WallType("WallClass");

		int k = mod.GetGoreSlot("GoreTextureOrClass");
		int l = ModGore.GetGoreSlot("ModName/GoreTextureOrClass");
#if COMPILE_ERROR
		int m = mod.GetGoreSlot<GoreClass>();
#endif
	}

	int ViaIdentifier() => BuffType("BuffClass");

	int? ViaConditionalAccess(Mod mod) => mod?.BuffType("BuffClass");
}