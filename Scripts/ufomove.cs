using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufomove : MonoBehaviour
{
    GameObject player;

    const float speedMove = 1.0f;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        float direction = player.transform.position.x - transform.position.x;
        float directiony = player.transform.position.y - transform.position.y;
        if ((Mathf.Abs(direction) < 20)&((Mathf.Abs(directiony) < 10)))
        {
            Vector3 pos = transform.position;
            pos.x += Mathf.Sign(direction) * speedMove * Time.deltaTime;
            pos.y += Mathf.Sign(directiony) * speedMove * Time.deltaTime;
            transform.position = pos;
        }
    }
   
}

