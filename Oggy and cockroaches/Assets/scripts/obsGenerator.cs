using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsGenerator : MonoBehaviour
{
    public Transform GenPoint;
    public GameObject Obstacal;

    float difference;
    public float minDif,
        MaxDif;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        difference = Random.Range(minDif, MaxDif);

        if (transform.position.x < GenPoint.position.x)
        {
            transform.position = new Vector3(
                transform.position.x + difference,
                transform.position.z
            );
            Instantiate(Obstacal, transform.position, transform.rotation);
        }
    }
}
