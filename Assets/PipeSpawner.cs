using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab; // Prefab لوله
    public float spawnInterval = 2f; // فاصله زمانی بین ایجاد لوله‌ها
    public float spawnHeightRange = 5f; // دامنه ارتفاع لوله‌ها

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    private void SpawnPipe()
    {
        float randomHeight = Random.Range(-spawnHeightRange, spawnHeightRange);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomHeight, 0);
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}
