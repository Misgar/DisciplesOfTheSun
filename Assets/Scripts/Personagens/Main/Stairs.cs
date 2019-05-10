using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isGrounded = false;
    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;
    // Update is called once per frame

      void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
    if (characterController.isGrounded)
        {
            

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

      
        moveDirection.y -= gravity * Time.deltaTime;

  
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
