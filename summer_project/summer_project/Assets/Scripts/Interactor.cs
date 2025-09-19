using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;


public class Interactor : MonoBehaviour
{
    public float InteractionRadius;
    private InteractableObject _closestInteractable;
    
    public bool isTriggered = false;// this is for player enter paper's trigger
    public GameObject target;
    public InteractableObject paper_interact = null;

    public int noteCount = 0;
    //get the animator component
    void Start()
    {
        
    }
    
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E) && isTriggered)
        {
            print("Interacted!!!!!!!!");
            
            paper_interact.StartUnfolding();
            noteCount++;
        }

        if (noteCount >= 11)
        {
            Invoke("SwitchToScene",7);
        }
    }

    private void SwitchToScene()
    {
        SceneManager.LoadScene("start_menu");
    }


    private void DetectClosestInteractableInRange()
    {
        var oldClosestInteractable = _closestInteractable;
        _closestInteractable = 
            Physics2D.OverlapCircleAll(transform.position, InteractionRadius)
                .Select(x => x.GetComponent<InteractableObject>())
                .Where(x => x != null)
                .OrderBy(x => Vector2.Distance(x.transform.position, transform.position))
                .FirstOrDefault();
        if (oldClosestInteractable != null)
        {
            oldClosestInteractable.SetInRange(false);
        }

        if (_closestInteractable != null)
        {
            _closestInteractable.SetInRange(true);
        }
        
    }

    //this is how, when the player encounters the "paper" object, the ontrigger event occurs and it registers
    //the specific paper (0,1,2)
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Paper"))
        {
            isTriggered = true;

            paper_interact = other.gameObject.GetComponent<InteractableObject>();
            
        }
    }

    //then when the player leaves, reset the variables so that the player can't press "e" and have a note
    //open where there is no note
    private void OnTriggerExit2D(Collider2D other)
    {
        isTriggered = false;

        paper_interact = null;
    }
}
