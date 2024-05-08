using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rigidBody;
    public float jumpForce = 1.0f;
    public bool isGrounded = true;
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 pMovement = new Vector3(horizontalMovement, 0 ,verticalMovement);

        rigidBody.MovePosition(rigidBody.position + pMovement * 2 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    void Jump()
    {
        if (isGrounded == true)
        {
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        } else {

            isGrounded = true;
        }
    }
    void FixedUpdate()  
    {
        
    }
}
