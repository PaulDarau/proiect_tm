using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileManager: MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLenght = 30;
    public int numberOftiles = 5;
    public Transform playerTransform;
    private List<GameObject> activeTiles = new List<GameObject>();
     void Start()
    {
      for(int i=0;i<numberOftiles;i++)
        {if (i == 0)
                SpawnTile(0);
        else
             SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }
    void Update()
    {
     if(playerTransform.position.z-35>zSpawn-(numberOftiles*tileLenght))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
        } 
    }
    public void SpawnTile(int tileIndex)
    {
      GameObject go =  Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(go);
        zSpawn += tileLenght;
    }
    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
