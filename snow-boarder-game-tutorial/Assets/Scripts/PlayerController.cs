using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float torque = 100;

    SurfaceEffector2D se;
    private float baseSpeed = 10f;
    private float boostSpeed = 25f;

    private void Start()
    {
        se = FindObjectOfType<SurfaceEffector2D>();
        se.speed = baseSpeed;
        rb = GetComponent<Rigidbody2D>();
    }
   
    private void Update()
    {
        RotatePlayer();
        AdjustSpeed();
    }

    private void RotatePlayer()
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

    private void AdjustSpeed()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            se.speed = boostSpeed;
        }
        else
        {
            se.speed = baseSpeed;
        }
    }
}
