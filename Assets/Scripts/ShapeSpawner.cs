using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    [Header("Shape Prefabs")]
    [SerializeField] private GameObject[] shapePrefabs;

    [Header("Spawn Timing")]
    [SerializeField] private float spawnInterval = 1.5f;

    [Header("Spawn Area (world units)")]
    [SerializeField] private float spawnMinX = -8f;
    [SerializeField] private float spawnMaxX = 8f;
    [SerializeField] private float spawnMinZ = -4f;
    [SerializeField] private float spawnMaxZ = 4f;
    [SerializeField] private float spawnY = 0f; // Fixed Y coordinate to match plane height

    private float timer = 0f;

    private void Update()
    {
        if (GameManager.Instance != null && GameManager.Instance.IsGameOver())
            return;

        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnShape();
            timer = 0f;
        }
    }

    private void SpawnShape()
    {
        if (shapePrefabs.Length == 0)
            return;

        float x = Random.Range(spawnMinX, spawnMaxX);
        float z = Random.Range(spawnMinZ, spawnMaxZ);
        Vector3 spawnPosition = new Vector3(x, spawnY, z);

        int prefabIndex = Random.Range(0, shapePrefabs.Length);
        Instantiate(shapePrefabs[prefabIndex], spawnPosition, Quaternion.identity);
    }
}
