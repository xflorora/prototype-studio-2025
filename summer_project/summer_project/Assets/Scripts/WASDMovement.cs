using UnityEngine;

public class WASDMovement : MonoBehaviour
{
    private static readonly int IsWalking = Animator.StringToHash("isWalking");

    //defining the keycode movements
    public KeyCode keyUp;
    public KeyCode keyDown;
    public KeyCode keyLeft;
    public KeyCode keyRight;
    
    //bool to move
    public bool canMove;
    
    //speed
    float speed = 7f;
    
    //rigidbody
    Rigidbody2D rb;
    //animator
    private Animator animator;

    //true false statement for walking
    private bool isWalking;
    
    //start is called once before the first execution of update after the MonoBehaviour is created
    void Start()
    {
        //calling rigidbody + animator + the bool to move is true (player can move)
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        canMove = true;
    }
    
    void Update()
    {
        if (!canMove) return;
        animator.SetBool(IsWalking, isWalking);
        isWalking = false;
        
        //if the player presses the respective key, transform the player's position in the corresponding direction
        //at the assigned speed in the intervals in seconds between each frame
        if (Input.GetKey(keyUp))
        {
            isWalking = true;
            transform.position += Vector3.up * (speed * Time.deltaTime);
        }
        
        if(Input.GetKey(keyDown))
        {
            isWalking = true;
            transform.position += Vector3.down * (speed * Time.deltaTime);
        }
        
        if(Input.GetKey(keyLeft))
        {
            isWalking = true;
            transform.position += Vector3.left * (speed * Time.deltaTime);
        }
        
        if(Input.GetKey(keyRight))
        {
            isWalking = true;
            transform.position += Vector3.right * (speed * Time.deltaTime);
        }
    }
}
