using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClips : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSource audioSource;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            Destroy(gameObject);
        }
    }
    public void PlayTreeChopSFX()
    {
        audioSource.volume = 0.6f;
        audioSource.clip = clips[0];
        audioSource.pitch = Random.Range(0.5f, 1.5f);
        audioSource.Play();
    }
    public void PlayCollectSFX()
    {
        audioSource.volume = 0.2f;
        audioSource.clip = clips[1];
        audioSource.pitch = Random.Range(0.5f, 1.5f);
        audioSource.Play();
    }

    internal void PlayGoldCollectSFX()
    {
        audioSource.volume = 0.4f;
        audioSource.clip = clips[3];
        audioSource.pitch = 1;
        audioSource.Play();
    }

    internal void PlayGoldHitGroundSFX()
    {
        audioSource.volume = 1f;
        audioSource.clip = clips[4];
        audioSource.pitch = 1;
        audioSource.Play();
    }

    public void PlayStonePickSFX()
    {
        audioSource.volume = 0.6f;
        audioSource.clip = clips[2];
        audioSource.pitch = Random.Range(0.5f, 1.5f);
        audioSource.Play();
    }
}
