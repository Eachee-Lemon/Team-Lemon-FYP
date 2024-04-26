using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class map1timetaken : MonoBehaviour
{
    Text timetakentext;
    void Start()
    {
        timetakentext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimerText();
    }
    void UpdateTimerText()
    {
        // Format the current value as minutes and seconds
        int minutes = Mathf.FloorToInt(timer.currentValue / 60);
        int seconds = Mathf.FloorToInt(timer.currentValue % 60);
        string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);

        // Update the Text component with the formatted timer string
        timetakentext.text = "Time Taken: " + timerString;
    }
}
