using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawn : MonoBehaviour {

    public GameObject meteorPrefab;
    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 3f;
    public float spawnXLimit = 6f;

    // Use this for initialization
    void Start () {
        Spawn();
	}

    private void Spawn()
    {
        if(maxSpawnDelay>minSpawnDelay)
        maxSpawnDelay -= 0.1f;
        float random = UnityEngine.Random.Range(-spawnXLimit, spawnXLimit);
        Vector3 spawnPos = transform.position + new Vector3(random, 0f, 0f);
        Instantiate(meteorPrefab, spawnPos, Quaternion.identity);

        Invoke("Spawn", UnityEngine.Random.Range(minSpawnDelay, maxSpawnDelay));
    }
}
