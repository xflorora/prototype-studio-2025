using UnityEngine;
using System.Collections;

public class WaspScript : MonoBehaviour
{
   public GameObject waspPrefab;
   public GameObject cicadaPrefab;
   private bool isSwatted = false;
   private Vector3 tempTarget;
   float swatTimer = 0f;
   
   public void Start()
   {
      StartCoroutine(SpawnWasp());
   }
   void Update()
   {
      if (isSwatted == false)
      {
         waspPrefab.transform.position = Vector3.MoveTowards(waspPrefab.transform.position,
            cicadaPrefab.transform.position,Time.deltaTime * 2f);  
      }
      else
      {
         waspPrefab.transform.position = Vector3.MoveTowards(waspPrefab.transform.position,
            tempTarget,Time.deltaTime * 2f);  
         swatTimer += Time.deltaTime;
         if (swatTimer > .5f)
         {
            isSwatted = false;
         }
      }
      
      if (Input.GetMouseButtonDown(0))
      {
         isSwatted = true;
         swatTimer = 0;
         tempTarget = new Vector3(Random.Range(transform.position.x - 5,transform.position.x + 5), 
            Random.Range(transform.position.y -5,transform.position.y +5), 0);
      }
      
   }
   
   IEnumerator SpawnWasp()
   {
      while (true)
      {
         Instantiate(waspPrefab, new Vector3(Random.Range(-4,4),Random.Range(-4,4),0), Quaternion.identity);
         yield return new WaitForSeconds(.3f);
      }
   }
}
