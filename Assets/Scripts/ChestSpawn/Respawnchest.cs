using UnityEngine;

public class Respawnchest : MonoBehaviour
{
    public GameObject chestPrefab; // Prefab of the chest to respawn
    public Transform[] spawnPoints; // Array of spawn points for the chest
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RespawnChest();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RespawnChest()
    {
        //foreach (Transform spawnPoint in spawnPoints)
        //{
         //   Instantiate(chestPrefab, spawnPoint.position, spawnPoint.rotation);
       // }
    }
}
