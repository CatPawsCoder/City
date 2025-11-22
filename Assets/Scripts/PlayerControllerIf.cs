using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerIf : MonoBehaviour
{


    private int speed = 20;
    //public bool gameOver;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //если конец игры не наступил то мы движемся вперед
        //if (gameOver == false)
        //{
        //    transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //}

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        
    }
}
