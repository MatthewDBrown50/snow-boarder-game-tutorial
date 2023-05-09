using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float torque = 100;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(torque * Time.deltaTime);
        } 
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(-torque * Time.deltaTime);
        }
    }
}
