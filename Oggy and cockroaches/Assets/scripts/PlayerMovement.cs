using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    private Rigidbody2D body;
    private Animator anim;
    private bool grounded;

    private bool moveleft;
    private bool moveright;
    private float horizontalmove;
    private bool ring = false;

    private void Awake()
    {
        // grab reference from object
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    float verticalInput;

    private void Start()
    {
        anim.SetTrigger("fall");
    }

    private void Update()
    {
        MovePlayer();
    }

    public void PointerUpLeft()
    {
        moveleft = false;
    }

    public void PointerDownLeft()
    {
        moveleft = true;
    }

    public void PointerUpRight()
    {
        moveright = false;
    }

    public void PointerDownRight()
    {
        moveright = true;
    }

    private void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (moveleft)
        {
            horizontalmove = -speed;
        }
        else if (moveright)
        {
            horizontalmove = speed;
        }
        else
        {
            horizontalmove = 0;
        }

        body.velocity = new Vector2(
            (horizontalmove != 0 ? horizontalmove : horizontalInput * speed),
            body.velocity.y
        );

        if (horizontalInput > 0.01f || horizontalmove > 0.01f)
            transform.localScale = new Vector3(2, 2, 2);
        else if (horizontalInput < -0.01f || horizontalmove < -0.01f)
            transform.localScale = new Vector3(-2, 2, 2);
        verticalInput = Input.GetAxis("Vertical");
        //Flip player when moving left

        // body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) && grounded)
        {
            Jump();
        }

        // set animator parameters
        anim.SetBool("run", horizontalInput != 0 || horizontalmove != 0);
        anim.SetBool("grounded", grounded);
    }

    public void Jump()
    {
        if (grounded)
        {
            body.velocity = new Vector2(body.velocity.x, verticalInput + jumpSpeed);
            anim.SetTrigger("jump");
            grounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;

        if (collision.gameObject.tag == "Collider")
        {
            anim.SetTrigger("fall");
            grounded = false;
            UIManager.Instance.Gameover();
        }
        if (collision.gameObject.tag == "ExitDoor")
            UIManager.Instance.GameEnd();

        if (collision.gameObject.tag == "Cockroaches")
        {
            Destroy(collision.gameObject);
            UIManager.Instance.Gameover();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ring")
        {
            Destroy(collision.gameObject);
            ring = true;
        }
        if (collision.gameObject.tag == "ExitDoor")
        {
            if (ring)
            {
                UIManager.Instance.GameEnd();
            }
        }
    }
}
