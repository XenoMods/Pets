using System.Reflection;
using Reactor.Extensions;
using Reactor.Unstrip;
using UnityEngine;
using XenoCore.Skin;
using XenoCore.Utils;

namespace Pets {
	public static class StandardPets {
		public static readonly ResourceLoader LOADER = new ResourceLoader("Pets.Resources.",
			Assembly.GetExecutingAssembly());

		public static readonly BundleDefinition BUNDLE = LOADER.Bundle("pets");

		public static readonly PetDefinition CREWPET = BUNDLE.SkinPet("Crewpet");
		public static readonly PetDefinition BEAR = BUNDLE.SkinPet("Bear");
		public static readonly PetDefinition FOX = BUNDLE.SkinPet("Fox");
		public static readonly PetDefinition RABBIT = BUNDLE.SkinPet("Rabbit");

		public static void Load() {
			PetsController.Add(CREWPET);
			PetsController.Add(BEAR);
			PetsController.Add(FOX);
			PetsController.Add(RABBIT);
		}
	}
}