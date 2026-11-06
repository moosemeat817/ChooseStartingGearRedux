using System.Collections.Generic;
using Il2Cpp;
using Il2CppTLD.AddressableAssets;
using MelonLoader;
using UnityEngine;

namespace ChooseStartingGear
{
    /// <summary>
    /// Loads gear item prefabs by name. GearItem.LoadGearItemPrefab was removed in game version 2.58,
    /// so prefabs are now loaded straight from the addressables.
    /// Each prefab is loaded once and cached; if the cached one has been unloaded, it is loaded again.
    /// </summary>
    internal static class GearPrefabs
    {
        private static readonly Dictionary<string, GearItem> s_Prefabs = new Dictionary<string, GearItem>();

        /// <summary>Gets a gear item's prefab by name (e.g. "GEAR_Hatchet"), or null if it doesn't exist.</summary>
        internal static GearItem Load(string gearName)
        {
            if (s_Prefabs.TryGetValue(gearName, out GearItem cached) && cached != null)
            {
                return cached;
            }

            GameObject prefab = AssetHelper.SafeLoadAssetAsync<GameObject>(gearName).WaitForCompletion();
            GearItem gearItem = prefab == null ? null : prefab.GetComponent<GearItem>();
            if (gearItem == null)
            {
                return null;
            }

            s_Prefabs[gearName] = gearItem;
            return gearItem;
        }
    }
}
