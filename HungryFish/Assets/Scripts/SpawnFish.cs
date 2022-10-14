using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnFish : MonoBehaviour
{
    public GameObject topLeftPredator;
    public GameObject bottomLeftPredator;

    // Start is called before the first frame update
    void Start()
    {
        // Calls the function below and repeats the Instantiate
        InvokeRepeating("spawnPredatorTop", Random.Range(4, 8), Random.Range(6, 12));
        InvokeRepeating("spawnPredatorBottom", Random.Range(8, 15), Random.Range(10, 6));
    }

    private void spawnPredatorTop()
    {
        //Spawn fish
        // First Random.Range = X Axis
        // Second Random.Range = Y Axis
        //SPAWN FISH AT RANDOM: Instantiate(fishSpawner, new Vector3(Random.Range(-10.3f, -12.35f), Random.Range(3, -3.5f), 0), Quaternion.identity);
        Instantiate(topLeftPredator, new Vector3(-9.6f, 3f), Quaternion.identity);
    }
    void spawnPredatorBottom()
    {
        Instantiate(bottomLeftPredator, new Vector3(-10, -3.2f), Quaternion.identity);
    }

}

