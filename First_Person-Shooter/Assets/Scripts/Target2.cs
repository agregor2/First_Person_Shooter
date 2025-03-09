using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ATTATCH THIS TO BOSS AND CHANGE THE HEALTH IF NEEDED BUT THIS WILL APPLY TO ALL BOSS
public class Target2 : MonoBehaviour, IDamageable
{

    public float health = 10000f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    

}
