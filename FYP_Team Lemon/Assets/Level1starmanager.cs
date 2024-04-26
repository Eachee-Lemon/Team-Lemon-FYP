using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1starmanager : MonoBehaviour
{
    public RawImage star1;
    public RawImage star2;
    public RawImage star3;

    void Update()
    {
        //star 1
        if (timer.currentValue <= 15)
        {
            star1.gameObject.SetActive(true);
        }
        else
        {
            star1.gameObject.SetActive(false);
        }

        // star 2
        if (timer.currentValue <= 10)
        {
            star2.gameObject.SetActive(true);
        }
        else
        {
            star2.gameObject.SetActive(false);
        }

        //star 3
        if (timer.currentValue <= 5)
        {
            star3.gameObject.SetActive(true);
        }
        else
        {
            star3.gameObject.SetActive(false);
        }
    }
}
