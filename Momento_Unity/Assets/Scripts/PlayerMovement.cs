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

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetBool("top", true);
            anim.SetBool("left", false);
            anim.SetBool("right", false);
            anim.SetBool("down", false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("right", true);
            anim.SetBool("left", false);
            anim.SetBool("top", false);
            anim.SetBool("down", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetBool("left", true);
            anim.SetBool("top", false);
            anim.SetBool("right", false);
            anim.SetBool("down", false);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetBool("down", true);
            anim.SetBool("left", false);
            anim.SetBool("right", false);
            anim.SetBool("top", false);
        }

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveH, moveV);
    }

}
