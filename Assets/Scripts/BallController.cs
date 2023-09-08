using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private float movementSpeed = 0.5f;
    public float verticalInput = 0.2f;
    public float horizontalInput = 0.1f;
    private Vector3 getPos;
    private Rigidbody ballRigidbody;
    public float jumpSpeed = 50.0f;
    public bool isJumping;
    public Collider bottomCollider;
    public float verticalVelocity;
    public Vector3 startPosition;



    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
        bottomCollider = GetComponent<BoxCollider>();
        verticalVelocity = ballRigidbody.velocity.y;
        startPosition = ballRigidbody.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        getPos = transform.position;
        if (isJumping == false && Input.GetKey(KeyCode.B) && ballRigidbody.velocity.y <= 0)
        {
            ballRigidbody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            isJumping = true;
        }
        // reset player position
        if (Input.GetKey(KeyCode.P))
        {
            transform.position = startPosition;
        }


        // movement code
        if (Input.GetKey(KeyCode.L))
        {

            transform.Translate(Vector3.right * horizontalInput * movementSpeed);
        }
        if (Input.GetKey(KeyCode.J))
        {

            transform.Translate(Vector3.left * horizontalInput * movementSpeed);
        }
        

    }

}