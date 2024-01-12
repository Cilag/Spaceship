using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnAsteroid", 0f, spawnInterval);
    }

    void SpawnAsteroid()
    {
        float randomX = Random.Range(-8f, 8f);
        Vector3 spawnPosition = new Vector3(randomX, 6f, 0f);
        Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
    }
}
