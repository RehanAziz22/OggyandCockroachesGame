using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementStoryThree : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float jumpSpeed;
    private bool grounded;
    public AudioSource audiogameover;
    private int lives = 3;

    private Animator anim;

    public AudioSource oggyAudio;
    float killcount;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
        anim.SetBool("run", true);
        anim.SetBool("grounded", grounded);
        // if (Input.anyKeyDown)
        // {
        //     rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        // }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow))
        {
            moveLeft();
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveRight();
        }
    }

    public void moveLeft()
    {
        if (speed > 1)
        {
            speed = speed - 1;
            moveLeft();
        }
    }

    public void moveRight()
    {
        if (speed < 4)
        {
            speed = speed + 1;
            moveRight();
        }
    }

    public void Jump()
    {
        if (grounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            anim.SetTrigger("jump");
            // grounded = false;
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
            // UIManager.Instance.Gameover();
        }
        if (collision.gameObject.tag == "Cockroaches")
        {
            Destroy(collision.gameObject);
            killcount++;
            Debug.Log(killcount);
            if (killcount == 1)
            {
                oggyAudio.Play();
            }
            if (killcount >= 5)
            {
                killcount = 0;
            }
        }
        // if (collision.gameObject.tag == "Collider")
        // {
        //     anim.SetTrigger("fall");
        //     grounded = false;
        //         // UIManager.Instance.Gameover();
        // }
        // if (collision.gameObject.tag == "ExitDoor")
        //     UIManager.Instance.GameEnd();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            if (speed < 14)
            {
                speed = speed + 1;
            }
        }
        if (collision.gameObject.tag == "Collider")
        {
            Destroy(collision.gameObject);
            speed = speed - 1;
            if (speed == 0)
            {
                anim.SetTrigger("fall");
                grounded = false;
                UIManager.Instance.Gameover();
                audiogameover.Play();
            }
        }
    }
}
