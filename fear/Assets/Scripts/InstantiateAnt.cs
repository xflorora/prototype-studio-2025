using System;
using UnityEngine;

public class InstantiateAnt : MonoBehaviour
{
    public GameObject antPrefab;
    public GameObject antPrefab2;
    public GameObject shoes;
    public Animator shoesAnimator;

    private void Start()
    {
        shoesAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoesAnimator.SetTrigger("shoesOn");
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("AntTrigger"))
        {
            Instantiate(antPrefab, new Vector3(0, 0, 1), Quaternion.identity);
            Instantiate(antPrefab2, new Vector3(0, 0, 1), Quaternion.identity);
        }
    }
    
}
