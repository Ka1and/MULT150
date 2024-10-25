using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        ToggleAudio();
    }

    bool ToggleAudio()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
                return false;
            }
            else
            {
                audioSource.Play();
                return true;
            }
        }
        return audioSource.isPlaying;
    }
}