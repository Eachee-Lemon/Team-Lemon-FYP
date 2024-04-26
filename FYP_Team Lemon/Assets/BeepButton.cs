using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeepButton : MonoBehaviour
{
    public AudioClip audioClip; // Assign the audio clip in the Unity Editor
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Assign the AudioClip to the AudioSource if not already assigned
        if (audioSource.clip != audioClip)
        {
            audioSource.clip = audioClip;
        }
    }

    public void PlayAudio()
    {
        // Check if the audio clip is assigned
        if (audioClip != null)
        {
            // Play the audio
            audioSource.Play();
        }
    }
}
