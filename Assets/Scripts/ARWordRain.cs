using UnityEngine;

public class ARWordRain : MonoBehaviour
{
    public GameObject[] wordPrefabs;
    public float spawnInterval = 0.5f;
    public float spawnRadius = 0.5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnWord), 0f, spawnInterval);
    }

    void SpawnWord()
    {
        Vector3 spawnPos = transform.position + new Vector3(
            Random.Range(-spawnRadius, spawnRadius),
            0,
            Random.Range(-spawnRadius, spawnRadius)
        );

        int index = Random.Range(0, wordPrefabs.Length);
        Instantiate(wordPrefabs[index], spawnPos, Quaternion.identity);
    }
}
