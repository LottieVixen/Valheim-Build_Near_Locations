using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace Valheim_build_near_locations
{
	[BepInPlugin(GUID, Name, Version)]
	[BepInProcess("valheim.exe")]
	[HarmonyPatch]
	public class ChangePlacePieceNoBuild : BaseUnityPlugin
	{
		private const string GUID = "valheim.lottievixen.build_near_locations";
		private const string Name = "Build Near Locations";
		private const string Version = "1.0.0.0";

		void Awake()
		{
			var harmony = new Harmony(GUID);
			harmony.PatchAll();
		}

		[HarmonyPrefix]
		[HarmonyPatch(typeof(Location), "IsInsideNoBuildLocation")]
		static bool Placement_Patch_NoBuild(ref bool __result)
		{
			__result = false;
			return false;
		}
	}
}
