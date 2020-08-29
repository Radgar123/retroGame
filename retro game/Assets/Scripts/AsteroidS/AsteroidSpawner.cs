using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{

  public int Count;
  public List<GameObject> spawnPool;
  public GameObject asteroid;

  void Start()
  {
    spawnObject();
  }

  public void spawnObject()
  {
    int randomItem=0;
    GameObject toSpawn;
    MeshCollider c = asteroid.GetComponent<MeshCollider>();

    float Sx, Sy;

    Vector2 pos;

    for(int i=0;i<Count;i++)
    {
      randomItem = Random.Range(0, spawnPool.Count);
      toSpawn = spawnPool[randomItem];

      Sx = Random.Range(c.bounds.min.x, c.bounds.max.x);
      Sy = Random.Range(c.bounds.min.y, c.bounds.max.y);
      pos = new Vector2(Sx,Sy);

      Instantiate(toSpawn,pos,transform.rotation);
    }

  }






}
