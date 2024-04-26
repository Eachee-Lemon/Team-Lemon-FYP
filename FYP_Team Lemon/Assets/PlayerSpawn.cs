using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject playerPrefab; 
    public Transform spawnPoint; 
    void Start()
    {
        SpawnPlayer();
    }
    void SpawnPlayer()
    {
        if (spawnPoint == null)
        {
            Debug.LogError("No spawn point assigned!");
            return;
        }

        // Spawn the player at the spawn point's position and rotation
        Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
