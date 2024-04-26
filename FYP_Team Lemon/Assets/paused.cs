using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paused : MonoBehaviour
{
    public static bool Paused = false;
    Text pausetext;
    void Start()
    {
        pausetext = GetComponent<Text>();
        pausetext.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Paused == false)
        {
            pausetext.enabled = false;
        }
        else
        {
            pausetext.enabled = true;
        }
    }
}
