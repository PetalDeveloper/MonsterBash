using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] zombiePrefabs;

    private float spawnRangeX = 10;
    private float spawnPosZ = 225;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomZombie", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void SpawnRandomZombie()
    {
        int zombieIndex = Random.Range(0, zombiePrefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 3, spawnPosZ);
        Instantiate(zombiePrefabs[zombieIndex], spawnpos, zombiePrefabs[zombieIndex].transform.rotation);
    }
}

