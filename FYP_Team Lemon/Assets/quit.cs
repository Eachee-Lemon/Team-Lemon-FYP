using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class quit : MonoBehaviour
{
    public RawImage quitbutton;

    public string sceneName;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (IsClickInsideRawImage())
            {
                resume.isResumed = true;
                minigametext.Minigametextactive = false;
                SceneManager.LoadScene(sceneName);
            }
        }
    }
    private bool IsClickInsideRawImage()
    {
        // Check if the mouse position is inside the bounds of the RawImage
        RectTransform rectTransform = quitbutton.rectTransform;
        Vector2 mousePosition = Input.mousePosition;
        return RectTransformUtility.RectangleContainsScreenPoint(rectTransform, mousePosition);
    }
}