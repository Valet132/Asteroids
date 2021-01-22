using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsterMove : MonoBehaviour
{
    public Vector2 speed = new Vector2(10, 10);


    public Vector2 direction = new Vector2(0, -1);
    private Vector2 movement;
    public int damage = 1;
    public bool isEnemyShot = false;

    void Update()
    {

        movement = new Vector2(
            speed.x * direction.x,
            speed.y * direction.y);
        
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = movement;
        if (transform.position.x < -10)
        transform.position = new Vector3 (transform.position.x + 20f, transform.position.y, transform.position.z);
        else if (transform.position.x > 10)
        transform.position = new Vector3 (transform.position.x - 20f, transform.position.y, transform.position.z);
        else if (transform.position.y < -5)
            transform.position = new Vector3(transform.position.x, transform.position.y + 10f, transform.position.z);
        else if (transform.position.y > 5)
            transform.position = new Vector3(transform.position.x, transform.position.y - 10f, transform.position.z);
    }
}
