using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnFish : MonoBehaviour
{
    // Spawn Game Objects

    public GameObject topLeftPredator;
    public GameObject bottomRightPredator;
    public GameObject redFish;
    public GameObject healthPickup;
    public GameObject coinPickup;

    public float forwardForce;

    // Start is called before the first frame update
    void Start()
    {

        // Calls the function below and repeats the Instantiate to Spawn fish
        // Spawns Fish
        InvokeRepeating("spawnPredatorTop", Random.Range(4, 8), Random.Range(6, 12));
        InvokeRepeating("spawnPredatorBottom", Random.Range(8, 15), Random.Range(10, 16));
        InvokeRepeating("spawnRedFish", Random.Range(1, 2), Random.Range(4, 12));

        // Spawns Pickups
        InvokeRepeating("spawnHealthPickup", Random.Range(6, 9), Random.Range(8, 16));


        //Calls the function below and repeats the Instantiate to Spawn Powerup
        InvokeRepeating("spawnCoin", Random.Range(3, 6), Random.Range(6, 9));
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
        Instantiate(bottomRightPredator, new Vector3(10f, -3.3f), Quaternion.identity);
    }
    void spawnRedFish()
    {
        Instantiate(redFish, new Vector3(-9.6f, -1.41f), Quaternion.identity);
    }

    void spawnHealthPickup()
    {
        // Spawn at random position
        Instantiate(healthPickup, new Vector3(Random.Range(-6.24f, 6.90f), Random.Range(6.65f, 6.7f), 0), Quaternion.identity);
    }

    void spawnCoin()
    {
        Instantiate(coinPickup, new Vector3(Random.Range(-6.25f, 5.25f), Random.Range(6.65f, 6.7f), 0), Quaternion.identity);
    }

}

