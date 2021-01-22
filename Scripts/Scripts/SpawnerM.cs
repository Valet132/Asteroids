using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerM : MonoBehaviour
{
    public Transform Spawnposm;
    public GameObject Asteroidm;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(Asteroidm, Spawnposm.position, Quaternion.identity);
        }
    }
}
