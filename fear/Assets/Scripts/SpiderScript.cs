using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class SpiderScript : MonoBehaviour
{
   public GameObject spiderPrefab;
   //public GameObject redEffect;
   public void Start()
   {
      StartCoroutine(SpawnSpider());
   }
   

   IEnumerator SpawnSpider()
   {
      while (true)
      {
         Instantiate(spiderPrefab, new Vector3(Random.Range(-5,5),Random.Range(-5,5),0), Quaternion.identity);
         yield return new WaitForSeconds(.3f);
      }
   }
}
