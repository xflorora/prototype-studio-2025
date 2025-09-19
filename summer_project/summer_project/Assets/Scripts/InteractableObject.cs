using System;
using UnityEngine;
using System.Collections;

public class InteractableObject : MonoBehaviour
{
    public GameObject OpenOnInteract;
    public GameObject OpenWhenInRange;
    private bool _isInRange;
    public WASDMovement wasdMovement;
    private static readonly int IsUnfolding = Animator.StringToHash("isUnfolding");
    private static readonly int IsDone = Animator.StringToHash("isDone");
    public Animator animator;
    public bool isUnfolding;
    public bool isDone;
    public AudioSource source;
    public AudioClip clip;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    

    private void Update()
    {
        animator.SetBool(IsUnfolding, isUnfolding);
        animator.SetBool(IsDone, isDone);
        //isUnfolding = false;
        OpenWhenInRange.SetActive(_isInRange);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            OpenOnInteract.SetActive(false);
            //player can move again
            wasdMovement.canMove = true;
        }
    }

    public virtual void SetInRange(bool isInRange)
    {
        _isInRange = isInRange;
    }

    public virtual void OnInteract()
    {
        
        Debug.Log("Called OnInteract");
        //player cannot move
        wasdMovement.canMove = false;
        //note is visible
        OpenOnInteract.SetActive(true);

    }
    
    IEnumerator UnfoldingCo()
    {
        isUnfolding = true;
        source.PlayOneShot(clip);
        yield return new WaitForSeconds(1.2f);
        //_closestInteractable?.OnInteract();
        OnInteract();
        
        //isUnfolding = false;
        isDone = true;
    }

    public void StartUnfolding()
    {
        //print("StartUnfolding");
        StartCoroutine(UnfoldingCo());
    }


}
