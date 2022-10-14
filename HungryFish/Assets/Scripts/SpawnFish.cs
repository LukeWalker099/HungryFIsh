using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFish : MonoBehaviour
{

    public GameObject fishSpawner;

    // Start is called before the first frame update
    void Start()
    {
        // Calls the function below and repeats the Instantiate
        InvokeRepeating("spawnFish", Random.Range(1, 3), Random.Range(4, 8));
    }

    private void spawnFish()
    {
        //Spawn fish
        // First Random.Range = X Axis
        // Second Random.Range = Y Axis
        //SPAWN FISH AT RANDOM: Instantiate(fishSpawner, new Vector3(Random.Range(-10.3f, -12.35f), Random.Range(3, -3.5f), 0), Quaternion.identity);
    }

}

