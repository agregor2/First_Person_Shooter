using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ATTATCH THIS TO ANY NORMAL ENEMY, TARGET 2 WILL BE FOR BOSS
public class Target1 : MonoBehaviour, IDamageable
{

    public float health = 100f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    

}
