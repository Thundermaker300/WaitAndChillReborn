﻿namespace WaitAndChillReborn.Patches
{
    using HarmonyLib;
    using InventorySystem.Items.Firearms.Modules;
    using UnityEngine;

    [HarmonyPatch(typeof(StandardHitregBase), nameof(StandardHitregBase.PlaceBullethole))]
    internal static class BulletHolePatch
    {
        private static bool Prefix(StandardHitregBase __instance, Ray ray, RaycastHit hit) => !Handler.IsLobby;
    }
}