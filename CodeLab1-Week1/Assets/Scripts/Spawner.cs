using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject spawnable;

    public float spawnTime;

    public float spawnSpeedIncrease;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime = spawnTime * spawnSpeedIncrease;
    }

    void Spawn()
    {
        var position = new Vector3(Random.Range(50, -50), 12, Random.Range(50, -50));
        Instantiate(spawnable, position, Quaternion.identity);
    }
}
