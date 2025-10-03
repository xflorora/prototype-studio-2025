using UnityEngine;

public class ParticleScript : MonoBehaviour
{
   public float speed = 1f;
   public float distanceFromCamera = 5f;
   
   void Update()
   {
      Vector3 mousePosition = Input.mousePosition;
      mousePosition.z = distanceFromCamera;

      Vector3 mouseScreenToWorld = Camera.main.ScreenToWorldPoint(mousePosition);

      Vector3 position = Vector3.Lerp(transform.position, mouseScreenToWorld, 1.0f - Mathf.Exp(-speed * Time.deltaTime));

      transform.position = position;
   }
}

