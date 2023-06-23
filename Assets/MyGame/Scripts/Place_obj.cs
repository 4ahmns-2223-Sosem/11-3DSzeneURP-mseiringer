using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place_obj : MonoBehaviour
{
    public GameObject objectPrefab; 
    public Vector3 spawnAreaSize; 

    private void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            Vector3 randomPosition = GetRandomPosition();
            Instantiate(objectPrefab, randomPosition, Quaternion.identity);
        }
    }

    private Vector3 GetRandomPosition()
    {
        Vector3 spawnAreaCenter = transform.position;
        Vector3 minSpawnArea = spawnAreaCenter - spawnAreaSize / 2f;
        Vector3 maxSpawnArea = spawnAreaCenter + spawnAreaSize / 2f;

        float randomX = UnityEngine.Random.Range(minSpawnArea.x, maxSpawnArea.x);
        float randomY = UnityEngine.Random.Range(minSpawnArea.y, maxSpawnArea.y);
        float randomZ = UnityEngine.Random.Range(minSpawnArea.z, maxSpawnArea.z);

        return new Vector3(randomX, randomY, randomZ);
    }
}