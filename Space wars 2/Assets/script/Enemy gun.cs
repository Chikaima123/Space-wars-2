using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemygun : MonoBehaviour
{
   public GameObject bulletPrefab; 
   public Transform firePoint;
   public float shootingInterval = 2f;

   private float shootingTimer;

   void Update()
   {
       shootingTimer += Time.deltaTime;

       if (shootingTimer >= shootingInterval)
       {
          Shoot();
          shootingTimer = 0f;
       }
   }

   void Shoot()
   {
       Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
   }  
}
