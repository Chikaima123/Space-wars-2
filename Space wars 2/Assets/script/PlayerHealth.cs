using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhealth : MonoBehaviour
{
   public int maxHealth = 3;
   [SerializeField] private int currentHealth;
   public GameObject explosionPrefab;

   void Start()
   {
     currentHealth = maxHealth;
   }
    
   public void TakeDamage(int damage)
   {
     currentHealth -= damage;

     if (currentHealth <= 0)
     {
        Die();
        
        GameOver();
     }
   }
   
   void Die()
   {
      Explode();
     Debug.Log("Player Died");
     Destroy(gameObject);
   }

   private void OnTriggerEnter2D(Collider2D collision)
   {
       Enemybullet bullet = collision.GetComponent<Enemybullet>();
       if (bullet != null && bullet.isEnemy)
       {
          TakeDamage(1);
          Destroy(bullet.gameObject);
       }
   }

   private void OnCollisionEnter2D(Collision2D collision)
   {
      if (collision.gameObject.CompareTag("Enemy"))
      {
         Die();
         GameOver();
      }
   }

   void GameOver()
   {
      Time.timeScale = 0;
   }

   void Explode()
   {
      GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
      Destroy(explosion, 1f);
   }   
   
}
