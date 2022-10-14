using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class Predator : MonoBehaviour
{
    public Rigidbody2D predatorRigidbody;
    public int predatorSpeed;
    public int forwardForce;


    private void Start()
    {

    }

    private void FixedUpdate()
    {
        // Makes predator move right
        predatorRigidbody.velocity = Vector2.right * forwardForce * Time.deltaTime;

        // Destroys predator off-screen
        if (predatorRigidbody.transform.position.x >= 20)
        {
            Destroy(gameObject);
        }
    }
}