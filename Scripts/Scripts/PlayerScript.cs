using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Vector2 speed = new Vector2(10, 10); //Скорость
    private Vector2 movement; //Управление


    void Update()
    {
        float inputX = Input.GetAxis("Horizontal"); //Информация оси
        float inputY = Input.GetAxis("Vertical");

        movement = new Vector2(
            speed.x * inputX,
            speed.y * inputY);

        bool shoot = Input.GetButtonDown("Fire1");
        shoot |= Input.GetButtonDown("Fire2");

        if(shoot)
        {
            WeaponScript weapon = GetComponent<WeaponScript>();
            if (weapon != null)
            {
                weapon.Attack(false);
            }
        }
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = movement;  //Перемещение
    }
}
