﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMinAster : MonoBehaviour
{
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
            if (shot.isEnemyShot != isEnemy)
            {
                ScoreScript.scoreValue += 100;
                Damage(shot.damage);
                Destroy(shot.gameObject);
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
