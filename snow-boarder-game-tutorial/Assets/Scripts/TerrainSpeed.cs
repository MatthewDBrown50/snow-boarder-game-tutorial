using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpeed : MonoBehaviour
{
    SurfaceEffector2D se;
    float baseSpeed = 10f;
    float boostSpeed = 25f;

    void Start()
    {
        se = GetComponent<SurfaceEffector2D>();
        se.speed = baseSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            se.speed = boostSpeed;
        }
        else
        {
            se.speed = baseSpeed;
        }
    }
}
