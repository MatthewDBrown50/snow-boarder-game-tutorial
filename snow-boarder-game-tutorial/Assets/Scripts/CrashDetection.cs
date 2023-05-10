using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetection : MonoBehaviour
{
    [SerializeField] private float reloadDelay = 1f;
    [SerializeField] private ParticleSystem crashEffect;
    private AudioSource crashSoundEffect;
    private bool hasCrashed = false;
    private PlayerController pc;

    private void Start()
    {
        crashSoundEffect = GetComponent<AudioSource>();
        pc = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Terrain") && !hasCrashed)
        {
            hasCrashed = true;
            crashSoundEffect.Play();
            crashEffect.Play();
            pc.DisableMovement();
            Invoke(nameof(ReloadScene), reloadDelay);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
