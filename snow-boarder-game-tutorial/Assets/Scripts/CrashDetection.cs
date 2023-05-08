using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Terrain")
        {
            Debug.Log("Game lost!");
        }
    }
}
