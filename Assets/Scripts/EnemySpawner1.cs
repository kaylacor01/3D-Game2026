using UnityEngine;

public class EnemySpawner1 : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;
    public float spawnInterval = 2f;
    public int maxEnemies = 10;
    public float radius = 8f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");

        if (enemies.Length >= maxEnemies)
            return;

        Vector2 circle = Random.insideUnitCircle * radius;
        Vector3 spawnPosition = new Vector3(player.position.x + circle.x, 0.5f, player. position.z + circle.y);
        Instantiate(enemyPrefab, spawnPosition, enemyPrefab.transform.rotation);
    }
}
