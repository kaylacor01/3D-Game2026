using UnityEngine;

public class ObjSpawn : MonoBehaviour
{
    public GameObject objPrefab;
    public Transform player;
    public float spawnInterval = 2f;
    public int maxObj = 8;
    public float radius = 12f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObj), 1f, spawnInterval);
    }

    void SpawnObj()
    {
        GameObject[] rocks = GameObject.FindGameObjectsWithTag("rocks");

        int countInside = 0;
        foreach(GameObject rock in rocks){
            if(Vector3.Distance(rock.transform.position, player.position) < radius)
                countInside++;
        }

        if (countInside >= maxObj)
            return;

        Vector2 circle = Random.insideUnitCircle * radius;
        Vector3 spawnPosition = new Vector3(player.position.x + circle.x, 0.5f, player. position.z + circle.y);
        Instantiate(objPrefab, spawnPosition, objPrefab.transform.rotation);
    }
}
