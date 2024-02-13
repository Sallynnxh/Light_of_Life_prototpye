using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float runSpeed=5.0f;
    public float jumpSpeed=2.0f;
    private Rigidbody2D myRigidbody;
    private BoxCollider2D myFeet;
    private bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myFeet = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Jump();
        CheckGounded();
    }
    void Run()
    {
        float moveDir = Input.GetAxis("Horizontal");
        Vector2 playerVel = new Vector2(moveDir * runSpeed, myRigidbody.velocity.y);
        myRigidbody.velocity = playerVel;
    }
    void CheckGounded()
    {
        isGround = myFeet.IsTouchingLayers(LayerMask.GetMask("Ground"));
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))//if push space->jump
        {
            if (isGround)
            {
                Vector2 jumpVel = new Vector2(0.0f, jumpSpeed);
                myRigidbody.velocity = Vector2.up * jumpVel;
            }
        }
    }

}
