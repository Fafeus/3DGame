using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    
    void Start()
    {
        
    }

    void Update()
    {
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        transform.position += transform.forward * vertical * speed * Time.deltaTime;
        transform.Rotate(new Vector3(0, horizontal * turnSpeed * Time.deltaTime, 0));

    }
}
