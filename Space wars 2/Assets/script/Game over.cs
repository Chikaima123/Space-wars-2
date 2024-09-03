using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
   public GameObject gameOverPanel;
   
   void Update()
   {
     if (GameObject.FindGameObjectWithTag("Player") == null)
     {
        gameOverPanel.SetActive(true);
     }
   }

   public void restart()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
