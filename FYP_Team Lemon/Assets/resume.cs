using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resume : MonoBehaviour
{
    public RawImage resumebutton;
    public static bool isResumed = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (IsClickInsideRawImage())
            {
                // Check if the game is paused
                if (isResumed == false)
                {
                    //Unpause the game
                    isResumed = true;
                    //pausebutton.isPaused = false;
                    Debug.Log("resume");
                }
            }
        }
    }
    private bool IsClickInsideRawImage()
    {
        // Check if the mouse position is inside the bounds of the RawImage
        RectTransform rectTransform = resumebutton.rectTransform;
        Vector2 mousePosition = Input.mousePosition;
        return RectTransformUtility.RectangleContainsScreenPoint(rectTransform, mousePosition);
    }
}
