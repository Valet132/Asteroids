using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthPlayer : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public int hp = 3;
    public bool isEnemy = true;
    public GameObject deathMenuUI;

    public void Damage(int damageCount)
    {
        hp -= damageCount;
        transform.position = new Vector3(1,1,1);
        HealthBar.healthValue -= 1;
        if (hp <= 0)
        {
            Destroy(gameObject);
            Death();
        }
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        Shot shot = otherCollider.gameObject.GetComponent<Shot>();
        if (shot != null)
        {
            if (shot.isEnemyShot != isEnemy)
            {

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
    public void Death()
    {
        Time.timeScale = 0f;
        deathMenuUI.SetActive(true);
    }
}
