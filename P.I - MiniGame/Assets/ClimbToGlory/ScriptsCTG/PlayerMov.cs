using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMov : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumnpheight = 3f;

    public Transform groundcheck;
    float groundDistance = 0.4f;
    public LayerMask groundmask;

    Vector3 velocity;
    bool isgrounded;


    void Update()
    {
        isgrounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundmask);
        if (isgrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal3");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump") && isgrounded)
        {
            velocity.y = Mathf.Sqrt(jumnpheight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

       


    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        
        if (hit.collider.CompareTag("Star"))
        {
            
            SceneManager.LoadScene("Ganhador 3");
        }

        if (hit.collider.CompareTag("Finish"))
        {
            SceneManager.LoadScene("Perdedor 3");
        }
    }
}
