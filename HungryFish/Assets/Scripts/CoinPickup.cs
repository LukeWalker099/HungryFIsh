using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPickup : MonoBehaviour
{
    public Rigidbody2D coinRigidbody;
    private void FixedUpdate()
    {
        if (coinRigidbody.transform.position.y <= -7f)
        {
            Destroy(gameObject);
        }
    }
}
