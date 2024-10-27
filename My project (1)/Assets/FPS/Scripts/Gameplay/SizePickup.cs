using Unity.FPS.Game;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class SizePickup : Pickup
    {
        [Header("Parameters")] [Tooltip("Amount of Shrink to Size on pickup")]
        public float SizeAmount = 0f;

        protected override void OnPicked(PlayerCharacterController player)
        {
            Size playerSize = player.GetComponent<Size>();
            playerSize.Shrink(SizeAmount);
            PlayPickupFeedback();
            Destroy(gameObject);
            }
    }
}