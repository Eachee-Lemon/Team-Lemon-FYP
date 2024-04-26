using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneNormalMap1norm : MonoBehaviour
{
    public static Boolean NormMap1Norm = false;
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        NormMap1Norm = true;
        Debug.Log("1");
    }
}
