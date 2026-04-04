using UnityEngine;

public class SafeSpawner : MonoBehaviour
{
    public GameObject housePrefab;
    public Transform player;
    public float avoidRadius = 8f; //how far away from the player the house must spawn

    //plane scale is 30,30,30 so half-size is 15
    private float planeHalfsize = 15f;
    
    void Start()
    {
         SpawnHouse();   
    }

    void SpawnHouse()
    {
        Vector3 spawnPos;

        //Keep picking a random point until it's OUTSIDE the avoid radius
        do{
            float x = Random.Range(-planeHalfSize, planeHalfSize);
            float z = Random.Range(-planeHalfSize, planeHalfSize);

            spawnPos = new Vector3(x, 0f, z);
        }
        while(Vector3.Distance(spawnPos, player.position) < avoid radius);

        //spawn the house once 
        Instantiate(housePrefab, spawnPos, Quaternion.identity);
    }
}
