using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minigametext : MonoBehaviour
{
    public GameObject Minigametext;
    public static bool Minigametextactive = false;
    public float hideDelay = 3f;

    public Text minigame1text;

    // Update is called once per frame
    void Start()
    {
        minigame1text.enabled = false;
    }
    void Update()
    {
        if (Minigametextactive == true)
        {
            minigame1text.enabled = true;
            Minigametext.SetActive(true);
            StartCoroutine(HideAfterDelay());
        }
        else
        {
            Minigametext.SetActive(false);
        }
    }
    IEnumerator HideAfterDelay()
    {
        yield return new WaitForSeconds(hideDelay);
        Minigametext.SetActive(false);
        Minigametextactive = false;
    }
}
