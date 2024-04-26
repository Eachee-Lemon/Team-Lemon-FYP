using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GameObject Coin;
    void Start()
    {
        Coin.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(Coin);
            if (map1minigame1text.Coins < 3)
            {
                map1minigame1text.Coins++;
            }
        }
    }
}
