using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public Rigidbody2D healthPickupRigidbody;

    private void FixedUpdate()
    {
        if (healthPickupRigidbody.transform.position.y <= -7f)
        {
            Destroy(gameObject);
        }
    }
}
