using BepInEx;
using RoR2;
using UnityEngine;

namespace PressToPickup
{
    [BepInPlugin("com.Moffein.PressToPickup", "PressToPickup", "1.1.0")]
    public class Plugin : BaseUnityPlugin
    {
        public void Awake()
        {
            On.RoR2.GenericPickupController.OnTriggerStay += (orig, self, other) =>
            {
                if (self.pickup != null && self.pickup.isTempItem)
                {
                    orig(self, other);
                }
            };
        }
    }
}
