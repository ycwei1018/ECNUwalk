using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudio : MonoBehaviour
{
    public AudioSource audioSource;
    private bool isPlaying = false;

    public void ToggleMusic()
    {
        if (isPlaying)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.Play();
        }

        isPlaying = !isPlaying;
    }
}
