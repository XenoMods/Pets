using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using HarmonyLib;
using Reactor;
using XenoCore;
using XenoCore.Utils;

namespace Pets {
	[BepInPlugin(Id)]
	[BepInProcess(Globals.PROCESS)]
	[BepInDependency(ReactorPlugin.Id)]
	[BepInDependency(XenoPlugin.Id)]
	// ReSharper disable once ClassNeverInstantiated.Global
	public class PetsPlugin : BasePlugin {
		public const string Id = "com.mishin870.pets";
		public static readonly string Version = "1.0.0";

		public Harmony Harmony { get; } = new Harmony(Id);

		public override void Load() {
			Harmony.PatchAll();
			
			VersionsList.Add("Pets", Version, true);

			StandardPets.Load();
		}
	}
}