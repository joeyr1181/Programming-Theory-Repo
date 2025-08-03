using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{

    // This class is responsible for spawning shapes at random positions within a defined area
    // It uses a timer to control the spawn rate and ensures shapes are spawned at specified intervals
    // Serialized fields allow customization in the Unity Inspector
    // The shapes are spawned within a defined area in the game world, specified by min and
    // max coordinates for both X and Z axes, with a fixed Y coordinate to match the plane height
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

    // Update is called once per frame
    // This method checks if the game is over before spawning shapes
    // It increments the timer and spawns shapes at regular intervals
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

    // This method spawns a shape at a random position within the defined area
    // It selects a random prefab from the array of shape prefabs and instantiates it at
    // a random position defined by the min and max coordinates for X and Z axes
    // The Y coordinate is fixed to ensure shapes appear on the plane
    // If no shape prefabs are defined, it does nothing
    // The random position is calculated using Random.Range for both X and Z axes
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
