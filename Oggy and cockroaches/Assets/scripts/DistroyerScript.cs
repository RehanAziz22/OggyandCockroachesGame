using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistroyerScript : MonoBehaviour
{

    GameObject distroyerobj;

    // Start is called before the first frame update
    void Start()
    {
        
        distroyerobj = GameObject.Find("Distroyer");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < distroyerobj.transform.position.x){
            Destroy(gameObject);
        }
        
    }
}
