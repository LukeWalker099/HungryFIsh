using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorLeft : MonoBehaviour
{
    public Rigidbody2D predatorRigidbody;
    public int predatorSpeed;
    public int forwardForce;

    private void FixedUpdate()
    {
        // Makes predator move right
        predatorRigidbody.velocity = Vector2.left * forwardForce * Time.deltaTime;

        // Destroys predator off-screen
        if (predatorRigidbody.transform.position.x >= 20)
        {
            Destroy(gameObject);
        }
    }
}
