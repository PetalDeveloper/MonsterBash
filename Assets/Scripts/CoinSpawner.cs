using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject CoinPrefab;
    public Transform[] spawnpoints; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        InvokeRepeating("SpawnCoin", 0, 5);

    }

    // Update is called once per frame
    void SpawnCoin()
    {
        
        Instantiate(CoinPrefab, spawnpoints[Random.Range(0, spawnpoints.Length)].position, CoinPrefab.transform.rotation);

    }
}
