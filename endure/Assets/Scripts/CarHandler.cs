using UnityEngine;
using UnityEngine.InputSystem;

public class CarHandler : MonoBehaviour
{
    //access the rigidbody
    [SerializeField] Rigidbody rb;

    [SerializeField] 
    Transform gameModel;

   //max values
   //private float maxSteerVelocity = 2;
   //private float maxForwardVelocity = 100;
   
    //multipliers
    private float accelerationMultiplier = 40;
    private float brakesMultiplier = 10;
    private float steeringMultiplier = 5;

    //input
    private Vector2 input = Vector2.zero;

    void Update()
    {
        //rotate car model when "turning"
        gameModel.transform.rotation = Quaternion.Euler(0, rb.linearVelocity.x * 5, 0);
    }
    void FixedUpdate()
    {
        //apply acceleration
        if (input.y > 0)
        {
            Accelerate();
        }
        else
            //when player lets go of the input button, it will slow down automatically
        {
            rb.linearDamping = 0.2f;
        }

        //apply brakes
        if (input.y < 0)
        {
            Brake();
        }

        Steer();
        
        //force the car to not go backwards
        if (rb.linearVelocity.z <= 0)
        {
            rb.linearVelocity = Vector3.zero;
        }
    }

    void Accelerate()
    {
        //no drag when accelerating the car (not slowing down)
        rb.linearDamping = 0;
        
        //stay within speed limit
      //  if (rb.linearVelocity.z >= maxForwardVelocity)
       // {
        //    return;
        //}
        //push rigidbody in forward direction with speed:
        rb.AddForce(rb.transform.forward * accelerationMultiplier * input.y);
    }

    void Brake()
    {
        //don't brake unless we are going forward
        if (rb.linearVelocity.z <= 0)
            return;
        rb.AddForce(rb.transform.forward * brakesMultiplier * input.y);
    }

    void Steer()
    {
        if (Mathf.Abs(input.x) > 0)
        {
            //speed-based steering limit. 
           // float speedBaseSteerLimit = rb.linearVelocity.z / 5.0f;
           // speedBaseSteerLimit = Mathf.Clamp01(speedBaseSteerLimit);
            
            //move car in sideways direction
            rb.AddForce(rb.transform.right * steeringMultiplier * input.x);
            
            //normalize x velocity
           // float normalizeX = rb.linearVelocity.x / maxSteerVelocity;
            
            //ensure that we don't allow it to get larger than 1 in magnitude
           // normalizeX = Mathf.Clamp(normalizeX, -1.0f, 1.0f);
            
            //make sure we stay within the speed limit
           // rb.linearVelocity = new Vector3(normalizeX * maxSteerVelocity, 0, rb.linearVelocity.z);
        }
        else
        {
            //auto center car
            rb.linearVelocity = Vector3.Lerp(rb.linearVelocity, new Vector3(0, 0, rb.linearVelocity.z), rb.linearVelocity.magnitude);
        }
    }

    public void SetInput(Vector2 inputVector)
    {
        inputVector.Normalize();
        input = inputVector;
    }
    
}
