using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
   public float shakeDuration = 0.5f;
   public float shakeMagnitude = 0.2f;

   private Vector3 initialPosition;
   
   void OnEnable()
   {
      initialPosition = transform.localPosition;
   }

   public void Shake()
   {
       StartCoroutine(ShakeCoroutine());
   }

   private IEnumerator ShakeCoroutine()
   {
      float elapsedTime = 0f;

      while (elapsedTime < shakeDuration)
      {
          Vector3 randomPoint = initialPosition + Random.insideUnitSphere * shakeMagnitude;
          randomPoint.z = initialPosition.z;

          transform.localPosition = randomPoint;

          elapsedTime += Time.deltaTime;
          yield return null;
      }

      transform.localPosition = initialPosition;

    }
}
