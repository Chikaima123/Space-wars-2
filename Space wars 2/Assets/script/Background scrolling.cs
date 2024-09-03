using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundscrolling : MonoBehaviour
{
  public float backgroundSpeed = 0.3f;  // Speed at which the background moves
  public Renderer backgroundRenderer; 

  // Update is called once per frame 
  void Update()
  {
    // Calculate the offset for the texture
    float offset = Time.time * backgroundSpeed;

    // Apply the offset to texture
    backgroundRenderer.material.mainTextureOffset = new Vector2(offset, 0);
  }

}
    
        
    

    
    
    
        
      
