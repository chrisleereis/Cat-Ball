using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisabledFlipController : MonoBehaviour
{
    private float movementSpeed = 0.5f;
    public float verticalInput = 0.2f;
    public float horizontalInput = 0.1f;
    private Vector3 getPos;
    private Rigidbody playerRigidbody;
    public float jumpSpeed = 50.0f;
    public bool isJumping;
    private Collider bottomCollider;
    public float verticalVelocity;
    public Vector3 startPosition;

    

    void awake()
    {
       
    }


    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        bottomCollider = GetComponent<BoxCollider>();
        verticalVelocity = playerRigidbody.velocity.y;
        startPosition= playerRigidbody.position;
        //isJumping = false;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        getPos = transform.position;
        // rigidbody jumping
        if (isJumping == false && Input.GetKey(KeyCode.Space) && playerRigidbody.velocity.y <= 0)
        {
            playerRigidbody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            isJumping = true;
        }
        // reset player position
        if (Input.GetKey(KeyCode.R))
        {
            transform.position = startPosition;
        }


        // movement code
        if (Input.GetKey(KeyCode.D))
        {           
            transform.Translate(Vector3.right * horizontalInput * movementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * horizontalInput * movementSpeed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            //if (facingLeft == true)
            //{
                transform.Translate(Vector3.forward * verticalInput * movementSpeed);
            //}
            //else
            //{
            //    transform.Translate(Vector3.back * verticalInput * movementSpeed);
            //}
        }
        if (Input.GetKey(KeyCode.S))
        {
            //if (facingRight == true)
            //{
            //    transform.Translate(Vector3.forward * verticalInput * movementSpeed);
            //}
            //else
            //{
                transform.Translate(Vector3.back * verticalInput * movementSpeed);
            //}
        }

    }
    void OnCollisionEnter(Collision bottomCollider)
    {
        // yield return new WaitForSeconds(0.1f);
        isJumping = false;
    }
}
