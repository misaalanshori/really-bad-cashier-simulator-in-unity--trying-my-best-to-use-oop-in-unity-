using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductSpawner : MonoBehaviour
{
    [Header("Prefabs to Spawn")]
    public List<GameObject> prefabs;

    [Header("Spawn Offset")]
    public float spawnHeight = 1f; // Offset above the cube

    /// <summary>
    /// Spawns a random prefab from the list at a random position above this object.
    /// </summary>
    public void SpawnRandomProduct()
    {
        if (prefabs == null || prefabs.Count == 0)
        {
            Debug.LogWarning("No prefabs assigned to the spawner.");
            return;
        }

        // Get the bounds of the cube
        Bounds bounds = GetComponent<Collider>().bounds;

        // Generate a random position within the bounds extended upwards
        float randomX = Random.Range(bounds.min.x, bounds.max.x);
        float randomZ = Random.Range(bounds.min.z, bounds.max.z);
        float randomY = bounds.max.y + Random.Range(0, spawnHeight);

        Vector3 spawnPosition = new Vector3(randomX, randomY, randomZ);

        // Choose a random prefab from the list
        GameObject randomPrefab = prefabs[Random.Range(0, prefabs.Count)];

        // Instantiate the prefab at the random position
        Instantiate(randomPrefab, spawnPosition, Quaternion.identity);
    }
}
