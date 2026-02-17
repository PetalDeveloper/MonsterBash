using UnityEngine;

public class SpawnTracer : MonoBehaviour
{
    public GameObject[] zombiePrefabs;

    public float spawnRangeY = -114;
    public float spawnPosX = 115;

    private float startDelay = 1;
    private float spawnInterval = 0.5f;
    

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
        Vector3 spawnpos = new Vector3(spawnPosX, 3, Random.Range(-spawnRangeY, spawnRangeY));
        Instantiate(zombiePrefabs[zombieIndex], spawnpos, zombiePrefabs[zombieIndex].transform.rotation);
    }
}

