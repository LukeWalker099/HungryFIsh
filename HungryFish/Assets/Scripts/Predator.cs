using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Predator : MonoBehaviour
{
    public Rigidbody2D predatorRigidbody;
    public int predatorSpeed;
    public int forwardForce;

    private void FixedUpdate()
    {
        // Adds force to predator
        predatorRigidbody.AddForce(new Vector2 (forwardForce * Time.deltaTime, 0));  

        // *IMPLEMENT RANDOM.RANGE FOR MOVEMENT*
        if (predatorRigidbody.transform.position.y < 2.9f)
        {
            predatorRigidbody.AddForce(Vector2.up * Time.deltaTime * predatorSpeed);
        }
        else
        {
            if (predatorRigidbody.transform.position.y > -3.6)
            {
                new Vector3(Random.Range(-10.3f, -12.35f), Random.Range(3, -3.5f), 0);
                //predatorRigidbody.AddForce(new Vector2(Random.Range(-10.3f, -12.35f), 0));
                //predatorRigidbody.AddForce(Vector2.down * Time.deltaTime * predatorSpeed);
            }

        }
    }
}
