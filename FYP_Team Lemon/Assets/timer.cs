using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float countSpeed = 1f; 
    public static float currentValue = 0f; 
    public Text timerText; 

    void Update()
    {
        if (map1win.win == 0)
        {
            currentValue += countSpeed * Time.deltaTime; // Increment current value over time
        }
        else
        {

        }
        UpdateTimerText(); // Update the timer text
    }

    void UpdateTimerText()
    {
        // Format the current value as minutes and seconds
        int minutes = Mathf.FloorToInt(currentValue / 60);
        int seconds = Mathf.FloorToInt(currentValue % 60);
        string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);

        // Update the Text component with the formatted timer string
        timerText.text = timerString;
    }
}
