using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CockroachesMovement : MonoBehaviour
{
    // public GameObject box;

    // // Use this for initialization
    // void Start () {

    // }

    // // Update is called once per frame
    // void Update () {
    //     //transform.LookAt(box.transform);
    //     Quaternion targetRotation = Quaternion.LookRotation(box.transform.position - transform.position);
    //     transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 1 * Time.deltaTime);
    //     transform.position += transform.forward * 3f * Time.deltaTime;
    // }
    public float moveDistance = 30f; // Distance to move left and right
    public float moveSpeed = 2.5f; // Speed of movement
    private float startPosition;
    private float targetPosition;
    private bool movingRight = true;
    private Vector3 initialScale;
    private Rigidbody2D cockroache;
    public GameObject player;
    public GameObject obstacle;
    public AudioSource enemyAudio;

    // void Update() { }

    void Start()
    {
        startPosition = transform.position.x;
        targetPosition = startPosition + moveDistance;
        initialScale = transform.localScale;
    }

    void Update()
    {
        // Get the horizontal positions of the player and the obstacle
        float playerHorizontalPosition = player.transform.position.x ;
        float obstacleHorizontalPosition = obstacle.transform.position.x-10;

        // Check if the horizontal positions match
        if (playerHorizontalPosition >= obstacleHorizontalPosition) {
            //play audio
            enemyAudio.Play();
         }
        if (movingRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            if (transform.position.x >= targetPosition)
            {
                movingRight = false;
                transform.localScale = initialScale;
            }
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            if (transform.position.x <= startPosition)
            {
                movingRight = true;
                transform.localScale = new Vector3(-initialScale.x, initialScale.y, initialScale.z);
            }
        }
    }
}
