using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject Asteroidm;
    public GameObject Asteroidm2;
    public int hp = 1;
    public bool isEnemy = true;
    
    public void Damage(int damageCount)
    {
        hp -= damageCount;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        Shot shot = otherCollider.gameObject.GetComponent<Shot>();
        if (shot != null)
        {
            if(shot.isEnemyShot != isEnemy)
            {
                ScoreScript.scoreValue += 50;
                Damage(shot.damage);
                Destroy(shot.gameObject);
                Instantiate(Asteroidm, GetComponent<Rigidbody2D>().position, Quaternion.identity);
                Instantiate(Asteroidm2, GetComponent<Rigidbody2D>().position, Quaternion.identity);
            }
        }
        Enemyscr rot = otherCollider.gameObject.GetComponent<Enemyscr>();
        if (rot != null)
        {
            if (rot.isEnemyShot == isEnemy)
            {
                Damage(rot.damage);
            }
        }
    }
}
