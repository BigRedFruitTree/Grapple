using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D myRB;
    public Transform weaponSlot;

    [Header("Movement Settings")]
    public float speed = 15.0f;
    public float jumpHeight = 5.0f;
    public float groundDetectDistance = 1f;
    private Vector2 groundDetection;
    public int jumps = 2;
    public int jumpsMax = 2;
    public bool isGrounded = false;
    public bool isRight = true;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        groundDetection = new Vector2(transform.position.x, transform.position.y - .51f);

        Vector3 temp = myRB.velocity;

            float verticalMove = Input.GetAxisRaw("Vertical");
            float horizontalMove = Input.GetAxisRaw("Horizontal");

            temp.z = horizontalMove * speed;

            if (Physics2D.Raycast(groundDetection, Vector2.down, groundDetectDistance))
            {
                jumps = jumpsMax;

                isGrounded = true;
            }
            else
                isGrounded = false;

            if (Input.GetKeyDown(KeyCode.Space) && jumps > 0)
            {
                temp.y = jumpHeight;
                jumps--;
            }

            myRB.velocity = (temp.z * transform.right) + (temp.y * transform.up);

        if (Input.GetKey(KeyCode.A) && isRight == true)
        {
            isRight = false;
            Flip();
        }

        if (Input.GetKey(KeyCode.D) && isRight == false)
        {
            isRight = true;
            Flip();
        }

        void Flip()
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}
