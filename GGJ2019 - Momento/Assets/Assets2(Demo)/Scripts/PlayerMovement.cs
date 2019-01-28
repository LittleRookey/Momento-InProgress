using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D rb;
    private float moveH, moveV;
    [SerializeField] private float moveSpeed = 5.0f;

    private Animator anim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        moveH = Input.GetAxis("Horizontal") * moveSpeed;
        moveV = Input.GetAxis("Vertical") * moveSpeed;

        if(Input.GetKeyDown(KeyCode.W)) {
            anim.SetBool("top", true);
        } else if (Input.GetKeyUp(KeyCode.W)) {
            anim.SetBool("top", false);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("left", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("left", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("right", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("right", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("down", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("down", false);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveH, moveV);
    }

}
