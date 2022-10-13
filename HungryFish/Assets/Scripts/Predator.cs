using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Predator : MonoBehaviour
{
    public Rigidbody2D predatorRigidbody;
    public int predatorSpeed;

    private void FixedUpdate()
    {
        if (predatorRigidbody.transform.position.y < 2.9f)
        {
            predatorRigidbody.AddForce(Vector2.up * Time.deltaTime * predatorSpeed);
        }
        else
        {
            if (predatorRigidbody.transform.position.y > -3.6)
            {
                predatorRigidbody.AddForce(Vector2.down * Time.deltaTime * predatorSpeed);

            }
        }
    }
}
