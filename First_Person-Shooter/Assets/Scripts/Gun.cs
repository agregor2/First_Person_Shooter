using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header("References")]
    [SerializeField] GunData gunData;

    private void Start()
    {
        PlayerShoot.shootInput += Shoot;
    }


    public void Shoot()
    {
        Debug.Log("Shot Gun!")
    }

}