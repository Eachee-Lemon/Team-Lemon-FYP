using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class map1win : MonoBehaviour
{
    public string SceneName;
    public static int win = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(SceneName);
            win = 1;
        }
    }
}
