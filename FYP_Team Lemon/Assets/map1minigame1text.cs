using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class map1minigame1text : MonoBehaviour
{
    public Text ColourChange;
    Text minigameText;
    public static int Coins = 0;
    void Start()
    {
        minigameText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        minigameText.text = Coins + "/3 Coins Collected";
        if (Coins >= 3)
        {
            ColourChange.color = Color.green;
        }
    }
}
