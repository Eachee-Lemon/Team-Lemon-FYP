using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        minigametext.Minigametextactive = false;
        map1win.win = 0;
        timer.currentValue = 0f;
    }
}
