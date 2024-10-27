using UnityEngine;



public class ShrinkPlayer : MonoBehaviour

{

    public float shrinkScale = 0.5f; // How much to shrink the player

    public Collider pickupCollider; // Collider on the shrink item



    void OnTriggerEnter(Collider other)

    {

        if (other.gameObject == pickupCollider.gameObject)

        {

            // Shrink the player when colliding with the pickup item

            transform.localScale = new Vector3(shrinkScale, shrinkScale, shrinkScale);

        }

    }

}