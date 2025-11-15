using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // public int speed = 20;
    public float speed = 5;
    //public float acceleration = 8f;
    void Start()
    {
        
    }

   
    void Update()
    {

        //if speed 
        //transform.Translate(new Vector3(0, 0, 0.04f));
        transform.Translate(new Vector3(0, speed * Time.deltaTime,0 ));
        //transform.Translate(Vector3.forward * Time.deltaTime * 20);

    }
}
