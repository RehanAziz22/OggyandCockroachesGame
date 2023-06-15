using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsGeneratorRandom : MonoBehaviour
{

    public Transform GenPoint;
    public GameObject Obstacal;
    public bool coin,spikeball,step,spikePlate;


    public float difference;
    public float minDif, MaxDif;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        difference = Random.Range(minDif, MaxDif);

        if(transform.position.x < GenPoint.position.x && coin){
            transform.position = new Vector3(transform.position.x + difference,Random.Range(-2,2),transform.position.z);
            Instantiate(Obstacal,transform.position,transform.rotation);
        }
        if(transform.position.x < GenPoint.position.x && spikeball){
            transform.position = new Vector3(transform.position.x + difference,Random.Range(0,-5),transform.position.z);
            Instantiate(Obstacal,transform.position,transform.rotation);
        }
        if(transform.position.x < GenPoint.position.x && step){
            transform.position = new Vector3(transform.position.x + difference,Random.Range(-2,3),transform.position.z);
            Instantiate(Obstacal,transform.position,transform.rotation);
        }
        if(transform.position.x < GenPoint.position.x && spikePlate){
            transform.position = new Vector3(transform.position.x + difference,Random.Range(-3,-3),transform.position.z);
            Instantiate(Obstacal,transform.position,transform.rotation);
        }
    }
}
