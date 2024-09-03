using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpeed : MonoBehaviour
{
    public float initialTimeScale = 1.0f;
    public float maxTimeScale = 5.0f;
    public float speedIncreaseRate = 0.5f;
    public float timeToMaxSpeed = 60f;

    private float elapsedTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = initialTimeScale;    
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        float newTimeScale = Mathf.Lerp(initialTimeScale, maxTimeScale, elapsedTime / timeToMaxSpeed);

        Time.timeScale = newTimeScale;

        Time.timeScale = Mathf.Clamp(Time.timeScale, initialTimeScale, maxTimeScale);
    }

    void OnDestroy()
    {
         Time.timeScale = 1.0f;
    }
}
