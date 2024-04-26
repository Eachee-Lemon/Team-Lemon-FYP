using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pausebutton : MonoBehaviour
{
    public RawImage pausemenu;
    public RawImage pause;
    public RawImage resumee;
    public RawImage quit;

    public static bool isPaused = false;

    void Start()
    {
        pausemenu.gameObject.SetActive(false);
        pause.gameObject.SetActive(true);
        resumee.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
    }

    private void Update()
    {
        // Check for mouse clicks
        if (Input.GetMouseButtonDown(0))
        {
            if (IsClickInsideRawImage())
            {
                // Check if the game is paused
                if (isPaused == true)
                {
                    // Unpause the game
                    Resume();
                }
                else
                {
                    Pause();
                    resume.isResumed = false;
                }
            }
        }
        if (isPaused == true && resume.isResumed == true)
        {
            // Unpause the game
            Resume();
            Debug.Log("conti");
            isPaused = false;
        }
    }

    public void Pause()
    {
            // Pause the game
            Time.timeScale = 0f;
            isPaused = true;
            //Paused.enabled = true;

            // Activate the clicked pause image
            pausemenu.gameObject.SetActive(true);
            pause.gameObject.SetActive(false);
            resumee.gameObject.SetActive(true);
            quit.gameObject.SetActive(true);
            paused.Paused = true;
    }

    public void Resume()
    {
            // Resume the game
            Time.timeScale = 1f;

        // Deactivate both pause images
            pausemenu.gameObject.SetActive(false);
            pause.gameObject.SetActive(true);
            resumee.gameObject.SetActive(false);
            quit.gameObject.SetActive(false);
            paused.Paused = false;
    }
    private bool IsClickInsideRawImage()
    {
        // Check if the mouse position is inside the bounds of the RawImage
        RectTransform rectTransform = pause.rectTransform;
        Vector2 mousePosition = Input.mousePosition;
        return RectTransformUtility.RectangleContainsScreenPoint(rectTransform, mousePosition);
    }
}