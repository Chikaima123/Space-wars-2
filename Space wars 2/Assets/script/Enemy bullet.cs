using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemybullet : MonoBehaviour
{
    public float speed = 5f;
    public float deactivate_timer = 3f;
    public Vector2 direction;
    public bool isEnemy = true;

    private void OnEnable()
    {
         Invoke("Deactivate", deactivate_timer);
    }
    
    private void OnDisable()
    {
        CancelInvoke();
    }

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
