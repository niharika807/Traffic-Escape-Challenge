using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 1f, 2f);
    }

    void SpawnObstacle()
    {
        float randomX = Random.Range(-2f, 2f);

        Instantiate(
            obstaclePrefab,
            new Vector3(randomX, 0.5f, 20f),
            Quaternion.identity
        );
    }
}
