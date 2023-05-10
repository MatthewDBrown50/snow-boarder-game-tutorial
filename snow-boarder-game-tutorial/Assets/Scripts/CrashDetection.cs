using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetection : MonoBehaviour
{
    [SerializeField] private float reloadDelay = 1f;
    [SerializeField] private ParticleSystem crashEffect;
    private AudioSource crashSoundEffect;
    private bool soundPlayed = false;

    private void Start()
    {
        crashSoundEffect = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Terrain"))
        {
            if(!soundPlayed)
            {
                crashSoundEffect.Play();
                soundPlayed = true;
            }
            crashEffect.Play();
            Invoke(nameof(ReloadScene), reloadDelay);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
