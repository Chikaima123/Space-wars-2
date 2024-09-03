using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{ 
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
   {
       Move();
   }
   
    private void Move()
   {
      playerDirection.x = Input.GetAxisRaw("Horizontal");
      playerDirection.y = Input.GetAxisRaw("Vertical");

      playerDirection.Normalize();
      
      rb.velocity = playerDirection * playerSpeed;
   }
}   
