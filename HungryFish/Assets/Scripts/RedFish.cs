using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFish : MonoBehaviour
{
    public Rigidbody2D redFishRigidBody;
    public int predatorSpeed;
    public int forwardForce;

    private void FixedUpdate()
    {
        // Makes predator move right
        redFishRigidBody.velocity = Vector2.right * forwardForce * Time.deltaTime;

        // Destroys predator off-screen
        if (redFishRigidBody.transform.position.x >= 20)
        {
            Destroy(gameObject);
        }
    }
}
