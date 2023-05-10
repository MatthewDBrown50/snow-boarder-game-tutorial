using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardAmbience : MonoBehaviour
{
    private AudioSource boardAmbientSoundEffect;

    private void Start()
    {
        boardAmbientSoundEffect = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Terrain"))
        {
            boardAmbientSoundEffect.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Terrain"))
        {
            boardAmbientSoundEffect.Stop();
        }
    }
}
