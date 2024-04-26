using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minigame1star : MonoBehaviour
{
    public RawImage goldstar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (map1minigame1text.Coins >= 3)
        {
            goldstar.gameObject.SetActive(true);
        }
        else
        {
            goldstar.gameObject.SetActive(false);
        }
    }
}
