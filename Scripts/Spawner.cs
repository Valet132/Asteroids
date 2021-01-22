using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform Spawnpos;
    public GameObject Asteroid;
    public float SpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Asteroid, Spawnpos.position, Quaternion.identity);
        StartCoroutine(SpawnCD());
    }

    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }

    IEnumerator SpawnCD()
    {
            yield return new WaitForSeconds(SpawnTime);
            Instantiate(Asteroid, Spawnpos.position, Quaternion.identity);
            Repeat();
    }
}
