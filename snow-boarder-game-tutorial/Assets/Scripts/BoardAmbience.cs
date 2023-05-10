using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardAmbience : MonoBehaviour
{
    [SerializeField] private AudioClip boardAmbientSoundEffect;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Terrain"))
        {
            audioSource.PlayOneShot(boardAmbientSoundEffect);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Terrain"))
        {
            audioSource.Stop();
        }
    }
}
