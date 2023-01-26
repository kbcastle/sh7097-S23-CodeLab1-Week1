using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSpecial : MonoBehaviour
{

    public GameObject spawnableSpecial;

    public float spawnTimeMin;

    public float spawnTimeMax;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSpecial", Random.Range(spawnTimeMin, spawnTimeMax),
                Random.Range(spawnTimeMin, spawnTimeMax));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnSpecial()
    {
        var position = new Vector3(Random.Range(50, -50), 12, Random.Range(50, -50));
        Instantiate(spawnableSpecial, position, Quaternion.identity);
    }
}
