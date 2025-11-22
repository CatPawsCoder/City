using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  
    public int speed = 20;


    // public int speed = 20;
    //public float speed = 5;
    public float acceleration = 8f;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);

        //if speed 
        //transform.Translate(new Vector3(0, 0, 0.04f));
        //transform.Translate(new Vector3(0, speed * Time.deltaTime,0 ));
        //transform.Translate(Vector3.forward * Time.deltaTime * 20);
        //// ДВИЖЕНИЕ ВПЕРЕД/НАЗАД
        //if (Input.GetKey(KeyCode.W))
        //{
        //    // Движение вперед
        //    transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    // Движение назад
        //    transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        //}

        //// ПОВОРОТЫ
        //if (Input.GetKey(KeyCode.A))
        //{
        //    // Поворот влево
        //    transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    // Поворот вправо
        //    transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        //}
    }


}
