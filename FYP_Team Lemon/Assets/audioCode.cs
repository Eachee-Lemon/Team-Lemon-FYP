using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioCode : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(PlayAudio);
    }

    void PlayAudio()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
