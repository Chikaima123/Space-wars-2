using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerbullet : MonoBehaviour
{
   public Vector2 direction = new Vector2(1, 0);
   public float speed = 15f;
   [SerializeField] private float TimebeforeDestroy = 2;


   public Vector2 velocity;

   public bool isEnemy = false;

   private void start()
   {
      Destroy(gameObject, TimebeforeDestroy);
   } 
    
    private void Update()
    {
        velocity = direction * speed;
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos += velocity * Time.fixedDeltaTime;

        transform.position = pos;
    }
}
