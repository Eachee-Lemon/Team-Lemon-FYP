using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneNormalMap1 : MonoBehaviour
{
    public static Boolean NormMap1 = false;
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        NormMap1 = true;
        Debug.Log("2");
    }
}
